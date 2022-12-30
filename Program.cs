namespace MultiDimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[,] regions = new string[7, 3]//soldaki değer satır, soldaki değer sütuna karşılık geliyor.
            {
                { "İstanbul","İzmit","Tekirdağ"},
                { "Ankara","Konya","Kırıkkale"},
                { "Antalya","Adana","Mersin"},
                { "Rize","Trabzon","Samsun"},
                { "Siirt","Diyarbakır","Batman"},
                { "İzmir","Uşak","Denizli"},
                { "Erzurum","Erzincan","Kars"}
            };

            for (int i = 0; i < regions.GetUpperBound(0); i++) //iç içe for döngüsü kullanıldı.
            {
                for (int j = 0; j < regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]); 
                }
            }

            Console.WriteLine();
            Console.ReadLine();

        }
    }
}