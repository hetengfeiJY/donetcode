using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Test1.Models
{
    [Table("Movie")]
    public class Movie
    {
        public int ID { get; set; }
        [Display(Name = "标题")]
        public string Title { get; set; }
        [Display(Name = "发布时间")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "类型")]
        public string Genre { get; set; }
        [Display(Name = "价格")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }  
        [Column("Rating")]
        public string Rating { get; set; }
        [NotMapped]  //不在数据库中显示
        public string Ratings { get; set; }
    }
}
