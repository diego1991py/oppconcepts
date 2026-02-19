using OppConcepts.Backend;

try
{
    var date1 = new Date();
    var date2 = new Date(2026, 12, 18);

    Console.WriteLine(date1);
    Console.WriteLine(date2);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}


