using Android.Text.Format;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Models
{
    [Table("TSItems")]
    public class TSItems
    {
        [PrimaryKey, AutoIncrement, NotNull, Unique]
        public int Id { get; set;}

        [NotNull, Unique]
        public string UserID { get; set;}

        public int Status { get; set;}

        [MaxLength(250), NotNull]
        public string Description { get; set;}
        public DateTime Date { get; set; }
        public int Hours { get; set; }
        public DateTime CR_date { get; set; }
        public DateTime MOD_date { get; set; }
    }
}
