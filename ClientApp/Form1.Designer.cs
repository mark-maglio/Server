namespace ClientApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sendbtn = new System.Windows.Forms.Button();
            this.connectbtn = new System.Windows.Forms.Button();
            this.statustxt1 = new System.Windows.Forms.TextBox();
            this.statustxt = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txthost = new System.Windows.Forms.TextBox();
            this.Host = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sendbtn
            // 
            this.Sendbtn.Location = new System.Drawing.Point(625, 223);
            this.Sendbtn.Name = "Sendbtn";
            this.Sendbtn.Size = new System.Drawing.Size(75, 23);
            this.Sendbtn.TabIndex = 15;
            this.Sendbtn.Text = "Send";
            this.Sendbtn.UseVisualStyleBackColor = true;
            // 
            // connectbtn
            // 
            this.connectbtn.Location = new System.Drawing.Point(625, 51);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(93, 23);
            this.connectbtn.TabIndex = 14;
            this.connectbtn.Text = "Connessione";
            this.connectbtn.UseVisualStyleBackColor = true;
            this.connectbtn.Click += new System.EventHandler(this.srtbtn_Click);
            // 
            // statustxt1
            // 
            this.statustxt1.Location = new System.Drawing.Point(65, 264);
            this.statustxt1.Multiline = true;
            this.statustxt1.Name = "statustxt1";
            this.statustxt1.Size = new System.Drawing.Size(653, 120);
            this.statustxt1.TabIndex = 13;
            // 
            // statustxt
            // 
            this.statustxt.Location = new System.Drawing.Point(65, 102);
            this.statustxt.Multiline = true;
            this.statustxt.Name = "statustxt";
            this.statustxt.Size = new System.Drawing.Size(653, 98);
            this.statustxt.TabIndex = 12;
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(458, 51);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(100, 20);
            this.textPort.TabIndex = 11;
            this.textPort.Text = "8910";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Port";
            // 
            // txthost
            // 
            this.txthost.Location = new System.Drawing.Point(134, 48);
            this.txthost.Name = "txthost";
            this.txthost.Size = new System.Drawing.Size(100, 20);
            this.txthost.TabIndex = 9;
            this.txthost.Text = "127.0.0.1";
            // 
            // Host
            // 
            this.Host.AutoSize = true;
            this.Host.Location = new System.Drawing.Point(73, 51);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(29, 13);
            this.Host.TabIndex = 8;
            this.Host.Text = "Host";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sendbtn);
            this.Controls.Add(this.connectbtn);
            this.Controls.Add(this.statustxt1);
            this.Controls.Add(this.statustxt);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txthost);
            this.Controls.Add(this.Host);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sendbtn;
        private System.Windows.Forms.Button connectbtn;
        private System.Windows.Forms.TextBox statustxt1;
        private System.Windows.Forms.TextBox statustxt;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthost;
        private System.Windows.Forms.Label Host;
    }
}

