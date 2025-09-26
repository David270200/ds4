Dictionary<string, string> paisesYCapitales = new Dictionary<string, string>
{
    { "Argentina", "Buenos Aires" },
    { "Brasil", "Brasilia" },
    { "Chile", "Santiago" },
    { "Colombia", "Bogota" }
};
foreach (KeyValuePair<string, string> par in paisesYCapitales)
{
    Console.WriteLine($"Pais: {par.Key}, Capital: {par.Value}");
}