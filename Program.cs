using System;
using System.Collections.Generic;

partial class Film
{
    internal TimeSpan Duration;
    internal int Year;
    private string director;
    private int budget;

    public Film()
    {
    }

    public Film(string director, int budget)
    {
        this.director = director;
        this.budget = budget;
    }

    public void DisplayAdditionalInfo()
    {
        Console.WriteLine($"Режиссер: {director}");
        Console.WriteLine($"Бюджет: {budget}");
    }

    
}

partial class Film
{
    private string genre;

    public Film(string genre)
    {
        this.genre = genre;
    }

    public void DisplayGenre()
    {
        Console.WriteLine($"Жанр: {genre}");
    }
}

enum ProgramType
{
    SealedTVProgram,
    Film,
    News,
    ArtFilm,
    Cartoon,
    Advertisement
}

class ProgramContainer
{
    private List<TVProgram> programs = new List<TVProgram>();

    public List<TVProgram> Programs
    {
        get { return programs; }
        set { programs = value; }
    }

    public void AddProgram(TVProgram program)
    {
        programs.Add(program);
    }

    //public void RemoveProgram(TVProgram program)
    //{
    //    programs.Remove(program);
    //}

    public void DisplayPrograms()
    {
        foreach (var program in programs)
        {
            Console.WriteLine(program.ToString());
            program.DisplayInfo();
            Console.WriteLine();
        }
    }
}

struct FilmInfo
{
    public string Title;
    public int Year;
    public TimeSpan Duration;
    public int NumberOfAds;
}

interface ICloneable
{
    bool DoClone();
}

abstract class TVProgram
{
    internal TimeSpan Duration;
    internal int Year;
    private readonly string director;
    private readonly int budget;

    protected TVProgram(string director, int budget, int Year,TimeSpan Duration)
    {
        this.director = director;
        this.budget = budget;
        this.Year = Year;
        this.Duration = Duration;
    }

    public abstract void DisplayInfo();

    public override string ToString()
    {
        return $"Тип объекта: {GetType().Name}";
    }

  
}

class ProgramController
{
    private ProgramContainer programContainer = new ProgramContainer();

    private TimeSpan customTimeSpan = new TimeSpan(1, 30, 45);
    private TimeSpan customTimeSpan1 = new TimeSpan(0, 20, 45);
    private TimeSpan customTimeSpan2 = new TimeSpan(3, 00, 00);
    private TimeSpan customTimeSpan3 = new TimeSpan(1, 30, 00);
    private TimeSpan customTimeSpan4 = new TimeSpan(0, 10, 00);

    public ProgramController()
    {
        programContainer.AddProgram(new SealedTVProgram("Sakes",2300000,2023, customTimeSpan));
        programContainer.AddProgram(new News("John",2130, 2020, customTimeSpan1));
        programContainer.AddProgram(new ArtFilm("Some Director", 100000, 2021, customTimeSpan2));
        programContainer.AddProgram(new Cartoon("Another Director", 80000, 2022, customTimeSpan3));
        programContainer.AddProgram(new Advertisement("",230230, 2023, customTimeSpan4));
    }

    public void FindFilmsByYear(int year)
    {
        Console.WriteLine($"Фильмы, снятые в {year} году:");

        foreach (var program in programContainer.Programs)
        {
            if (program is TVProgram film && film.Year == year)
            {
                Console.WriteLine($"{film}, Год выпуска: {film.Year}");
            }
        }

        Console.WriteLine();
    }

    public TimeSpan CalculateTotalDuration()
    {
        TimeSpan totalDuration = TimeSpan.Zero;

        foreach (var program in programContainer.Programs)
        {
            totalDuration += GetProgramDuration(program);
        }

        Console.WriteLine($"Общая продолжительность программы: {totalDuration}");
        return totalDuration;
    }

    public int CountAdvertisements()
    {
        int adCount = 0;

        foreach (var program in programContainer.Programs)
        {
            if (program is Advertisement)
            {
                adCount++;
            }
        }

        Console.WriteLine($"Число рекламных роликов: {adCount}");
        return adCount;
    }

    private TimeSpan GetProgramDuration(TVProgram program)
    {
        return program is TVProgram tVProgram ? tVProgram.Duration : TimeSpan.Zero;
    }
}

sealed class SealedTVProgram : TVProgram
{
    public SealedTVProgram(string director, int budget, int Year, TimeSpan Duration) : base(director, budget, Year, Duration)
    {
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Это плотная телевизионная программа.");
    }
}

class News : TVProgram
{
    public News(string director, int budget, int Year, TimeSpan Duration) : base(director, budget, Year, Duration)
    {
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Это новости.");
    }
}

internal class ArtFilm : TVProgram
{
    public ArtFilm(string director, int budget, int Year, TimeSpan Duration) : base(director, budget, Year, Duration)
    {
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Это художественный фильм.");
    }
}

class Cartoon : TVProgram
{
    public Cartoon(string director, int budget, int Year, TimeSpan Duration) : base(director, budget, Year, Duration)
    {
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Это мультфильм.");
    }
}

class Advertisement : TVProgram
{
    public Advertisement(string director, int budget, int Year, TimeSpan Duration) : base(director, budget, Year, Duration)
    {
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Это реклама.");
    }
}

class Director
{
    public void Direct()
    {
        Console.WriteLine("Режиссер снимает телевизионную программу.");
    }
}

class Printer
{
    public void IAmPrinting(TVProgram tvProgram)
    {
        Console.WriteLine(tvProgram.ToString());
        tvProgram.DisplayInfo();
    }
}

class Program
{
    static void Main()
    {
        TimeSpan customTimeSpan = new TimeSpan(1, 30, 45);
        TimeSpan customTimeSpan1 = new TimeSpan(0, 20, 45);
        TimeSpan customTimeSpan2 = new TimeSpan(3, 00, 00);
        TimeSpan customTimeSpan3 = new TimeSpan(1, 30, 00);
        TimeSpan customTimeSpan4 = new TimeSpan(0, 10, 00);

        TVProgram[] programs = new TVProgram[]
        {
            new SealedTVProgram("Dad and Son",230000, 2023, customTimeSpan),
            new News("Sam",100000, 2022, customTimeSpan1),
            new ArtFilm("Some Director", 100000, 2021, customTimeSpan2),
            new Cartoon("Another Director", 80000, 2023, customTimeSpan3),
            new Advertisement("Fingers",123123, 2020, customTimeSpan4)
        };

        Printer printer = new Printer();

        foreach (var program in programs)
        {
            printer.IAmPrinting(program);
            Console.WriteLine();
        }

            Director director = new Director();
        director.Direct();

        ProgramController controller = new ProgramController();
        controller.FindFilmsByYear(2023);
        controller.CalculateTotalDuration();
        controller.CountAdvertisements();
    }
}

