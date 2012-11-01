namespace CartPlayer
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCartIdent1 = new System.Windows.Forms.Label();
            this.chkboxCart1Loop = new System.Windows.Forms.CheckBox();
            this.lblItemName1 = new System.Windows.Forms.Label();
            this.lblTimingCart1 = new System.Windows.Forms.Label();
            this.btnCartStop1 = new System.Windows.Forms.Button();
            this.pbarCart1 = new System.Windows.Forms.ProgressBar();
            this.btnPlayAudio1 = new System.Windows.Forms.Button();
            this.btnLoadCart1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tmrCart1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCartIdent2 = new System.Windows.Forms.Label();
            this.chkboxCart2Loop = new System.Windows.Forms.CheckBox();
            this.lblItemName2 = new System.Windows.Forms.Label();
            this.lblTimingCart2 = new System.Windows.Forms.Label();
            this.btnCartStop2 = new System.Windows.Forms.Button();
            this.pbarCart2 = new System.Windows.Forms.ProgressBar();
            this.btnPlayAudio2 = new System.Windows.Forms.Button();
            this.btnLoadCart2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCartIdent3 = new System.Windows.Forms.Label();
            this.chkboxCart3Loop = new System.Windows.Forms.CheckBox();
            this.lblItemName3 = new System.Windows.Forms.Label();
            this.lblTimingCart3 = new System.Windows.Forms.Label();
            this.btnCartStop3 = new System.Windows.Forms.Button();
            this.pbarCart3 = new System.Windows.Forms.ProgressBar();
            this.btnPlayAudio3 = new System.Windows.Forms.Button();
            this.btnLoadCart3 = new System.Windows.Forms.Button();
            this.tmrCart2 = new System.Windows.Forms.Timer(this.components);
            this.tmrCart3 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CartPlayer.Properties.Resources.ban_sr;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(974, 67);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lblCartIdent1);
            this.panel1.Controls.Add(this.chkboxCart1Loop);
            this.panel1.Controls.Add(this.lblItemName1);
            this.panel1.Controls.Add(this.lblTimingCart1);
            this.panel1.Controls.Add(this.btnCartStop1);
            this.panel1.Controls.Add(this.pbarCart1);
            this.panel1.Controls.Add(this.btnPlayAudio1);
            this.panel1.Controls.Add(this.btnLoadCart1);
            this.panel1.Location = new System.Drawing.Point(22, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 106);
            this.panel1.TabIndex = 1;
            // 
            // lblCartIdent1
            // 
            this.lblCartIdent1.Font = new System.Drawing.Font("Gill Sans MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartIdent1.Location = new System.Drawing.Point(894, 0);
            this.lblCartIdent1.Name = "lblCartIdent1";
            this.lblCartIdent1.Size = new System.Drawing.Size(42, 106);
            this.lblCartIdent1.TabIndex = 7;
            this.lblCartIdent1.Text = "1";
            this.lblCartIdent1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkboxCart1Loop
            // 
            this.chkboxCart1Loop.AutoSize = true;
            this.chkboxCart1Loop.Location = new System.Drawing.Point(790, 82);
            this.chkboxCart1Loop.Name = "chkboxCart1Loop";
            this.chkboxCart1Loop.Size = new System.Drawing.Size(50, 17);
            this.chkboxCart1Loop.TabIndex = 6;
            this.chkboxCart1Loop.Text = "Loop";
            this.chkboxCart1Loop.UseVisualStyleBackColor = true;
            this.chkboxCart1Loop.CheckedChanged += new System.EventHandler(this.chkboxCart1Loop_CheckedChanged);
            // 
            // lblItemName1
            // 
            this.lblItemName1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemName1.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName1.Location = new System.Drawing.Point(260, 12);
            this.lblItemName1.Name = "lblItemName1";
            this.lblItemName1.Size = new System.Drawing.Size(511, 27);
            this.lblItemName1.TabIndex = 5;
            this.lblItemName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimingCart1
            // 
            this.lblTimingCart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimingCart1.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimingCart1.Location = new System.Drawing.Point(260, 74);
            this.lblTimingCart1.Name = "lblTimingCart1";
            this.lblTimingCart1.Size = new System.Drawing.Size(511, 27);
            this.lblTimingCart1.TabIndex = 4;
            this.lblTimingCart1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCartStop1
            // 
            this.btnCartStop1.Enabled = false;
            this.btnCartStop1.Location = new System.Drawing.Point(786, 12);
            this.btnCartStop1.Name = "btnCartStop1";
            this.btnCartStop1.Size = new System.Drawing.Size(102, 68);
            this.btnCartStop1.TabIndex = 3;
            this.btnCartStop1.Text = "STOP AUDIO";
            this.btnCartStop1.UseVisualStyleBackColor = true;
            this.btnCartStop1.Click += new System.EventHandler(this.btnCartStop1_Click);
            // 
            // pbarCart1
            // 
            this.pbarCart1.Location = new System.Drawing.Point(260, 32);
            this.pbarCart1.Name = "pbarCart1";
            this.pbarCart1.Size = new System.Drawing.Size(511, 38);
            this.pbarCart1.TabIndex = 2;
            // 
            // btnPlayAudio1
            // 
            this.btnPlayAudio1.Enabled = false;
            this.btnPlayAudio1.Location = new System.Drawing.Point(135, 11);
            this.btnPlayAudio1.Name = "btnPlayAudio1";
            this.btnPlayAudio1.Size = new System.Drawing.Size(112, 84);
            this.btnPlayAudio1.TabIndex = 1;
            this.btnPlayAudio1.Text = "PLAY whatever";
            this.btnPlayAudio1.UseVisualStyleBackColor = true;
            this.btnPlayAudio1.Click += new System.EventHandler(this.btnPlayAudio1_Click);
            // 
            // btnLoadCart1
            // 
            this.btnLoadCart1.Location = new System.Drawing.Point(12, 10);
            this.btnLoadCart1.Name = "btnLoadCart1";
            this.btnLoadCart1.Size = new System.Drawing.Size(110, 85);
            this.btnLoadCart1.TabIndex = 0;
            this.btnLoadCart1.Text = "LOAD AUDIO";
            this.btnLoadCart1.UseVisualStyleBackColor = true;
            this.btnLoadCart1.Click += new System.EventHandler(this.btnLoadCart1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tmrCart1
            // 
            this.tmrCart1.Interval = 10;
            this.tmrCart1.Tick += new System.EventHandler(this.tmrCart1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.lblCartIdent2);
            this.panel2.Controls.Add(this.chkboxCart2Loop);
            this.panel2.Controls.Add(this.lblItemName2);
            this.panel2.Controls.Add(this.lblTimingCart2);
            this.panel2.Controls.Add(this.btnCartStop2);
            this.panel2.Controls.Add(this.pbarCart2);
            this.panel2.Controls.Add(this.btnPlayAudio2);
            this.panel2.Controls.Add(this.btnLoadCart2);
            this.panel2.Location = new System.Drawing.Point(22, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 106);
            this.panel2.TabIndex = 7;
            // 
            // lblCartIdent2
            // 
            this.lblCartIdent2.Font = new System.Drawing.Font("Gill Sans MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartIdent2.Location = new System.Drawing.Point(894, 0);
            this.lblCartIdent2.Name = "lblCartIdent2";
            this.lblCartIdent2.Size = new System.Drawing.Size(42, 106);
            this.lblCartIdent2.TabIndex = 8;
            this.lblCartIdent2.Text = "2";
            this.lblCartIdent2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkboxCart2Loop
            // 
            this.chkboxCart2Loop.AutoSize = true;
            this.chkboxCart2Loop.Location = new System.Drawing.Point(790, 82);
            this.chkboxCart2Loop.Name = "chkboxCart2Loop";
            this.chkboxCart2Loop.Size = new System.Drawing.Size(50, 17);
            this.chkboxCart2Loop.TabIndex = 6;
            this.chkboxCart2Loop.Text = "Loop";
            this.chkboxCart2Loop.UseVisualStyleBackColor = true;
            this.chkboxCart2Loop.CheckedChanged += new System.EventHandler(this.chkboxCart2Loop_CheckedChanged);
            // 
            // lblItemName2
            // 
            this.lblItemName2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemName2.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName2.Location = new System.Drawing.Point(260, 12);
            this.lblItemName2.Name = "lblItemName2";
            this.lblItemName2.Size = new System.Drawing.Size(511, 27);
            this.lblItemName2.TabIndex = 5;
            this.lblItemName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimingCart2
            // 
            this.lblTimingCart2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimingCart2.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimingCart2.Location = new System.Drawing.Point(260, 74);
            this.lblTimingCart2.Name = "lblTimingCart2";
            this.lblTimingCart2.Size = new System.Drawing.Size(511, 27);
            this.lblTimingCart2.TabIndex = 4;
            this.lblTimingCart2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCartStop2
            // 
            this.btnCartStop2.Enabled = false;
            this.btnCartStop2.Location = new System.Drawing.Point(786, 12);
            this.btnCartStop2.Name = "btnCartStop2";
            this.btnCartStop2.Size = new System.Drawing.Size(102, 68);
            this.btnCartStop2.TabIndex = 3;
            this.btnCartStop2.Text = "STOP AUDIO";
            this.btnCartStop2.UseVisualStyleBackColor = true;
            this.btnCartStop2.Click += new System.EventHandler(this.btnCartStop2_Click);
            // 
            // pbarCart2
            // 
            this.pbarCart2.Location = new System.Drawing.Point(260, 32);
            this.pbarCart2.Name = "pbarCart2";
            this.pbarCart2.Size = new System.Drawing.Size(511, 38);
            this.pbarCart2.TabIndex = 2;
            // 
            // btnPlayAudio2
            // 
            this.btnPlayAudio2.Enabled = false;
            this.btnPlayAudio2.Location = new System.Drawing.Point(135, 11);
            this.btnPlayAudio2.Name = "btnPlayAudio2";
            this.btnPlayAudio2.Size = new System.Drawing.Size(112, 84);
            this.btnPlayAudio2.TabIndex = 1;
            this.btnPlayAudio2.Text = "PLAY AUDIO";
            this.btnPlayAudio2.UseVisualStyleBackColor = true;
            this.btnPlayAudio2.Click += new System.EventHandler(this.btnPlayAudio2_Click);
            // 
            // btnLoadCart2
            // 
            this.btnLoadCart2.Location = new System.Drawing.Point(12, 10);
            this.btnLoadCart2.Name = "btnLoadCart2";
            this.btnLoadCart2.Size = new System.Drawing.Size(110, 85);
            this.btnLoadCart2.TabIndex = 0;
            this.btnLoadCart2.Text = "LOAD AUDIO";
            this.btnLoadCart2.UseVisualStyleBackColor = true;
            this.btnLoadCart2.Click += new System.EventHandler(this.btnLoadCart2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.lblCartIdent3);
            this.panel3.Controls.Add(this.chkboxCart3Loop);
            this.panel3.Controls.Add(this.lblItemName3);
            this.panel3.Controls.Add(this.lblTimingCart3);
            this.panel3.Controls.Add(this.btnCartStop3);
            this.panel3.Controls.Add(this.pbarCart3);
            this.panel3.Controls.Add(this.btnPlayAudio3);
            this.panel3.Controls.Add(this.btnLoadCart3);
            this.panel3.Location = new System.Drawing.Point(22, 359);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 106);
            this.panel3.TabIndex = 8;
            // 
            // lblCartIdent3
            // 
            this.lblCartIdent3.Font = new System.Drawing.Font("Gill Sans MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartIdent3.Location = new System.Drawing.Point(897, 0);
            this.lblCartIdent3.Name = "lblCartIdent3";
            this.lblCartIdent3.Size = new System.Drawing.Size(42, 106);
            this.lblCartIdent3.TabIndex = 8;
            this.lblCartIdent3.Text = "3";
            this.lblCartIdent3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkboxCart3Loop
            // 
            this.chkboxCart3Loop.AutoSize = true;
            this.chkboxCart3Loop.Location = new System.Drawing.Point(790, 82);
            this.chkboxCart3Loop.Name = "chkboxCart3Loop";
            this.chkboxCart3Loop.Size = new System.Drawing.Size(50, 17);
            this.chkboxCart3Loop.TabIndex = 6;
            this.chkboxCart3Loop.Text = "Loop";
            this.chkboxCart3Loop.UseVisualStyleBackColor = true;
            this.chkboxCart3Loop.CheckedChanged += new System.EventHandler(this.chkboxCart3Loop_CheckedChanged);
            // 
            // lblItemName3
            // 
            this.lblItemName3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemName3.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName3.Location = new System.Drawing.Point(260, 12);
            this.lblItemName3.Name = "lblItemName3";
            this.lblItemName3.Size = new System.Drawing.Size(511, 27);
            this.lblItemName3.TabIndex = 5;
            this.lblItemName3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimingCart3
            // 
            this.lblTimingCart3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimingCart3.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimingCart3.Location = new System.Drawing.Point(260, 74);
            this.lblTimingCart3.Name = "lblTimingCart3";
            this.lblTimingCart3.Size = new System.Drawing.Size(511, 27);
            this.lblTimingCart3.TabIndex = 4;
            this.lblTimingCart3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCartStop3
            // 
            this.btnCartStop3.Enabled = false;
            this.btnCartStop3.Location = new System.Drawing.Point(786, 12);
            this.btnCartStop3.Name = "btnCartStop3";
            this.btnCartStop3.Size = new System.Drawing.Size(102, 68);
            this.btnCartStop3.TabIndex = 3;
            this.btnCartStop3.Text = "STOP AUDIO";
            this.btnCartStop3.UseVisualStyleBackColor = true;
            this.btnCartStop3.Click += new System.EventHandler(this.btnCartStop3_Click);
            // 
            // pbarCart3
            // 
            this.pbarCart3.Location = new System.Drawing.Point(260, 32);
            this.pbarCart3.Name = "pbarCart3";
            this.pbarCart3.Size = new System.Drawing.Size(511, 38);
            this.pbarCart3.TabIndex = 2;
            // 
            // btnPlayAudio3
            // 
            this.btnPlayAudio3.Enabled = false;
            this.btnPlayAudio3.Location = new System.Drawing.Point(135, 11);
            this.btnPlayAudio3.Name = "btnPlayAudio3";
            this.btnPlayAudio3.Size = new System.Drawing.Size(112, 84);
            this.btnPlayAudio3.TabIndex = 1;
            this.btnPlayAudio3.Text = "PLAY AUDIO";
            this.btnPlayAudio3.UseVisualStyleBackColor = true;
            this.btnPlayAudio3.Click += new System.EventHandler(this.btnPlayAudio3_Click);
            // 
            // btnLoadCart3
            // 
            this.btnLoadCart3.Location = new System.Drawing.Point(12, 10);
            this.btnLoadCart3.Name = "btnLoadCart3";
            this.btnLoadCart3.Size = new System.Drawing.Size(110, 85);
            this.btnLoadCart3.TabIndex = 0;
            this.btnLoadCart3.Text = "LOAD AUDIO";
            this.btnLoadCart3.UseVisualStyleBackColor = true;
            this.btnLoadCart3.Click += new System.EventHandler(this.btnLoadCart3_Click);
            // 
            // tmrCart2
            // 
            this.tmrCart2.Interval = 10;
            this.tmrCart2.Tick += new System.EventHandler(this.tmrCart2_Tick);
            // 
            // tmrCart3
            // 
            this.tmrCart3.Interval = 10;
            this.tmrCart3.Tick += new System.EventHandler(this.tmrCart3_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 479);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(973, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(773, 17);
            this.toolStripStatusLabel1.Text = "Cart Player by Andy Mace - 11/03/2012";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 501);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "School Report Package Player";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTimingCart1;
        private System.Windows.Forms.Button btnCartStop1;
        private System.Windows.Forms.ProgressBar pbarCart1;
        private System.Windows.Forms.Button btnPlayAudio1;
        private System.Windows.Forms.Button btnLoadCart1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer tmrCart1;
        private System.Windows.Forms.Label lblItemName1;
        private System.Windows.Forms.CheckBox chkboxCart1Loop;
        private System.Windows.Forms.Label lblCartIdent1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCartIdent2;
        private System.Windows.Forms.CheckBox chkboxCart2Loop;
        private System.Windows.Forms.Label lblItemName2;
        private System.Windows.Forms.Label lblTimingCart2;
        private System.Windows.Forms.Button btnCartStop2;
        private System.Windows.Forms.ProgressBar pbarCart2;
        private System.Windows.Forms.Button btnPlayAudio2;
        private System.Windows.Forms.Button btnLoadCart2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCartIdent3;
        private System.Windows.Forms.CheckBox chkboxCart3Loop;
        private System.Windows.Forms.Label lblItemName3;
        private System.Windows.Forms.Label lblTimingCart3;
        private System.Windows.Forms.Button btnCartStop3;
        private System.Windows.Forms.ProgressBar pbarCart3;
        private System.Windows.Forms.Button btnPlayAudio3;
        private System.Windows.Forms.Button btnLoadCart3;
        private System.Windows.Forms.Timer tmrCart2;
        private System.Windows.Forms.Timer tmrCart3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

