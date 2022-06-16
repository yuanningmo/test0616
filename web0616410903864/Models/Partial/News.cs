using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web0616410903864.Models
{
    [MetadataType(typeof(StudentMetadata))]
    public partial class News
    {

    }

    public class StudentMetadata
    {
        

        public int Id { get; set; }

        [Required(ErrorMessage = "欄位標題必須是最大長度危50的字串。")]
        [StringLength(50)]
        [Display(Name = "標題")]
        public string Title { get; set; }

        [Required(ErrorMessage = "必填欄位")]
        [Display(Name = "內容")]
        public string Content { get; set; }

        [Required(ErrorMessage = "必填欄位")]
        [Display(Name = "發布日期")]
        public System.DateTime PublishDate { get; set; }
    }
}