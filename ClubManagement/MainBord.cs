using ClubManagementBusinessLayer;
using ClubManagementBusinessLayer.base_classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClubManagementBusinessLayer.base_classes.Table;

namespace ClubManagement
{
    public partial class MainBord : Form
    {
        Billiard MainBilliardTable = new Billiard();
        VIP_billiards MainVIP_Billiards = new VIP_billiards();
        ClubManagementBusinessLayer.Foosball MainFoosballTable = new ClubManagementBusinessLayer.Foosball();
        ClubManagementBusinessLayer.Tennis MainTennisTable = new ClubManagementBusinessLayer.Tennis();


        public MainBord()
        {
            InitializeComponent();
        }

        private void MainBord_Load(object sender, EventArgs e)
        {
            // جداول البلياردو
            LeftPool.BilliardInstance.Subscribe(MainBilliardTable);
            MiddleLeftPool.BilliardInstance.Subscribe(MainBilliardTable);
            MiddleRightPool.BilliardInstance.Subscribe(MainBilliardTable);
            RightPool.BilliardInstance.Subscribe(MainBilliardTable);

            // VIP Billiards
            Front_Left.VIP_BilliardInstance.Subscribe(MainVIP_Billiards);
            Front_Right.VIP_BilliardInstance.Subscribe(MainVIP_Billiards);

            // Foosball
            Firstfoosball.foosballInstance.Subscribe(MainFoosballTable);
            Secondfoosball.foosballInstance.Subscribe(MainFoosballTable);
            Thirdfoosball.foosballInstance.Subscribe(MainFoosballTable);

            // Tennis
            Firsttennis.TennisInstance.Subscribe(MainTennisTable);
            Secondtennis.TennisInstance.Subscribe(MainTennisTable);
            Thirdtennis.TennisInstance.Subscribe(MainTennisTable);


            btnNext_Click(null, null);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            switch (lblTableName.Text)
            {
                case "Table Name":
                    SetBilliard();
                    break;
                case "Billiard":
                    SetVIP_Billiard();
                    break;
             
                case "VIP Billiard":
                    SetFoosball();
                    break;
                    
                case "Foosball":
                    SetTennis();
                    break;
                case "Tennis":
                    SetBilliard();
                    break;
            }
        }

        private void btnPrevous_Click(object sender, EventArgs e)
        {
            switch (lblTableName.Text)
            {
                case "Table Name":
                    SetTennis();
                    break;
                case "Billiard":
                    SetTennis();
                    break;

                case "VIP Billiard":
                    SetBilliard();
                    break;

                case "Foosball":
                    SetVIP_Billiard();
                    break;
                case "Tennis":
                    SetFoosball();
                    break;
            }
        }

        void SetBilliard()
        {
            ShowFeesScrean();
            lblTableName.Text = MainBilliardTable.TableName;
            txtHolrFees.Text = MainBilliardTable.GetFeesbyHour().ToString();
            txtMatchFees.Text = MainBilliardTable.GetFeesbyMatche().ToString();
        }
        void SetFoosball()
        {
            ShowFeesbyMatchScrean();
            lblTableName.Text = MainFoosballTable.TableName;
            txtMatchFees.Text = MainFoosballTable.GetFeesbyMatche().ToString();
        }
        void SetVIP_Billiard()
        {
            ShowFeesbyHourScrean();
            lblTableName.Text = MainVIP_Billiards.TableName;
            txtHolrFees.Text = MainVIP_Billiards.GetHourlyFees().ToString();
        }
        void SetTennis()
        {
            ShowFeesbyMatchScrean();
            lblTableName.Text = MainTennisTable.TableName;
            txtMatchFees.Text = MainTennisTable.GetFeesbyMatche().ToString();
        }


        void ShowFeesScrean()
        {
            txtHolrFees.Visible = true;
            lblHourlyFees.Visible = true;
            txtMatchFees.Visible = true;
            lblMatchsFees.Visible = true;
        }
        void ShowFeesbyMatchScrean()
        {
            txtHolrFees.Visible = false;
            lblHourlyFees.Visible = false;
            txtMatchFees.Visible = true;
            lblMatchsFees.Visible = true;
        }
        void ShowFeesbyHourScrean()
        {
            txtHolrFees.Visible = true;
            lblHourlyFees.Visible = true;
            txtMatchFees.Visible = false;
            lblMatchsFees.Visible = false;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            switch (lblTableName.Text)
            {
                case "Table Name":
                    break;
                case "Billiard":
                    BilliardFeesChange();
                    break;
                case "VIP Billiard":
                    VIP_BilliardFeesChange();
                    break;
                case "Foosball":
                    FoosballFeesChange();
                    break;
                case "Tennis":
                    TennisFeesChange();
                    break;
            }
            string Message = "The changes you have done, Will apply to existing players.";
            MessageBox.Show(Message, "Fees Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnReset_Click(null, null);
        }

        bool BilliardFeesChange()
        {
            if ((float)Convert.ToDouble(txtHolrFees.Text) != MainBilliardTable.GetFeesbyHour() && (float)Convert.ToDouble(txtMatchFees.Text) != MainBilliardTable.GetFeesbyMatche())
            {
                return MainBilliardTable.ChangeAllFees((float)Convert.ToDouble(txtHolrFees.Text), (float)Convert.ToDouble(txtMatchFees.Text));
            }

            if ((float)Convert.ToDouble(txtHolrFees.Text) != MainBilliardTable.GetFeesbyHour())
            {
                return MainBilliardTable.ChangeHourlyFees((float)Convert.ToDouble(txtHolrFees.Text));
            }

            if ((float)Convert.ToDouble(txtMatchFees.Text) != MainBilliardTable.GetFeesbyMatche())
            {
                return MainBilliardTable.ChangeMatchFees((float)Convert.ToDouble(txtMatchFees.Text));
            }
            return false;
        }

        bool VIP_BilliardFeesChange()
        {
            if ((float)Convert.ToDouble(txtHolrFees.Text) != MainVIP_Billiards.GetHourlyFees())
            {
                return MainVIP_Billiards.ChangeHourlyFees((float)Convert.ToDouble(txtHolrFees.Text));
            }
            return false;
        }

        bool FoosballFeesChange()
        {
            if ((float)Convert.ToDouble(txtMatchFees.Text) != MainFoosballTable.GetFeesbyMatche())
            {
                return MainFoosballTable.ChangeMatchFees((float)Convert.ToDouble(txtMatchFees.Text));
            }
            return false;
        }

        bool TennisFeesChange()
        {
            if ((float)Convert.ToDouble(txtMatchFees.Text) != MainTennisTable.GetFeesbyMatche())
            {
                return MainTennisTable.ChangeMatchFees((float)Convert.ToDouble(txtMatchFees.Text));
            }
            return false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            switch (lblTableName.Text)
            {
                case "Table Name":
                    break;
                case "Billiard":
                    SetBilliard();
                    break;
                case "VIP Billiard":
                    SetVIP_Billiard();
                    break;
                case "Foosball":
                    SetFoosball();
                    break;
                case "Tennis":
                    SetTennis();
                    break;
            }
        }

        private void OnPoolTableComplete(object sender, _8Pool.PoolTable.TableCompletedEventArgs e)
        {
            string Message = "Player |" + e.PlayerNamed + "| Have Played for " + e.value;

            if(e.TypePlayed == ClupManagementDataAccessLayer.Playedtypes.enPlayedtypes.Hourly)
            {
                Message = Message + "Mintes And The fees of that Is "+ (e.value * MainBilliardTable.GetFeesbyHour()).ToString();
            }

            if (e.TypePlayed == ClupManagementDataAccessLayer.Playedtypes.enPlayedtypes.Matches)
            {
                Message = Message + "times And The fees of that Is " + (e.value * MainBilliardTable.GetFeesbyMatche()).ToString();
            }

            MessageBox.Show(Message,"Table Report",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void OnVIPPoolTableComplete(object sender, Pool_VIP.TableCompletedEventArgs e)
        {
            string Message = "Player |" + e.PlayerNamed + "| Have Played for " + e.value + "Mintes And The fees of that Is " + (e.value * MainVIP_Billiards.GetHourlyFees()).ToString();

            MessageBox.Show(Message, "Table Report", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void OnFoostballTableComplete(object sender, Foosball.TableCompletedEventArgs e)
        {
            string Message = "Player |" + e.PlayerNamed + "| Have Played for " + e.timesplayed + " times And The fees of that Is " + (e.timesplayed * MainFoosballTable.GetFeesbyMatche()).ToString();
            MessageBox.Show(Message, "Table Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OnTennisTableComplete(object sender, Tennis.TableCompletedEventArgs e)
        {
            string Message = "Player |" + e.PlayerNamed + "| Have Played for " + e.timesplayed + " times And The fees of that Is " + (e.timesplayed * MainTennisTable.GetFeesbyMatche()).ToString();
            MessageBox.Show(Message, "Table Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
