using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoP6
{
    interface IInventoryCommand
    {
        void Do();
        void Undo();
    }
}
