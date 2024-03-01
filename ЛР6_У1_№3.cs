using System;
using System.Collections.Generic;
using System.Linq;

struct SurveyResponse
{
    public string PersonOfYear;
}

class Program
{
    static void Main(string[] args)
    {
        SurveyResponse[] surveyResponses = new SurveyResponse[]
        {
            new SurveyResponse { PersonOfYear = "Шаман" },
            new SurveyResponse { PersonOfYear = "Настя Ивлеева" },
            new SurveyResponse { PersonOfYear = "Филипп Киркоров" },
            new SurveyResponse { PersonOfYear = "Евгений Пригожин" },
            new SurveyResponse { PersonOfYear = "Шаман" },
            new SurveyResponse { PersonOfYear = "Настя Ивлеева" },
            new SurveyResponse { PersonOfYear = "Шаман" },
            new SurveyResponse { PersonOfYear = "Егор Крид" },
            new SurveyResponse { PersonOfYear = "Евгений Пригожин" },
            new SurveyResponse { PersonOfYear = "Шаман" },
        };

        Dictionary<string, int> responseFrequency = new Dictionary<string, int>();

        foreach (var response in surveyResponses)
        {
            if (responseFrequency.ContainsKey(response.PersonOfYear))
                responseFrequency[response.PersonOfYear]++;
            else
                responseFrequency[response.PersonOfYear] = 1;
        }

        var sortedResponses = responseFrequency.OrderByDescending(pair => pair.Value);

        int totalResponses = surveyResponses.Length;

        Console.WriteLine("Пять наиболее частых ответов:");

        foreach (var pair in sortedResponses.Take(Math.Min(5, sortedResponses.Count())))
        {
            double percentage = ((double)pair.Value / totalResponses) * 100;
            Console.WriteLine($"{pair.Key}: {pair.Value} ответов ({percentage:0.00}% от общего числа)");
        }
    }
}