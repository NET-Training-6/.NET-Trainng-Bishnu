class ConditionalLearner
{
    // Ask user to enter his total percentage and greet him as following:
    // if his total marks less than 60%, print "You passed with second division".
    // if his total marks greater than 60% and less than 80%, print "You passed with first division".
    // if his total marks greater than 80% , print "You passed with distiction".

    public void Task1()
    {
        Console.Write("Enter your total marks out of 500:");
        var markText = Console.ReadLine();
        var marks = double.Parse(markText);
        var totalMarks = (marks / 500) * 100;
        var message = "You passed with {0}" + ", your percentage is " + totalMarks;

        if(totalMarks < 60)
        {
            Console.WriteLine(message, "second division");
        }        
        else if(totalMarks > 60 && totalMarks < 80)
        {
            Console.WriteLine(message, "first division");
        }
        else if(totalMarks > 80 && totalMarks < 100)
        {
            Console.WriteLine(message, "distiction", "", "");
        }
        else
        {
            Console.WriteLine("Did you really attempt exams? Its not possible.");
        }
    }
    void Task2()
    {
        var d = DateTime.Now.DayOfWeek;

        switch(d)
        {
            case DayOfWeek.Sunday: 
            break;
            case DayOfWeek.Monday: 
            break;
            case DayOfWeek.Tuesday: 
            break;
            case DayOfWeek.Wednesday: 
            break;
            case DayOfWeek.Thursday: 
            break;
            case DayOfWeek.Friday: 
            break;
            case DayOfWeek.Saturday: 
            break;
        }
    }
}

enum Gender
{
    Male,
    Female,
    Others
}