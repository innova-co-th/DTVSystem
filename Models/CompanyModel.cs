using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTVSystem.Models
{
    public class CompanyModel
    {
        [Key]
        public int Company_ID { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string Company_name { get; set; }
    }
}
