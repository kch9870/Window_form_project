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
using TeamProject.View;

namespace TeamProject
{
    /// <summary>
    /// Main.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Main : Page
    {
        string getId;
        public Main(string id)
        {
            getId = id;
            InitializeComponent();
            Idtxt.Content = getId;
        }

        private void PlacePracticeBT_Click(object sender, RoutedEventArgs e)
        {
            PlaceProtect place = new PlaceProtect(getId);
            this.NavigationService.Navigate(place);
        }

        private void LongScriptPracitceBT_Click(object sender, RoutedEventArgs e)
        {
            View.Menu menu = new View.Menu(getId);
            this.NavigationService.Navigate(menu);
        }

        private void GameBT_Click(object sender, RoutedEventArgs e)
        {
            Game game = new Game(getId);
            this.NavigationService.Navigate(game);
        }

        private void SettingBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
               new Uri("/View/Setting.xaml", UriKind.Relative)
               );
        }

        private void EndBT_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("한컴 타자연습을 끝냅니다.");
            Environment.Exit(0);
        }
    }
}
