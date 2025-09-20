namespace ClubManagement
{
    partial class Foosball
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
            this.grpTable = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.Counter = new System.Windows.Forms.Label();
            this.btnDeleteone = new System.Windows.Forms.Button();
            this.btnPlayOne = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTable
            // 
            this.grpTable.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpTable.Controls.Add(this.btnStart);
            this.grpTable.Controls.Add(this.btnReset);
            this.grpTable.Controls.Add(this.Counter);
            this.grpTable.Controls.Add(this.btnDeleteone);
            this.grpTable.Controls.Add(this.btnPlayOne);
            this.grpTable.Controls.Add(this.lblName);
            this.grpTable.Controls.Add(this.btnSave);
            this.grpTable.Controls.Add(this.panel1);
            this.grpTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTable.ForeColor = System.Drawing.Color.White;
            this.grpTable.Location = new System.Drawing.Point(3, 0);
            this.grpTable.Name = "grpTable";
            this.grpTable.Size = new System.Drawing.Size(240, 400);
            this.grpTable.TabIndex = 6;
            this.grpTable.TabStop = false;
            this.grpTable.Text = "Tabel 1";
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(19, 249);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(202, 126);
            this.btnStart.TabIndex = 20;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::ClubManagement.Properties.Resources.reload;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(181, 337);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(41, 38);
            this.btnReset.TabIndex = 19;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Counter
            // 
            this.Counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Counter.Location = new System.Drawing.Point(19, 249);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(156, 82);
            this.Counter.TabIndex = 17;
            this.Counter.Text = "0";
            this.Counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeleteone
            // 
            this.btnDeleteone.BackgroundImage = global::ClubManagement.Properties.Resources.arrow_down_1_;
            this.btnDeleteone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeleteone.ForeColor = System.Drawing.Color.White;
            this.btnDeleteone.Location = new System.Drawing.Point(181, 293);
            this.btnDeleteone.Name = "btnDeleteone";
            this.btnDeleteone.Size = new System.Drawing.Size(41, 38);
            this.btnDeleteone.TabIndex = 16;
            this.btnDeleteone.UseVisualStyleBackColor = true;
            this.btnDeleteone.Click += new System.EventHandler(this.btnDeleteone_Click);
            // 
            // btnPlayOne
            // 
            this.btnPlayOne.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlayOne.BackgroundImage = global::ClubManagement.Properties.Resources.arrow_up_2_;
            this.btnPlayOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlayOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlayOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPlayOne.ForeColor = System.Drawing.Color.White;
            this.btnPlayOne.Location = new System.Drawing.Point(181, 249);
            this.btnPlayOne.Name = "btnPlayOne";
            this.btnPlayOne.Size = new System.Drawing.Size(41, 38);
            this.btnPlayOne.TabIndex = 15;
            this.btnPlayOne.UseVisualStyleBackColor = false;
            this.btnPlayOne.Click += new System.EventHandler(this.btnPlayOne_Click);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblName.Location = new System.Drawing.Point(19, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(203, 31);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Gust";
            this.lblName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblName.Leave += new System.EventHandler(this.lblName_Leave);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(69, 337);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 38);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ClubManagement.Properties.Resources._61X0ktUTPOL__UF350_350_QL80_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(19, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 181);
            this.panel1.TabIndex = 6;
            // 
            // Foosball
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.grpTable);
            this.Name = "Foosball";
            this.Size = new System.Drawing.Size(246, 403);
            this.grpTable.ResumeLayout(false);
            this.grpTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTable;
        private System.Windows.Forms.TextBox lblName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Counter;
        private System.Windows.Forms.Button btnDeleteone;
        private System.Windows.Forms.Button btnPlayOne;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStart;
    }
}
