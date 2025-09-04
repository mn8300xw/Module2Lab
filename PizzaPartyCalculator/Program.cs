//Declare variables
int numberOfGuests;
int slicesPerGuest = 3; // Assume each guest eats 3 slices
int slicesPerPizza = 8; // Standard pizza has 8 slices

Console.Write("Enter the number of guests: ");
// Call the Parse function to turn the value the user entered into an int
numberOfGuests = int.Parse(Console.ReadLine());

int totalSlicesNeeded = numberOfGuests * slicesPerGuest;

int pizzasNeeded = (int)Math.Ceiling((double)totalSlicesNeeded / slicesPerPizza);

Console.WriteLine($"For {numberOfGuests} guests, you'll need {pizzasNeeded} pizzas.");