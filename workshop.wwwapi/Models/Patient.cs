using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace workshop.wwwapi.Models
{
    //TODO: decorate class/columns accordingly    
    [Table("patient")]
    public class Patient
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("patient_name")]
        public string FullName { get; set; }
        [Column("appointments")]
        public List<Appointment> appointments { get; set; } = new List<Appointment>();

        




    }
}
