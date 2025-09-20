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
    public partial class Pool_VIP : UserControl
    {
        private VIP_billiards VIP_Billiard = new VIP_billiards();

        public VIP_billiards VIP_BilliardInstance
        {
            get { return VIP_Billiard; }
        }

        public Pool_VIP()
        {
            InitializeComponent();
        }


        public class TableCompletedEventArgs : EventArgs
        {
            public string PlayerNamed { get; }
            public float value { get; }

            public TableCompletedEventArgs(string PlayerNamed, float value)
            {
                this.PlayerNamed = PlayerNamed;
                this.value = value;
            }
        }

        public event EventHandler<TableCompletedEventArgs> OnTableComplete;

        public void RaiseOnTableComplete(string PlayerNamed, float value)
        {
            RaiseOnTableComplete(new TableCompletedEventArgs(PlayerNamed, value));
        }

        protected virtual void RaiseOnTableComplete(TableCompletedEventArgs e)
        {
            OnTableComplete?.Invoke(this, e);
        }


        int _Seconds;
        private string _TableTitle = "Table";
        [
        Category("VIP Pool Config"),
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
        Category("VIP Pool Config"),
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

        void ResetTheTable()
        {
            TablePlayer = "Gust";
            lblTime.Text = "00:00:00";
            btnStartStop.Text = "Start";
            _Seconds = 0;
            lblName.Enabled = true;
            timer1.Stop();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "Start")
            {
                btnStartStop.Text = "Pause";
                timer1.Start();
                VIP_Billiard.Start(TablePlayer);
                lblName.Enabled = false;
            }
            else if (btnStartStop.Text == "Pause")
            {
                btnStartStop.Text = "Continoe";
                timer1.Stop();
                VIP_Billiard.PauseTimer();
            }
            else if (btnStartStop.Text == "Continoe")
            {
                btnStartStop.Text = "Pause";
                timer1.Start();
                VIP_Billiard.ResumeTimer();
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

        private void btnEnd_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            RaiseOnTableComplete(_TablePlayer, _CalculateTimeSpend());
            VIP_Billiard.End();
            ResetTheTable();
        }

        float _CalculateTimeSpend()
        {
            float TotalMinets = 0;

            while (_Seconds >= 60)
            {
                TotalMinets++;
                _Seconds -= 60;
            }

            //We take the Integer number of minutes.
            return TotalMinets;

            //If we want to rewind time exactly.
            //return TotalMinets += _Seconds / 100;
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
