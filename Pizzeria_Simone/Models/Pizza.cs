using System.ComponentModel.DataAnnotations;

namespace Pizzeria_Simone.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Il campo titolo è obbligatorio")]
        [StringLength(10, ErrorMessage ="Il titolo non può avere più di 10 caratteri")]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }


        public Pizza()
        {

        }

        public Pizza(int id, string title, string Description, string image, float Price)
        {
            this.Id = Id;
            this.Title = Title;
            this.Description = Description; 
            this.Image = Image;
            this.Price = Price;

        }
    }
}
