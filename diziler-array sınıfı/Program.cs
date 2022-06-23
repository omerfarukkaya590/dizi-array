// See https://aka.ms/new-console-template for more information

class Program
    {
        static void Main(string[] args)
        {
           //Sort
           int[] sayıDizisi={15,13,90,32,26,38,1,4};

           Console.WriteLine("*****sırasız dizi*****");

           foreach (var sayi in sayıDizisi)
                    Console.WriteLine(sayi);

           Console.WriteLine("*****sıralı dizi*****");
           Array.Sort(sayıDizisi);
           foreach (var sayi in sayıDizisi)
                    Console.WriteLine(sayi);
            //Clear   
            Console.WriteLine("*****array clear*****");
            Array.Clear(sayıDizisi,3,2);
            foreach (var sayi in sayıDizisi)
                    Console.WriteLine(sayi);
             //Reverse       
            Console.WriteLine("*****array reverse*****");
            Array.Reverse(sayıDizisi);
            foreach (var sayi in sayıDizisi)
                    Console.WriteLine(sayi);
            //Indexof
            Console.WriteLine("*****array IndexOf*****");
            
            Console.WriteLine(Array.IndexOf(sayıDizisi,13));

            //Resize
            Console.WriteLine("*****array Resize*****");
            Array.Resize<int>(ref sayıDizisi,9);
            sayıDizisi[8]=11;
            foreach (var sayi in sayıDizisi)
                     Console.WriteLine(sayi);
        }
    }