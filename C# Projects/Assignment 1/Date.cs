using System;

public class Date
{
    private int year;   // Field
    private int month;  // Field
    private int day;    // Field
    readonly int[] month30s = { 4, 6, 9, 11 };
    readonly int[] month31s = { 1, 3, 5, 7, 8, 9, 10, 12 };
    readonly int[] month28or29 = { 2 };
    // Constructor
    public Date(int year, int month, int day)
    {
        this.year = year;
        this.month = month;
        this.day = day;
    }
    // Add method with day perameter
    public void Add(int days)
    {
        this.day += days;
        this.Normalize();
    }
    // Add method with day,month perameter
    public void Add(int month, int days)
    {
        this.month += month;
        this.day += days;
        this.Normalize();
    }
    // Add method with day,month,year perameter
    public void Add(Date other)
    {
        this.month += other.month;
        this.day += other.day;
        this.year += other.year;
        this.Normalize();
    }
    // normalize function
    private void Normalize()
    {
        bool x = false;
        while (!x)
        {

            if (this.month31s.Contains(this.month) && this.day > 31)
            {
                this.month++;
                this.day -= 31;
            }
            else if (this.month30s.Contains(this.month) && this.day > 30)
            {
                this.month++;
                this.day -= 30;
            }
            else if (this.month28or29.Contains(this.month) && Convert.ToBoolean(this.year % 4) && this.day > 29)
            {
                this.month++;
                this.day -= 29;

            }
            else if (this.month28or29.Contains(this.month) && !Convert.ToBoolean(this.year % 4) && this.day > 28)
            {
                this.month++;
                this.day -= 28;

            }
            else
            {
                if (this.month > 12)
                {
                    this.year++;
                    this.month -= 12;
                    x = false;
                }
                else
                {
                    x = true;
                }
            }

        }
    }
    // Tostring() function
    public override string ToString()
    {
        return "Date Object note:-" + " *Displyed date will be in MM-DD-YYYY formate" +
            "\nDate:- " + this.month.ToString() + "-" + this.day + "-" + this.year +
            "\n";


    }
}