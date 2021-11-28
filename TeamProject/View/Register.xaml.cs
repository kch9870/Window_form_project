using MySql.Data.MySqlClient;
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

namespace TeamProject.View
{
    /// <summary>
    /// Register.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerBT_Click(object sender, RoutedEventArgs e)
        {
            DataConnection data = new DataConnection();
            string edit_id = Nametxt.Text;
            string id = Nametxt.Text;
            int typing = int.Parse(Typingtxt.Text);
            int accuracy = int.Parse(Accuracytxt.Text);
            MySqlConnection conn = data.Connection();

            conn.Open();

            string sql = "Insert `teamproject`.`user` SET `id` = '" + id + "', `typing` = '" + typing + "', `accuracy` = '" + accuracy + "' ";
            try
            {
                Console.WriteLine(sql);
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }
            MessageBox.Show("등록되었습니다.");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
