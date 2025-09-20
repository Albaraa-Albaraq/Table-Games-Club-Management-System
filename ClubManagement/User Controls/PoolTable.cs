using ClubManagement;
using ClubManagementBusinessLayer;
using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Windows.Forms;
using static ClupManagementDataAccessLayer.Playedtypes;

namespace _8Pool
{
    public partial class PoolTable : UserControl
    {
        private Billiard Billiard = new Billiard();

        public Billiard BilliardInstance
        {
            get { return Billiard; }
        }

        public PoolTable()
        {
            InitializeComponent();
        }

        public class TableCompletedEventArgs : EventArgs
        {
            public string PlayerNamed { get; }
            public enPlayedtypes TypePlayed { get; }
            public float value { get; }

            public TableCompletedEventArgs(string PlayerNamed, enPlayedtypes TypePlayed, float value)
            {
                this.PlayerNamed = PlayerNamed;
                this.TypePlayed = TypePlayed;
                this.value = value;
            }
        }

        public event EventHandler<TableCompletedEventArgs> OnTableComplete;

        public void RaiseOnTableComplete(string PlayerNamed, enPlayedtypes TyprPlayed, float value)
        {
            RaiseOnTableComplete(new TableCompletedEventArgs(PlayerNamed, TyprPlayed, value));
        }

        protected virtual void RaiseOnTableComplete(TableCompletedEventArgs e)
        {
            OnTableComplete?.Invoke(this, e);
        }


        int _Seconds;
        
        // Private data member that backs the EndColor property.
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
                Billiard.Playername = value;
                // The Invalidate method calls the OnPaint method, which redraws
                // the control.  
                Invalidate();
            }
        }


        void ResetTheTable()
        {
            Billiard = new ClubManagementBusinessLayer.Billiard();
            TablePlayer = "Gust";
            lblTime.Text = "00:00:00";
            btnStartStop.Text = "Start";
            _Seconds = 0;
            NM_Matchs.Value = 0;
            RBTN_Fees_by_hour.Visible = true;
            RBTN_Fees_by_match.Visible = true;
            RBTN_Fees_by_hour.Checked = true;
            lblName.Enabled =true;
            timer1.Stop();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "Start") 
            {
                btnStartStop.Text = "Pause";
                timer1.Start();
                Billiard.Start(TablePlayer);
                lblName.Enabled = false;
                RBTN_Fees_by_hour.Visible = false;
                RBTN_Fees_by_match.Visible = false;
            }
            else if (btnStartStop.Text == "Pause")
            {
                btnStartStop.Text = "Continoe";
                timer1.Stop();
                Billiard.PauseTimer();
            }
            else if (btnStartStop.Text == "Continoe")
            {
                btnStartStop.Text = "Pause";
                timer1.Start();
                Billiard.ResumeTimer();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _Seconds++;

            TimeSpan time = TimeSpan.FromSeconds(_Seconds);
            string str = time.ToString(@"hh\:mm\:ss");
            lblTime.Text = str;
            lblTime.Refresh();
        }

        private void PoolTable_Load(object sender, EventArgs e)
        {
            grpTable.Text = _TableTitle;
            lblName.Text=_TablePlayer;
            RBTN_Fees_by_hour.Checked = true;
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            lblName.Text = toolStripTextBox1.Text;
        }

        private void RBTN_Fees_by_hour_CheckedChanged(object sender, EventArgs e)
        {
            NM_Matchs.Visible = false;
            btn_Finsh.Visible = false;
            lblTime.Visible = true;
            btnStartStop.Visible = true;
            btnEnd.Visible = true;

            Billiard.SetFeesbyHour();
        }

        private void RBTN_Fees_by_match_CheckedChanged(object sender, EventArgs e)
        {
            NM_Matchs.Visible = true;
            btn_Finsh.Visible = true;
            lblTime.Visible = false;
            btnStartStop.Visible = false;
            btnEnd.Visible = false;

            Billiard.SetFeesbyMatche();
        }

        private void btn_Finsh_Click(object sender, EventArgs e)
        {
            RaiseOnTableComplete(TablePlayer, enPlayedtypes.Matches, (float)NM_Matchs.Value);
            Billiard.SaveMatchs((short)NM_Matchs.Value);
            ResetTheTable();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            RaiseOnTableComplete(TablePlayer, enPlayedtypes.Hourly, _CalculateTimeSpend());
            Billiard.End();
            ResetTheTable();
        }

        float _CalculateTimeSpend()
        {
            float TotalMinets = 0;

            while(_Seconds >= 60)
            {
                TotalMinets++;
                _Seconds -= 60;
            }

            //We take the Integer number of minutes.
            return TotalMinets;

            //If we want to rewind time exactly.
            //return TotalMinets += _Seconds / 100;
        }

        private void grpTable_Enter(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTheTable();
        }

        private void lblName_Leave(object sender, EventArgs e)
        {
            TablePlayer = lblName.Text;
        }

    }
}
