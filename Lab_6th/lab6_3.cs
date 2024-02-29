using System;
using System.Collections.Generic;
using System.Linq;

class RadioPoll
{
    static void Main()
    {
        Dictionary<string, int> animalResponses = new Dictionary<string, int>();
        Dictionary<string, int> characterTraitResponses = new Dictionary<string, int>();
        Dictionary<string, int> objectResponses = new Dictionary<string, int>();

        FillResponses(animalResponses, "животное");
        FillResponses(characterTraitResponses, "черта характера");
        FillResponses(objectResponses, "неодушевленный предмет");

        PrintTopResponses(animalResponses, "Животное");
        PrintTopResponses(characterTraitResponses, "Черта характера");
        PrintTopResponses(objectResponses, "Неодушевленный предмет");
    }

    static void FillResponses(Dictionary<string, int> responses, string question)
    {
        Console.WriteLine($"Введите ответы на вопрос: Какое {question} Вы связываете с Японией и японцами? (для завершения введите 'done')");

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

