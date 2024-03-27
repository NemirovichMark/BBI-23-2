using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

class Country
{
    public string Name { get; }
    public Survey[] surveys { get; set; }

    public Country(string name)
    {
        Name = name;
    }
}

class Russia : Country
{
    public Russia()
        : base("Россия")
    {
    }
}

class Japan : Country
{
    public Japan()
        : base("Япония")
    {
    }
}


class Survey
{
    private string _animal;
    private string _character;
    private string _thing;
    private Country _country;

    public string animal { get { return _animal; } }
    public string character { get { return _character; } }
    public string thing { get { return _thing; } }

    public Country country { get { return _country; } }

    public Survey(string animal, string character, string thing, Country country)
    {
        _animal = animal;
        _character = character;
        _thing = thing;
        _country = country;
    }

    public void printSurvey()
    {
        Console.WriteLine(
            "Animal: {0,15} \t => char: {1,20} \t thing: {2,15}",
            animal, character, thing);
    }
}

class Program
{
    static void printElemCountOfArray(KeyValuePair<string, int>[] values, int limit, int totalCount)
    {
        Console.WriteLine();
        for (int index = 0; index < Math.Min(limit, values.Length); ++index)
        {
            Console.WriteLine(
                "value: {0,30} \t => percent: {1,6}",
                values[index].Key, ((double)values[index].Value / totalCount * 100).ToString("00.00" +
                "" +
                ""));
        }
    }

    static void CalculatePercentsByCountry(Survey[] survery, Type countryToFilter)
    {
        int animalAnswers = survery.Count(surveyItem => !string.IsNullOrEmpty(surveyItem.animal) && surveyItem.country.GetType().Equals(countryToFilter));
        int charAnswers = survery.Count(surveyItem => !string.IsNullOrEmpty(surveyItem.character) && surveyItem.country.GetType().Equals(countryToFilter));
        int thingAnswers = survery.Count(surveyItem => !string.IsNullOrEmpty(surveyItem.thing) && surveyItem.country.GetType().Equals(countryToFilter));

        Dictionary<string, int> animalAnswersCount = new Dictionary<string, int>();
        for (int index = 0; index < survery.Length; ++index)
        {
            if (!survery[index].country.GetType().Equals(countryToFilter))
                continue;

            if (animalAnswersCount.ContainsKey(survery[index].animal))
                animalAnswersCount[survery[index].animal]++;
            else
                animalAnswersCount[survery[index].animal] = 1;
        }
        var animalAnswersAsArray = animalAnswersCount.ToArray();
        Array.Sort(animalAnswersAsArray, (a, b) => a.Value.CompareTo(b.Value));
        Array.Reverse(animalAnswersAsArray);
        printElemCountOfArray(animalAnswersAsArray, 5, animalAnswers);

        Dictionary<string, int> charAnswersCount = new Dictionary<string, int>();
        for (int index = 0; index < survery.Length; ++index)
        {
            if (!survery[index].country.GetType().Equals(countryToFilter))
                continue;

            if (charAnswersCount.ContainsKey(survery[index].character))
                charAnswersCount[survery[index].character]++;
            else
                charAnswersCount[survery[index].character] = 1;
        }
        var charAnswersAsArray = charAnswersCount.ToArray();
        Array.Sort(charAnswersAsArray, (a, b) => a.Value.CompareTo(b.Value));
        Array.Reverse(charAnswersAsArray);
        printElemCountOfArray(charAnswersAsArray, 5, charAnswers);


        Dictionary<string, int> thingAnswersCount = new Dictionary<string, int>();
        for (int index = 0; index < survery.Length; ++index)
        {
            if (!survery[index].country.GetType().Equals(countryToFilter))
                continue;

            if (thingAnswersCount.ContainsKey(survery[index].thing))
                thingAnswersCount[survery[index].thing]++;
            else
                thingAnswersCount[survery[index].thing] = 1;
        }
        var thingAnswersAsArray = thingAnswersCount.ToArray();
        Array.Sort(thingAnswersAsArray, (a, b) => a.Value.CompareTo(b.Value));
        Array.Reverse(thingAnswersAsArray);
        printElemCountOfArray(thingAnswersAsArray, 5, thingAnswers);
    }
    static void Main()
    {
        Survey[] survery = { new Survey("кошка", "застенчивость", "рис", new Japan()),
                             new Survey("собака", "дисциплинированость", "кимоно", new Japan()),
                             new Survey("медведь", "трудолюбие", "чай", new Russia()),
                             new Survey("рыба", "вежливость", "сакура", new Japan()),
                             new Survey("медведь", "вежливость", "гречка", new Russia()),
                             new Survey("дракон", "целеустремлённость", "сакура", new Japan()),
                             new Survey("лягушка", "скромность", "рис", new Japan())
                            };

        Console.WriteLine("Unordered:");

        for (int index = 0; index < survery.Length; ++index)
            survery[index].printSurvey();

        Console.WriteLine();
        Console.WriteLine("==== Japan ====");
        CalculatePercentsByCountry(survery, new Japan().GetType());

        Console.WriteLine();
        Console.WriteLine("==== Russia ====");
        CalculatePercentsByCountry(survery, new Russia().GetType());
    }
}

