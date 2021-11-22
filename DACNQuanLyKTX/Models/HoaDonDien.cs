namespace DACNQuanLyKTX.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDonDien")]
    public partial class HoaDonDien
    {
        [Key]
        [StringLength(10)]
        public string MaHoaDonDien { get; set; }

        [Required]
        [StringLength(10)]
        public string MaQL { get; set; }

        [Required]
        [StringLength(10)]
        public string MaPhong { get; set; }

        public double SoDienSuDung { get; set; }

        [Column(TypeName = "money")]
        public decimal DonGiaDien { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayLap { get; set; }

        public virtual Phong Phong { get; set; }

        public virtual QuanLy QuanLy { get; set; }
    }
}
