namespace ClubManagement
{
    partial class MainBord
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpTable = new System.Windows.Forms.GroupBox();
            this.txtMatchFees = new System.Windows.Forms.TextBox();
            this.txtHolrFees = new System.Windows.Forms.TextBox();
            this.lblMatchsFees = new System.Windows.Forms.Label();
            this.lblHourlyFees = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTableName = new System.Windows.Forms.Label();
            this.btnPrevous = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Firstfoosball = new ClubManagement.Foosball();
            this.Firsttennis = new ClubManagement.Tennis();
            this.Secondtennis = new ClubManagement.Tennis();
            this.Thirdtennis = new ClubManagement.Tennis();
            this.Secondfoosball = new ClubManagement.Foosball();
            this.Thirdfoosball = new ClubManagement.Foosball();
            this.RightPool = new _8Pool.PoolTable();
            this.MiddleRightPool = new _8Pool.PoolTable();
            this.MiddleLeftPool = new _8Pool.PoolTable();
            this.LeftPool = new _8Pool.PoolTable();
            this.Front_Right = new ClubManagement.Pool_VIP();
            this.Front_Left = new ClubManagement.Pool_VIP();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.grpTable);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 973);
            this.panel1.TabIndex = 11;
            // 
            // grpTable
            // 
            this.grpTable.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpTable.Controls.Add(this.txtMatchFees);
            this.grpTable.Controls.Add(this.txtHolrFees);
            this.grpTable.Controls.Add(this.lblMatchsFees);
            this.grpTable.Controls.Add(this.lblHourlyFees);
            this.grpTable.Controls.Add(this.btnReset);
            this.grpTable.Controls.Add(this.lblTableName);
            this.grpTable.Controls.Add(this.btnPrevous);
            this.grpTable.Controls.Add(this.btnNext);
            this.grpTable.Controls.Add(this.btnSaveChanges);
            this.grpTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTable.ForeColor = System.Drawing.Color.White;
            this.grpTable.Location = new System.Drawing.Point(11, 734);
            this.grpTable.Name = "grpTable";
            this.grpTable.Size = new System.Drawing.Size(373, 233);
            this.grpTable.TabIndex = 9;
            this.grpTable.TabStop = false;
            // 
            // txtMatchFees
            // 
            this.txtMatchFees.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtMatchFees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatchFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatchFees.ForeColor = System.Drawing.SystemColors.Window;
            this.txtMatchFees.Location = new System.Drawing.Point(182, 120);
            this.txtMatchFees.MaxLength = 4;
            this.txtMatchFees.Name = "txtMatchFees";
            this.txtMatchFees.Size = new System.Drawing.Size(128, 22);
            this.txtMatchFees.TabIndex = 24;
            this.txtMatchFees.Text = "000";
            this.txtMatchFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHolrFees
            // 
            this.txtHolrFees.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtHolrFees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHolrFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHolrFees.ForeColor = System.Drawing.SystemColors.Window;
            this.txtHolrFees.Location = new System.Drawing.Point(182, 78);
            this.txtHolrFees.MaxLength = 4;
            this.txtHolrFees.Name = "txtHolrFees";
            this.txtHolrFees.Size = new System.Drawing.Size(128, 22);
            this.txtHolrFees.TabIndex = 23;
            this.txtHolrFees.Text = "000";
            this.txtHolrFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMatchsFees
            // 
            this.lblMatchsFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchsFees.Location = new System.Drawing.Point(67, 115);
            this.lblMatchsFees.Name = "lblMatchsFees";
            this.lblMatchsFees.Size = new System.Drawing.Size(110, 32);
            this.lblMatchsFees.TabIndex = 20;
            this.lblMatchsFees.Text = "Match fees :";
            this.lblMatchsFees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHourlyFees
            // 
            this.lblHourlyFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyFees.Location = new System.Drawing.Point(67, 70);
            this.lblHourlyFees.Name = "lblHourlyFees";
            this.lblHourlyFees.Size = new System.Drawing.Size(112, 28);
            this.lblHourlyFees.TabIndex = 19;
            this.lblHourlyFees.Text = "Hourly fees :";
            this.lblHourlyFees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::ClubManagement.Properties.Resources.reload;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(284, 164);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(41, 38);
            this.btnReset.TabIndex = 18;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTableName
            // 
            this.lblTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableName.Location = new System.Drawing.Point(10, 15);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(357, 48);
            this.lblTableName.TabIndex = 17;
            this.lblTableName.Text = "Table Name";
            this.lblTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrevous
            // 
            this.btnPrevous.BackgroundImage = global::ClubManagement.Properties.Resources.sdds;
            this.btnPrevous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrevous.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrevous.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPrevous.ForeColor = System.Drawing.Color.White;
            this.btnPrevous.Location = new System.Drawing.Point(12, 87);
            this.btnPrevous.Name = "btnPrevous";
            this.btnPrevous.Size = new System.Drawing.Size(41, 38);
            this.btnPrevous.TabIndex = 16;
            this.btnPrevous.UseVisualStyleBackColor = true;
            this.btnPrevous.Click += new System.EventHandler(this.btnPrevous_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNext.BackgroundImage = global::ClubManagement.Properties.Resources.ewewe;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(316, 86);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(41, 38);
            this.btnNext.TabIndex = 15;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(103, 167);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(146, 42);
            this.btnSaveChanges.TabIndex = 8;
            this.btnSaveChanges.Text = "Save Change";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 237);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table Games Club Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCyan;
            this.label2.Location = new System.Drawing.Point(27, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 362);
            this.label2.TabIndex = 1;
            this.label2.Text = "Transform your table game management experience into a smooth and professional on" +
    "e.\r\nSave time, streamline your operations, and focus on growing your business.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Firstfoosball
            // 
            this.Firstfoosball.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Firstfoosball.Location = new System.Drawing.Point(912, 562);
            this.Firstfoosball.Name = "Firstfoosball";
            this.Firstfoosball.Size = new System.Drawing.Size(246, 403);
            this.Firstfoosball.TabIndex = 23;
            this.Firstfoosball.TablePlayer = "Gust";
            this.Firstfoosball.TableTitle = "First";
            this.Firstfoosball.OnTableComplete += new System.EventHandler<ClubManagement.Foosball.TableCompletedEventArgs>(this.OnFoostballTableComplete);
            // 
            // Firsttennis
            // 
            this.Firsttennis.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Firsttennis.Location = new System.Drawing.Point(1160, 562);
            this.Firsttennis.Name = "Firsttennis";
            this.Firsttennis.Size = new System.Drawing.Size(246, 403);
            this.Firsttennis.TabIndex = 22;
            this.Firsttennis.TablePlayer = "Gust";
            this.Firsttennis.TableTitle = "First";
            this.Firsttennis.OnTableComplete += new System.EventHandler<ClubManagement.Tennis.TableCompletedEventArgs>(this.OnTennisTableComplete);
            // 
            // Secondtennis
            // 
            this.Secondtennis.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Secondtennis.Location = new System.Drawing.Point(1406, 562);
            this.Secondtennis.Name = "Secondtennis";
            this.Secondtennis.Size = new System.Drawing.Size(246, 403);
            this.Secondtennis.TabIndex = 21;
            this.Secondtennis.TablePlayer = "Gust";
            this.Secondtennis.TableTitle = "Second";
            this.Secondtennis.OnTableComplete += new System.EventHandler<ClubManagement.Tennis.TableCompletedEventArgs>(this.OnTennisTableComplete);
            // 
            // Thirdtennis
            // 
            this.Thirdtennis.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Thirdtennis.Location = new System.Drawing.Point(1658, 562);
            this.Thirdtennis.Name = "Thirdtennis";
            this.Thirdtennis.Size = new System.Drawing.Size(246, 403);
            this.Thirdtennis.TabIndex = 20;
            this.Thirdtennis.TablePlayer = "Gust";
            this.Thirdtennis.TableTitle = "Third";
            this.Thirdtennis.OnTableComplete += new System.EventHandler<ClubManagement.Tennis.TableCompletedEventArgs>(this.OnTennisTableComplete);
            // 
            // Secondfoosball
            // 
            this.Secondfoosball.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Secondfoosball.Location = new System.Drawing.Point(662, 562);
            this.Secondfoosball.Name = "Secondfoosball";
            this.Secondfoosball.Size = new System.Drawing.Size(246, 403);
            this.Secondfoosball.TabIndex = 19;
            this.Secondfoosball.TablePlayer = "Gust";
            this.Secondfoosball.TableTitle = "Second";
            this.Secondfoosball.OnTableComplete += new System.EventHandler<ClubManagement.Foosball.TableCompletedEventArgs>(this.OnFoostballTableComplete);
            // 
            // Thirdfoosball
            // 
            this.Thirdfoosball.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Thirdfoosball.Location = new System.Drawing.Point(410, 562);
            this.Thirdfoosball.Name = "Thirdfoosball";
            this.Thirdfoosball.Size = new System.Drawing.Size(246, 403);
            this.Thirdfoosball.TabIndex = 18;
            this.Thirdfoosball.TablePlayer = "Gust";
            this.Thirdfoosball.TableTitle = "Third";
            this.Thirdfoosball.OnTableComplete += new System.EventHandler<ClubManagement.Foosball.TableCompletedEventArgs>(this.OnFoostballTableComplete);
            // 
            // RightPool
            // 
            this.RightPool.BackColor = System.Drawing.Color.Black;
            this.RightPool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RightPool.Location = new System.Drawing.Point(1547, 280);
            this.RightPool.Name = "RightPool";
            this.RightPool.Size = new System.Drawing.Size(365, 276);
            this.RightPool.TabIndex = 17;
            this.RightPool.TablePlayer = "Gust";
            this.RightPool.TableTitle = "Right";
            this.RightPool.OnTableComplete += new System.EventHandler<_8Pool.PoolTable.TableCompletedEventArgs>(this.OnPoolTableComplete);
            // 
            // MiddleRightPool
            // 
            this.MiddleRightPool.BackColor = System.Drawing.Color.Black;
            this.MiddleRightPool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MiddleRightPool.Location = new System.Drawing.Point(1168, 280);
            this.MiddleRightPool.Name = "MiddleRightPool";
            this.MiddleRightPool.Size = new System.Drawing.Size(373, 276);
            this.MiddleRightPool.TabIndex = 16;
            this.MiddleRightPool.TablePlayer = "Gust";
            this.MiddleRightPool.TableTitle = "Middle Right";
            this.MiddleRightPool.OnTableComplete += new System.EventHandler<_8Pool.PoolTable.TableCompletedEventArgs>(this.OnPoolTableComplete);
            // 
            // MiddleLeftPool
            // 
            this.MiddleLeftPool.BackColor = System.Drawing.Color.Black;
            this.MiddleLeftPool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MiddleLeftPool.Location = new System.Drawing.Point(789, 280);
            this.MiddleLeftPool.Name = "MiddleLeftPool";
            this.MiddleLeftPool.Size = new System.Drawing.Size(373, 276);
            this.MiddleLeftPool.TabIndex = 15;
            this.MiddleLeftPool.TablePlayer = "Gust";
            this.MiddleLeftPool.TableTitle = "Middle Left";
            this.MiddleLeftPool.OnTableComplete += new System.EventHandler<_8Pool.PoolTable.TableCompletedEventArgs>(this.OnPoolTableComplete);
            // 
            // LeftPool
            // 
            this.LeftPool.BackColor = System.Drawing.Color.Black;
            this.LeftPool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LeftPool.Location = new System.Drawing.Point(410, 280);
            this.LeftPool.Name = "LeftPool";
            this.LeftPool.Size = new System.Drawing.Size(373, 276);
            this.LeftPool.TabIndex = 14;
            this.LeftPool.TablePlayer = "Gust";
            this.LeftPool.TableTitle = "Left";
            this.LeftPool.OnTableComplete += new System.EventHandler<_8Pool.PoolTable.TableCompletedEventArgs>(this.OnPoolTableComplete);
            // 
            // Front_Right
            // 
            this.Front_Right.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Front_Right.Location = new System.Drawing.Point(1160, 12);
            this.Front_Right.Name = "Front_Right";
            this.Front_Right.Size = new System.Drawing.Size(744, 262);
            this.Front_Right.TabIndex = 13;
            this.Front_Right.TablePlayer = "Gust";
            this.Front_Right.TableTitle = "Front Right";
            this.Front_Right.OnTableComplete += new System.EventHandler<ClubManagement.Pool_VIP.TableCompletedEventArgs>(this.OnVIPPoolTableComplete);
            // 
            // Front_Left
            // 
            this.Front_Left.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Front_Left.Location = new System.Drawing.Point(410, 12);
            this.Front_Left.Name = "Front_Left";
            this.Front_Left.Size = new System.Drawing.Size(744, 262);
            this.Front_Left.TabIndex = 12;
            this.Front_Left.TablePlayer = "Gust";
            this.Front_Left.TableTitle = "Front Left";
            this.Front_Left.OnTableComplete += new System.EventHandler<ClubManagement.Pool_VIP.TableCompletedEventArgs>(this.OnVIPPoolTableComplete);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightCyan;
            this.label3.Location = new System.Drawing.Point(12, 649);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 69);
            this.label3.TabIndex = 10;
            this.label3.Text = "This is the fees applied to your players now.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1924, 991);
            this.Controls.Add(this.Firstfoosball);
            this.Controls.Add(this.Firsttennis);
            this.Controls.Add(this.Secondtennis);
            this.Controls.Add(this.Thirdtennis);
            this.Controls.Add(this.Secondfoosball);
            this.Controls.Add(this.Thirdfoosball);
            this.Controls.Add(this.RightPool);
            this.Controls.Add(this.MiddleRightPool);
            this.Controls.Add(this.MiddleLeftPool);
            this.Controls.Add(this.LeftPool);
            this.Controls.Add(this.Front_Right);
            this.Controls.Add(this.Front_Left);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainBord";
            this.Text = "MainBord";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainBord_Load);
            this.panel1.ResumeLayout(false);
            this.grpTable.ResumeLayout(false);
            this.grpTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Pool_VIP Front_Left;
        private Pool_VIP Front_Right;
        private _8Pool.PoolTable LeftPool;
        private _8Pool.PoolTable MiddleLeftPool;
        private _8Pool.PoolTable MiddleRightPool;
        private _8Pool.PoolTable RightPool;
        private Foosball Thirdfoosball;
        private Foosball Secondfoosball;
        private Tennis Thirdtennis;
        private Tennis Secondtennis;
        private Tennis Firsttennis;
        private Foosball Firstfoosball;
        private System.Windows.Forms.GroupBox grpTable;
        private System.Windows.Forms.Label lblMatchsFees;
        private System.Windows.Forms.Label lblHourlyFees;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Button btnPrevous;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtMatchFees;
        private System.Windows.Forms.TextBox txtHolrFees;
        private System.Windows.Forms.Label label3;
    }
}