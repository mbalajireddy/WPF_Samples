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

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for ObjectDataBinding.xaml
    /// </summary>
    public partial class ObjectDataBinding : Window
    {
        DataModel _obj;
        public ObjectDataBinding()
        {
            InitializeComponent();
            _obj = new DataModel();
            this.DataContext = _obj;
        }

       
        private void OnGetName_Click(object sender, RoutedEventArgs e)
        {
            
            _obj.Name = "Default Value";
            
        }

        private void OnSetName_Click(object sender, RoutedEventArgs e)
        {
            _obj.Name = "New Value";
             MessageBox.Show(_obj.Name);
        }

        private void OnUpdateName_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_obj.Name);
        }
    }
}
