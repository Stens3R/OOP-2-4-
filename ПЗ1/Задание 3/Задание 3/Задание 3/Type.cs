using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    internal class Type : Itype
    {
        private readonly Idata<Iitem> _itemData;
        private readonly Idata<Icheck> _checkData;
        public string Name { get ; set ; }
        public int CountItems { get; set; }

        public Type(Idata<Iitem> itemData, Idata<Icheck> checkData)
        {
            _itemData = itemData ?? throw new ArgumentNullException(nameof(itemData));
            _checkData = checkData ?? throw new ArgumentNullException(nameof(checkData));
        }

        public void Add(Iitem book)
        {
            _itemData.Add(book);
            CountItems += 1;
        }

        public IEnumerable<Iitem> GetAllItems()
        {
            return _itemData.ReadAll();
        }

        public Check Sell(Iitem item)
        {
            _itemData.Remove(item);
            CountItems -= 1;

            var check = new Check()
            {
                Item = item,
                Type = this,
                DateTime = DateTime.Now
            };

            _checkData.Add(check);
            return check;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
