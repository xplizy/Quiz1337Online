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
    
    public partial class CreateNewQuizWindow : Window
    {
        
        Quiz tempQuiz = new Quiz();
        public CreateNewQuizWindow()
        {
            InitializeComponent();

        }

        private void btnSaveQuestion_Click(object sender, RoutedEventArgs e)
        {

            int correctAnswer = -1;

            if (string.IsNullOrEmpty(QuizName.Text))
            {
                MessageBox.Show("Input a Quizname!");
                return;
            }
            else if (QuizManager.CheckIfQuizExists(QuizName.Text))
            {
                MessageBox.Show("That Quiz name is already used!, change your title");
                return;
            }

            tempQuiz = new Quiz(QuizName.Text, CategoryName.Text);


            if (string.IsNullOrEmpty(CategoryName.Text) || string.IsNullOrEmpty(QuestionStatement.Text) || string.IsNullOrEmpty(Answer1.Text) || string.IsNullOrEmpty(Answer2.Text) || string.IsNullOrEmpty(Answer3.Text))
            {
                MessageBox.Show("Input category, statement, answers and check in the correct answer!");
            }
            else
            {
                if (Checkbox1.IsChecked == true && Checkbox2.IsChecked == false && Checkbox3.IsChecked == false)
                {
                    correctAnswer = 0;
                }
                else if (Checkbox2.IsChecked == true && Checkbox1.IsChecked == false && Checkbox3.IsChecked == false)
                {
                    correctAnswer = 1;
                }
                else if (Checkbox3.IsChecked == true && Checkbox1.IsChecked == false && Checkbox2.IsChecked == false)
                {
                    correctAnswer = 2;
                }
                else if (Checkbox1.IsChecked == false && Checkbox2.IsChecked == false && Checkbox3.IsChecked == false)
                {
                    MessageBox.Show("Check in the correct answer");
                    return;
                }

                Question tempQuestion = new Question(CategoryName.Text, QuestionStatement.Text, new string[3] { Answer1.Text, Answer2.Text, Answer3.Text }, correctAnswer);

                tempQuiz.AddQuestion(tempQuestion);
                MessageBox.Show("Question was created!");

                TextBlockQuizName.Text = "QUIZ NAME:";
                CategoryName.Text = string.Empty;
                QuestionStatement.Text = string.Empty;
                Answer1.Text = string.Empty;
                Answer2.Text = string.Empty;
                Answer3.Text = string.Empty;
                Checkbox1.IsChecked = false;
                Checkbox2.IsChecked = false;
                Checkbox3.IsChecked = false;



            }
            
        }

        private void btnSaveQuiz_Click(object sender, RoutedEventArgs e)
        {

            QuizManager.listQuizes.Add(tempQuiz);
            MessageBox.Show($" {tempQuiz.Title} was created!");
            QuizName.Text = string.Empty;
          
        }

        private void btnMainMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
