
//INPUT   //OUTPUT
//2       //28.5
//3 
//4 
//25       


        double packOfPen = double.Parse(Console.ReadLine());
        double packOfMarker = double.Parse(Console.ReadLine());
        double cleanLitries = double.Parse(Console.ReadLine());
        double discount = double.Parse(Console.ReadLine());

        double penPrice = packOfPen * 5.80; // Коригирано: packOfPen, а не packOfMarker
        double markerPrice = packOfMarker * 7.20;
        double cleanPrice = cleanLitries * 1.20;

        double allPrice = penPrice + markerPrice + cleanPrice;
        double discountPrice = allPrice - (allPrice * discount) / 100;

        Console.WriteLine($"Annie will need {discountPrice} money.");





