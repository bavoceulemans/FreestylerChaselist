using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//FreestylerConnection.dll added as a refrence. Methods are static
using FreestylerConnection;
using static System.Windows.Forms.ListViewItem;

namespace FreestylerChaselist
{
    public partial class Form1 : Form
    {
        public string rootFolder = "C:/Freestyler/Chases/";
        public string projectName = "";
        System.Drawing.Font unselectedFont;
        System.Drawing.Font selectedFont;
        string[] loadedNames;
        int rootChannel = 0;
        bool isPlaying = false;
        int currentlyPlaying = -1;
        List<Chase> chaseList;

        public Form1()
        {
            InitializeComponent();

            //Create the chaseList
            chaseList = new List<Chase>();

            //Create the fonts
            unselectedFont = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular);
            selectedFont = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Bold);

            //Create empty array of loaded chases
            loadedNames = new string[20];

            //Connect to FreeStyler and update label
            connectionStatusLabel.Text = (FreestylerConnection.sender.freestylerConnected() != 0 ? "FS Connected" : "FS Not Found");
        }

        public void loadChase(int chasenr, string projectName, string chaseName, byte options)
        {
            int channel = rootChannel+(chasenr % 2); //Even chases go into channel 0; Odd numbered into channel 1

            string str = "0"+channel;
            str += projectName + "/"; //Add the projectname to the str
            str += chaseName; //Add the chaseName to the str
            str += ".chb"; //Add the suffix
            byte[] chaseValues = new byte[str.Length * sizeof(char)]; //The bytelist that has to be send
            byte[] optionsValues = new byte[2];

            //insert faderValues into correct position in array
            for (int i = 0; i < str.Length; i++)
            {
                chaseValues[i] = (byte)str[i];
            }

            //set the options
            optionsValues[0] = (byte)channel;
            optionsValues[1] = options;

            //send complated dmx values
            FreestylerConnection.sender.sendMessageFunction(chaseValues, 5);
            FreestylerConnection.sender.sendMessageFunction(optionsValues, 6);

            //set the array
            loadedNames[channel] = chaseName;
        }

        private void openProjectButton_Click(object sender, EventArgs e)
        {
            projectName = projectNameTextbox.Text;

            if (projectName != "")
            {
                //Check if the chaselist folder exists
                if (!Directory.Exists("" + rootFolder + projectName))
                {
                    Directory.CreateDirectory("" + rootFolder + projectName);
                }

                //Check if the chaselist file exists
                if (!File.Exists("" + rootFolder + projectName + "/" + projectName + ".chl"))
                {
                    File.Create("" + rootFolder + projectName + "/" + projectName + ".chl").Dispose();
                }
                else
                {
                    string path = rootFolder + projectName + "/" + projectName + ".chl";
                    string line = "";
                    listView1.Items.Clear();
                    chaseList.Clear();
                    currentlyPlaying = -1;
                    loadedNames = new string[20];

                    using (System.IO.StreamReader file =
                    new System.IO.StreamReader(path))
                    {
                        while ((line = file.ReadLine()) != null)
                        {
                            string[] args = line.Split(';');

                            byte optionsByte = byte.Parse(args[3]);
                            string optionsString = "";
                            if (IsBitSet(optionsByte, 3)) optionsString += "A"; else optionsString += "."; //Random
                            if (IsBitSet(optionsByte, 2)) optionsString += "E"; else optionsString += "."; //Reverse
                            if (!IsBitSet(optionsByte, 1)) optionsString += "L"; else optionsString += "."; //Loop (inverted)
                            int chaseId = int.Parse(args[0]);

                            Chase newChase = new Chase(args[1], args[2], optionsString, int.Parse(args[4]));
                            chaseList.Insert(chaseId, newChase);
                        }
                    }
                }

                //Update the listview
                updateListView();

                //Enable the saveButton
                saveProjectButton.Enabled = true;
                playChaseButton.Enabled = true;
                stopChaseButton.Enabled = true;

            }
        }

        private void saveProjectButton_Click(object sender, EventArgs e)
        {
            //Check if there is a project
            if (projectName != "")
            {
                string path = rootFolder + projectName + "/" + projectName + ".chl";

                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(path))
                {
                    for (int id = 0; id < chaseList.Count; id++)
                    {
                        string str = "";
                        Chase chase = chaseList[id];

                        str += id + ";";
                        str += chase.name + ";";
                        str += chase.cue + ";";
                        str += optionsStringToByte(chase.optionsString) + ";";
                        str += "" + chase.time;

                        file.WriteLine(str);
                    }
                }
            }
        }

        private byte optionsStringToByte(string str)
        {
            byte ret = 0;

            if (str.Contains("A")) ret += 8; //Random
            if (str.Contains("E")) ret += 4; //Reverse
            if (!str.Contains("L")) ret += 2; //Loop (inverted)

            return ret;
        }

        public void updateListView()
        {
            listView1.Items.Clear();

            for (int id = 0; id < chaseList.Count; id++)
            {
                Chase chase = chaseList[id];
                string timeString = chase.time + "ms";

                string[] row = { chase.name, chase.cue, chase.optionsString, timeString };
                listView1.Items.Add(""+id).SubItems.AddRange(row);
            }
        }

        public bool IsBitSet(byte b, int pos)
        {
            return (b & (1 << pos)) != 0;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int chaseId = listView1.SelectedIndices[0];
            playChase(chaseId);
        }

        public void playChase(int chaseId)
        {
            //Reset the colors
            resetListViewColors();

            //Get the chase info
            Chase chase = chaseList[chaseId];
            string chaseName = chase.name;
            string cue = chase.cue;
            string optionsString = chase.optionsString;
            byte options = optionsStringToByte(optionsString);
            int time = chase.time;

            int channel = rootChannel + (chaseId % 2); //Even chases go into channel 0; Odd numbered into channel 1
            int nextChannel = rootChannel + ((chaseId + 1) % 2); //Even chases go into channel 0; Odd numbered into channel 1

            //Set the cue label
            cueLabel.Text = "Cue: " + cue;

            //Check if the chase is loaded
            if (loadedNames[channel] != chaseName)
            {
                //Load the chase
                loadChase(chaseId, projectName, chaseName, options);
            }

            //Preload the next chase
            if (chaseId < chaseList.Count - 1)
            {
                //Get the next index
                int nextIndex = chaseId + 1;

                //Get the name of the next chase
                string nextChaseName = chaseList[chaseId+1].name;
                string nextOptionsString = chaseList[chaseId + 1].optionsString;
                byte nextOptions = optionsStringToByte(nextOptionsString);

                //Check if the chase is loaded
                if (loadedNames[nextChannel] != nextChaseName)
                {
                    //Load the chase
                    loadChase(nextIndex, projectName, nextChaseName, nextOptions);
                }
            }

            //Play the chase
            FreestylerConnection.sender.sendCommandFunction(505 + channel, 1); //Start
            FreestylerConnection.sender.sendCommandFunction(525 + nextChannel, 1); //Stop

            //Set the booleans
            isPlaying = true;
            currentlyPlaying = chaseId;

            //Set the timer
            if (time > 0)
            {
                timer1.Interval = time;
                timer1.Enabled = true;
            }

            //Adjust the UI
            setUIMode("Playing");

            ListViewItem listViewChase = listView1.Items[chaseId];

            //Set the color
            listViewChase.BackColor = Color.Green;
            listViewChase.Font = selectedFont;
            listViewChase.Selected = true;
            //listView1.Select();
        }

        public void setUIMode(string status)
        {
            if (status == "Playing")
            {
                openProjectButton.Enabled = false;
                saveProjectButton.Enabled = false;
                this.ControlBox = false; //Hide exit button
            } else if (status == "Stop")
            {
                openProjectButton.Enabled = true;
                saveProjectButton.Enabled = true;
                this.ControlBox = true; //Show exit button
            }
        }

        [Obsolete("playSelectedChase is deprecated, please use playChase(index) instead.")]
        public void playSelectedChase()
        {
            //Reset the colors
            resetListViewColors();

            ListView.SelectedListViewItemCollection args = this.listView1.SelectedItems;

            foreach (ListViewItem chase in args)
            {
                //Set the color
                chase.BackColor = Color.Green;
                chase.Font = selectedFont;

                //Get the chase info
                int chasenr = int.Parse(chase.SubItems[0].Text);
                string chaseName = chase.SubItems[1].Text;
                string cue = chase.SubItems[2].Text;
                string optionsString = chase.SubItems[3].Text;
                int time = int.Parse(chase.SubItems[4].Text.Substring(0, (chase.SubItems[4].Text.Length - 2)));

                int channel = rootChannel+(chasenr % 2); //Even chases go into channel 0; Odd numbered into channel 1
                int nextChannel = rootChannel + ((chasenr + 1) % 2); //Even chases go into channel 0; Odd numbered into channel 1

                //Set the cue label
                cueLabel.Text = "Cue: " + cue;

                //Check if the chase is loaded
                if (loadedNames[channel] != chaseName)
                {
                    //Load the chase
                    loadChase(chasenr, projectName, chaseName, 0);
                }

                //Preload the next chase
                if (listView1.SelectedIndices[0] < listView1.Items.Count - 1)
                {
                    //Get the next index
                    int nextIndex = listView1.SelectedIndices[0] + 1;

                    //Get the name of the next chase
                    string nextChaseName = listView1.Items[nextIndex].SubItems[1].Text;

                    //Check if the chase is loaded
                    if (loadedNames[nextChannel] != nextChaseName)
                    {
                        //Load the chase
                        loadChase(nextIndex, projectName, nextChaseName, 0);
                    }
                }

                //Play the chase
                FreestylerConnection.sender.sendCommandFunction(505 + channel, 1); //Start
                FreestylerConnection.sender.sendCommandFunction(525 + nextChannel, 1); //Stop
            }
        }

        private void resetListViewColors()
        {
            foreach (ListViewItem chase in listView1.Items)
            {
                chase.BackColor = Color.White;
                chase.Font = unselectedFont;
                chase.Selected = false;
            }
        }

        private void playChaseButton_Click(object sender, EventArgs e)
        {
            if (currentlyPlaying+1 < chaseList.Count)
            {
                playChase(currentlyPlaying+1);
            }
        }

        private void stopChaseButton_Click(object sender, EventArgs e)
        {
            if (isPlaying == true)
            {
                //What channels needs to be stopped
                int channel = rootChannel + (currentlyPlaying % 2); //Even chases go into channel 0; Odd numbered into channel 1

                //Stop the chase
                FreestylerConnection.sender.sendCommandFunction(525 + channel, 1); //Stop

                resetListViewColors();

                isPlaying = false;

                ListViewItem listViewChase = listView1.Items[currentlyPlaying];
                currentlyPlaying--;

                //Set the color
                listViewChase.Selected = true;
                listView1.Select();

                setUIMode("Stop");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            if (currentlyPlaying + 1 < chaseList.Count)
            {
                playChase(currentlyPlaying + 1);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isPlaying == true)
            {
                e.Cancel = true;
                MessageBox.Show("A chase is still playing!");
            }
        }
    }
}
