using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEBAPI.Models
{

    [Table ("Emp")]
    public class Emp
    {
        [Key]

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }



    }
}
