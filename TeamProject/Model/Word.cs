using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace TeamProject.Model
{
    public class Word
    {
        Label label;
        float speed;

        public Word(Label label, float speed)
        {
            this.label = label;
            this.speed = speed;
        }
        public void down()
        {
            label.Margin = new System.Windows.Thickness(label.Margin.Left, label.Margin.Top + speed, 0, 0);
        }
        public bool miss()
        {
            if (label.Margin.Top > 400)
            {
                label.Visibility = System.Windows.Visibility.Hidden;
                return true;
            }
            return false;
        }
        public bool check(string text)
        {
            if (label.Content.Equals(text))
            {
                label.Visibility = System.Windows.Visibility.Hidden;
                return true;
            }
            return false;
        }
    }
}
