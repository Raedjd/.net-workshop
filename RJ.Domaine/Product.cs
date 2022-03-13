using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ.Domaine
{
    public class Product : Concept
    {
        public readonly object CategoryId;
        public Category categoryRef;

        //Attribute & Getters et Setters
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(50, ErrorMessage = "Length must be under 25")] 
        [StringLength(25, ErrorMessage = "Length must be under 25")] 
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Display(Name = "Production Date"), DataType(DataType.Date)]
        public DateTime DateProd { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
        //[ForeignKey("CategoryFK")]
        public Category Category { get; set; }

        //------------------------------------seance6---------------------------------//
        public  string Image { get; set; }
        //-----------------------------------------------------------------------------//
        public IList<Provider> providers { get; set; }

        public Product()
        {
            this.providers = new List<Provider>();
        }

        public override void getDetails()
        {
            Console.WriteLine($"{Quantity} {Name} {Price}" + $"{ProductId} {Description} {DateProd}");
        }

        public virtual void GetMyType()
        {
            Console.WriteLine("I'am a product");
        }
    }
} 
 