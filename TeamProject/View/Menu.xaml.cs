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

namespace TeamProject.View
{
    /// <summary>
    /// Menu.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Menu : Page
    {
        string getId;
        public Menu(string id)
        {
            getId = id;
            InitializeComponent();
        }

        private void English_Click(object sender, RoutedEventArgs e)
        {
            LongScriptEnglish longScriptEnglish = new LongScriptEnglish(getId);
            this.NavigationService.Navigate(longScriptEnglish);
        }

        private void Korean_Click(object sender, RoutedEventArgs e)
        {
            LongScriptPractice longScriptPractice = new LongScriptPractice(getId);
            this.NavigationService.Navigate(longScriptPractice);
        }
    }
}
