using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
using TeamProject.View;
using System.Configuration;

namespace TeamProject
{
    /// <summary>
    /// Setting.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Setting : Page
    {
        string id;
        public Setting()
        {
            InitializeComponent();
        }

        private void registerBT_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void editBT_Click(object sender, RoutedEventArgs e)
        {
            Edit edit = new Edit();
            edit.ShowDialog();
        }

        private void DeleteBT_Click(object sender, RoutedEventArgs e)
        {
            DataConnection data = new DataConnection();
            MySqlConnection conn = data.Connection();
            try
            {
                conn.Open();
                string sql = "delete from user where id ='" + Nametxt.Content + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                Console.WriteLine(sql);
                MySqlDataAdapter sqlda = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();

                Setting set = new Setting();
                this.NavigationService.Navigate(set);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {

                conn.Close();
            }
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            DataConnection data = new DataConnection();
            MySqlConnection conn = data.Connection();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select id from user", conn);
                
                MySqlDataAdapter sqlda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sqlda.Fill(ds, "ggrid");
                gridd.DataContext = ds;
            }catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        private void gridd_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataRowView d = gridd.CurrentCell.Item as System.Data.DataRowView;
            id = d.Row[0].ToString();
            Nametxt.Content = id;
        }

        private void HomeBT_Click(object sender, RoutedEventArgs e)
        {
            Main main = new Main(id);
            this.NavigationService.Navigate(main);
            /*NavigationService.Navigate(
            new Uri("/View/Main.xaml", UriKind.Relative)
            );*/
        }

        private void ChoiceBT_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RefreshBT_Click(object sender, RoutedEventArgs e)
        {
            Setting set = new Setting();
            this.NavigationService.Navigate(set);
        }

        /*private void gridd1_Loaded(object sender, RoutedEventArgs e)
        {
           
        }*/

        private void gridd1_Loaded_1(object sender, RoutedEventArgs e)
        {
            DataConnection data = new DataConnection();
            MySqlConnection conn = data.Connection();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select id,longtyping,longaccuracy,longtypingenglish,longaccuracyenglish from longpractice", conn);

                MySqlDataAdapter sqlda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sqlda.Fill(ds, "ggrid1");
                gridd1.DataContext = ds;
                MessageBox.Show("test");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
