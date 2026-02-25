using OppConcepts.Backend;

try
{
    //var date1 = new Date();
    //var date2 = new Date(2026, 12, 18);

    //Console.WriteLine(date1);
    //Console.WriteLine(date2);


    var employees = new List<Employee>();
    decimal payroll = 0;

    var employe1 = new SalaryEmployee(1010, "Diego", "Valecia", true, new Date(1991, 12, 18), new Date(2020, 1, 1), 2500000);
    employees.Add(employe1);

    var employe2= new SalaryEmployee(2020, "Samuel", "Valecia", true, new Date(2000, 5, 18), new Date(2024, 12, 1), 3000000);
    employees.Add(employe2);

    var employe3 = new HourlyEmployee(3030, "Matias", "Valecia", true, new Date(210, 11, 20), new Date(2025, 1, 1), 15000, 160);
    employees.Add(employe3);

    var employe4 = new HourlyEmployee(4040, "Laura", "Valecia", true, new Date(1999, 6, 25), new Date(2026, 2, 15), 10000, 200);
    employees.Add(employe4);

    var employee5 = new CommisionEmployee(5050, "Andrea", "Martínes", true, new Date(1990, 12, 17), new Date(2019, 10, 10), 0.03f, 600000000);
    employees.Add(employee5);

    var employee6 = new CommisionEmployee(6060, "Jaime", "Montoya", true, new Date(1987, 10, 18), new Date(2015, 5, 15), 0.03f, 250000000);
    employees.Add(employee6);

    var employee7 = new BaseCommisionEmployee(7070, "Juan", "Montoya", true, new Date(1995, 6, 6), new Date(2025, 2, 27), 0.015f, 100000000, 600000);
    employees.Add(employee7);

    var employee8 = new BaseCommisionEmployee(8080, "Katherine", "Molina", true, new Date(1993, 2, 7), new Date(2026, 2, 24), 0.015f, 0, 600000);
    employees.Add(employee8);

    foreach ( var employe in employees )
    {
        Console.WriteLine(new string('-', 47));
        Console.WriteLine(employe);
        payroll += employe.GetValueToPay();
    }
    Console.WriteLine(new string('=', 47));
    Console.WriteLine($"*Payroll..................:{payroll,20:C2}");

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}


