using System;
class Lab1A{
    public static void Main(String[] args){
        char[,] art = make_forward();
        char[,] flippedArt = make_mirror(make_forward());

        print2dArray(art);
        Console.WriteLine();
        print2dArray(flippedArt);

        for (int col = 0; col < art.GetLength(0); col++)
        {
            for (int row = 0; row < art.GetLength(1); row++)
            {
                Console.Write(art[col, row]);
            }
            for (int row = 0; row < art.GetLength(1); row++)
            {
                Console.Write(flippedArt[col, row]);
            }
            Console.WriteLine();
        }

    }

    public static void print2dArray(char[,] input){
        for (int col = 0; col < input.GetLength(0); col++)
        {
            for (int row = 0; row < input.GetLength(1); row++)
            {
                Console.Write(input[col, row]);
            }
            Console.WriteLine();
        }
    }
    public static char[,] make_mirror(char[,] input){
        char[,] flipped = new char[input.GetLength(0),input.GetLength(1)];

        for (int col = 0; col < input.GetLength(0); col++)
        {
            for (int row = 0; row < input.GetLength(1); row++)
            {
                flipped[col,row] = input[col,12-row];
            }
        }

        for (int col = 0; col < flipped.GetLength(0); col++)
        {
            for (int row = 0; row < flipped.GetLength(1); row++)
            {
                
                switch(flipped[col,row]){
                    case '(':
                        flipped[col,row] = ')';
                        break;
                    case ')':
                        flipped[col, row] = '(';
                        break;
                    case '/':
                        flipped[col, row] = '\\';
                        break;
                    case '\\':
                        flipped[col, row] = '/';
                        break;
                }

            }
        }
        return flipped;
    }

    public static char[,] make_forward()
    {
        char[,] pixel = new char[4,13];
        pixel[0, 0] = ' '; 
        pixel[0, 1] = ' '; 
        pixel[0, 2] = '_'; 
        pixel[0, 3] = '_';
        pixel[0, 4] = '_';
        pixel[0, 5] = '_'; 
        pixel[0, 6] = '_'; 
        pixel[0, 7] = '_'; 
        pixel[0, 8] = ' '; 
        pixel[0, 9] = ' '; 
        pixel[0, 10] = ' '; 
        pixel[0, 11] = ' '; 
        pixel[0, 12] = ' '; 
        pixel[1, 0] = ' '; 
        pixel[1, 1] = '/'; 
        pixel[1, 2] = '|'; 
        pixel[1, 3] = '_'; 
        pixel[1, 4] = '|'; 
        pixel[1, 5] = '|'; 
        pixel[1, 6] = '_'; 
        pixel[1, 7] = '\\'; 
        pixel[1, 8] = '\''; 
        pixel[1, 9] = '.'; 
        pixel[1, 10] = '_'; 
        pixel[1, 11] = '_'; 
        pixel[1, 12] = ' '; 
        pixel[2, 0] = '('; 
        pixel[2, 1] = ' '; 
        pixel[2, 2] = ' '; pixel[2, 3] = ' '; pixel[2, 4] = '_'; pixel[2, 5] = ' '; pixel[2, 6] = ' '; pixel[2, 7] = ' '; pixel[2, 8] = ' '; pixel[2, 9] = '_'; pixel[2, 10] = ' '; pixel[2, 11] = '_'; pixel[2, 12] = '\\'; pixel[3, 0] = '='; pixel[3, 1] = '\''; pixel[3, 2] = '-'; pixel[3, 3] = '('; pixel[3, 4] = '_'; pixel[3, 5] = ')'; pixel[3, 6] = '-'; pixel[3, 7] = '-'; pixel[3, 8] = '('; pixel[3, 9] = '_'; pixel[3, 10] = ')'; pixel[3, 11] = '-'; pixel[3, 12] = '\'';
        return pixel;
    }
}

