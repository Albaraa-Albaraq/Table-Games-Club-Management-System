using ClubManagementBusinessLayer.base_classes;
using System;
using static ClupManagementDataAccessLayer.Playedtypes;

namespace ClubManagementBusinessLayer
{
    public class Foosball : Table
    {
        protected static TableFees TableFees { get; set; }

        public delegate void FoosballFeesEventHandler();

        public event FoosballFeesEventHandler FoosballFeesChanged;

        public Foosball() : base(enTabletypes.Foosball)
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

        protected virtual void OnFeesChanged()
        {
            FoosballFeesChanged?.Invoke();
        }

        private void RefreshFees()
        {
            dues = TableFees.CreateDues(Playername, DefultPlayType, -1);
        }

        public void Subscribe(Foosball foosball)
        {
            foosball.FoosballFeesChanged += RefreshFees;
        }

    }
}
