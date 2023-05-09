using Castle.MicroKernel.SubSystems.Conversion;

namespace SupermarketWEB.Models
{
    public class Product
    {
        public int Id { get; set; } //Sera la llave primaria
        public string Name { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; } //Será la llave foranea
        public Category Category { get; set; } //Propiedad de navegación

    }
}
