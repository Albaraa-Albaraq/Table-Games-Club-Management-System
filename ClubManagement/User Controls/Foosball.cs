using ClubManagementBusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ClubManagement
{
    public partial class Foosball : UserControl
    {
        private ClubManagementBusinessLayer.Foosball foosball = new ClubManagementBusinessLayer.Foosball();

        public ClubManagementBusinessLayer.Foosball foosballInstance
        {
            get { return foosball; }
        }

        public Foosball()
        {
            InitializeComponent();
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

        void Reset()
        {
            foosball = new ClubManagementBusinessLayer.Foosball();
            Counter.Text = "0";
            btnStart.Visible = true;
            lblName.Enabled = true;
            TablePlayer = "Gust";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RaiseOnTableComplete(TablePlayer,foosball.TimesPlay());
            foosball.End();
            Reset();
        }

        private void btnPlayOne_Click(object sender, EventArgs e)
        {
            foosball.PlayedOnceMore();
            Counter.Text = foosball.TimesPlay().ToString();

        }

        private void btnDeleteone_Click(object sender, EventArgs e)
        {
            foosball.PlayedDleteOnce();
            Counter.Text = foosball.TimesPlay().ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            foosball.Start(TablePlayer);
            btnStart.Visible = false;
            lblName.Enabled = false;
        }

        internal void Subscribe()
        {
            throw new NotImplementedException();
        }

        private void lblName_Leave(object sender, EventArgs e)
        {
            TablePlayer = lblName.Text;
        }

    }
}
