// See https://aka.ms/new-console-template for more information


using System;
 
class Program {
 
    static void Main(string[] args)
    {
        int[] arr = {100, 0, 5, 792};
 
        try {
 
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i] / arr[i + 1]);
            }
        }

        catch (IndexOutOfRangeException e) {
 
            Console.WriteLine("An Exception has occurred : {0}", e.Message);
        }

        catch (DivideByZeroException e) {
 
            Console.WriteLine("An Exception has occurred : {0}", e.Message);
        }

        catch (ArgumentOutOfRangeException e) {
 
            Console.WriteLine("An Exception has occurred : {0}", e.Message);
        }
        finally {
            for (int i = 0; i < arr.Length; i++) {
                Console.Write(" {0}", arr[i]);
            }
        }
    }
}