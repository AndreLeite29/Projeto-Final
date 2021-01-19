using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Stand_v2
{
    class Program
    {
        class Carros 
        {
            public Carros(string name, int miles_per_Gallon, int cylinders, int kilometers, int horsepower, int weight_in_lbs, float acceleration, string year, string origin, int price)
            {
                Name = name;
                Miles_per_Gallon = miles_per_Gallon;
                Cylinders = cylinders;
                Kilometers = kilometers;
                Horsepower = horsepower;
                Weight_in_lbs = weight_in_lbs;
                Acceleration = acceleration;
                Year = year;
                Origin = origin;
                Price = price;
            }

            public string Name { get; set; }

            public int Miles_per_Gallon { get; set; }

            public int Cylinders { get; set; }

            public int Kilometers { get; set; }

            public int Horsepower { get; set; }

            public int Weight_in_lbs { get; set; }

            public float Acceleration { get; set; }

            public string Year { get; set; }

            public string Origin { get; set; }

            public int Price { get; set; }
        }                                        //Propriedades

        class Stand
        {
            public static void LerFicheiro(string FicheiroCaminho)
            {
                if (File.Exists(FicheiroCaminho))
                {
                    StreamReader FicheiroNome = File.OpenText(FicheiroCaminho);             //Abrir ficheiro
                    string LerTudo = FicheiroNome.ReadToEnd();                              //Ler ficheiro
                    ListaCarros = JsonConvert.DeserializeObject<List<Carros>>(LerTudo);     //Passar informação do ficheiro para a lista            
                    FicheiroNome.Close();                                                   //Fechar ficheiro
                }
                else
                {
                    Console.WriteLine("Ficheiro não encontrado");
                }
            }       //Metodo para Ler ficheiro
            public static void ImprimirTodosCarros()
            {

                for (int i = 0; i < ListaCarros.Count; i++)
                {

                    Console.WriteLine(ListaCarros[i].Name);

                }
            }   //Metodo para imprimir o nome de todos os carros
            public static void ImprimirTodasInformacoesCarros()
            {
                for (int i = 0; i < ListaCarros.Count; i++)
                {
                    Console.WriteLine("Nome: " + ListaCarros[i].Name);
                    Console.WriteLine("Miles_per_Gallon: " + ListaCarros[i].Miles_per_Gallon);
                    Console.WriteLine("Kilometers: " + ListaCarros[i].Kilometers);
                    Console.WriteLine("Horsepower: " + ListaCarros[i].Horsepower);
                    Console.WriteLine("Weight_in_lbs: " + ListaCarros[i].Weight_in_lbs);
                    Console.WriteLine("Acceleration: " + ListaCarros[i].Acceleration);
                    Console.WriteLine("Year: " + ListaCarros[i].Year);
                    Console.WriteLine("Origin: " + ListaCarros[i].Origin);
                    Console.WriteLine("Price: " + ListaCarros[i].Price);
                    Console.WriteLine("\n----------------------\n");
                }
            }   //Metodo para imprimir a informação total de todos os carros
            public static int Maiscavalos() 
            {
                int Maiornumcavalos = 0;

                for (int i=0; i < ListaCarros.Count; i++)
                {
                    if(ListaCarros[i].Horsepower > Maiornumcavalos)
                    {

                        Maiornumcavalos = ListaCarros[i].Horsepower;

                    }
                }
                return Maiornumcavalos;
                
            }            //Metodo para retornar o carro com maior numero de cavalos no stand
            public static int Menoscavalos()
            {
                int menorcavalos = 300;

                for (int i = 0; i < ListaCarros.Count; i++)
                {
                    if (ListaCarros[i].Horsepower < menorcavalos)
                    {

                        menorcavalos = ListaCarros[i].Horsepower;

                    }
                }
                return menorcavalos;

            }            //Metodo para retornar o carro com menor numero de cavalos no stand
            public static void MenosKilometros()
            {
                int MenorKilometros = 10000000;
                for (int i = 0; i < ListaCarros.Count; i++)
                {
                    if (ListaCarros[i].Kilometers < MenorKilometros)
                    {

                        MenorKilometros = ListaCarros[i].Kilometers;

                    }
                }
                Console.WriteLine(MenorKilometros);
            }       //Metodo para imprimir o carro com menor numero de kilometros
            public static void MaisKilometros()
            {
                int MaiorKilometros = 0;
                for (int i = 0; i < ListaCarros.Count; i++)
                {
                    if (ListaCarros[i].Kilometers < MaiorKilometros)

                    {

                        MaiorKilometros = ListaCarros[i].Kilometers;

                    }
                }
                Console.WriteLine(MaiorKilometros);
            }       //Metodo para imprimir o carro com maior numero de kilometros
            public static void FiltrarKilometros(int kilometros1, int kilometros2)
            {
                List<Carros> CarrosPossiveis= new List<Carros>();        //Lista filtrar kilometros               
                for (int i = 0; i < ListaCarros.Count; i++)
                {
                    if (ListaCarros[i].Kilometers >= kilometros1 && ListaCarros[i].Kilometers <= kilometros2 || ListaCarros[i].Kilometers <= kilometros1 && ListaCarros[i].Kilometers >= kilometros2)
                    {

                        CarrosPossiveis.Add(ListaCarros[i]);

                    }
                }
                for (int j = 0; j < CarrosPossiveis.Count; j++)
                {

                    Console.WriteLine(CarrosPossiveis[j].Name);

                }
                 if (CarrosPossiveis.Count == 0)
                {

                    Console.WriteLine("Não existem carros nesses parametros");

                }
            }   //Metodo para filtrar kilometros entre dois parametros
            public static int MelhorMediaConsumo()
            {
                int gasoleo = 0;
                for (int i = 0; i < ListaCarros.Count; i++)
                {
                    if (ListaCarros[i].Miles_per_Gallon > gasoleo )
                    {

                        gasoleo = ListaCarros[i].Miles_per_Gallon;

                    }
                }
                return gasoleo;
            }         //Metodo para retornar a melhor média de consumo
            public static float MaiorAceleracao()
            {
                float aceleracao = 0;
                for (int i = 0; i < ListaCarros.Count; i++)
                {
                    if (ListaCarros[i].Acceleration > aceleracao)
                    {

                        aceleracao = ListaCarros[i].Acceleration;

                    }
                }
                return aceleracao;
            }           //Metodo para retornar o carro com a maior aceleracao
            public static int MaisCaro()
            {
                int maiorpreço = 0;
                for (int i = 0; i < ListaCarros.Count; i++)
                {
                    if (ListaCarros[i].Price > maiorpreço)
                    {

                        maiorpreço = ListaCarros[i].Price;

                    }
                }
                return maiorpreço;
            }                   //Metodo para retornar o carro mais caro
            public static int MaisBarato()
            {
                int menorpreco = 100000000;
                for (int i = 0; i < ListaCarros.Count; i++)
                {
                    if (ListaCarros[i].Price < menorpreco)
                    {

                        menorpreco = ListaCarros[i].Price;

                    }
                }
                return menorpreco;
            }                   //Metodo para retornar o carro mais barato
            public static int TotalSaldo()
            {
                int precototal = 0;
                for (int i = 0; i < ListaCarros.Count; i++)
                {
                    precototal += ListaCarros[i].Price;
                }
                return precototal;
            }                   //Metodo para retornar o saldo em carros do stand
            public static int MediaCarros()
            {
                int mediapreco = 0;
                for (int i = 0; i < ListaCarros.Count; i++)
                {
                    mediapreco += ListaCarros[i].Price;
                }
                mediapreco = mediapreco / ListaCarros.Count;
                return mediapreco;
            }                   //Metodo para retornar a media total do saldo de todos os carros

            //public static DateTime MaisAntigo()                     //Metodo para retornar o carro mais antigo
            //{
            //    for (int i = 0; i < ListaCarros.Count; i++)
            //    {
            //            ListaCarros[i].Year;
            //    }
            //}                                        
            //public static DateTime MaisRecente()                    //Metodo para retornar o carro mais recente
            //{
            //    for (int i = 0; i < ListaCarros.Count; i++)
            //    {
            //        ListaCarros[i].Year;
            //    }
            //}                              
            
            public static void Origem(string origem1)
            {
                int quantidade = 0;
                for (int i = 0; i < ListaCarros.Count; i++)
                {
                    if (ListaCarros[i].Origin == origem1)
                    {
                        quantidade += 1;
                    }
                }
                Console.WriteLine(quantidade);
            }             //Metodo para retornar o numero de carros originarios de "origem1"
            public static int MaisPesado()
            {
                int maiorpeso = 0;
                for (int i = 0; i < ListaCarros.Count; i++)
                {
                    if (ListaCarros[i].Weight_in_lbs > maiorpeso)
                    {

                        maiorpeso = ListaCarros[i].Weight_in_lbs;

                    }                    
                }
                return maiorpeso;
            }                         //Metodo para retornar o valor do carro mais pesado
            public static int MenosPesado()
            {
                int menorpeso = 0;
                for (int i = 0; i < ListaCarros.Count; i++)
                {
                    if (ListaCarros[i].Weight_in_lbs < menorpeso)
                    {

                        menorpeso = ListaCarros[i].Weight_in_lbs;

                    }
                }
                return menorpeso;
            }                         //Metodo para retornar o valor do carro mais pesado
            public static int MediadoPeso()
            {
                int mediapeso = 0;
                for (int i = 0; i < ListaCarros.Count; i++)
                {
                    mediapeso += ListaCarros[i].Weight_in_lbs;
                }
                mediapeso = mediapeso / ListaCarros.Count;
                return mediapeso;
            }                       //Metodo para retornar a media de todos os carros do stand
            public static void AdicionarCarros(string Name, int Miles_per_Gallon, int Cylinders, int Kilometers, int Horsepower, int Weight_in_lbs, float Acceleration, string Year, string Origin, int Price)
            {
                string FicheiroCaminho = (@"D:\Users\André\Desktop\carros.json");
                StreamReader FicheiroNome = File.OpenText(FicheiroCaminho);             //Abrir ficheiro
                string LerTudo = FicheiroNome.ReadToEnd();                              //Ler ficheiro até ao fim
                FicheiroNome.Close();                                                   //Fechar ficheiro
                ListaCarros.Add(new Carros(Name, Miles_per_Gallon, Cylinders, Kilometers, Horsepower, Weight_in_lbs, Acceleration, Year, Origin, Price));       //Adicionar à lista o carro do utilizador
                string Copiar = JsonConvert.SerializeObject(ListaCarros.ToArray());     //Coverter os objetos da lista num array
                StreamWriter sw = new StreamWriter(FicheiroCaminho);                    //Caminho
                sw.Write(Copiar);                                                       //Reescrever o ficheiro json
                sw.Close();                                                             //Fechar ficheiro

            } //Metodo para adicionar carros ao json
        }

        private static List<Carros> ListaCarros;            //Lista dos Carros
        static void Main(string[] args)
        {
            Stand.LerFicheiro(@"D:\Users\André\Desktop\carros.json");
            //Stand.ImprimirTodosCarros();
            //Stand.ImprimirTodasInformacoesCarros();
            //Stand.Maiscavalos();
            //Stand.Menoscavalos();
            //Stand.MenosKilometros();
            //Stand.MaisKilometros();
            //Stand.FiltrarKilometros(100000, 300000);
            //Stand.MelhorMediaConsumo();
            //Stand.MaiorAceleracao();
            //Stand.MaisCaro();
            //Stand.TotalSaldo();
            //Stand.Origem("Portugal");
            //Stand.MediaCarros();
            //Stand.MaisPesado();
            //Stand.MenosPesado();
            //Stand.EscreverFicheiro()
            //Stand.AdicionarCarros("peugeot", 2, 3, 200, 100, 3000, 10,"2020-10-20", "Italy", 205000);
        }
    }
}
