//"A store offers several types of fruits at preferential prices. The customer can choose between the following types of fruits:
//Apples - priced at 1.20 lv. per kilogram
//Pears - priced at 1.50 lv. per kilogram
//Bananas - priced at 1.80 lv. per kilogram
//Write a program that, given quantities of each type of fruit, calculates the total price for them. Then, the customer has the option to add a dessert to the order. The dessert costs 2.50 lv. Finally, a delivery fee of 3.00 lv. is added to the total amount.
//Write a program that, when given quantities of apples, pears, and bananas, calculates the total price of the fruit order, adds the price of the dessert and the delivery fee, and displays the total amount on the screen."

//INPUT
//5
//3
//2





        double apples = double.Parse(Console.ReadLine());
        double pears = double.Parse(Console.ReadLine());
        double bananas = double.Parse(Console.ReadLine());
        double dessert = double.Parse(Console.ReadLine());
        double delivery = double.Parse(Console.ReadLine());

        
        double applePrice = apples * 1.20;
        double pearPrice = pears * 1.50;
        double bananaPrice = bananas * 1.80;

        
        double fruitsTotalPrice = applePrice + pearPrice + bananaPrice;

        
        double dessertPrice = 2.50;
        double deliveryFee = 3.00;

        
        double totalPrice = fruitsTotalPrice + dessertPrice + deliveryFee;

       
        Console.WriteLine($"{totalPrice:F2}");
   



