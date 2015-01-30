using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using ThalesSim.Core.TCP;


namespace CVVCalc
{
    public partial class FormGenCVV : Form
    {
        
        public FormGenCVV()
        {
            InitializeComponent();
        }

        private void buttonGenCVV_Click(object sender, EventArgs e)
        {          
            GenerateCVV cvv = new GenerateCVV(textIP.Text, int.Parse(textPort.Text), textPAN.Text, textExpirationDate.Text,
                                            textServiceCode.Text, textCVKeyA.Text, textCVKeyB.Text);
            textCVV.Text = cvv.getCVV();
            textIndentCVV.Text = cvv.getIndentCVV();
            textICVV.Text = cvv.getICVV();
        }

        private void FormGenCVV_Load(object sender, EventArgs e)
        {
            textCVKeyA.Text = "A48530E054476A2E"; //key under HSM LMK
            textCVKeyB.Text = "331653838EE37313"; //key under HSM LMK
            //textCVKeyA.Text = "1111111111111111";  //clear key 40~4F
            //textCVKeyB.Text = "2222222222222222";  //clear key 40~4F
            textPAN.Text = "4123456789012345";
            textExpirationDate.Text = "8701";
            textServiceCode.Text = "101";
            textPVKeyA.Text = "A48530E054476A2E";   //key under HSM LMK
            textPVKeyB.Text = "331653838EE37313";   //key under HSM LMK
            //textPVKeyA.Text = "1111111111111111"; //clear key 40~4F
            //textPVKeyB.Text = "2222222222222222"; //clear key 40~4F
            textPAN2.Text = "4839123456789019";
            textPVKI.Text = "3";
            textPIN.Text = "387283";
            buttonGenCVV.Focus();
            textIP.Text = "192.168.30.168";
            textPort.Text = "1500";
        }

        private void buttonGenPVV_Click(object sender, EventArgs e)
        {
            GeneratePVV pvv = new GeneratePVV(textIP.Text, int.Parse(textPort.Text), textPAN2.Text, 
                                            textPVKI.Text, textPIN.Text, textPVKeyA.Text, textPVKeyB.Text);
            textTSP.Text = pvv.getTSP();
            textPVV.Text = pvv.getPVV();
        }
   
    }
}
