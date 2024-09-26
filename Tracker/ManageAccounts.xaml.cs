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

namespace Tracker
{
    /// <summary>
    /// Interaction logic for ManageAccounts.xaml
    /// </summary>
    public partial class ManageAccounts : Window
    {
        public ManageAccounts()
        {
            InitializeComponent();
        }

        private void Username_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
                Dashboard mwd = new Dashboard();
                mwd.Show();
                this.Close();
            
        }
        private void Window_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        
        public void GetSettings()
        {
            lbl_Name.Text = Properties.Settings.Default.Accounts;
            lbl_Name_Copy.Text = Properties.Settings.Default.Accounts1;
            lbl_Name_Copy1.Text = Properties.Settings.Default.Accounts2;
            lbl_Name_Copy2.Text = Properties.Settings.Default.Accounts3;
            lbl_Name_Copy3.Text = Properties.Settings.Default.Accounts4;
            lbl_Name_Copy4.Text = Properties.Settings.Default.Accounts5;
            lbl_Name_Copy5.Text = Properties.Settings.Default.Accounts6;
            lbl_Name_Copy6.Text = Properties.Settings.Default.Accounts7;
            lbl_Name_Copy7.Text = Properties.Settings.Default.Accounts8;
        }

      

        private void Border_Loaded(object sender, RoutedEventArgs e)
        {
            GetSettings();
     
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.Accounts = lbl_Name.Text;
            Properties.Settings.Default.Accounts1 = lbl_Name_Copy.Text;
            Properties.Settings.Default.Accounts2 = lbl_Name_Copy1.Text;
            Properties.Settings.Default.Accounts3 = lbl_Name_Copy2.Text;
            Properties.Settings.Default.Accounts4 = lbl_Name_Copy3.Text;
            Properties.Settings.Default.Accounts5 = lbl_Name_Copy4.Text;
            Properties.Settings.Default.Accounts6 = lbl_Name_Copy5.Text;
            Properties.Settings.Default.Accounts7 = lbl_Name_Copy6.Text;
            Properties.Settings.Default.Accounts8 = lbl_Name_Copy7.Text;
            
            Properties.Settings.Default.Save();
        }

        private void save(object sender, RoutedEventArgs e)
        {
            SaveSettings();
            GetSettings();
        }
        private void exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
