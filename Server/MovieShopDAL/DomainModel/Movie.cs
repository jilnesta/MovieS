using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace MovieShopDAL.DomainModel
{
    [DataContract(IsReference = true)]
    [Table("Movie")]
    public class Movie
    {
        [Key]
        [DataMember]
        public int Id { get; set; }


        [StringLength(50)]
        [DataMember]
        public string Title { get; set; }
        [DataType("Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        //[Range(1, 9000)]
        [DataMember]
        public DateTime Year { get; set; }

        [DataMember]
        public double Price { get; set; }

        [DataMember]
        public virtual ICollection<Genre> Genres { get; set; }

        [DataMember]
        public String url { get; set; }
        [DataMember]
        public String Description { get; set; }

        [DataMember]
        public string MovieCoverUrl { get; set; }
    }
}
