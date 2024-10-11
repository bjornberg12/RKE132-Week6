string[] snacks = { "sushi", "pizza", "chicken", "takeaway" };


Random rand = new Random();

int randomIndex = rand.Next(0, snacks.Length);

Console.WriteLine($"toning we eat {snacks[randomIndex]}");