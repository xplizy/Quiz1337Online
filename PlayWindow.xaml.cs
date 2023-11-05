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
   
    public partial class PlayWindow : Window
    {
        public static Quiz activeQuiz = new Quiz();
        public static Question currentQuestion;
        public int correctAnswers { get; set; } = 0;
        public int questionIndex { get; set; } = 0;
        public string quizStatus { get; set; } = string.Empty;

        public PlayWindow()
        {
            InitializeComponent();
            currentQuestion = activeQuiz.GetRandomQuestion();
            this.DataContext = currentQuestion;
            quizStatus = QuizStatus();

        }

        private void btnStopPlaying_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAnswer1_Click(object sender, RoutedEventArgs e)
        {
            if (currentQuestion.CorrectAnswer == 0)
            {
                MessageBox.Show("Correct!");
                correctAnswers++;
                ProgressBar.Value += 10;
            }
            else
            {
                MessageBox.Show("Wrong answer!");
            }
            activeQuiz.RemoveQuestion(0);
            currentQuestion = activeQuiz.GetRandomQuestion();
            questionIndex++;
            this.DataContext = currentQuestion;
            quizStatus = QuizStatus();
            if (questionIndex == 10)
            {
                double percentage = (double)correctAnswers / 10 * 100;
                MessageBox.Show($"You answered {correctAnswers} out of 10 questions correctly. ({percentage}%).");
            }
        }

        private void btnAnswer2_Click(object sender, RoutedEventArgs e)
        {
            if (currentQuestion.CorrectAnswer == 1)
            {
                MessageBox.Show("Correct!");
                correctAnswers++;
                ProgressBar.Value += 10;
            }
            else
            {
                MessageBox.Show("Wrong answer!");
            }
            activeQuiz.RemoveQuestion(0);
            currentQuestion = activeQuiz.GetRandomQuestion();
            questionIndex++;
            this.DataContext = currentQuestion;
            quizStatus = QuizStatus();
            if (questionIndex == 10)
            {
                double percentage = (double)correctAnswers / 10 * 100;
                MessageBox.Show($"You answered {correctAnswers} out of 10 questions correctly. ({percentage}%).");
            }
        }

        private void btnAnswer3_Click(object sender, RoutedEventArgs e)
        {
            if (currentQuestion.CorrectAnswer == 2)
            {
                MessageBox.Show("Correct!");
                correctAnswers++;
                ProgressBar.Value += 10;
            }
            else
            {
                MessageBox.Show("Wrong answer!");
            }
            activeQuiz.RemoveQuestion(0);
            currentQuestion = activeQuiz.GetRandomQuestion();
            questionIndex++;
            this.DataContext = currentQuestion;
            quizStatus = QuizStatus();
            if (questionIndex == 10)
            {
                double percentage = (double)correctAnswers / 10 * 100;
                MessageBox.Show($"You answered {correctAnswers} out of 10 questions correctly. ({percentage}%).");
            }
        }
        private string QuizStatus()
        {
            return $"Correct answers: {correctAnswers} / {questionIndex}";
        }
    }
}
