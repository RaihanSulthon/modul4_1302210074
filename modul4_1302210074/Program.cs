using System.Runtime.CompilerServices;

namespace modul4_1302210074
{
    class MainProgram
    {
        public static void Main(string[] args)
        {
            KodeBuah dict_kode_buah = new KodeBuah();
            Console.WriteLine("Kode Buah Semangka \n");
            dict_kode_buah.getkodebuah("Semangka");

            Console.WriteLine("Nama Semua Buah dan Namanya");
            dict_kode_buah.getallbuah();
            Console.WriteLine("\n");
            
        }
    }
    class KodeBuah
    {
        Dictionary<String, string> buah = new Dictionary<String, string>()
        {
            {"Apel","A00"},
            {"Aprikot","B00"},
            {"Alpukat","C00"},
            {"Pisang","D00"},
            {"Paprika","E00"},
            {"Blackberry","F00"},
            {"Ceri","H00"},
            {"Kelapa","I00"},
            {"Jagung","J00"},
            {"Kurma","K00"},
            {"Durian","L00"},
            {"Anggur","M00"},
            {"Melon","N00"},
            {"Semangka","O00"},
        };

        public void getkodebuah(String kode){
            if (buah.ContainsKey(kode))
            {
                Console.WriteLine(kode + " : " + buah[kode]);
            }
            else
            {
                Console.WriteLine(kode + "Buah dan kode tidak terdaftar");
            }
        }

        public void getallbuah()
        {
            foreach(KeyValuePair<string, string> i in buah)
            {
                Console.WriteLine(i.Key + " : " + i.Value);
            }
        }
    }
}