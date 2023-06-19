using salary;
using System;

class Program : Worker
{
    static void Main() 
    {
        Worker[] workers = new Worker[10]
        {
            new Worker { Name = "Ken",      Salary = 4000 },
            new Worker { Name = "Matthew",  Salary = 6900 },
            new Worker { Name = "Charles",  Salary = 7000 },
            new Worker {Name = "James",     Salary = 3900},
            new Worker {Name = "Jerry",     Salary = 8000},
            new Worker {Name = "Jeremiah",  Salary = 1500},
            new Worker {Name = "Jacob",     Salary = 7800},
            new Worker {Name = "Jamie",     Salary = 7100},
            new Worker {Name = "Jane",      Salary = 7900},
            new Worker {Name = "John",      Salary = 3800}
        };

        Array.Sort(workers, (w1, w2) => w2.Salary.CompareTo(w1.Salary));

        foreach (Worker worker in workers)
        {
            Console.WriteLine($"Name: {worker.Name}, Salary: {worker.Salary}");
        }
    }
}
