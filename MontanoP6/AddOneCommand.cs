using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoP6
{
    class AddOneCommand : IInventoryCommand
    {
        public AddOneCommand()
        {

        }
        public AddOneCommand(List<Inventory> targetList, Inventory item)
        {
            this.TargetList = targetList;
            this.Item = item;
            
            
        }
        
        public Inventory Item { get; set; }
        public List<Inventory> TargetList {get;set; }

        public void Do()
        {
            TargetList.Add(Item);
        }

        public void Undo()
        {
            TargetList.Remove(Item);
        }
    }
}
