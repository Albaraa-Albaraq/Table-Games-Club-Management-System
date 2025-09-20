using ClupManagementDataAccessLayer;
using System;
using static ClupManagementDataAccessLayer.Playedtypes;

namespace ClubManagementBusinessLayer.base_classes
{
    public class TableFees
    {
        protected int FeeId { get; set; }
        protected int TableId { get; set; }
        public float? FeesByHour { get; set; }
        public float? FeesByMatch { get; set; }
        protected DateTime CreatedAt { get; set; }
        public bool Saved { get; set; } = true;
        protected TableFeesDTO AsDTO => new TableFeesDTO(FeeId, TableId, FeesByHour, FeesByMatch, CreatedAt);

        public TableFees(TableFeesDTO dto)
        {
            FeeId = dto.FeeId;
            TableId = dto.TableId;
            FeesByHour = dto.FeesByHour;
            FeesByMatch = dto.FeesByMatch;
            CreatedAt = dto.CreatedAt;
        }

        public TableFees()
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            FeeId = -1;
            TableId = -1;
            FeesByHour = -1;
            FeesByMatch = -1;
            CreatedAt = DateTime.Now;
        }

        public static TableFees Find(int tableId)
        {
            return new TableFees(TableFeesData.FindById(tableId));
        }

        public bool Save()
        {
            if (Saved)
                return false;

            int newId = TableFeesData.Save(AsDTO);
            if (newId != FeeId)
            {
                FeeId = newId;
                Saved = true;
                return true;
            }
            return false;
        }

        public Dues CreateDues(string personName, enPlayedtypes playedType, short value)
        {
            return new Dues(TableId, FeeId, personName, DateTime.Now, playedType, value);
        }

        public bool ChangeFeesByHour(float feesByHour)
        {
            if (feesByHour != FeesByHour)
            {
                FeesByHour = feesByHour;
                Saved = false;
            }
            return Save();
        }

        public bool ChangeFeesByMatch(float feesbymatch)
        {
            if (feesbymatch != FeesByMatch)
            {
                FeesByMatch = feesbymatch;
                Saved = false;
            }
            return Save();
        }

        public float? GetFeesByHour() => FeesByHour;

        public float? GetFeesByMatch() => FeesByMatch;

        //public static List<TableDTO> GetAllTable()
        //{
        //    return Table_Data.GetAllTables();
        //}

    }

}
