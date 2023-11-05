using Labb3_NET22.DataModels;
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

namespace Labb3_NET22
{
    
    public partial class StartNewQuizWindow : Window
    {
        public StartNewQuizWindow()
        {
            InitializeComponent();
            Quiz tempQuiz = Quiz.CreateRandomQuiz();
            cbbQuizChoose.ItemsSource = QuizManager.listQuizes;
        }

        private void btnMainMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
        private void cbbQuizChoose_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PlayWindow.activeQuiz = (Quiz)cbbQuizChoose.SelectedItem;
        }

        private void btnStartQuiz_Click(object sender, RoutedEventArgs e)
        {

            PlayWindow.activeQuiz = (Quiz)cbbQuizChoose.SelectedItem;
            if (PlayWindow.activeQuiz != null)
            {
                PlayWindow playWindow = new PlayWindow();
                playWindow.Show();
            }
            else
            {
                MessageBox.Show("Please choose a quiz");
            }
        }

    }
}
