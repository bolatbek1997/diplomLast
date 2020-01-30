namespace DiplomLast.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuizResult")]
    public partial class QuizResult
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public string testXml { get; set; }

        public decimal? userPoint { get; set; }

        public decimal? maxPoint { get; set; }

        [StringLength(50)]
        public string userTime { get; set; }

        [StringLength(50)]
        public string maxTime { get; set; }
        public int testerID { get; set; }

        [StringLength(12)]
        public string aspNetUserId { get; set; }
        public DateTime testerDate { get; set; }
    }
}
