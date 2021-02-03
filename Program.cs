using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _8_Лаба
{
    class Program
    {
        /*
          Задание 6
  Составить программу, которая содержит динамическую информацию о наличии
  автобусов в автобусном парке.
  Сведения о каждом автобусе включают:
   номер автобуса;
   фамилию и инициалы водителя;
   номер маршрута;
   признак того, где находится автобус — на маршруте или в парке.
  Программа должна обеспечивать:
   начальное формирование данных обо всех автобусах из файла;
   сохранение данных в файл;
   при выезде каждого автобуса из парка вводится номер автобуса, и программа
  устанавливает значение признака «автобус на маршруте»;
   при въезде каждого автобуса в парк вводится номер автобуса, и программа
  устанавливает значение признака «автобус в парке»;
   по запросу выдаются сведения об автобусах, находящихся в парке, или об
  автобусах, находящихся на маршруте.
  Оценка снижается на 3 балла, если в работе используется не двунаправленный
  список, а массив. Программа должна обеспечивать диалог с помощью меню и контроль
  ошибок при вводе.
           */
        static void Main(string[] args)
        {
            LinkedList<Bus> BUSS = new LinkedList<Bus>();
            BUSS.AddFirst(new Bus { Nomer_Avtobusa = 1, FIO_Vodytel = "Иванов В.И", Nomer_Marshruta = 3, Raspolozhenie = "В парке" });
            BUSS.AddAfter(BUSS.Last, new Bus { Nomer_Avtobusa = 2, FIO_Vodytel = "Сидоров Н.П.", Nomer_Marshruta = 5, Raspolozhenie = "На маршруте" });
            BUSS.AddAfter(BUSS.Last, new Bus { Nomer_Avtobusa = 3, FIO_Vodytel = "Сергеев А.Н", Nomer_Marshruta = 9, Raspolozhenie = "В парке" });
            BUSS.AddAfter(BUSS.Last, new Bus { Nomer_Avtobusa = 4, FIO_Vodytel = "Рожков В.А.", Nomer_Marshruta = 1, Raspolozhenie = "На маршруте" });
            BUSS.AddAfter(BUSS.Last, new Bus { Nomer_Avtobusa = 5, FIO_Vodytel = "Кашин К.П.", Nomer_Marshruta = 2, Raspolozhenie = "В парке" });
            BUSS.AddAfter(BUSS.Last, new Bus { Nomer_Avtobusa = 6, FIO_Vodytel = "Печкин В.В.", Nomer_Marshruta = 13, Raspolozhenie = "На маршруте" });
            BUSS.AddAfter(BUSS.Last, new Bus { Nomer_Avtobusa = 7, FIO_Vodytel = "Конев З.П.", Nomer_Marshruta = 76, Raspolozhenie = "В парке" });
            BUSS.AddAfter(BUSS.Last, new Bus { Nomer_Avtobusa = 8, FIO_Vodytel = "Кержаков М.А", Nomer_Marshruta = 10, Raspolozhenie = "На маршруте" });
            BUSS.AddAfter(BUSS.Last, new Bus { Nomer_Avtobusa = 9, FIO_Vodytel = "Стопин К.А.", Nomer_Marshruta = 15, Raspolozhenie = "В парке" });
            BUSS.AddAfter(BUSS.Last, new Bus { Nomer_Avtobusa = 10, FIO_Vodytel = "Пономарёв А.Ю.", Nomer_Marshruta = 80, Raspolozhenie = "На маршруте" });

            Write(BUSS);
            read(BUSS);
            string z;
            string x;
     
            do {
                do
                {
                    Console.WriteLine("Если хотите узнать про автобусы в парке напишите 'В парке',если хотите узнат про автобусы на маршруте напишите 'На маршруте'");
                     x = Console.ReadLine();
                      if (x == "В парке"||x == "На маршруте")

                        {
                           
                         
                        }
                    else
                    {
                        Console.WriteLine("Не верно");
                    }
                     
                   

                } while (x != "В парке" && x != "На маршруте");

                foreach (object a in BUSS)
                {
                    if (((Bus)a).Raspolozhenie == x)
                    {
                        Console.WriteLine(((Bus)a).Nomer_Avtobusa + "     " + ((Bus)a).FIO_Vodytel + '\t' + '\t' + ((Bus)a).Nomer_Marshruta + '\t' + ((Bus)a).Raspolozhenie);                  

                    }
                }
                do
                {
                    Console.WriteLine("Повторить?Введите 'да' или 'нет'");
                    z = Console.ReadLine();
                    if (z == "да" || z == "нет")
                    {
                       
                    }
                    else
                    {
                        Console.WriteLine("Не верно");
                    }
                   
                } while (z != "да" && z != "нет");
                
            } while (z!="нет" );
          
        }      
    const string file1 = "2.txt";
        static void read(LinkedList<Bus> BUSS)
        {
            Bus bis = new Bus();
            string[] readText = File.ReadAllLines(file1);
            try
            {
               
                Console.ReadLine();
                for (int i = 0; i < readText.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Console.WriteLine(readText[i]);
                            break;
                        default:
                            Console.WriteLine(readText[i]);
                           


                            break;
                    }
                }
               

                for(int i=0;i<readText.Length;i++)
                {
                    if (bis.Raspolozhenie == "В парке")
                    {
                        Console.WriteLine(readText[i]);
                    }
                }
                Console.ReadLine();


            }
            catch (IOException e)
            {
                Console.WriteLine("An IO exception has been thrown!");
                Console.WriteLine(e.ToString());
                Console.ReadLine();


            }
        }
           
        static LinkedList<Bus>  Write(LinkedList<Bus> BUSS)
        {         
            try
            {

                StreamWriter sw = new StreamWriter(file1);
                sw.WriteLine("№" + '\t'  + "Водитель" + '\t'  + "№ маршрута"+ '\t' + "Расположение");
                 foreach (object a in BUSS)
                       {
                    sw.WriteLine(((Bus)a).Nomer_Avtobusa+"     " + ((Bus)a).FIO_Vodytel+ '\t'+'\t'  + ((Bus)a).Nomer_Marshruta+ '\t' +((Bus)a).Raspolozhenie);                  
                       }
                Bus Bis = new Bus();
                    sw.Close();                      
            }
            catch (IOException e)
            {
                Console.WriteLine("An IO exception has been thrown!");
                Console.WriteLine(e.ToString());
                Console.ReadLine();
                
            }
            return BUSS;
        }        
    }
}