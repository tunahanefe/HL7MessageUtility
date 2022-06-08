namespace HL7MessageApp
{
    partial class MainForm
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
            this.tbHL7Vals = new System.Windows.Forms.TextBox();
            this.btnAdt = new System.Windows.Forms.Button();
            this.btnAdtToText = new System.Windows.Forms.Button();
            this.tbHL7 = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHL7 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbHL7Vals
            // 
            this.tbHL7Vals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHL7Vals.Location = new System.Drawing.Point(0, 0);
            this.tbHL7Vals.Multiline = true;
            this.tbHL7Vals.Name = "tbHL7Vals";
            this.tbHL7Vals.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbHL7Vals.Size = new System.Drawing.Size(881, 404);
            this.tbHL7Vals.TabIndex = 3;
            // 
            // btnAdt
            // 
            this.btnAdt.Location = new System.Drawing.Point(11, 9);
            this.btnAdt.Name = "btnAdt";
            this.btnAdt.Size = new System.Drawing.Size(123, 23);
            this.btnAdt.TabIndex = 0;
            this.btnAdt.Text = "Örnek: ADT To Mesaj";
            this.btnAdt.UseVisualStyleBackColor = true;
            this.btnAdt.Click += new System.EventHandler(this.btnAdt_Click);
            // 
            // btnAdtToText
            // 
            this.btnAdtToText.Location = new System.Drawing.Point(137, 9);
            this.btnAdtToText.Name = "btnAdtToText";
            this.btnAdtToText.Size = new System.Drawing.Size(126, 23);
            this.btnAdtToText.TabIndex = 1;
            this.btnAdtToText.Text = "Mesaj To Model";
            this.btnAdtToText.UseVisualStyleBackColor = true;
            this.btnAdtToText.Click += new System.EventHandler(this.btnAdtToText_Click);
            // 
            // tbHL7
            // 
            this.tbHL7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHL7.Location = new System.Drawing.Point(0, 39);
            this.tbHL7.Multiline = true;
            this.tbHL7.Name = "tbHL7";
            this.tbHL7.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbHL7.Size = new System.Drawing.Size(881, 225);
            this.tbHL7.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.treeView1);
            this.splitContainer1.Size = new System.Drawing.Size(1181, 674);
            this.splitContainer1.SplitterDistance = 883;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tbHL7);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tbHL7Vals);
            this.splitContainer2.Size = new System.Drawing.Size(881, 672);
            this.splitContainer2.SplitterDistance = 264;
            this.splitContainer2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnHL7);
            this.panel1.Controls.Add(this.btnAdt);
            this.panel1.Controls.Add(this.btnAdtToText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 39);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tbIP);
            this.panel2.Controls.Add(this.tbPort);
            this.panel2.Controls.Add(this.btnGonder);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(310, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 29);
            this.panel2.TabIndex = 8;
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(25, 4);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(100, 20);
            this.tbIP.TabIndex = 5;
            this.tbIP.Text = "192.168.2.10";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(154, 4);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(40, 20);
            this.tbPort.TabIndex = 7;
            this.tbPort.Text = "15003";
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(194, 3);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(52, 22);
            this.btnGonder.TabIndex = 3;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP:";
            // 
            // btnHL7
            // 
            this.btnHL7.Location = new System.Drawing.Point(269, 9);
            this.btnHL7.Name = "btnHL7";
            this.btnHL7.Size = new System.Drawing.Size(35, 23);
            this.btnHL7.TabIndex = 2;
            this.btnHL7.Text = "HL7";
            this.btnHL7.UseVisualStyleBackColor = true;
            this.btnHL7.Click += new System.EventHandler(this.btnHL7_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(292, 672);
            this.treeView1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 674);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "HL7 Mesajı oluşturma ve parçalama.";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbHL7Vals;
        private System.Windows.Forms.Button btnAdt;
        private System.Windows.Forms.Button btnAdtToText;
        private System.Windows.Forms.TextBox tbHL7;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHL7;
        private System.Windows.Forms.TreeView treeView1;
    }
}

