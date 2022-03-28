using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoP6
{
    class AddMultipleCommand : IInventoryCommand
    {
        private int number = new Random().Next(1,10);

        public Inventory Item { get; set; }
        public List<Inventory> TargetList { get; set; }

        public AddMultipleCommand()
        {

        }

        public AddMultipleCommand(List<Inventory> targetList, Inventory item)
        {
            this.TargetList = targetList;
            this.Item = item;
            
        }

        public void Do()
        {
            for (int i = 0; i < number; i++)
            {
                TargetList.Add(Item);
            }
        }

        public void Undo()
        {
            for (int i = 0; i < number; i++)
            {
                TargetList.Remove(Item);
            }
        }


    }
}
