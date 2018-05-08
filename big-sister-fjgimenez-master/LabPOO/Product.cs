using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace LabPOO
{
    class Product
    {
        private string name;
        private int stock;
        private int price; //Price for one unit of the product
        private string unit;

        public Product(string name, int price, int stock, string unit)
        {
            this.name = name;
            this.stock = stock;
            this.price = price;
            this.unit = unit;
        }

        public bool Agregar(List<Product> carrito)
        {
            if (stock > 0)
            {
                carrito.Add(this);
                stock--;
                return true;
            }
            return false;
        }

        public string Name { get => name; }
        public int Stock { get => stock; }
        public int Price { get => price; }
        public string Unit { get => unit; }

        public delegate void NoenReceta(Product product);
        public event NoenReceta OnsacarProducto; 
        public void SacarProducto()
            {
            if (OnsacarProducto != null)
            {
                
            }
        }
        OnsacarProducto += new NoenReceta(product.SacarProducto);
        OnsacarProducto(product);
    }
}
