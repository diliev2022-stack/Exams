using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Entities
{
    public class Town
    {
       
    public int Id {  get; set; }

    [Required]
    [MaxLength(30)]
    public string Name { get; set; } = null!;

    public ICollection<Client> Clients { get; set; } = new HashSet<Client>();
    
    }
}
