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

            Console.WriteLine("Status Posisi");
            PosisiKarakterGame posisi = new PosisiKarakterGame();
            posisi.key();
            
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

    class PosisiKarakterGame
    {
        enum state { Tengkurap, Jongkok, Berdiri, Terbang};

        public void key()
        {
            state state= state.Terbang;

            string[] status_posisi = { "Tengkurap", "Jongkok", "Berdiri", "Terbang" };
            do
            {
                Console.WriteLine("Posisi" + " " + status_posisi[(int)state]);
                Console.WriteLine("Command : ");
                String command = Console.ReadLine();
                switch (state)
                {
                    case state.Tengkurap:
                        if(command == "w")
                        {
                            state = state.Jongkok;
                        }
                        break;
                case state.Jongkok:
                        if(command == "w")
                        {
                            state = state.Berdiri;
                        }else if(command == "S")
                        {
                            state = state.Tengkurap;
                        }
                        break;
                case state.Berdiri:
                        if(command == "w")
                        {
                            state = state.Terbang;
                            Console.WriteLine("Posisi take off");
                        }else if(command == "S")
                        {
                            state = state.Jongkok;
                        }
                        break;
                case state.Terbang:
                        if(command == "x")
                        {
                            state= state.Jongkok;
                            Console.WriteLine("Posisi Landing");
                        }else if(command == "S")
                        {
                            state = state.Berdiri;
                        }
                        break;
                }
            }while(true);
        }
    }
}