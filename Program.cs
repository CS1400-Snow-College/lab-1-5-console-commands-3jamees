// See https://aka.ms/new-console-template for more information



        

        int startX = 10;
        int startY = 5;

        
        Console.SetCursorPosition(startX + 3 * 12, startY);
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("            ");
        Console.Write("            ");
        Console.ResetColor();

        
        Console.SetCursorPosition(startX + 2 * 12, startY + 1);
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("            ");
        Console.Write("            ");
        Console.Write("            ");
        Console.ResetColor();

        
        Console.SetCursorPosition(startX + 1 * 12, startY + 2);
        Console.BackgroundColor = ConsoleColor.Black; // Hair
        Console.Write("            ");
        Console.BackgroundColor = ConsoleColor.Red;   // Hat
        Console.Write("            ");
        Console.Write("            ");
        Console.BackgroundColor = ConsoleColor.Black; // Hair
        Console.Write("            ");
        Console.ResetColor();

        
        Console.SetCursorPosition(startX + 1 * 12, startY + 3);
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Write("            ");
        Console.BackgroundColor = ConsoleColor.DarkYellow; // Face
        Console.Write("            ");
        Console.Write("            ");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Write("            ");
        Console.ResetColor();

        
        Console.SetCursorPosition(startX + 1 * 12, startY + 4);
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        Console.Write("            ");
        Console.Write("            ");
        Console.Write("            ");
        Console.ResetColor();

        
        Console.SetCursorPosition(startX + 0 * 12, startY + 5);
        Console.BackgroundColor = ConsoleColor.DarkYellow; // Arm
        Console.Write("            ");
        Console.BackgroundColor = ConsoleColor.Blue; // Shirt
        Console.Write("            ");
        Console.Write("            ");
        Console.BackgroundColor = ConsoleColor.DarkYellow; // Arm
        Console.Write("            ");
        Console.ResetColor();

        
        Console.SetCursorPosition(startX + 1 * 12, startY + 6);
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Write("            ");
        Console.Write("            ");
        Console.Write("            ");
        Console.ResetColor();

        
        Console.SetCursorPosition(startX + 1 * 12, startY + 7);
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("            ");
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Write("            ");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("            ");
        Console.ResetColor();

        
        Console.SetCursorPosition(startX + 1 * 12, startY + 8);
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Write("            ");
        Console.Write("            ");
        Console.Write("            ");
        Console.ResetColor();

        
        Console.SetCursorPosition(startX + 1 * 12, startY + 9);
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.Write("            ");
        Console.Write("            ");
        Console.Write("            ");
        Console.ResetColor();

        // Move cursor below drawing
        Console.SetCursorPosition(0, startY + 11);
        Console.ResetColor();
    

