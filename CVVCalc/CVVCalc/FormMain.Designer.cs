namespace CVVCalc
{
    partial class FormGenCVV
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPAN = new System.Windows.Forms.Label();
            this.labelExpirationDate = new System.Windows.Forms.Label();
            this.labelServiceCode = new System.Windows.Forms.Label();
            this.textPAN = new System.Windows.Forms.TextBox();
            this.textExpirationDate = new System.Windows.Forms.TextBox();
            this.textServiceCode = new System.Windows.Forms.TextBox();
            this.labelICVV = new System.Windows.Forms.Label();
            this.labelIndentCVV = new System.Windows.Forms.Label();
            this.labelCVV = new System.Windows.Forms.Label();
            this.textCVV = new System.Windows.Forms.TextBox();
            this.textIndentCVV = new System.Windows.Forms.TextBox();
            this.textICVV = new System.Windows.Forms.TextBox();
            this.buttonGenCVV = new System.Windows.Forms.Button();
            this.labelCVKeyA = new System.Windows.Forms.Label();
            this.labelCVKeyB = new System.Windows.Forms.Label();
            this.textCVKeyA = new System.Windows.Forms.TextBox();
            this.textCVKeyB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textPAN2 = new System.Windows.Forms.TextBox();
            this.labelPAN2 = new System.Windows.Forms.Label();
            this.buttonGenPVV = new System.Windows.Forms.Button();
            this.textPVV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textTSP = new System.Windows.Forms.TextBox();
            this.labelTSP = new System.Windows.Forms.Label();
            this.textPVKeyB = new System.Windows.Forms.TextBox();
            this.textPVKeyA = new System.Windows.Forms.TextBox();
            this.labelPVKeyB = new System.Windows.Forms.Label();
            this.labelPVKeyA = new System.Windows.Forms.Label();
            this.textPIN = new System.Windows.Forms.TextBox();
            this.textPVKI = new System.Windows.Forms.TextBox();
            this.labelPIN = new System.Windows.Forms.Label();
            this.labelPVKI = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.textIP = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.textPort = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPAN
            // 
            this.labelPAN.AutoSize = true;
            this.labelPAN.Location = new System.Drawing.Point(99, 116);
            this.labelPAN.Name = "labelPAN";
            this.labelPAN.Size = new System.Drawing.Size(59, 20);
            this.labelPAN.TabIndex = 0;
            this.labelPAN.Text = "PAN：";
            // 
            // labelExpirationDate
            // 
            this.labelExpirationDate.AutoSize = true;
            this.labelExpirationDate.Location = new System.Drawing.Point(18, 151);
            this.labelExpirationDate.Name = "labelExpirationDate";
            this.labelExpirationDate.Size = new System.Drawing.Size(141, 20);
            this.labelExpirationDate.TabIndex = 1;
            this.labelExpirationDate.Text = "Expiration Date：";
            // 
            // labelServiceCode
            // 
            this.labelServiceCode.AutoSize = true;
            this.labelServiceCode.Location = new System.Drawing.Point(36, 186);
            this.labelServiceCode.Name = "labelServiceCode";
            this.labelServiceCode.Size = new System.Drawing.Size(122, 20);
            this.labelServiceCode.TabIndex = 2;
            this.labelServiceCode.Text = "Service Code：";
            // 
            // textPAN
            // 
            this.textPAN.Location = new System.Drawing.Point(165, 113);
            this.textPAN.MaxLength = 16;
            this.textPAN.Name = "textPAN";
            this.textPAN.Size = new System.Drawing.Size(170, 29);
            this.textPAN.TabIndex = 4;
            // 
            // textExpirationDate
            // 
            this.textExpirationDate.Location = new System.Drawing.Point(165, 148);
            this.textExpirationDate.MaxLength = 4;
            this.textExpirationDate.Name = "textExpirationDate";
            this.textExpirationDate.Size = new System.Drawing.Size(84, 29);
            this.textExpirationDate.TabIndex = 5;
            // 
            // textServiceCode
            // 
            this.textServiceCode.Location = new System.Drawing.Point(165, 183);
            this.textServiceCode.MaxLength = 3;
            this.textServiceCode.Name = "textServiceCode";
            this.textServiceCode.Size = new System.Drawing.Size(84, 29);
            this.textServiceCode.TabIndex = 6;
            // 
            // labelICVV
            // 
            this.labelICVV.AutoSize = true;
            this.labelICVV.Location = new System.Drawing.Point(97, 347);
            this.labelICVV.Name = "labelICVV";
            this.labelICVV.Size = new System.Drawing.Size(62, 20);
            this.labelICVV.TabIndex = 8;
            this.labelICVV.Text = "iCVV：";
            // 
            // labelIndentCVV
            // 
            this.labelIndentCVV.AutoSize = true;
            this.labelIndentCVV.Location = new System.Drawing.Point(51, 312);
            this.labelIndentCVV.Name = "labelIndentCVV";
            this.labelIndentCVV.Size = new System.Drawing.Size(108, 20);
            this.labelIndentCVV.TabIndex = 7;
            this.labelIndentCVV.Text = "IndentCVV：";
            // 
            // labelCVV
            // 
            this.labelCVV.AutoSize = true;
            this.labelCVV.Location = new System.Drawing.Point(101, 277);
            this.labelCVV.Name = "labelCVV";
            this.labelCVV.Size = new System.Drawing.Size(58, 20);
            this.labelCVV.TabIndex = 6;
            this.labelCVV.Text = "CVV：";
            // 
            // textCVV
            // 
            this.textCVV.Location = new System.Drawing.Point(165, 274);
            this.textCVV.MaxLength = 4;
            this.textCVV.Name = "textCVV";
            this.textCVV.Size = new System.Drawing.Size(84, 29);
            this.textCVV.TabIndex = 9;
            // 
            // textIndentCVV
            // 
            this.textIndentCVV.Location = new System.Drawing.Point(165, 309);
            this.textIndentCVV.MaxLength = 4;
            this.textIndentCVV.Name = "textIndentCVV";
            this.textIndentCVV.Size = new System.Drawing.Size(84, 29);
            this.textIndentCVV.TabIndex = 10;
            // 
            // textICVV
            // 
            this.textICVV.Location = new System.Drawing.Point(165, 344);
            this.textICVV.MaxLength = 4;
            this.textICVV.Name = "textICVV";
            this.textICVV.Size = new System.Drawing.Size(84, 29);
            this.textICVV.TabIndex = 11;
            // 
            // buttonGenCVV
            // 
            this.buttonGenCVV.Location = new System.Drawing.Point(21, 227);
            this.buttonGenCVV.Name = "buttonGenCVV";
            this.buttonGenCVV.Size = new System.Drawing.Size(314, 30);
            this.buttonGenCVV.TabIndex = 1;
            this.buttonGenCVV.Text = "產    生    CVV";
            this.buttonGenCVV.UseVisualStyleBackColor = true;
            this.buttonGenCVV.Click += new System.EventHandler(this.buttonGenCVV_Click);
            // 
            // labelCVKeyA
            // 
            this.labelCVKeyA.AutoSize = true;
            this.labelCVKeyA.Location = new System.Drawing.Point(17, 31);
            this.labelCVKeyA.Name = "labelCVKeyA";
            this.labelCVKeyA.Size = new System.Drawing.Size(85, 20);
            this.labelCVKeyA.TabIndex = 13;
            this.labelCVKeyA.Text = "CVKeyA：";
            // 
            // labelCVKeyB
            // 
            this.labelCVKeyB.AutoSize = true;
            this.labelCVKeyB.Location = new System.Drawing.Point(18, 66);
            this.labelCVKeyB.Name = "labelCVKeyB";
            this.labelCVKeyB.Size = new System.Drawing.Size(84, 20);
            this.labelCVKeyB.TabIndex = 14;
            this.labelCVKeyB.Text = "CVKeyB：";
            // 
            // textCVKeyA
            // 
            this.textCVKeyA.Location = new System.Drawing.Point(103, 28);
            this.textCVKeyA.MaxLength = 16;
            this.textCVKeyA.Name = "textCVKeyA";
            this.textCVKeyA.Size = new System.Drawing.Size(232, 29);
            this.textCVKeyA.TabIndex = 2;
            // 
            // textCVKeyB
            // 
            this.textCVKeyB.Location = new System.Drawing.Point(103, 63);
            this.textCVKeyB.MaxLength = 16;
            this.textCVKeyB.Name = "textCVKeyB";
            this.textCVKeyB.Size = new System.Drawing.Size(232, 29);
            this.textCVKeyB.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGenCVV);
            this.groupBox1.Controls.Add(this.labelPAN);
            this.groupBox1.Controls.Add(this.labelExpirationDate);
            this.groupBox1.Controls.Add(this.labelServiceCode);
            this.groupBox1.Controls.Add(this.textPAN);
            this.groupBox1.Controls.Add(this.textExpirationDate);
            this.groupBox1.Controls.Add(this.textServiceCode);
            this.groupBox1.Controls.Add(this.labelCVV);
            this.groupBox1.Controls.Add(this.labelIndentCVV);
            this.groupBox1.Controls.Add(this.labelICVV);
            this.groupBox1.Controls.Add(this.textCVV);
            this.groupBox1.Controls.Add(this.textIndentCVV);
            this.groupBox1.Controls.Add(this.textICVV);
            this.groupBox1.Controls.Add(this.labelCVKeyA);
            this.groupBox1.Controls.Add(this.labelCVKeyB);
            this.groupBox1.Controls.Add(this.textCVKeyA);
            this.groupBox1.Controls.Add(this.textCVKeyB);
            this.groupBox1.Location = new System.Drawing.Point(14, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 389);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CVV Calc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textPAN2);
            this.groupBox2.Controls.Add(this.labelPAN2);
            this.groupBox2.Controls.Add(this.buttonGenPVV);
            this.groupBox2.Controls.Add(this.textPVV);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textTSP);
            this.groupBox2.Controls.Add(this.labelTSP);
            this.groupBox2.Controls.Add(this.textPVKeyB);
            this.groupBox2.Controls.Add(this.textPVKeyA);
            this.groupBox2.Controls.Add(this.labelPVKeyB);
            this.groupBox2.Controls.Add(this.labelPVKeyA);
            this.groupBox2.Controls.Add(this.textPIN);
            this.groupBox2.Controls.Add(this.textPVKI);
            this.groupBox2.Controls.Add(this.labelPIN);
            this.groupBox2.Controls.Add(this.labelPVKI);
            this.groupBox2.Location = new System.Drawing.Point(372, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 389);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PVV Calc";
            // 
            // textPAN2
            // 
            this.textPAN2.Location = new System.Drawing.Point(103, 113);
            this.textPAN2.MaxLength = 16;
            this.textPAN2.Name = "textPAN2";
            this.textPAN2.Size = new System.Drawing.Size(171, 29);
            this.textPAN2.TabIndex = 13;
            // 
            // labelPAN2
            // 
            this.labelPAN2.AutoSize = true;
            this.labelPAN2.Location = new System.Drawing.Point(42, 116);
            this.labelPAN2.Name = "labelPAN2";
            this.labelPAN2.Size = new System.Drawing.Size(59, 20);
            this.labelPAN2.TabIndex = 45;
            this.labelPAN2.Text = "PAN：";
            // 
            // buttonGenPVV
            // 
            this.buttonGenPVV.Location = new System.Drawing.Point(21, 227);
            this.buttonGenPVV.Name = "buttonGenPVV";
            this.buttonGenPVV.Size = new System.Drawing.Size(315, 30);
            this.buttonGenPVV.TabIndex = 10;
            this.buttonGenPVV.Text = "產    生    PVV";
            this.buttonGenPVV.UseVisualStyleBackColor = true;
            this.buttonGenPVV.Click += new System.EventHandler(this.buttonGenPVV_Click);
            // 
            // textPVV
            // 
            this.textPVV.Location = new System.Drawing.Point(103, 309);
            this.textPVV.MaxLength = 4;
            this.textPVV.Name = "textPVV";
            this.textPVV.Size = new System.Drawing.Size(85, 29);
            this.textPVV.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "PVV：";
            // 
            // textTSP
            // 
            this.textTSP.Enabled = false;
            this.textTSP.Location = new System.Drawing.Point(103, 274);
            this.textTSP.MaxLength = 4;
            this.textTSP.Name = "textTSP";
            this.textTSP.Size = new System.Drawing.Size(233, 29);
            this.textTSP.TabIndex = 16;
            // 
            // labelTSP
            // 
            this.labelTSP.AutoSize = true;
            this.labelTSP.Location = new System.Drawing.Point(48, 277);
            this.labelTSP.Name = "labelTSP";
            this.labelTSP.Size = new System.Drawing.Size(53, 20);
            this.labelTSP.TabIndex = 40;
            this.labelTSP.Text = "TSP：";
            // 
            // textPVKeyB
            // 
            this.textPVKeyB.Location = new System.Drawing.Point(103, 63);
            this.textPVKeyB.MaxLength = 16;
            this.textPVKeyB.Name = "textPVKeyB";
            this.textPVKeyB.Size = new System.Drawing.Size(233, 29);
            this.textPVKeyB.TabIndex = 12;
            // 
            // textPVKeyA
            // 
            this.textPVKeyA.Location = new System.Drawing.Point(103, 28);
            this.textPVKeyA.MaxLength = 16;
            this.textPVKeyA.Name = "textPVKeyA";
            this.textPVKeyA.Size = new System.Drawing.Size(233, 29);
            this.textPVKeyA.TabIndex = 11;
            // 
            // labelPVKeyB
            // 
            this.labelPVKeyB.AutoSize = true;
            this.labelPVKeyB.Location = new System.Drawing.Point(18, 66);
            this.labelPVKeyB.Name = "labelPVKeyB";
            this.labelPVKeyB.Size = new System.Drawing.Size(83, 20);
            this.labelPVKeyB.TabIndex = 37;
            this.labelPVKeyB.Text = "PVKeyB：";
            // 
            // labelPVKeyA
            // 
            this.labelPVKeyA.AutoSize = true;
            this.labelPVKeyA.Location = new System.Drawing.Point(17, 31);
            this.labelPVKeyA.Name = "labelPVKeyA";
            this.labelPVKeyA.Size = new System.Drawing.Size(84, 20);
            this.labelPVKeyA.TabIndex = 36;
            this.labelPVKeyA.Text = "PVKeyA：";
            // 
            // textPIN
            // 
            this.textPIN.Location = new System.Drawing.Point(103, 183);
            this.textPIN.MaxLength = 12;
            this.textPIN.Name = "textPIN";
            this.textPIN.Size = new System.Drawing.Size(233, 29);
            this.textPIN.TabIndex = 15;
            // 
            // textPVKI
            // 
            this.textPVKI.Location = new System.Drawing.Point(103, 148);
            this.textPVKI.MaxLength = 1;
            this.textPVKI.Name = "textPVKI";
            this.textPVKI.Size = new System.Drawing.Size(85, 29);
            this.textPVKI.TabIndex = 14;
            // 
            // labelPIN
            // 
            this.labelPIN.AutoSize = true;
            this.labelPIN.Location = new System.Drawing.Point(48, 186);
            this.labelPIN.Name = "labelPIN";
            this.labelPIN.Size = new System.Drawing.Size(53, 20);
            this.labelPIN.TabIndex = 33;
            this.labelPIN.Text = "PIN：";
            // 
            // labelPVKI
            // 
            this.labelPVKI.AutoSize = true;
            this.labelPVKI.Location = new System.Drawing.Point(40, 151);
            this.labelPVKI.Name = "labelPVKI";
            this.labelPVKI.Size = new System.Drawing.Size(61, 20);
            this.labelPVKI.TabIndex = 32;
            this.labelPVKI.Text = "PVKI：";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(31, 9);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(40, 20);
            this.labelIP.TabIndex = 34;
            this.labelIP.Text = "IP：";
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(77, 6);
            this.textIP.MaxLength = 16;
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(232, 29);
            this.textIP.TabIndex = 35;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(341, 9);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(40, 20);
            this.labelPort.TabIndex = 36;
            this.labelPort.Text = "IP：";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(387, 6);
            this.textPort.MaxLength = 16;
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(104, 29);
            this.textPort.TabIndex = 37;
            // 
            // FormGenCVV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 442);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormGenCVV";
            this.Text = "CVV Calculation";
            this.Load += new System.EventHandler(this.FormGenCVV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPAN;
        private System.Windows.Forms.Label labelExpirationDate;
        private System.Windows.Forms.Label labelServiceCode;
        private System.Windows.Forms.TextBox textPAN;
        private System.Windows.Forms.TextBox textExpirationDate;
        private System.Windows.Forms.TextBox textServiceCode;
        private System.Windows.Forms.Label labelICVV;
        private System.Windows.Forms.Label labelIndentCVV;
        private System.Windows.Forms.Label labelCVV;
        private System.Windows.Forms.TextBox textCVV;
        private System.Windows.Forms.TextBox textIndentCVV;
        private System.Windows.Forms.TextBox textICVV;
        private System.Windows.Forms.Button buttonGenCVV;
        private System.Windows.Forms.Label labelCVKeyA;
        private System.Windows.Forms.Label labelCVKeyB;
        private System.Windows.Forms.TextBox textCVKeyA;
        private System.Windows.Forms.TextBox textCVKeyB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textPAN2;
        private System.Windows.Forms.Label labelPAN2;
        private System.Windows.Forms.Button buttonGenPVV;
        private System.Windows.Forms.TextBox textPVV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTSP;
        private System.Windows.Forms.Label labelTSP;
        private System.Windows.Forms.TextBox textPVKeyB;
        private System.Windows.Forms.TextBox textPVKeyA;
        private System.Windows.Forms.Label labelPVKeyB;
        private System.Windows.Forms.Label labelPVKeyA;
        private System.Windows.Forms.TextBox textPIN;
        private System.Windows.Forms.TextBox textPVKI;
        private System.Windows.Forms.Label labelPIN;
        private System.Windows.Forms.Label labelPVKI;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textPort;
    }
}

