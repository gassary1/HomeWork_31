using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_31
{
    class Player : Person
    {
        public Player(string name, int gold) : base(name, gold) { }

        private void AddItem(Item item)
        {
            if (_items.Contains(item.Name))
            {

            }
        }
    }
}
