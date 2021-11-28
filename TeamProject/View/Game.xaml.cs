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
using TeamProject.Control;
using TeamProject.Model;
using System.Windows.Threading;

namespace TeamProject.View
{
    /// <summary>
    /// Game.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Game : Page
    {
        public static Grid grid = new Grid();
        GameControl gameControl = new GameControl();
        DispatcherTimer spwaner;
        DispatcherTimer downer;
        DispatcherTimer leveler;

        string getId;

        public Game(string id)
        {
            getId = id;
            InitializeComponent();
            Idtxt.Content = getId;
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Started();
            changedValue();
        }
        private void spwaner_Tick(object sender, EventArgs e)
        {
            gameControl.spwanLabel(game);
            changedValue();
        }
        private void downer_Tick(object sender, EventArgs e)
        {
            if(gameControl.life==0)
            {
                spwaner.Stop();
                downer.Stop();
                leveler.Stop();
                MessageBox.Show("Game Over");
                Main main = new Main(getId);
                this.NavigationService.Navigate(main);
            }
            gameControl.MoveDown();
            changedValue();
        }
        private void leveler_Tick(object sender, EventArgs e)
        {
            gameControl.levelUp();
            spwaner.Interval = TimeSpan.FromMilliseconds(gameControl.spwanSpeed);
            changedValue();
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                gameControl.enterText(textbox.Text);
                textbox.Text = "";
            }
        }
        public void changedValue()
        {
            level.Value = gameControl.level;
            life.Value = gameControl.life;
            lifecount.Content = gameControl.life;
            changedLifeBar();
            levelcount.Content = gameControl.level;
            score.Content = gameControl.scores;
        }
        public void changedLifeBar()
        {
            if (life.Value <= 10 && life.Value > 8)
            {
                life.Foreground = Brushes.Green;
            }
            else if (life.Value <= 8 && life.Value > 6)
            {
                life.Foreground = Brushes.Lime;
            }
            else if (life.Value <= 6 && life.Value > 4)
            {
                life.Foreground = Brushes.Orange;
            }
            else if (life.Value <= 4 && life.Value > 2)
            {
                life.Foreground = Brushes.OrangeRed;
            }
            else life.Foreground = Brushes.Red;
        }

        public void Started()
        {
            spwaner = new DispatcherTimer();
            spwaner.Interval = TimeSpan.FromMilliseconds(1000);
            spwaner.Tick += new EventHandler(spwaner_Tick);
            spwaner.Start();

            downer = new DispatcherTimer();
            downer.Interval = TimeSpan.FromMilliseconds(10);
            downer.Tick += new EventHandler(downer_Tick);
            downer.Start();

            leveler = new DispatcherTimer();
            leveler.Interval = TimeSpan.FromMilliseconds(10000);
            leveler.Tick += new EventHandler(leveler_Tick);
            leveler.Start();
        }

        private void HomeBT_Click(object sender, RoutedEventArgs e)
        {
            Main main = new Main(getId);
            this.NavigationService.Navigate(main);
        }
    }
}
