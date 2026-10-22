using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Entities
{
    public class Purchase
    {
       
        public int Id { get; set; }

        [ForeignKey("Car")]
        [Required]
        public int CarId { get; set; }
        public Car Car { get; set; } = null!;

        [ForeignKey("Client")]
        [Required]
        public int ClientId { get; set; }
        public Client Client {  get; set; } = null!;

        [Required]
        public DateTime PurchaseDate { get; set; }

        
    }
}

