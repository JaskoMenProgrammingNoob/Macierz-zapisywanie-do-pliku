using System.IO;
class Macierz
{
    int[,] tablica = new int[10, 10];
    int[,] tablica1 = new int[10, 10];
    FileStream Fin, Fout;
    string czytaj_tablice;
    public void czytaj_dane(int[,] tablica)
    {
        for(int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if(i == j)
                {
                    tablica[i, j] = 1;
                }
                else
                {
                    tablica[i, j] = 0;
                }
                //tablica[i, j] = 0;
                //tablica[i,i] = 1;
                
            }
            
        }
        
    }
    public void zapisz_dane_do_pliku(int[,] tablica)
    {
        Fout = new FileStream("Macierz.txt", FileMode.Create);
        StreamWriter zapisz = new StreamWriter(Fout);
        for(int i = 0; i < 10; i++)
       {
           for (int j = 0; j < 10; j++)
           {
               zapisz.Write(tablica[i,j]);
                Console.Write(tablica[i,j] + " ");
            }
            zapisz.WriteLine();
           Console.WriteLine();
       } 
        zapisz.Close();
        Fout.Close();

    }
    public void czytaj_dane_z_pliku(int [,] tablica1)
    {
        Console.WriteLine("Zapisuje macierz 10x10");
        Fin = new FileStream("Macierz.txt", FileMode.Open);
        StreamReader odczyt = new StreamReader(Fin);
        for(int i = 0; i <10; i++)
        {
            string[] linia = odczyt.ReadLine().Split(' ');
            for (int j = 0; j < 10; j++)
            {
                tablica1[i,j] = int.Parse(linia[j]);
                Console.Write(tablica1[i, j] + " ");
            }
            Console.WriteLine();
        }
        odczyt.Close();
        Fin.Close();
    } 


    static void Main(string[] args)
    {

        int[,] tablica = new int[10, 10];
        int[,] tablica1 = new int[10, 10];
        
        Macierz macierz = new Macierz();
        macierz.czytaj_dane(tablica);
        macierz.zapisz_dane_do_pliku(tablica);
        macierz.czytaj_dane_z_pliku(tablica1);
        Console.Read();
    }
}