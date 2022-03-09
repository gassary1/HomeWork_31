using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_31
{
    class Seller : Person
    {
        private static List<Item> _products;
        private Player _player;

        public Seller(string name, int gold) : base(name, gold)
        {

        }
        public bool SellProduct()
        {
            if (TryGetProduct(out Item product))
            {
                if (product.Amount > 0)
                {
                    
                }
            }
        }

        private bool TryGetProduct(int currentPosition, out Item product)
        {
            int itemPosition = currentPosition - 1;
            product = null;

            if (_products[itemPosition] == null)
            {
                return false;
            }

            product = _products[itemPosition];
            return true;
        }
    }
}
