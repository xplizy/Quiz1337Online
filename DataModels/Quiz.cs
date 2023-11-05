using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace Labb3_NET22.DataModels;

public class Quiz
{
    private List<Question>? Questions { get; set; }
    private string? _title = string.Empty;
    private string? _category = string.Empty;
    public string? Title => _title;
    public string? Category => _category;
    

    public Quiz(string title, string category)
    {
        _title = title;
        _category = category;
        Questions = new List<Question>();
    }
    public Quiz()
    {
        Questions = new List<Question>();
    }
    public Question GetRandomQuestion()
    {
        if (Questions.Count > 0)
        {
            Random random = new Random();
            int randomIndex = random.Next(0, Questions.Count);
            return Questions[randomIndex];
        }
        else
        {
            return new Question("", "Game Over", new string[3] { "", "", "" }, 0);
            
        }
       
    }
    

   

    public void AddQuestion(Question question)
    {
        Question tempQuestion = new Question(question.Category, question.Statement, question.Answers, question.CorrectAnswer);
        Questions.Add(tempQuestion);
    }

    public void RemoveQuestion(int index)
    {
        
        if (Questions.Count > 0)
        {
            Questions.RemoveAt(index);
        }
        else
        {

        }
        
    }

    public async void GenerateQuestions()
    {
        AddQuestion(new Question("Football", " In 1999, Jason McAteer left Liverpool to join which club?", new string[3] { "Bolton Wanderers", "Blackburn Rovers", "Tranmere Rovers" }, 1));
        AddQuestion(new Question("Football", " Lionel Messi holds the record for most goals in a calendar year but how many did he score?", new string[3] { "81", "91", "101" }, 1));
        AddQuestion(new Question("Football", " Wayne Rooney scored a hat trick on his Manchester United debut against which club?", new string[3] { "Fenerbahce", "Galatasaray", "Besiktas" }, 0));
        AddQuestion(new Question("Football", " Tony Adams captained an English title winning side in how many decades?", new string[3] { "1", "2", "3" }, 2));
        AddQuestion(new Question("Football", " Thierry Henry made his professional debut with which club?", new string[3] { "Monaco ", "Juventus", "Arsenal" }, 0));
        AddQuestion(new Question("Football", " Paul Van Himst is a celebrated footballer of which nationality?", new string[3] { "France", "The Netherlands", "Belgium" }, 2));
        AddQuestion(new Question("Football", " Which nation won the 1986 World Cup?", new string[3] { "West Germany", "Brazil", "Argentina" }, 2));
        AddQuestion(new Question("Football", " Which Argentinian football club who play their home games at La Bombonera are known by the nickname 'Azul y Oro'?", new string[3] { "Boca Juniors", "Cruz Azul", "River Plate" }, 0));
        AddQuestion(new Question("Football", " Which Spanish side was named FIFA's Club of the Century in 2000?", new string[3] { "Barcelona", "Valencia", "Real Madrid" }, 2));
        AddQuestion(new Question("Football", " Upon his retirement from international football in 2000, which English striker had scored 30 times in 63 appearances for his country?", new string[3] { "Alan Shearer", "Micheal Owen", "Teddy Sheringham" }, 0));

        AddQuestion(new Question("Pokemon", "Ash and Pikachu was on their vacation on an island, name it?", new string[3] { "Alola", "Ula ula", "Mele Mele" }, 2));
        AddQuestion(new Question("Pokemon", "Ash was swimming on along with a Pokémon, name it?", new string[3] { "Mimikyu", "Pikipek", "Sharpedo" }, 2));
        AddQuestion(new Question("Pokemon", "Name the other person on vacation along with Ash and Pikachu?", new string[3] { "Ash’s mum", "Professor Samson", "Lana" }, 0));
        AddQuestion(new Question("Pokemon", "On the sea, Lana sat with which Pokémon?", new string[3] { "Lapras", "Snorlax", "Hypno" }, 0));
        AddQuestion(new Question("Pokemon", "Name the Pokémon that she catched with her fishing rod?", new string[3] { "Feemas", "Shukaku", "Tirtouga" }, 1));
        AddQuestion(new Question("Pokemon", "When Ash was on the Melemele beach, he step on a Pokémon, what was it?", new string[3] { "Charizad", "Litten", "Eevee" }, 1));
        AddQuestion(new Question("Pokemon", "When Ash and Pikachu were trying to catch up Grubbin, what Pokémon did chased them?", new string[3] { "Milotic", "Tapu Koko", "Psyduck" }, 1));
        AddQuestion(new Question("Pokemon", "On their way, they met a Pokemon in the woods, name it?", new string[3] { "Psybuck", "Vulpix", "Bewear" }, 2));
        AddQuestion(new Question("Pokemon", "The Blond girl who is scared of Pokémon’s is?", new string[3] { "Misty", "Mallow", "Lillie" }, 2));
        AddQuestion(new Question("Pokemon", "In the Pokémon school many students were bullied by whom?", new string[3] { "Team skull", "Seren", "Jessie" }, 0));

        AddQuestion(new Question("Game of Thrones", "Where do most of the events in Game of Thrones take place?", new string[3] { "Northeros", "Easteros", "Westeros" }, 2));
        AddQuestion(new Question("Game of Thrones", "Who shot the burning arrow that sunk Lord Hoster Tully’s ship at his funeral?", new string[3] { "Brynden Tully", "Edmure Tully", "Catelyn Tully" }, 0));
        AddQuestion(new Question("Game of Thrones", "For how many kings did Lord Tywin Lannister serve as Hand?", new string[3] { "3", "2", "0" }, 0));
        AddQuestion(new Question("Game of Thrones", "“A crow gone bad. A man gone mad. A people so had. A North so sad.” Who said these lines?", new string[3] { "Mance Rayder", "Jon Snow", "Bran Stark" }, 0));
        AddQuestion(new Question("Game of Thrones", "Which of these was The King Who Knelt?", new string[3] { "Torrhen Stark", "Mikken Stark", "Eddard Stark" }, 0));
        AddQuestion(new Question("Game of Thrones", "What does Varys usually say is his goal?", new string[3] { "To serve the realm", "To avenge the Targaryens", "To survive" }, 0));
        AddQuestion(new Question("Game of Thrones", "Patchface came from which of the Free Cities?'?", new string[3] { "Valyria", "Lorath", "Volantis" }, 2));
        AddQuestion(new Question("Game of Thrones", "How many knights were in Robert’s Kingsguard??", new string[3] { "7", "9", "8" }, 0));
        AddQuestion(new Question("Game of Thrones", "House Tyrell’s castle is called…", new string[3] { "Harrenhal", "The Shadow Tower", "Highgarden" }, 2));
        AddQuestion(new Question("Game of Thrones", "When the series began, the king of Westeros was…", new string[3] { "Eddard Stark", "Robert Baratheon", "Aerys II Targaryen" }, 1));

        





        string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string directoryName = "Quiz1337";

        string fileName = "Quiz1337.json";

        string directoryFilePath = Path.Combine(directoryPath, directoryName);
        string filePath = Path.Combine(directoryFilePath, fileName);

        string json = JsonConvert.SerializeObject(Questions, Newtonsoft.Json.Formatting.Indented);

        try
        {
            Directory.CreateDirectory(directoryFilePath);
            await File.WriteAllTextAsync(filePath, json);
        }
        catch (IOException e)
        {
            MessageBox.Show("An error occurred: " + e.Message);
        }


    }

    public static Quiz CreateRandomQuiz()
    {
        Quiz tempQuiz = new Quiz("Quiz1", "None");
        Random rand = new Random();
        List<int> usedIndices = new List<int>(); 

        for (int i = 0; i < 10; i++)
        {
            int randomIndex;

            do
            {
                randomIndex = rand.Next(0, QuizManager.AllQuestions.Count);
            } while (usedIndices.Contains(randomIndex)); 

            tempQuiz.Questions.Add(QuizManager.AllQuestions[randomIndex]);
            usedIndices.Add(randomIndex); 
        }
        QuizManager.listQuizes.Add(tempQuiz);
        return tempQuiz;
    }

    internal static Quiz? LoadFromFile(string v)
    {
        throw new NotImplementedException();
    }
}