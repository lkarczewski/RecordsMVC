using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcRecords.Models
{
    public class Album
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane.")]
        [DataType(DataType.Text)]
        [StringLength(50)]
        [DisplayName("Tytuł")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Data wydania")]
        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane.")]
        [DataType(DataType.Text)]
        [StringLength(50)]
        [DisplayName("Gatunek")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane.")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        [DisplayName("Cena")]
        public decimal Price { get; set; }

        //[Required(ErrorMessage = "Pole jest wymagane.")]
        //[DataType(DataType.Text)]
        //[StringLength(50)]
        //public string SerialNumber { get; set; }

        [ForeignKey("Artist")]
        [DisplayName("Wykonawca")]
        public int ArtistId { get; set; }

        public virtual Artist Artist { get; set; }
    }
}