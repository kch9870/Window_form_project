using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TeamProject.Model;
using TeamProject.View;
using System.Windows.Threading;

namespace TeamProject.Control
{
    public class GameControl
    {
        int correct = 0;
        public int scores = 0;
        public int life = 10; //체력
        public int spwanSpeed = 2000;
        public int level = 1; //레벨
        float wordSpeed = 1; //스피드(레벨에 따라 0.5씩 증가)

        public void levelUp()
        {
            if (level == 15)
            {
                MessageBox.Show("최고 레벨 입니다!!");
            }
            level += 1;
            wordSpeed += .5f;
            spwanSpeed -= 50;
        }
        public void enterText(string text)
        {
            if (WordControl.wordChecker(text))
            {
                correct++;
                scores += 10;
            }
            else scores -= 20;
        }
        public void MoveDown()
        {
            if (WordControl.isMissed())
            {
                
                life--;
            }
            WordControl.WordsDown();
        }
        public void spwanLabel(Grid grid)
        {
            Random r = new Random();
            int rLeft;

            Label label = new Label();
            label.Height = 35;
            label.Width = 60;
            label.FontSize = 15;
            label.Content = GameModel.words[r.Next(0, GameModel.words.Length - 1)];

            rLeft = r.Next(-400, 400);
            label.Margin = new Thickness(rLeft, -450, 0, 0);

            grid.Children.Add(label);

            Word word = new Word(label, wordSpeed);

            WordControl.addWord(word);
        }
    }
}
