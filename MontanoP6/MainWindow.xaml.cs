using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MontanoP6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Inventory> inventoryItems = new List<Inventory>();
        List<IInventoryCommand> commands = new List<IInventoryCommand>();
      
        public MainWindow()
        {   
           InitializeComponent();
            
        }
        

        private void lblAddOne_Click(object sender, RoutedEventArgs e)
        {
            Inventory item = new Inventory(tbxItemName.Text);
            AddOneCommand single = new AddOneCommand(inventoryItems, item);
            single.Do();
            commands.Add(single);
            lbxInventory.ItemsSource = inventoryItems;
            lbxInventory.Items.Refresh();
            
            
        }

        private void btnAddMulti_Click(object sender, RoutedEventArgs e)
        {
            Inventory item = new Inventory(tbxItemName.Text);
            AddMultipleCommand multi = new AddMultipleCommand(inventoryItems, item);
            multi.Do();
            commands.Add(multi);
            lbxInventory.ItemsSource = inventoryItems;
            lbxInventory.Items.Refresh();
        }

        private void btnUndo_Click(object sender, RoutedEventArgs e)
        {
            commands[commands.Count - 1].Undo();
            commands.RemoveAt(commands.Count - 1);
            lbxInventory.ItemsSource = inventoryItems;
            lbxInventory.Items.Refresh();
           
        }
    }
}
