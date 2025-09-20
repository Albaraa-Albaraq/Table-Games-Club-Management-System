using ClupManagementDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClupManagementDataAccessLayer.Playedtypes;

namespace ClubManagementBusinessLayer.base_classes
{
    public class Dues
    {
        public int DuesId { get; set; }
        public int TableId { get; set; }
        public int FeeId { get; set; }
        public string PersonName { get; set; } = String.Empty;
        public DateTime DateAndTime { get; set; }
        public enPlayedtypes PlayedType { get; set; }
        public short Value { get; set; }

        public DuesDTO AsDTO => new DuesDTO(DuesId, TableId, FeeId, PersonName, DateAndTime, PlayedType, Value);

        public Dues(int tableId, int feeId, string personName, DateTime dateAndTime, enPlayedtypes playedType, short value)
        {
            TableId = tableId;
            FeeId = feeId;
            PersonName = personName;
            DateAndTime = dateAndTime;
            PlayedType = playedType;
            Value = value;
        }

        public Dues()
        {
            _Reset();

        }

        private void _Reset()
        {
            TableId = -1;
            FeeId = -1;
            PersonName = string.Empty;
            DateAndTime = DateTime.Now;
            PlayedType = enPlayedtypes.Hourly;
            Value = -1;
        }

        public bool Save()
        {
            DuesId = DuesData.AddDuse(AsDTO);
            return DuesId != -1;
        }

        public void Unload()
        {
            PersonName = string.Empty;
            DateAndTime = DateTime.Now;
            Value = -1;
        }

    }
}
