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
using System.Windows.Shapes;
using System.Collections.ObjectModel;


namespace DataBinding
{
    /// <summary>
    /// Interaction logic for CollectionDemo.xaml
    /// </summary>
    public partial class CollectionDemo : Window
    {
        ObservableCollection<DataModel> _dataModelList;

        public CollectionDemo()
        {
            InitializeComponent();
            _dataModelList = new ObservableCollection<DataModel>();
            DataModel _obj1 = new DataModel();
            _obj1.Id = "ID001";
            _obj1.Name = "Tom";
            _obj1.Age = 30;

             DataModel _obj2 = new DataModel();
            _obj2.Id = "ID002";
            _obj2.Name = "Harry";
            _obj2.Age = 25;

             DataModel _obj3 = new DataModel();
            _obj3.Id = "ID003";
            _obj3.Name = "Jack";
            _obj3.Age = 20;

            _dataModelList.Add(_obj1);
            _dataModelList.Add(_obj2);
            _dataModelList.Add(_obj3);

            this.DataContext = _dataModelList;

        }
    }
}
