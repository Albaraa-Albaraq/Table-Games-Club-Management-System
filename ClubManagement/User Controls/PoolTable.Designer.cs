namespace _8Pool
{
    partial class PoolTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpTable = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.TextBox();
            this.btn_Finsh = new System.Windows.Forms.Button();
            this.RBTN_Fees_by_match = new System.Windows.Forms.RadioButton();
            this.RBTN_Fees_by_hour = new System.Windows.Forms.RadioButton();
            this.NM_Matchs = new System.Windows.Forms.NumericUpDown();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmsPlayer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grpTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NM_Matchs)).BeginInit();
            this.cmsPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTable
            // 
            this.grpTable.Controls.Add(this.btnReset);
            this.grpTable.Controls.Add(this.lblName);
            this.grpTable.Controls.Add(this.btn_Finsh);
            this.grpTable.Controls.Add(this.RBTN_Fees_by_match);
            this.grpTable.Controls.Add(this.RBTN_Fees_by_hour);
            this.grpTable.Controls.Add(this.NM_Matchs);
            this.grpTable.Controls.Add(this.lblTime);
            this.grpTable.Controls.Add(this.btnEnd);
            this.grpTable.Controls.Add(this.btnStartStop);
            this.grpTable.Controls.Add(this.panel1);
            this.grpTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTable.ForeColor = System.Drawing.Color.White;
            this.grpTable.Location = new System.Drawing.Point(8, 3);
            this.grpTable.Name = "grpTable";
            this.grpTable.Size = new System.Drawing.Size(353, 262);
            this.grpTable.TabIndex = 5;
            this.grpTable.TabStop = false;
            this.grpTable.Text = "Tabel 1";
            this.grpTable.Enter += new System.EventHandler(this.grpTable_Enter);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::ClubManagement.Properties.Resources.reload;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(310, 216);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(41, 38);
            this.btnReset.TabIndex = 20;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblName.Location = new System.Drawing.Point(81, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(191, 31);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Gust";
            this.lblName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblName.Leave += new System.EventHandler(this.lblName_Leave);
            // 
            // btn_Finsh
            // 
            this.btn_Finsh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Finsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Finsh.ForeColor = System.Drawing.Color.White;
            this.btn_Finsh.Location = new System.Drawing.Point(113, 216);
            this.btn_Finsh.Name = "btn_Finsh";
            this.btn_Finsh.Size = new System.Drawing.Size(133, 38);
            this.btn_Finsh.TabIndex = 13;
            this.btn_Finsh.Text = "Finish";
            this.btn_Finsh.UseVisualStyleBackColor = true;
            this.btn_Finsh.Click += new System.EventHandler(this.btn_Finsh_Click);
            // 
            // RBTN_Fees_by_match
            // 
            this.RBTN_Fees_by_match.Location = new System.Drawing.Point(243, 107);
            this.RBTN_Fees_by_match.Name = "RBTN_Fees_by_match";
            this.RBTN_Fees_by_match.Size = new System.Drawing.Size(97, 47);
            this.RBTN_Fees_by_match.TabIndex = 12;
            this.RBTN_Fees_by_match.Text = "Fees by match";
            this.RBTN_Fees_by_match.UseVisualStyleBackColor = true;
            this.RBTN_Fees_by_match.CheckedChanged += new System.EventHandler(this.RBTN_Fees_by_match_CheckedChanged);
            // 
            // RBTN_Fees_by_hour
            // 
            this.RBTN_Fees_by_hour.Location = new System.Drawing.Point(243, 65);
            this.RBTN_Fees_by_hour.Name = "RBTN_Fees_by_hour";
            this.RBTN_Fees_by_hour.Size = new System.Drawing.Size(103, 46);
            this.RBTN_Fees_by_hour.TabIndex = 11;
            this.RBTN_Fees_by_hour.Text = "Fees  by hour";
            this.RBTN_Fees_by_hour.UseVisualStyleBackColor = true;
            this.RBTN_Fees_by_hour.CheckedChanged += new System.EventHandler(this.RBTN_Fees_by_hour_CheckedChanged);
            // 
            // NM_Matchs
            // 
            this.NM_Matchs.Location = new System.Drawing.Point(243, 167);
            this.NM_Matchs.Name = "NM_Matchs";
            this.NM_Matchs.Size = new System.Drawing.Size(82, 26);
            this.NM_Matchs.TabIndex = 10;
            this.NM_Matchs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(216, 157);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(131, 35);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEnd
            // 
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEnd.ForeColor = System.Drawing.Color.White;
            this.btnEnd.Location = new System.Drawing.Point(54, 216);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(106, 38);
            this.btnEnd.TabIndex = 8;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnStartStop
            // 
            this.btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStartStop.ForeColor = System.Drawing.Color.White;
            this.btnStartStop.Location = new System.Drawing.Point(198, 216);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(106, 38);
            this.btnStartStop.TabIndex = 7;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ClubManagement.Properties.Resources.billiards_5489526_1280;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(19, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 145);
            this.panel1.TabIndex = 6;
            // 
            // cmsPlayer
            // 
            this.cmsPlayer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.cmsPlayer.Name = "cmsPlayer";
            this.cmsPlayer.Size = new System.Drawing.Size(161, 29);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PoolTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.grpTable);
            this.DoubleBuffered = true;
            this.Name = "PoolTable";
            this.Size = new System.Drawing.Size(373, 276);
            this.Load += new System.EventHandler(this.PoolTable_Load);
            this.grpTable.ResumeLayout(false);
            this.grpTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NM_Matchs)).EndInit();
            this.cmsPlayer.ResumeLayout(false);
            this.cmsPlayer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTable;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip cmsPlayer;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.RadioButton RBTN_Fees_by_match;
        private System.Windows.Forms.RadioButton RBTN_Fees_by_hour;
        private System.Windows.Forms.NumericUpDown NM_Matchs;
        private System.Windows.Forms.Button btn_Finsh;
        private System.Windows.Forms.TextBox lblName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnReset;
    }
}
