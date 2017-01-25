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

namespace FreestylerChaselist
{
    public partial class Form1 : Form
    {
        public string rootFolder = "C:/Freestyler/Chases/";
        public string projectName = "";

        public Form1()
        {
            InitializeComponent();

            //Connect to FreeStyler and update label
            connectionStatusLabel.Text = (FreestylerConnection.sender.freestylerConnected() != 0 ? "FS Connected" : "FS Not Found");
        }

        public void loadChase(int chasenr, string projectName, string chaseName, byte options)
        {
            int channel = chasenr % 2; //Even chases go into channel 0; Odd numbered into channel 1

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
        }

        private void openProjectButton_Click(object sender, EventArgs e)
        {
            projectName = projectNameTextbox.Text;

            //Check if the chaselist folder exists
            if (!Directory.Exists(""+rootFolder+projectName))
            {
                Directory.CreateDirectory("" + rootFolder + projectName);
            }

            //Check if the chaselist file exists
            if (!File.Exists(""+rootFolder+projectName+"/"+projectName+".chl"))
            {
                File.Create("" + rootFolder + projectName + "/" + projectName + ".chl").Dispose();
            } else
            {
                string path = rootFolder + projectName + "/" + projectName + ".chl";
                string line = "";

                using (System.IO.StreamReader file =
                new System.IO.StreamReader(path))
                {
                    while((line = file.ReadLine()) != null)
                    {
                        MessageBox.Show(line);
                    }
                }
            }

            //Enable the saveButton
            saveProjectButton.Enabled = true;
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
                    file.WriteLine("Lorem");
                    file.WriteLine("Ipsum");
                }
            }
        }
    }
}
