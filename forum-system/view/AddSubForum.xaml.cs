using forum_system.controller;
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

namespace forum_system.view
{
    /// <summary>
    /// Interaction logic for AddSubForum.xaml
    /// </summary>
    public partial class AddSubForum : Window
    {
        IController controller;
        public AddSubForum(IController controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CreateSubForum(object sender, RoutedEventArgs e)
        {
            if (controller.Contain(name.Text))
            {
                MessageBox.Show("name already exists");
               
            }
            else
            {
                controller.addSubForum(name.Text, descruption.Text);
            }
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
