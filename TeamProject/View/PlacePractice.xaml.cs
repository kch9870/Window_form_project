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

namespace TeamProject
{
    /// <summary>
    /// PlaceProtect.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PlaceProtect : Page
    {
        public  String[] word = new String[] { "ㄱ", "ㄴ", "ㄷ", "ㄹ", "ㅁ", "ㅂ", "ㅅ", "ㅇ", "ㅈ", "ㅊ", "ㅋ", "ㅌ", "ㅍ", "ㅎ", "ㅏ", "ㅑ", "ㅓ", "ㅕ", "ㅗ", "ㅛ", "ㅜ", "ㅠ", "ㅡ", "ㅣ", "ㅃ", "ㅉ", "ㄸ", "ㄲ", "ㅆ", "[", "{", "}", "]", ";", ":", ",", ".", "/", "?" };
        public  int correct_num = 1;
        public  int wrong_num = 0;
        string getId;

        public PlaceProtect(string id)
        {
            getId = id;
            InitializeComponent();
        }

        public string Load()
        {
            Random rn = new Random();
            int i = rn.Next(0, 38);

            return word[i];
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            string word1 = Load();
            Idtxt.Content = getId;
            Wordtxt.Content = word1;
        }

        private void Typingtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (Typingtxt.Text.Equals(Wordtxt.Content))
                {
                    for (int j = 0; j < 25; j++)
                    {
                        if(correct_num == 25)
                        {
                            MessageBox.Show("진행도 :" + correct_num * 4 + "%\n오타수 : " + wrong_num + "\n정확도 : " + (100 - wrong_num * 2) + "%");
                            break;
                        }                                               
                        else
                        {
                            Typingtxt.Text = "";
                            string word2 = Load();
                            Wordtxt.Content = word2;
                        }

                    }
                    correct_num++;
                    Progresstxt.Content = "진행도 : " + (correct_num * 4) + "%";
                    ProgressPB.Value = correct_num * 4;
                    if (wrong_num == 0)
                    {
                        Accuracytxt.Content = "정확도 : 100%";
                        accuracyPB.Value = 100;
                    }
                }
                else
                {
                    Typingtxt.Text = "";
                    wrong_num++;3
                    Typotxt.Content = "오타수 : " + wrong_num;
                    typoPB.Value = wrong_num;

                    Accuracytxt.Content = "정확도 : " + (100 - (wrong_num * 4)) + "%";
                    accuracyPB.Value = 100 - (wrong_num * 4);
                }
            }
        }

        private void HomeBT_Click(object sender, RoutedEventArgs e)
        {
            Main main = new Main(getId);
            this.NavigationService.Navigate(main);
        }
    }
}

