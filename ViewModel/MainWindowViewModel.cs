using MVVM.Model;
using MVVM.MVVM;
using System.Collections.ObjectModel;

namespace MVVM.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }
        public MainWindowViewModel()
        {
            Items.Add(new Item
            {
                Name = "0001",
                SerialNumber = "123123",
                Quanitity = 8
            }); 
        }

        private Item selectedItem;

      
        public Item SelectedItem
        {
            get { return selectedItem; }
            set { 
                selectedItem = value;
                OnPropertyChanged();
            }
        }

    }
}
