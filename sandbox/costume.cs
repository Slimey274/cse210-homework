class Costume
{
    // atributes
    public string headWear;
    public string gloves;
    public string shoes;
    public string upperGarment;
    public string lowerGarmnent;
    public string accesory;

    // behaviors
    static void ShowWardrobe()
    {
        string result = " ";
        result += $"Head": {headWear}\n
        result += $"Hands": {gloves}\n
        result += $"Feet": {shoes}\n
        result += $"Torso": {upperGarment}\n
        result += $"Legs": {lowerGarment}\n
        result += $"Accesory": {accesory}\n
        Console.WriteLine(result);
    }
}