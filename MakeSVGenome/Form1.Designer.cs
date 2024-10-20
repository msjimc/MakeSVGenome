namespace MakeSVGenome
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            btnMakeRead = new Button();
            nudInterval = new NumericUpDown();
            nudlength = new NumericUpDown();
            label3 = new Label();
            chkRC = new CheckBox();
            txtInsertion = new TextBox();
            label2 = new Label();
            btnPut = new Button();
            txtDonor = new TextBox();
            lblInsert = new Label();
            btnGet = new Button();
            btnQuit = new Button();
            menuStrip1 = new MenuStrip();
            batchJobToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudInterval).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudlength).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnMakeRead);
            groupBox1.Controls.Add(nudInterval);
            groupBox1.Controls.Add(nudlength);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(chkRC);
            groupBox1.Controls.Add(txtInsertion);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnPut);
            groupBox1.Controls.Add(txtDonor);
            groupBox1.Controls.Add(lblInsert);
            groupBox1.Controls.Add(btnGet);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(663, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Options";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(221, 158);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 12;
            label5.Text = "Interval (Kb)";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(11, 158);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 11;
            label4.Text = "Read length (kb)";
            // 
            // btnMakeRead
            // 
            btnMakeRead.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMakeRead.Location = new Point(579, 154);
            btnMakeRead.Name = "btnMakeRead";
            btnMakeRead.Size = new Size(75, 23);
            btnMakeRead.TabIndex = 10;
            btnMakeRead.Text = "Make";
            btnMakeRead.UseVisualStyleBackColor = true;
            btnMakeRead.Click += btnMakeRead_Click;
            // 
            // nudInterval
            // 
            nudInterval.Anchor = AnchorStyles.Top;
            nudInterval.Location = new Point(298, 156);
            nudInterval.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudInterval.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudInterval.Name = "nudInterval";
            nudInterval.Size = new Size(75, 23);
            nudInterval.TabIndex = 9;
            nudInterval.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudlength
            // 
            nudlength.Anchor = AnchorStyles.Top;
            nudlength.Location = new Point(111, 156);
            nudlength.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudlength.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudlength.Name = "nudlength";
            nudlength.Size = new Size(74, 23);
            nudlength.TabIndex = 8;
            nudlength.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 136);
            label3.Name = "label3";
            label3.Size = new Size(327, 15);
            label3.TabIndex = 7;
            label3.Text = "Create reads , set the read length and gap between each read";
            // 
            // chkRC
            // 
            chkRC.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkRC.AutoSize = true;
            chkRC.CheckAlign = ContentAlignment.MiddleRight;
            chkRC.Location = new Point(439, 43);
            chkRC.Name = "chkRC";
            chkRC.Size = new Size(137, 19);
            chkRC.TabIndex = 6;
            chkRC.Text = "Reverse complement";
            chkRC.UseVisualStyleBackColor = true;
            // 
            // txtInsertion
            // 
            txtInsertion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtInsertion.Location = new Point(8, 98);
            txtInsertion.Name = "txtInsertion";
            txtInsertion.Size = new Size(565, 23);
            txtInsertion.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 76);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 4;
            label2.Text = "Enter insertion point";
            // 
            // btnPut
            // 
            btnPut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPut.Location = new Point(579, 98);
            btnPut.Name = "btnPut";
            btnPut.Size = new Size(75, 23);
            btnPut.TabIndex = 3;
            btnPut.Text = "Put";
            btnPut.UseVisualStyleBackColor = true;
            btnPut.Click += btnPut_Click;
            // 
            // txtDonor
            // 
            txtDonor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDonor.Location = new Point(11, 41);
            txtDonor.Name = "txtDonor";
            txtDonor.Size = new Size(422, 23);
            txtDonor.TabIndex = 2;
            // 
            // lblInsert
            // 
            lblInsert.AutoSize = true;
            lblInsert.Location = new Point(11, 19);
            lblInsert.Name = "lblInsert";
            lblInsert.Size = new Size(340, 15);
            lblInsert.TabIndex = 1;
            lblInsert.Text = "Enter location of donor sequence (e.g. 100,000,000-105,000,000)";
            // 
            // btnGet
            // 
            btnGet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGet.Location = new Point(582, 41);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(75, 23);
            btnGet.TabIndex = 0;
            btnGet.Text = "Get";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // btnQuit
            // 
            btnQuit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnQuit.Location = new Point(591, 233);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 23);
            btnQuit.TabIndex = 1;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { batchJobToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(687, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // batchJobToolStripMenuItem
            // 
            batchJobToolStripMenuItem.Name = "batchJobToolStripMenuItem";
            batchJobToolStripMenuItem.Size = new Size(69, 20);
            batchJobToolStripMenuItem.Text = "Batch job";
            batchJobToolStripMenuItem.Click += batchJobToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 268);
            Controls.Add(btnQuit);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Make structural variants";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudInterval).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudlength).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDonor;
        private Label lblInsert;
        private Button btnGet;
        private Button btnQuit;
        private CheckBox chkRC;
        private TextBox txtInsertion;
        private Label label2;
        private Button btnPut;
        private Label label5;
        private Label label4;
        private Button btnMakeRead;
        private NumericUpDown nudInterval;
        private NumericUpDown nudlength;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem batchJobToolStripMenuItem;
    }
}
