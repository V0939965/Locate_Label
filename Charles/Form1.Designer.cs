namespace Charles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.group_Interface = new System.Windows.Forms.GroupBox();
            this.imShow = new System.Windows.Forms.PictureBox();
            this.group_Configurations = new System.Windows.Forms.GroupBox();
            this.tStartStop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PulPerRot = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Mis = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FromCamera = new System.Windows.Forms.RadioButton();
            this.FromFolder = new System.Windows.Forms.RadioButton();
            this.LinkFolder = new System.Windows.Forms.TextBox();
            this.ChooseLink = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Threshold_Value_Import = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.group_Interface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imShow)).BeginInit();
            this.group_Configurations.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_Interface
            // 
            this.group_Interface.Controls.Add(this.imShow);
            this.group_Interface.Location = new System.Drawing.Point(12, 12);
            this.group_Interface.Name = "group_Interface";
            this.group_Interface.Size = new System.Drawing.Size(600, 517);
            this.group_Interface.TabIndex = 0;
            this.group_Interface.TabStop = false;
            this.group_Interface.Text = "Interface";
            // 
            // imShow
            // 
            this.imShow.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.imShow.Location = new System.Drawing.Point(22, 32);
            this.imShow.Name = "imShow";
            this.imShow.Size = new System.Drawing.Size(555, 464);
            this.imShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imShow.TabIndex = 0;
            this.imShow.TabStop = false;
            // 
            // group_Configurations
            // 
            this.group_Configurations.Controls.Add(this.panel4);
            this.group_Configurations.Controls.Add(this.panel5);
            this.group_Configurations.Controls.Add(this.panel2);
            this.group_Configurations.Controls.Add(this.panel1);
            this.group_Configurations.Location = new System.Drawing.Point(622, 12);
            this.group_Configurations.Name = "group_Configurations";
            this.group_Configurations.Size = new System.Drawing.Size(250, 148);
            this.group_Configurations.TabIndex = 1;
            this.group_Configurations.TabStop = false;
            this.group_Configurations.Text = "Configurations";
            // 
            // tStartStop
            // 
            this.tStartStop.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tStartStop.ForeColor = System.Drawing.Color.Black;
            this.tStartStop.Location = new System.Drawing.Point(622, 483);
            this.tStartStop.Name = "tStartStop";
            this.tStartStop.Size = new System.Drawing.Size(250, 46);
            this.tStartStop.TabIndex = 2;
            this.tStartStop.TabStop = false;
            this.tStartStop.Text = "Start";
            this.tStartStop.UseVisualStyleBackColor = true;
            this.tStartStop.Click += new System.EventHandler(this.tStartStop_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PulPerRot);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 25);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Tag = "";
            this.label1.Text = "Pulse Per Rotation";
            // 
            // PulPerRot
            // 
            this.PulPerRot.Location = new System.Drawing.Point(174, 2);
            this.PulPerRot.Name = "PulPerRot";
            this.PulPerRot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PulPerRot.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.PulPerRot.Size = new System.Drawing.Size(61, 22);
            this.PulPerRot.TabIndex = 1;
            this.PulPerRot.TabStop = false;
            this.PulPerRot.Text = "36000";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Mis);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 25);
            this.panel2.TabIndex = 2;
            // 
            // Mis
            // 
            this.Mis.Location = new System.Drawing.Point(174, 2);
            this.Mis.Name = "Mis";
            this.Mis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Mis.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Mis.Size = new System.Drawing.Size(61, 22);
            this.Mis.TabIndex = 2;
            this.Mis.TabStop = false;
            this.Mis.Text = "360";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Tag = "";
            this.label2.Text = "Mis-specification";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChooseLink);
            this.groupBox1.Controls.Add(this.LinkFolder);
            this.groupBox1.Controls.Add(this.FromFolder);
            this.groupBox1.Controls.Add(this.FromCamera);
            this.groupBox1.Location = new System.Drawing.Point(622, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 104);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Running Mode";
            // 
            // FromCamera
            // 
            this.FromCamera.AutoSize = true;
            this.FromCamera.Location = new System.Drawing.Point(22, 24);
            this.FromCamera.Name = "FromCamera";
            this.FromCamera.Size = new System.Drawing.Size(87, 17);
            this.FromCamera.TabIndex = 0;
            this.FromCamera.TabStop = true;
            this.FromCamera.Text = "From Camera";
            this.FromCamera.UseVisualStyleBackColor = true;
            // 
            // FromFolder
            // 
            this.FromFolder.AutoSize = true;
            this.FromFolder.Location = new System.Drawing.Point(22, 47);
            this.FromFolder.Name = "FromFolder";
            this.FromFolder.Size = new System.Drawing.Size(80, 17);
            this.FromFolder.TabIndex = 1;
            this.FromFolder.TabStop = true;
            this.FromFolder.Text = "From Folder";
            this.FromFolder.UseVisualStyleBackColor = true;
            // 
            // LinkFolder
            // 
            this.LinkFolder.Location = new System.Drawing.Point(22, 70);
            this.LinkFolder.Name = "LinkFolder";
            this.LinkFolder.Size = new System.Drawing.Size(181, 20);
            this.LinkFolder.TabIndex = 2;
            // 
            // ChooseLink
            // 
            this.ChooseLink.Location = new System.Drawing.Point(210, 68);
            this.ChooseLink.Name = "ChooseLink";
            this.ChooseLink.Size = new System.Drawing.Size(34, 23);
            this.ChooseLink.TabIndex = 3;
            this.ChooseLink.Text = "...";
            this.ChooseLink.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Location = new System.Drawing.Point(622, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 193);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameter";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Threshold_Value_Import);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(6, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 25);
            this.panel3.TabIndex = 1;
            // 
            // Threshold_Value_Import
            // 
            this.Threshold_Value_Import.Location = new System.Drawing.Point(174, 2);
            this.Threshold_Value_Import.Name = "Threshold_Value_Import";
            this.Threshold_Value_Import.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Threshold_Value_Import.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Threshold_Value_Import.Size = new System.Drawing.Size(61, 22);
            this.Threshold_Value_Import.TabIndex = 1;
            this.Threshold_Value_Import.TabStop = false;
            this.Threshold_Value_Import.Text = "127";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 0;
            this.label3.Tag = "";
            this.label3.Text = "Threshold Value";
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Location = new System.Drawing.Point(17, 538);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(28, 13);
            this.log.TabIndex = 5;
            this.log.Text = "Log:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.richTextBox1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(6, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 25);
            this.panel4.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(174, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(61, 22);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "36000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Tag = "";
            this.label4.Text = "Pulse X";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.richTextBox2);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(6, 82);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(238, 25);
            this.panel5.TabIndex = 3;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(174, 2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox2.Size = new System.Drawing.Size(61, 22);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.TabStop = false;
            this.richTextBox2.Text = "36000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Tag = "";
            this.label5.Text = "Pulse Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.log);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tStartStop);
            this.Controls.Add(this.group_Configurations);
            this.Controls.Add(this.group_Interface);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Locate_Label";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.group_Interface.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imShow)).EndInit();
            this.group_Configurations.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox group_Interface;
        private System.Windows.Forms.GroupBox group_Configurations;
        private System.Windows.Forms.PictureBox imShow;
        private System.Windows.Forms.Button tStartStop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox PulPerRot;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox Mis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ChooseLink;
        private System.Windows.Forms.TextBox LinkFolder;
        private System.Windows.Forms.RadioButton FromFolder;
        private System.Windows.Forms.RadioButton FromCamera;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox Threshold_Value_Import;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label5;
    }
}

