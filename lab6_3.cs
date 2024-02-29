using System;
using System.Collections.Generic;
using System.Linq;

struct PollQuestion
{
    private string question;
    private Dictionary<string, int> responses;

    public string Question => question;
    public Dictionary<string, int> Responses => responses;

    public PollQuestion(string question)
    {
        this.question = question;
        responses = new Dictionary<string, int>();
    }
}

class RadioPoll
{
    static void Main()
    {
        PollQuestion animalPoll = new PollQuestion("Какое животное Вы связываете с Японией и японцами?");
        PollQuestion characterTraitPoll = new PollQuestion("Какую черту характера Вы связываете с Японией и японцами?");
        PollQuestion objectPoll = new PollQuestion("Какой неодушевленный предмет Вы связываете с Японией и японцами?");

        FillResponses(animalPoll.Responses, animalPoll.Question);
        FillResponses(characterTraitPoll.Responses, characterTraitPoll.Question);
        FillResponses(objectPoll.Responses, objectPoll.Question);

        PrintTopResponses(animalPoll.Responses, "Животное");
        PrintTopResponses(characterTraitPoll.Responses, "Черта характера");
        PrintTopResponses(objectPoll.Responses, "Неодушевленный предмет");
    }

    static void FillResponses(Dictionary<string, int> responses, string question)
    {
        Console.WriteLine($"Введите ответы на вопрос: {question} (для завершения введите 'done')");

        while (true)
        {
            Console.Write("Ответ: ");
            string answer = Console.ReadLine().Trim().ToLower();

            if (answer == "done")
                break;

            if (string.IsNullOrEmpty(answer))
            {
                Console.WriteLine("Ответ не может быть пустым. Повторите ввод.");
                continue;
            }

            if (responses.ContainsKey(answer))
                responses[answer]++;
            else
                responses[answer] = 1;
        }
    }

    static void PrintTopResponses(Dictionary<string, int> responses, string question)
    {
        Console.WriteLine($"\nТоп-5 наиболее часто встречающихся ответов на вопрос: {question}");

        if (responses.Count == 0)
        {
            Console.WriteLine("Ответы отсутствуют.");
            return;
        }

        var sortedResponses = responses.OrderByDescending(x => x.Value).Take(5);

        int totalResponses = responses.Sum(x => x.Value);
        foreach (var response in sortedResponses)
        {
            double percentage = (double)response.Value / totalResponses * 100;
            Console.WriteLine($"{response.Key}: {response.Value} ({percentage:f2}%)");
        }
    }
}
