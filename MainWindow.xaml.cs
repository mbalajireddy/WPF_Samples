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

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ////Object to perform Binding
            //Binding ZoomControl_value_connect_imagecontrol_width = new Binding();
            
            ////Define source object then define source property

            ////This is source object
            //ZoomControl_value_connect_imagecontrol_width.Source = this.ZoomControl;
            
            ////This is source property
            //ZoomControl_value_connect_imagecontrol_width.Path = new PropertyPath("Value");

            //this.ImageControl.SetBinding(Image.WidthProperty, ZoomControl_value_connect_imagecontrol_width);

            

            ////Part2 : Displaying zoomed value(Image Width) in TextBox
            //Binding ImageControl_Width_Connectwith_Textbox_Text = new Binding();
            //ImageControl_Width_Connectwith_Textbox_Text.Source = this.ImageControl;
            //ImageControl_Width_Connectwith_Textbox_Text.Path = new PropertyPath("Width");
            //this.TextBoxControl.SetBinding(TextBox.TextProperty, ImageControl_Width_Connectwith_Textbox_Text);
        }
    }
}
