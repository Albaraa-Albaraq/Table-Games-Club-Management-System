using ClupManagementDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using static ClupManagementDataAccessLayer.Playedtypes;

namespace ClubManagementBusinessLayer.base_classes
{
    public abstract class Table
    {
        protected int TableId { get; set; }
        public string TableName { get; set; }
        protected Dues dues { get; set; }
        public enPlayedtypes DefultPlayType { get; set; }

        protected GameTimer _timer = new GameTimer();
        protected short Counter { get; set; }
        protected bool IsLocked { get; set; } = false;

        public string Playername 
        {
            get { return dues.PersonName; } 
            set { dues.PersonName = value; }
        }

        public enum enTabletypes { Billiard = 1, Foosball = 2, VIP_Billiard = 3, Tennis = 5 };
        public enTabletypes TableType;

        protected Table(TableDTO dto)
        {
            TableId = dto.Tab_ID;
            TableName = dto.TableName;
        }

        public Table(enTabletypes tabletype)
        {
            this.TableType = tabletype;
            var T = Table_Data.FindByID((int)tabletype);

            if (T != null)
            {
                TableId = T.Tab_ID;
                TableName = T.TableName;
            }
        }

        public abstract bool Start(string PersonName, short V = 0);
        public abstract bool End();

        public static List<TableDTO> GetAllTable()
        {
            return Table_Data.GetAllTables();
        }

        protected void StartTimer()
        {
            if (dues.PlayedType == enPlayedtypes.Hourly)
                _timer.Start();
        }

        protected void PauseTime()
        {
            if (_timer.IsRunning)
                _timer.Pause();
        }

        protected void ResumeTime()
        {
            if (!_timer.IsRunning && dues.PlayedType == enPlayedtypes.Hourly)
                _timer.Resume();
        }

        protected void ResetTimer()
        {
            _timer.Reset();
        }

        protected short ElapsedTime()
        {
            return (short)_timer.Elapsed.TotalMinutes;
        }

        protected short TimesPlayed() => Counter;

        public bool Save()
        {
            if (dues.Save())
            {
                Unload();
                return true;
            }

            return false;
        }

        protected void Unload()
        {
            dues.PersonName = string.Empty;
            ResetTimer();
            Counter = -1;
            dues.PlayedType = DefultPlayType;
            IsLocked = false;
            dues.Unload();
        }

    }

}
