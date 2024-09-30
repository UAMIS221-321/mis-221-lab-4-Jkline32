//main
using System.Globalization;

DisplayMenu();
string userChoice = GetMenuChoice();
RoutEm(userChoice);

//end main

static void DisplayMenu(){
    Console.Clear();
    System.Console.WriteLine("Type a number for which option you would like:\n1. Plain topping-less pizza slice\n2. Cheese pizza slice\n3. Pepperoni pizza slice\n4. Exit");
}

static string GetMenuChoice(){
    System.Console.WriteLine("Please enter your pizza slice choice...");
    return Console.ReadLine();
}

static void RoutEm(string userChoice){
    switch(userChoice){
        case "1":
        PlainToppingPizza();
        break;
        case "2":
        CheesePizza();
        break;
        case "3":
        PepperoniPizza();
        break;
        case "4":
        Exit();
        break;
        default:
        System.Console.WriteLine("Invalid pizza slice choice");
        break;
    }
}

static void PlainToppingPizza(){
    Random rand = new Random();
    int numRows = rand.Next(8,13);

    for(int i = numRows; i >= 1; i--){
        for(int j = 1; j <= i; j++){
            Console.Write("* ");
        }
        System.Console.WriteLine();
    }

}

static void CheesePizza(){
    Random rand = new Random();
    int numRows = rand.Next(8, 13); 

    for (int i = numRows; i >= 1; i--)
    {
        for (int j = 1; j <= i; j++){
            if (j == 1 || j == i || i == numRows){
                Console.Write("* ");
            }
            else{
                Console.Write("# ");
            }
        }
        Console.WriteLine(); 
    }

}

static void PepperoniPizza(){
 Random rand = new Random();
 int numRows = rand.Next(8, 13); 

for (int i = numRows; i >= 1; i--){
    for (int j = 1; j <= i; j++){
        if (j != 1 && j != i && rand.Next(0, 4) == 0){
            Console.Write("[] "); 
            }
            else if (j == 1 || j == i || i == numRows){
                Console.Write("* "); 
            }
            else{
            Console.Write("# "); 
            }
        }
        Console.WriteLine(); 
    }
}

static void Exit(){
    System.Console.WriteLine("Press any key to Exit...");
    Console.ReadKey();
}




