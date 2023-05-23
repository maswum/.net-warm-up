using System;

public class patetrnOne{
    public void pattern(){
        int rowInt = 4;

        for(int i = 0; i < rowInt - 1; i++){
            for(int rowCol = 0; rowCol <= 2 * rowInt; rowCol++){
                if(rowCol == rowInt - i || rowCol == rowInt + i){
                    Console.Write("*");
                }
                else{
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        for(int i = 1; i <= rowInt; i++){
            for(int rowCol = 0; rowCol <= 2 * rowInt; rowCol++){
                if(rowCol == i || rowCol == 2 * rowInt - i){
                    Console.Write("*");
                }
                else{
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        
        for(int i = 1; i < rowInt - 1; i++){
            for(int rowCol = 0; rowCol <= 2 * rowInt; rowCol++){
                if(rowCol == (rowInt - i) || rowCol == (rowInt + i)){
                    Console.Write("*");
                }
                else{
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        for(int i = 1; i <= rowInt; i++){
            for(int rowCol = 0; rowCol <= 2 * rowInt; rowCol++){
                if(rowCol == i || rowCol == 2 * rowInt - i){
                    Console.Write("*");
                }
                else{
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}

public class patternTwo{
    public void pattern(){
        int size = 6;
        int tempS = 6;

        for(int i = 1; i <= size; i++){

            int number = tempS;

            for(int rowCol = 0; rowCol <= 2 * size; rowCol++){
                if(rowCol == i || rowCol == 2 * size - i){
                    if(number % 2 == 0){
                        Console.Write("*");
                    }
                    else{
                        Console.Write(number);
                    }
                }
                else{
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            tempS--;
        }
        
        tempS=2;
        for(int i = size - 1; i >= 1; i--){

            int number = tempS;

            for(int rowCol = 0; rowCol <= 2 * size; rowCol++){
                if(rowCol == i || rowCol == 2 * size - i){
                    if(number % 2 == 0){
                        Console.Write("*");
                    }
                    else{
                        Console.Write(number);
                    }
                }
                else{
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            tempS++;
        }   
        
    }
}

public class patternThree{
    public void pattern(){

        int rowSize = 5;

        for(int row = 1; row <= rowSize; row++){
            for(int column = 1; column <= row; column++){
                Console.Write(row * column + " ");
            }
            Console.WriteLine();
        }

        for(int row = rowSize - 1; row >= 1; row--){
            for(int column = 1; column <= row; column++){
                Console.Write(row * column + " ");
            }
            Console.WriteLine();
        }
    }
}

public class patternFour{
    public void pattern(){

        int rowCount = 6;

        for(int row = 1; row <= rowCount; row++){
            int currentCount = row;

            for(int column = 1; column < rowCount; column++){

                Console.Write(currentCount + " ");
                currentCount *= (row + 1);
            }
            Console.WriteLine();
        }
    }
}
public class Program{
    public static void Main(){
        Console.WriteLine("Pattern 1:");
        patetrnOne pattern1 = new patetrnOne();
        pattern1.pattern();

        Console.WriteLine("\nPattern 2: ");
        patternTwo pattern2 = new patternTwo();
        pattern2.pattern();

        Console.WriteLine("\nPattern 3: ");
        patternThree pattern3 = new patternThree();
        pattern3.pattern();

        Console.WriteLine("\nPattern 4: ");
        patternFour pattern4 = new patternFour();
        pattern4.pattern();
    }
}