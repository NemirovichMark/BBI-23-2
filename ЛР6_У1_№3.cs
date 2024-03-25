using System;
using System.Collections.Generic;
using System.Linq;

struct SurveyResponse
{
    private string _personOfYear;

    public SurveyResponse(string personOfYear)
    {
        _personOfYear = personOfYear;
    }

    public string GetPersonOfYear()
    {
        return _personOfYear;
    }

    public void PrintResponse(int count, double percentage)
    {
        Console.WriteLine($"{_personOfYear}: {count} ответов ({percentage:0.00}% от общего числа)");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SurveyResponse[] surveyResponses = new SurveyResponse[]
        {
            new SurveyResponse("Шаман"),
            new SurveyResponse("Настя Ивлеева"),
            new SurveyResponse("Филипп Киркоров"),
            new SurveyResponse("Евгений Пригожин"),
            new SurveyResponse("Шаман"),
            new SurveyResponse("Настя Ивлеева"),
            new SurveyResponse("Шаман"),
            new SurveyResponse("Егор Крид"),
            new SurveyResponse("Евгений Пригожин"),
            new SurveyResponse("Шаман"),
        };

        int totalResponses = surveyResponses.Length;

        Console.WriteLine("Пять наиболее частых ответов:");

        var groupedResponses = surveyResponses
            .GroupBy(response => response.GetPersonOfYear())
            .OrderByDescending(group => group.Count())
            .Take(5);

        foreach (var response in groupedResponses)
        {
            double percentage = (double)response.Count() / totalResponses * 100;
            response.First().PrintResponse(response.Count(), percentage);
        }
    }
}