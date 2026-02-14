namespace PortProxyManager
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
            this.lblListen = new System.Windows.Forms.Label();
            this.txtListen = new System.Windows.Forms.TextBox();
            this.lblTargetPort = new System.Windows.Forms.Label();
            this.txtTargetPort = new System.Windows.Forms.TextBox();
            this.lblTargetIP = new System.Windows.Forms.Label();
            this.txtTargetIP = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnFirewall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblListen
            // 
            this.lblListen.AutoSize = true;
            this.lblListen.Location = new System.Drawing.Point(12, 15);
            this.lblListen.Name = "lblListen";
            this.lblListen.Size = new System.Drawing.Size(66, 15);
            this.lblListen.TabIndex = 0;
            this.lblListen.Text = "Listen Port:";
            // 
            // txtListen
            // 
            this.txtListen.Location = new System.Drawing.Point(84, 12);
            this.txtListen.Name = "txtListen";
            this.txtListen.Size = new System.Drawing.Size(100, 23);
            this.txtListen.TabIndex = 1;
            // 
            // lblTargetPort
            // 
            this.lblTargetPort.AutoSize = true;
            this.lblTargetPort.Location = new System.Drawing.Point(12, 44);
            this.lblTargetPort.Name = "lblTargetPort";
            this.lblTargetPort.Size = new System.Drawing.Size(69, 15);
            this.lblTargetPort.TabIndex = 2;
            this.lblTargetPort.Text = "Target Port:";
            // 
            // txtTargetPort
            // 
            this.txtTargetPort.Location = new System.Drawing.Point(84, 41);
            this.txtTargetPort.Name = "txtTargetPort";
            this.txtTargetPort.Size = new System.Drawing.Size(100, 23);
            this.txtTargetPort.TabIndex = 3;
            // 
            // lblTargetIP
            // 
            this.lblTargetIP.AutoSize = true;
            this.lblTargetIP.Location = new System.Drawing.Point(12, 73);
            this.lblTargetIP.Name = "lblTargetIP";
            this.lblTargetIP.Size = new System.Drawing.Size(58, 15);
            this.lblTargetIP.TabIndex = 4;
            this.lblTargetIP.Text = "Target IP:";
            // 
            // txtTargetIP
            // 
            this.txtTargetIP.Location = new System.Drawing.Point(84, 70);
            this.txtTargetIP.Name = "txtTargetIP";
            this.txtTargetIP.Size = new System.Drawing.Size(100, 23);
            this.txtTargetIP.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(200, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Rule";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(200, 40);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete Rule";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(200, 70);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(120, 23);
            this.btnList.TabIndex = 8;
            this.btnList.Text = "List All Rules";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            //
            // btnFirewall
            //
            this.btnFirewall.Location = new System.Drawing.Point(330, 12);
            this.btnFirewall.Name = "btnFirewall";
            this.btnFirewall.Size = new System.Drawing.Size(130, 23);
            this.btnFirewall.TabIndex = 9;
            this.btnFirewall.Text = "Add Firewall Rule";
            this.btnFirewall.UseVisualStyleBackColor = true;
            this.btnFirewall.Click += new System.EventHandler(this.btnFirewall_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(12, 110);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(776, 328);
            this.txtOutput.TabIndex = 10;
            this.txtOutput.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFirewall);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTargetIP);
            this.Controls.Add(this.lblTargetIP);
            this.Controls.Add(this.txtTargetPort);
            this.Controls.Add(this.lblTargetPort);
            this.Controls.Add(this.txtListen);
            this.Controls.Add(this.lblListen);
            this.Name = "Form1";
            this.Text = "Port Proxy Manager";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblListen;
        private System.Windows.Forms.TextBox txtListen;
        private System.Windows.Forms.Label lblTargetPort;
        private System.Windows.Forms.TextBox txtTargetPort;
        private System.Windows.Forms.Label lblTargetIP;
        private System.Windows.Forms.TextBox txtTargetIP;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnFirewall;
    }
}
