using System;
using static ClupManagementDataAccessLayer.Playedtypes;
using ClubManagementBusinessLayer.base_classes;

namespace ClubManagementBusinessLayer
{
    public class Tennis : Table
    {
        protected static TableFees TableFees { get; set; }

        public delegate void TennisFeesEventHandler();

        public event TennisFeesEventHandler TennisFeesChanged;

        public Tennis() : base(enTabletypes.Tennis)
        {
            DefultPlayType = enPlayedtypes.Matches;
            TableFees = TableFees.Find(TableId);
            dues = TableFees.CreateDues(String.Empty, DefultPlayType, -1);
        }

        public override bool Start(string _PersonName, short value = 0)
        {
            if (dues.PlayedType == enPlayedtypes.Matches)
            {
                dues.PersonName = _PersonName;
                IsLocked = true;
                Counter = value;
                return true;
            }
            else
                return false;
        }

        public override bool End()
        {
            if (dues.PlayedType == enPlayedtypes.Matches)
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
                Counter++;
        }

        public void PlayedDleteOnce()
        {
            if (dues.PlayedType == enPlayedtypes.Matches && IsLocked && Counter > 0)
                Counter--;
        }

        public short TimesPlay() => TimesPlayed();

        public bool ChangeMatchFees(float fee)
        {
            if (!IsLocked)
            {
                bool result = TableFees.ChangeFeesByMatch(fee);
                if (result)
                {
                    OnFeesChanged();
                    return true;
                }
            }
            return false;
        }

        public float? GetFeesbyMatche() => TableFees.GetFeesByMatch();

        public void Reset()
        {
            Counter = 0;
            dues.PersonName = string.Empty;
        }

        protected virtual void OnFeesChanged()
        {
            TennisFeesChanged?.Invoke();
        }

        private void RefreshFees()
        {
            dues = TableFees.CreateDues(Playername, DefultPlayType, -1);
        }

        public void Subscribe(Tennis tennis)
        {
            tennis.TennisFeesChanged += RefreshFees;
        }
    }

}
