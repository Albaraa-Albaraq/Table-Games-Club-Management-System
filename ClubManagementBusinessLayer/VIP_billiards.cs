using ClubManagementBusinessLayer.base_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClubManagementBusinessLayer.base_classes.Table;
using static ClupManagementDataAccessLayer.Playedtypes;

namespace ClubManagementBusinessLayer
{
    public class VIP_billiards : Table
    {
        protected static TableFees TableFees { get; set; }

        public delegate void VIP_billiardsFeesEventHandler();

        public event VIP_billiardsFeesEventHandler VIP_billiardsFeesChanged;

        public VIP_billiards() : base(enTabletypes.VIP_Billiard)
        {
            DefultPlayType = enPlayedtypes.Hourly;
            TableFees = TableFees.Find(TableId);
            dues = TableFees.CreateDues(String.Empty, DefultPlayType, -1);
        }

        public override bool Start(string _PersonName, short value = 0)
        {
            if (dues.PlayedType == enPlayedtypes.Hourly)
            {
                dues.PersonName = _PersonName;
                IsLocked = true;
                StartTimer();
                return true;
            }
            return false;
        }

        public override bool End()
        {
            if (dues.PlayedType == enPlayedtypes.Hourly)
            {
                PauseTimer();
                dues.Value = ElapsedTime();
            }
            else
                return false;
            return Save();
        }

        public short TimePlayNow() => ElapsedTime();

        public void PauseTimer() => PauseTime();

        public void ResumeTimer() => ResumeTime();

        public bool ChangeHourlyFees(float fee)
        {
            if (!IsLocked)
            {
                bool result = TableFees.ChangeFeesByHour(fee);
                if (result)
                {
                    OnFeesChanged();
                    return true;
                }
            }
            return false;
        }

        public float? GetHourlyFees() => TableFees.GetFeesByHour();

        protected virtual void OnFeesChanged()
        {
            VIP_billiardsFeesChanged?.Invoke();
        }

        private void RefreshFees()
        {
            dues = TableFees.CreateDues(Playername, DefultPlayType, -1);
        }

        public void Subscribe(VIP_billiards VIP_billiard)
        {
            VIP_billiard.VIP_billiardsFeesChanged += RefreshFees;
        }
    }

}
