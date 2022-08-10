using Donguler;

    namespace Donguler
{
    class Donguler
    {
        static void Main(string[] args)
        {

            //array - dizi
            string[] kurslar = new string[] { "Yazılım Geliştici Yetiştirme Kampı", 
                "Programlamaya başlangıç için temel kurs" , 
                "Java" ,"Python" ,"C#"};
            
            for (int i = 0; i < kurslar.Length; i++) // ++ bir bir arttır demek. Genel amaçlar için
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");


            foreach (string kurs in kurslar) //dizi temelli yapıları tek tek dönmeye yarar
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}