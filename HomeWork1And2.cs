using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string surname = "";
            string patronymic = "";

            short age = 0;
            short height = 0;
            float weight = 0;
            long phoneNumber = 0;

            string flat = "";
            string house = "";
            string street = "";

            string temp = "";
            bool counter = true;
            bool counter2 = true;


            while (counter)
            {

                Console.WriteLine("Напишите ваше имя " + name);
                name = Console.ReadLine();
                name = name.Trim();
                Console.Clear();


                Console.WriteLine("Напишите ваше фамилию " + surname);
                surname = Console.ReadLine();
                surname = surname.Trim();
                Console.Clear();

                Console.WriteLine("Напишите ваше отчество " + patronymic);
                patronymic = Console.ReadLine();
                patronymic = patronymic.Trim();
                Console.Clear();



                while (counter2)
                {

                    Console.WriteLine("Напишите ваш возраст " + age);
                    temp = Console.ReadLine();

                    for (int i = 0; i < temp.Length; i++)
                    {

                        if (temp[i] != '0' && temp[i] != '1' && temp[i] != '2' && temp[i] != '3' && temp[i] != '4' &&
                                temp[i] != '5' && temp[i] != '6' && temp[i] != '7' && temp[i] != '8' && temp[i] != '9')
                        {
                            Console.Clear();

                            Console.WriteLine("Вы ввели неправильно возраст, попробуйте еще раз.");
                            Console.ReadKey();
                            Console.Clear();
                            counter2 = true;
                            break;

                        }
                        else { counter2 = false; }

                    }
                }
                age = Convert.ToInt16(temp);
                Console.Clear();

                counter2 = true;
                while (counter2)
                {
                    Console.WriteLine("Напишите ваш рост в см " + height);
                    temp = Console.ReadLine();

                    for (int i = 0; i < temp.Length; i++)
                    {

                        if (temp[i] != '0' && temp[i] != '1' && temp[i] != '2' && temp[i] != '3' && temp[i] != '4' &&
                                temp[i] != '5' && temp[i] != '6' && temp[i] != '7' && temp[i] != '8' && temp[i] != '9')
                        {
                            Console.Clear();

                            Console.WriteLine("Вы ввели неправильно рост , попробуйте еще раз.");
                            Console.ReadKey();
                            Console.Clear();
                            counter2 = true;
                            break;

                        }
                        else { counter2 = false; }

                    }


                }
                height = Convert.ToInt16(temp);
                Console.Clear();

                counter2 = true;
                while (counter2)
                {
                    Console.WriteLine("Напишите ваш вес в кг " + weight);
                    temp = Console.ReadLine();
                    temp = temp.Replace(".", ",");

                    for (int i = 0; i < temp.Length; i++)
                    {

                        if (temp[i] != '0' && temp[i] != '1' && temp[i] != '2' && temp[i] != '3' && temp[i] != '4' &&
                                temp[i] != '5' && temp[i] != '6' && temp[i] != '7' && temp[i] != '8' && temp[i] != '9' && temp[i] != '.' && temp[i] != ',')
                        {
                            Console.Clear();

                            Console.WriteLine("Вы ввели неправильно вес , попробуйте еще раз.");
                            Console.ReadKey();
                            Console.Clear();
                            counter2 = true;
                            break;

                        }
                        else { counter2 = false; }

                    }
                }

                weight = Convert.ToSingle(temp);
                Console.Clear();

                counter2 = true;
                while (counter2)
                {
                    Console.WriteLine("Напишите ваш телефона " + phoneNumber);
                    temp = Console.ReadLine();
                    for (int i = 0; i < temp.Length; i++)
                    {

                        if (temp[i] != '0' && temp[i] != '1' && temp[i] != '2' && temp[i] != '3' && temp[i] != '4' &&
                                temp[i] != '5' && temp[i] != '6' && temp[i] != '7' && temp[i] != '8' && temp[i] != '9')
                        {
                            Console.Clear();

                            Console.WriteLine("Вы ввели неправильно номер телефона , попробуйте еще раз.");
                            Console.ReadKey();
                            Console.Clear();
                            counter2 = true;
                            break;

                        }

                        else { counter2 = false; }
                    }

                    phoneNumber = long.Parse(temp);
                    Console.Clear();


                    Console.WriteLine("Напишите улицу вашего проживания " + street);
                    street = Console.ReadLine();
                    street = street.Trim();
                    Console.Clear();

                    Console.WriteLine("Напишите дом вашего проживания " + house);
                    house = Console.ReadLine();
                    house = house.Trim();
                    Console.Clear();

                    Console.WriteLine("Напишите номер квартиры вашего проживания " + flat);
                    flat = Console.ReadLine();
                    flat = flat.Trim();
                    Console.Clear();


                    Console.WriteLine("ФИО: " + name + " " + surname + " " + patronymic);
                    Console.WriteLine("Рост:" + height + " Вес: " + weight + " Возраст: " + age + " Номер телефона: " + phoneNumber);
                    Console.WriteLine("Ваш адрес:" + street + "," + house + "," + flat);

                    while (true)
                    {
                        Console.WriteLine("Введенные данные правильные? да(Y) нет (любая клавиша)");

                        if (Console.ReadKey().Key == ConsoleKey.Y)
                        {
                            counter = false;
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            break;
                        }
                    }
                }
            }
            /*
             string name = "";
            float quantity = 0;
            string unit = "";
            decimal price = 0;
            string temp = "";
            bool counter = true;


            
            Console.WriteLine("Название продукта");
            name = Console.ReadLine();
            name = name.ToUpper();
            name = name.Trim();
            Console.Clear();
            


           while (counter)
           {
                Console.WriteLine("Количество товара");
                temp = Console.ReadLine();
                temp = temp.Replace(".", ",");

                for (int i = 0; i < temp.Length; i++)
               {
                    if (temp[i] != '0' && temp[i] != '1' && temp[i] != '2' && temp[i] != '3' && temp[i] != '4' &&
                                temp[i] != '5' && temp[i] != '6' && temp[i] != '7' && temp[i] != '8' && temp[i] != '9' && temp[i] != '.' && temp[i] != ',')
                    {
                        counter = true;
                        Console.WriteLine("Количество введено неправильно, попробуйте еще раз.");
                        break;
                    }
                    else
                    {
                        counter = false;
                    }
                   
               }
                Console.Clear();
            }

            Console.Clear();
            Console.WriteLine("Единицы измерения продукта");
            unit = Console.ReadLine();
            unit = unit.ToLower();
            Console.Clear();

            counter = true;
            while (counter)
            {
                Console.WriteLine("Цена товара");
                temp = Console.ReadLine();
                temp = temp.Replace(".", ",");

                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i] != '0' && temp[i] != '1' && temp[i] != '2' && temp[i] != '3' && temp[i] != '4' &&
                                temp[i] != '5' && temp[i] != '6' && temp[i] != '7' && temp[i] != '8' && temp[i] != '9' && temp[i] != '.' && temp[i] != ',')
                    {
                        counter = true;
                        Console.WriteLine("Цена введена неправильно, попробуйте еще раз.");
                        break;
                    }
                    else
                    {
                        counter = false;
                    }

                }
                Console.Clear();
            }

            Console.Clear();
            Console.WriteLine("Имя продукта "+name);
            Console.WriteLine("Количество продуктов " + quantity);
            Console.WriteLine("Единица измерения " + unit);
            Console.WriteLine("Цена " + price);
            */
        }
    }
}
