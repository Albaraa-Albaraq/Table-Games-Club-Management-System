using ClubManagementBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubManagement
{
    public partial class Tennis : UserControl
    {
        public ClubManagementBusinessLayer.Tennis tennis = new ClubManagementBusinessLayer.Tennis();

        public ClubManagementBusinessLayer.Tennis TennisInstance
        {
            get { return tennis; }
        }

        public Tennis()
        {
            InitializeComponent();
        }


        private string _TableTitle = "Table";
        [
        Category("Pool Config"),
        Description("The table Name.")
        ]
        public string TableTitle
        {
            get
            {
                return _TableTitle;
            }
            set
            {
                _TableTitle = value;

                grpTable.Text = value;

                // The Invalidate method calls the OnPaint method, which redraws
                // the control.  
                Invalidate();
            }
        }

        private string _TablePlayer = "Gust";
        [
        Category("Pool Config"),
        Description("The Player Name.")
        ]
        public string TablePlayer
        {
            get
            {
                return _TablePlayer;
            }
            set
            {
                _TablePlayer = value;

                lblName.Text = value;

                // The Invalidate method calls the OnPaint method, which redraws
                // the control.  
                Invalidate();
            }
        }


        public class TableCompletedEventArgs : EventArgs
        {
            public string PlayerNamed { get; }
            public short timesplayed { get; }

            public TableCompletedEventArgs(string PlayerNamed, short timesplayed)
            {
                this.PlayerNamed = PlayerNamed;
                this.timesplayed = timesplayed;
            }
        }

        public event EventHandler<TableCompletedEventArgs> OnTableComplete;

        public void RaiseOnTableComplete(string PlayerNamed, short timesplayed)
        {
            RaiseOnTableComplete(new TableCompletedEventArgs(PlayerNamed, timesplayed));
        }

        protected virtual void RaiseOnTableComplete(TableCompletedEventArgs e)
        {
            OnTableComplete?.Invoke(this, e);
        }

        void Reset()
        {
            tennis = new ClubManagementBusinessLayer.Tennis();
            Counter.Text = "0";
            btnStart.Visible = true;
            lblName.Enabled = true;
            TablePlayer = "Gust";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RaiseOnTableComplete(TablePlayer, tennis.TimesPlay());
            tennis.End();
            Reset();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tennis.Start(TablePlayer);
            btnStart.Visible = false;
            lblName.Enabled = false;
        }

        private void btnPlayOne_Click(object sender, EventArgs e)
        {
            tennis.PlayedOnceMore();
            Counter.Text = tennis.TimesPlay().ToString();

        }

        private void btnDeleteone_Click(object sender, EventArgs e)
        {
            tennis.PlayedDleteOnce();
            Counter.Text = tennis.TimesPlay().ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void lblName_Leave(object sender, EventArgs e)
        {
            TablePlayer = lblName.Text;
        }
    }
}
