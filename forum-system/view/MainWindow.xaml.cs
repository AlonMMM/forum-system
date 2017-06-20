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
using forum_system.view;
using forum_system.controller;
using forum_system.model;
using forum_system.model.forum_components;

namespace forum_system
{
    public partial class MainWindow : Window, IView
    {
        IController controller;
        IMember loggedInMember;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void notifyUser(string message)
        {
            MessageBox.Show(message);
        }

        private void startMVC()
        {
            Model model = new Model();
            controller = new Forum(this, model);
            model.setController(controller);
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Login loginWindow = new view.Login(this);
            loginWindow.Show();
            this.Close();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Not implemented.");
        }

        private void startDiscussion(string creator, string content, string title, string date, int repliedToId)
        {
            Message message = new Message( creator, content, title, date, repliedToId);
            loggedInMember.startDiscussion(message);
        }



    }
}
