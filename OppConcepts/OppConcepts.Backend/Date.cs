using static System.Net.Mime.MediaTypeNames;

namespace OppConcepts.Backend;

public class Date
{   
    //Atributos privados
    private int _year;
    private int _month;
    private int _day;

    //Constructor
    public Date()
    {
        _year = 1900;
        _month = 1;
        _day = 1;
    }

    //Segundo Constructor
    public Date(int year, int month, int day)
    {
        Year = year;
        Month = month;
        Day = day;
        
    }

    //propiedades
    public int Year 
    { 
        get => _year;
        set => _year = ValidateYear(value); 
    }
    public int Month 
    { 
      get => _month;
      set => _month = ValidateMonth(value); 
    }
    public int Day 
    { 
      get => _day; 
      set => _day = ValidateDay(value); 
    }

    //Metodo público
    public override string ToString()
    {
        return $"{Year:0000}/{Month:00}/{Day:00}";
    }

    //Metodos privados
    private int ValidateYear(int year)
    {
        if (year < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(year), "El año debe ser mayor a cero");
        }
        return year;
    }

    private int ValidateMonth(int month)
    {
        if (month < 1 || month > 12)
        {
            throw new ArgumentOutOfRangeException(nameof(month), "El mes debe estar entre 1 y 12");
        }
        return month;
    }

    private int ValidateDay(int day)
    {
        if (day < 1)
        {
            throw new ArgumentOutOfRangeException(nameof(day), "El día debe ser mayor a 1");
        }
        if (day == 29 && Month == 2 && IsLeapYear(Year))
        {
            return day;
        }
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (day > daysInMonth[Month - 1])
        {
            throw new ArgumentOutOfRangeException(nameof(day), $"El día debe estar entre 1 y {daysInMonth[Month -1 ]} para el mes {Month}");
        }
        return day;
    }

    private bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0); 
    }
    

}
