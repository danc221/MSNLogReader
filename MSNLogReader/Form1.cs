using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MSNLogReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string timestamp = "";
            string curMsg = "";
            string curName = "";
            int startName;
            int endName;
            int startTs;
            int endTs;
            var list = new List<string>();

            using (StreamReader sr = new StreamReader("samplelog.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                // Determine if start of message (contains a time stamp and a : after the timestamp)
                if ((list.ElementAt(i).ToString().Contains("[")) && (list.ElementAt(i).ToString().IndexOf(":", list.ElementAt(i).ToString().IndexOf("]")) > 0))
                {
                    // Length of whole message
                    int msgLen;
                    curMsg = "";
                    msgLen = list.ElementAt(i).ToString().Length;

                    // Get timestamp start/end index
                    startTs = list.ElementAt(i).ToString().IndexOf("[");
                    endTs = list.ElementAt(i).ToString().IndexOf("]");
                    timestamp = list.ElementAt(i).ToString().Substring(startTs + 1, endTs - 1);

                    // Get end index of name
                    endName = list.ElementAt(i).ToString().IndexOf(":", endTs);
                    // Get the current name
                    curName = list.ElementAt(i).ToString().Substring(endTs + 2, (endName - 1) - endTs);

                    curMsg = list.ElementAt(i).ToString().Substring(endName + 2, msgLen - endName - 2);

                    debugBox.Text = debugBox.Text + "\n" + "Current message length: " + msgLen.ToString() + "\n"
                                        + " Current Name: " + curName + "\n";

                    debugBox.Text = debugBox.Text + "Current Message: " + curMsg;

                }
                //
                else if (list.ElementAt(i).ToString().Contains("added to the"))
                {

                }
                // Concatenate message onto previous line
                else
                {
                    curMsg = curMsg + " " + list.ElementAt(i).ToString().TrimStart();
                }

                // TODO: this ain't right
                // Show messages
                outputBox.Text = outputBox.Text + timestamp + " " + curName + "\n" + curMsg + "\n\n";
            }


        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            //DateTime setTime = "20:52:50";

            // setTime++;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            chatWindow chat = new chatWindow();

            chat.Show();
        }

    }
}