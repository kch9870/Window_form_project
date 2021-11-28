using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
using MySql.Data.MySqlClient;

namespace TeamProject.View
{
    /// <summary>
    /// LongScriptEnglish.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LongScriptEnglish : Page
    {
        int label_num = 5;
        int wrong_num = 0;
        int speed = 0;
        int accuracy = 0;
        float s1, s2, s3, s4, s5;
        string getId;
        System.Diagnostics.Stopwatch sw = new Stopwatch();

        public LongScriptEnglish(string id)
        {
            getId = id;
            InitializeComponent();
            Idtxt.Content = getId;
        }
        private void textbox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            string a = label1.Content.ToString();
            a = a.TrimEnd();
            if (e.Key == Key.Enter)
            {
                sw.Stop();
                float sec = float.Parse((sw.ElapsedMilliseconds * 0.01).ToString());
                int x = (int)(60 / sec);
                speed = (int)(textbox1.Text.Length * x);
                s1 = speed;
                speed = (int)s1;

                if ((textbox1.Text).Equals(a))
                {
                    typingtxt.Content = "타수 : " + speed + "타";
                    accuracy = 100 - (wrong_num * 20);
                    accuracytxt.Content = "정확도 :" + accuracy + "%";
                    textbox2.Focus();
                }
                else
                {
                    wrong_num++;
                    typingtxt.Content = "타수 : " + speed + "타";
                    accuracy = 100 - (wrong_num * 20);
                    accuracytxt.Content = "정확도 :" + accuracy + "%";
                    textbox2.Focus();
                }
            }
        }

        private void textbox2_KeyDown(object sender, KeyEventArgs e)
        {
            string a = label2.Content.ToString();
            a = a.TrimEnd();
            if (e.Key == Key.Enter)
            {
                sw.Stop();
                float sec = float.Parse((sw.ElapsedMilliseconds * 0.01).ToString());
                int x = (int)(60 / sec);
                speed = (int)(textbox1.Text.Length * x);
                s2 = speed;
                speed = (int)((s1 + s2) / 2);

                if ((textbox2.Text).Equals(a))
                {
                    typingtxt.Content = "타수 : " + speed + "타";
                    accuracy = 100 - (wrong_num * 20);
                    accuracytxt.Content = "정확도 :" + accuracy + "%";
                    textbox3.Focus();
                }
                else
                {
                    wrong_num++;
                    typingtxt.Content = "타수 : " + speed + "타";
                    accuracy = 100 - (wrong_num * 20);
                    accuracytxt.Content = "정확도 :" + accuracy + "%";
                    textbox3.Focus();
                }
            }
        }

        private void textbox3_KeyDown(object sender, KeyEventArgs e)
        {
            string a = label3.Content.ToString();
            a = a.TrimEnd();
            if (e.Key == Key.Enter)
            {
                sw.Stop();
                float sec = float.Parse((sw.ElapsedMilliseconds * 0.01).ToString());
                int x = (int)(60 / sec);
                speed = (int)(textbox1.Text.Length * x);
                s3 = speed;
                speed = (int)((s1 + s2 + s3) / 3);

                if ((textbox3.Text).Equals(a))
                {
                    typingtxt.Content = "타수 : " + speed + "타";
                    accuracy = 100 - (wrong_num * 20);
                    accuracytxt.Content = "정확도 :" + accuracy + "%";
                    textbox4.Focus();
                }
                else
                {
                    wrong_num++;
                    typingtxt.Content = "타수 : " + speed + "타";
                    accuracy = 100 - (wrong_num * 20);
                    accuracytxt.Content = "정확도 :" + accuracy + "%";
                    textbox4.Focus();
                }
            }
        }

        

        private void textbox4_KeyDown(object sender, KeyEventArgs e)
        {
            string a = label4.Content.ToString();
            a = a.TrimEnd();
            if (e.Key == Key.Enter)
            {
                sw.Stop();
                float sec = float.Parse((sw.ElapsedMilliseconds * 0.01).ToString());
                int x = (int)(60 / sec);
                speed = (int)(textbox1.Text.Length * x);
                s4 = speed;
                speed = (int)((s1 + s2 + s3 + s4) / 4);

                if ((textbox4.Text).Equals(a))
                {
                    typingtxt.Content = "타수 : " + speed + "타";
                    accuracy = 100 - (wrong_num * 20);
                    accuracytxt.Content = "정확도 :" + accuracy + "%";
                    textbox5.Focus();
                }
                else
                {
                    wrong_num++;
                    typingtxt.Content = "타수 : " + speed + "타";
                    accuracy = 100 - (wrong_num * 20);
                    accuracytxt.Content = "정확도 :" + accuracy + "%";
                    textbox5.Focus();
                }
            }
        }

        private void textbox5_KeyDown(object sender, KeyEventArgs e)
        {
            string a = label5.Content.ToString();
            a = a.TrimEnd();
            if (e.Key == Key.Enter)
            {
                sw.Stop();
                float sec = float.Parse((sw.ElapsedMilliseconds * 0.01).ToString());
                int x = (int)(60 / sec);
                speed = (int)(textbox1.Text.Length * x);
                s5 = speed;
                speed = (int)((s1 + s2 + s3 + s4 + s5) / 5);

                if ((textbox5.Text).Equals(a))
                {
                    typingtxt.Content = "타수 : " + speed + "타";
                    accuracy = 100 - (wrong_num * 20);
                    accuracytxt.Content = "정확도 :" + accuracy + "%";
                    MessageBox.Show("타수 : " + speed + "\n정확도 : " + accuracy);
                    insertInformation();
                    NextPage();
                    textbox1.Focus();
                }
                else
                {
                    wrong_num++;
                    typingtxt.Content = "타수 : " + speed + "타";
                    accuracy = 100 - (wrong_num * 20);
                    accuracytxt.Content = "정확도 :" + accuracy + "%";
                    MessageBox.Show("타수 : " + speed + "\n정확도 : " + accuracy);
                    insertInformation();
                    NextPage();
                    textbox1.Focus();
                }
            }
        }

        private void NextPage()
        {
            label_num += 5;
            List<Label> label = new List<Label>();
            label.Add(label1);
            label.Add(label2);
            label.Add(label3);
            label.Add(label4);
            label.Add(label5);
            string TextPath = @"C:\Users\kch98\Desktop\Unv\TeamProject (1)\TeamProject\NewFolder1\English1.txt";
            string[] TextLine;

            StreamReader text1 = new StreamReader(TextPath);
            TextLine = text1.ReadToEnd().Split('\n');
            text1.Close();
            for (int i = label_num, j = 0; i < label_num + 5; i++)
            {
                label[j++].Content = TextLine[i];
            }
            speed = 0;
            wrong_num = 0;
            textbox1.Text = "";
            textbox2.Text = "";
            textbox3.Text = "";
            textbox4.Text = "";
            textbox5.Text = "";
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            sw.Reset();
            List<Label> label = new List<Label>();
            label.Add(label1);
            label.Add(label2);
            label.Add(label3);
            label.Add(label4);
            label.Add(label5);
            string TextPath = @"C:\Users\kch98\Desktop\Unv\TeamProject (1)\TeamProject\NewFolder1\English1.txt";
            string[] TextLine;

            StreamReader text1 = new StreamReader(TextPath);
            TextLine = text1.ReadToEnd().Split('\n');
            text1.Close();
            for (int i = 0, j = 0; i < label_num; i++)
            {
                label[j++].Content = TextLine[i];
            }
            textbox1.Focus();
        }
        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            sw.Reset();
            sw.Start();

            
        }

        private void HomeBT_Click(object sender, RoutedEventArgs e)
        {
            Main main = new Main(getId);
            this.NavigationService.Navigate(main);
        }

        private void textbox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            sw.Restart();
        }

        private void textbox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            sw.Restart();
        }

        private void textbox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            sw.Restart();
        }

        private void textbox5_TextChanged(object sender, TextChangedEventArgs e)
        {
            sw.Restart();
        }

        public void insertInformation()     //타수와 정확도
        {
            DataConnection data = new DataConnection();
            MySqlConnection conn = data.Connection();

            conn.Open();

            string sql = "Insert `teamproject`.`longpractice` SET `id` = '" + getId + "', `longtypingenglish` = '" + speed + "', `longaccuracyenglish` = '" + accuracy + "' ";
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
    }
}

