using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5TemmuzUygulama.Data
{
    [Index("Tur",IsUnique = true)]
    public class Donem
    {
        [Key]
        public int SemesterNo { get; set; }

        
        public string Tur { get; set; } = null!;

        [Column("Name")]
        public string Ad { get; set; } = null!;


        [Column(TypeName = "varchar(5)")]
        [MaxLength(5)]
        public string SemesterCode { get; set; } = null!;

        [NotMapped]
        public string Details { get; set; } = null!;

        public int ParaBaglantisi { get; set; } 

        public TotalMoney TotalMoney { get; set; } = null!;

    }
}
