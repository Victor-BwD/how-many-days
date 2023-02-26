string dateInputed = "";
DateTime today = DateTime.Today;

Console.WriteLine("Welcome to my date calculator!");
Console.WriteLine("You can see how many days have passed since your desired date.");
Console.WriteLine("Input the date or write Quit to quit.");

while(true)
{
    Console.WriteLine("Which date? (or 'quit')");
    dateInputed = Console.ReadLine();
    
    if (dateInputed.Equals("quit", StringComparison.OrdinalIgnoreCase)) {
        break;
    }

    DateTime parsedDate;
    TimeSpan timeSpan;
    if (DateTime.TryParse(dateInputed, out parsedDate)) {
        if (parsedDate < today) {
            timeSpan = today - parsedDate;
            Console.WriteLine($"That date went by {timeSpan.Days} days ago!");
        }else if (parsedDate == today) {
            Console.WriteLine("The date is today!");
        }
        else {
            timeSpan = parsedDate - today;
            Console.WriteLine($"That date will be in {timeSpan.Days} days!");
        }
    }
    else {
        Console.WriteLine("That doesn't seem to be a valid date");
    }
}