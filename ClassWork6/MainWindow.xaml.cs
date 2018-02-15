//Author: Trever Hall
//File: MainWindow.xaml.cs
//Date: February 15, 2018
//Description: 


using System;
using System.Collections.Generic;
using System.Data.OleDb;
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

namespace ClassWork6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OleDbConnection cn;

        public MainWindow()
        {
            cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\CW6DataBase.mdb");
            InitializeComponent();
        }



        private void MyTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //////////Buttons//////////

        private void See_Assets_Click(object sender, RoutedEventArgs e)
        {
            string query = "select* from Assets";
            OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader read = cmd.ExecuteReader();
            string data = "";

            while (read.Read())
            {
                data += read[0].ToString() + " " + read[1].ToString() + " "  + read[2].ToString() + "\n";
            }
            MyTextBox.Text = data;
            cn.Close();
        }

        private void See_Employees_Click(object sender, RoutedEventArgs e)
        {
            string query = "select* from Employees";
            OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader read = cmd.ExecuteReader();
            string data = "";

            while (read.Read())
            {
                data += read[0].ToString() + " " + read[1].ToString() + " " + read[2].ToString() + "\n";
            }

            MyTextBox.Text = data;
            cn.Close();
        }

        private void Add_Employee_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Add_Asset_Click(object sender, RoutedEventArgs e)
        {
            string query = "select* from Assets";
            OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader read = cmd.ExecuteReader();
        }

        //////////End Buttons//////////
    }
}
