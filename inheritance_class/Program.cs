using System;

namespace inheritance_class
{
    class Program
    {
        static void Main(string[] args)
        {
            bikecycle benelli = new bikecycle("Benelli","Abu-Abu");
            car kijang = new car("Kijang","Merah");
            Console.WriteLine(kijang.model);
            kijang.spesifikasi();
            kijang.honk();
            Console.WriteLine(benelli.model);
            benelli.spesifikasi();
            benelli.honk();

        }
    }
    class transportasi
    {
        public int roda;
        public string color;
        public transportasi(){
           
        }
        public void honk(){
            Console.WriteLine("Tutttt tutttttttt");
        }

    }   
    class car:transportasi{
        public string model;
        public car(string nama_model_mobil, string ColorMobil){
            model = nama_model_mobil;
            roda = 4;
            color = ColorMobil;
        }
        public void spesifikasi(){
            Console.WriteLine("Jumlah roda: " + roda +", Model: " + model + ", Color: " + color);
        }
    }
    class bikecycle:transportasi{
        public string model;
        public bikecycle(string nama_model_motor, string ColorMotor){
            model = nama_model_motor;
            roda = 2;
            color = ColorMotor;
        }
        public void spesifikasi(){
            Console.WriteLine("Jumlah roda: " + roda +", Model: " + model + ", Color: " + color);
        }
    }
}
