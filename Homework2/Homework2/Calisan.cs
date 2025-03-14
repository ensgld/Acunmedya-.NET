using System.ComponentModel.DataAnnotations;

namespace Homework2;

public class Calisan
{ 
    string name;
    string surname;
    string job;
    string department;
    public int salary;

    public Calisan(string name, string surname, string job, string department, int salary)
    {
        this.name = name;
        this.surname = surname;
        this.job = job;
        this.department = department;
        this.salary = salary;
    }

    public string displayAttribute()
    {
        return this.name + " " + this.surname + " " + this.job + " " + this.department + " " + this.salary;
    }
    
}