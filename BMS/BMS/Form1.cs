using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtTextToSpeak.Text = "Hello my name is Paul and you smell really really bad";

            btnSayIt.Focus();
        }

        private void btnSayIt_Click(object sender, EventArgs e)
        {
            var synthesizer = new SpeechSynthesizer();

            synthesizer.Speak(txtTextToSpeak.Text);
        }
    }
}
