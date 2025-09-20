using ClubManagementBusinessLayer.base_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static ClupManagementDataAccessLayer.Playedtypes;

namespace ClubManagementBusinessLayer
{
    public class Billiard : Table
    {
        protected static TableFees Table_Fees { get; set; }

        public delegate void BilliardFeesEventHandler();

        public event BilliardFeesEventHandler BilliardFeesChanged;

        public Billiard() : base(enTabletypes.Billiard)
        {
            DefultPlayType = enPlayedtypes.Hourly;
            Table_Fees = TableFees.Find(TableId);
            dues = Table_Fees.CreateDues(String.Empty, DefultPlayType, -1);
        }

        public override bool Start(string _PersonName, short value = 0)
        {
            dues.PersonName = _PersonName;
            IsLocked = true;
            if (dues.PlayedType == enPlayedtypes.Hourly)
            {
                StartTimer();
                return true;
            }
            else if (dues.PlayedType == enPlayedtypes.Matches)
            {
                Counter = value;
                return true;
            }
            else
            {
                IsLocked = false;
                return false;
            }
        }

        public override bool End()
        {
            if (dues.PlayedType == enPlayedtypes.Hourly)
            {
                PauseTimer();
                dues.Value = ElapsedTime();
            }
            else if (dues.PlayedType == enPlayedtypes.Matches)
            {
                dues.Value = Counter;
            }
            else
                return false;
            return Save();
        }

        public void PlayedOnceMore()
        {
            if (dues.PlayedType == enPlayedtypes.Matches && IsLocked)
            {
                Counter++;
            }
        }

        public void PlayedDleteOnce()
        {
            if (dues.PlayedType == enPlayedtypes.Matches && IsLocked)
                Counter--;
        }

        public void SetFeesbyHour()
        {
            if (dues.PlayedType == enPlayedtypes.Matches && !IsLocked)
                dues.PlayedType = enPlayedtypes.Hourly;
        }

        public void SetFeesbyMatche()
        {
            if (dues.PlayedType == enPlayedtypes.Hourly && !IsLocked)
                dues.PlayedType = enPlayedtypes.Matches;
        }

        public float? GetFeesbyHour()
        {
            return Table_Fees.GetFeesByHour();
        }

        public float? GetFeesbyMatche()
        {
            return Table_Fees.GetFeesByMatch();

        }

        public void PauseTimer() => PauseTime();

        public void ResumeTimer() => ResumeTime();

        public short TimesPlay() => TimesPlayed();

        public (float?, float?) GetFees() => (Table_Fees.FeesByHour, Table_Fees.FeesByMatch);
        
        public bool SaveMatchs (short matchs)
        {
            IsLocked = true;
            if (dues.PlayedType == enPlayedtypes.Matches && IsLocked && matchs > 0 && Playername != string.Empty)
            {
                dues.Value = matchs;
                IsLocked = false;
                return Save();
            }
            return false;
        }

        public bool ChangeMatchFees(float fee)
        {
            if (!IsLocked)
            {
                bool result = Table_Fees.ChangeFeesByMatch(fee);
                if (result)
                {
                    OnFeesChanged();
                    return true;
                }
            }
            return false;
        }

        public bool ChangeHourlyFees(float fee)
        {
            if (!IsLocked)
            {
                bool result = Table_Fees.ChangeFeesByHour(fee);
                if (result)
                {
                    OnFeesChanged();
                    return true;
                }
            }
            return false;
        }

        public bool ChangeAllFees(float feesByHour = 0, float feesbymatch = 0)
        {
            if (feesByHour == Table_Fees.FeesByHour || feesbymatch == Table_Fees.FeesByMatch)
                return false;
            else
            {
                Table_Fees.FeesByHour = feesByHour;
                Table_Fees.FeesByMatch = feesbymatch;
                Table_Fees.Saved = false;
            }
            bool result = Table_Fees.Save();
            if (result)
            {
                OnFeesChanged();
                return true;
            }
            return false;
        }

        protected virtual void OnFeesChanged()
        {
            BilliardFeesChanged?.Invoke();
        }

        private void RefreshFees()
        {
            dues = Table_Fees.CreateDues(Playername, DefultPlayType, -1);
        } 

        public void Subscribe(Billiard billiard)
        {
            billiard.BilliardFeesChanged += RefreshFees;
        }

    }
}
