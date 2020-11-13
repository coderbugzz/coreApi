using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace coreApi.Models
{
    public class member
    {
        [Key]
        public long Id { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }
        
        [Column(TypeName = "nvarchar(50)")]
        public string MiddleName { get; set; }
    }
}