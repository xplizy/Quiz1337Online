using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Labb3_NET22.DataModels
{
    internal class QuizManager
    {
        public static List<Question> AllQuestions { get; set; } = new List<Question>();
        public static List<Quiz> listQuizes { get; set; } = new List<Quiz>();
        public static List<string> selectedCategories { get; set; } = new List<string>();


        public static void AddQuiz(Quiz quiz)
        {
            listQuizes.Add(quiz);
        }
        public static bool CheckIfQuizExists(string title)
        {
            foreach (var quiz in listQuizes)
            {
                if (quiz.Title == title)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckIfQuestionExist(string statement)
        {
            foreach (var question in AllQuestions)
            {
                if (question.Statement == statement)
                {
                    return true;
                }
            }
            return false;
        }
        public static async void LoadAllQuestions()
        {
            string directoryName = @".\\Quiz1337";
            string fileName = "Quiz1337.json";
            string directoryFilePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + directoryName;
            string filepath = Path.Combine(directoryFilePath, fileName);

            List<Question> questions = new List<Question>();

            try
            {
                if (File.Exists(filepath))
                {
                    string json = await File.ReadAllTextAsync(filepath);
                    questions = JsonConvert.DeserializeObject<List<Question>>(json);
                    QuizManager.AllQuestions = questions;
                }
                else
                {
                    MessageBox.Show("File does not exist");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error" + exception.Message);
            }
        }
        public async void LoadAllQuizes()
        {

        }

    }
}

