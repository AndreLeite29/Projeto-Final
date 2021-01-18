using System;
using System.Collections.Generic;

namespace ProjetoFinal
{
    class Program
    {
        public abstract class Veiculo // não pode ser instanciada
        {                                      
            public string marca, motor, cor, matricula;                  //Atributos
            public int kilometros, cavalos, preço;
            public bool novo;

            public Veiculo(string marca, int kilometros, string motor, int cavalos, string cor, int preço, bool novo, string matricula) //Parametros
            {
                this.marca = marca;
                this.kilometros = kilometros;
                this.motor = motor;
                this.cavalos = cavalos;
                this.cor = cor;
                this.preço = preço;
                this.novo = novo;
                this.matricula = matricula;
            }
        }
        class Mota : Veiculo                                //MOTA
        {
            public int rodas;                                    //Atributos

            public Mota(int rodas, string marca, int kilometros, string motor, int cavalos, string cor, int preço, bool novo, string matricula) :base(marca, kilometros, motor, cavalos, cor, preço, novo, matricula) //Parametros 
            {
                this.rodas = rodas;
            }

            public void CompararKilometrosMotas(object objeto) //Metodo comparar kilometros das motas
            {
                Mota mota = (Mota)(objeto);
                if (this.kilometros > mota.kilometros)
                    Console.WriteLine("A matricula " + this.matricula + " possui mais quilometros do que a matricula " + mota.matricula);
                else if (this.kilometros < mota.kilometros)
                    Console.WriteLine("A matricula " + this.matricula + " possui menos quilometros do que a matricula " + mota.matricula);
                else
                     Console.WriteLine("A matricula " + this.matricula + " possui os mesmos quilometros do que a matricula " + mota.matricula);
            }
        }

        class Carro : Veiculo                              //CARRO   
        {                          
            public int portas, rodas;   //Atributos

            public Carro(int portas, int rodas, string marca, int kilometros, string motor, int cavalos, string cor, int preço, bool novo, string matricula) : base(marca, kilometros, motor, cavalos, cor, preço, novo, matricula)//construtor por default
            {
                this.rodas = rodas;
                this.portas = portas;
            }
        }

        static void Main(string[] args)
        {
            Mota novamota1 = new Mota(2, "Volvo", 120000, "V1", 90, "Amarelo", 5600, false,"AAAAAA");           //Instanciar objeto
            Mota novamota2 = new Mota(4, "Fiat", 20, "V1", 90, "Amarelo", 10000, true,"BBBBB");                 //Instanciar objeto

            novamota1.CompararKilometrosMotas(novamota2);  //Chamar o metodo de comprar os kilometros da mota, (novamota1 é .this) e (novamota2 é objeto)


            List < Carro > listacarros = new List<Carro>();         //Criar lista Motas

            listacarros.Add(new Carro(5, 4, "bmw", 200000, "V8", 200, "Preto", 30000, false, "AAAAAA"));       //Adicionar Carro à lista
            listacarros.Add(new Carro(5, 4, "Fiat", 10, "V9", 320, "Azul", 50000,true,"BBBBBB"));               //Adicionar Carro à lista
            listacarros.Add(new Carro(3, 4, "Audi", 20, "V5", 70, "Cinzento", 2000, true, "BBEEEA"));

            float preco_total_carros = 0;
            float preco_total_motas = 0;
            float preco_total = 0;

            List<Mota> listamotas = new List<Mota>();               //Criar lista Motas

            listamotas.Add(new Mota(4, "Volvo", 20, "V3", 150, "Roxa", 20000, true, "CCCCCCC"));                //Adicionar Mota à lista
            listamotas.Add(new Mota(2, "Vespa", 100000, "V2", 100, "Preta", 5200, false, "DDDDDDDD"));          //Adicionar Mota à lista
            listamotas.Add(new Mota(2, "Vespa", 300000, "V1", 60, "Azul", 3000, false, "EDADVEL"));

            for (int i = 0; i<listacarros.Count; i++)                                                           //Ciclo para soma do preço dos carros
            {
                preco_total_carros += listacarros[i].preço;
            }
            Console.WriteLine("Preço da soma de todos os carros do stand " + preco_total_carros + " $");

            for (int i = 0; i < listamotas.Count; i++)                                                          //Ciclo para soma do preço das motas
            {
                preco_total_motas += listamotas[i].preço;
            }
            Console.WriteLine("Preço da soma de todas as motas do stand " + preco_total_motas + " $");

            preco_total = preco_total_motas + preco_total_carros;

            Console.WriteLine("Preço da soma de todos os veiculos do stand " + preco_total + " $");             //Imprimir preço total dos veiculos


            //--------------------------------------------------------------------------------------------//

            int listacarrosnovos = 0;
            int listamotasnovas = 0;
            int listaveiculosnovos = 0;

            for (int i = 0; i < listacarros.Count; i++)                                                           //Ciclo para contar os veiculos novos
            {
                if(listacarros[i].novo == true)
                {
                    listacarrosnovos += 1;

                }
            }

            for (int i = 0; i < listamotas.Count; i++)                                                           //Ciclo para contar os veiculos novos
            {
                if (listamotas[i].novo == true)
                {
                    listamotasnovas += 1;
                }
            }

            listaveiculosnovos = listacarrosnovos + listamotasnovas;


            Console.WriteLine("Existem " + listaveiculosnovos + " veiculos novos no stand!");                //Imprimir veiculos novos no stand


            //-----------------------------------------------------------------------------------------//
            //float valor1 = 10000;        //valor para substituir pelo valor minimo da relação preço/kilometro é "10000" para nunca atingir aquele valor
            //float valor2 = 10000;
            //string matricula1 = "";
            //string matricula2 = "";


            //for (int i = 0; i < listacarros.Count; i++)                                                           
            //{
            //    if (listacarros[i].kilometros/listacarros[i].preço < valor1)
            //    {
            //        valor1 = listacarros[i].kilometros / listacarros[i].preço;          //valor para substituir pelo valor minimo da relação preço/kilometro
            //        matricula1 = listacarros[i].matricula;                              //matricula do carro com melhor relação
            //    }
            //}
            //for (int i = 0; i < listamotas.Count; i++)                                                           
            //{
            //    if (listamotas[i].kilometros / listamotas[i].preço < valor2)
            //    {
            //        valor2 = listamotas[i].kilometros / listamotas[i].preço;        //valor para substituir pelo valor minimo da relação preço/kilometro
            //        matricula2 = listamotas[i].matricula;                           //matricula da mota com melhor relação
            //    }
            //}
            //if(valor1 > valor2)
            //{
            //    Console.WriteLine("A matricula do veiculo com melhor relação preço/quilometros é " + matricula2 );
            //}
            //else if (valor2 > valor1)
            //{
            //    Console.WriteLine("A matricula do veiculo com melhor relação preço/quilometros é " + matricula1);
            //}
            //else
            //{
            //    Console.WriteLine("As matriculas dos veiculos com melhor relação preço/quilometros são " + matricula1 + " e " + matricula2);
            //}

            int maiornumcavalos = 0;
            string matriculamaiorcavalos = "";
            int menornumcavalos = 300;
            string matriculamenorcavalos = "";

            for (int i=0; i < listacarros.Count; i++)
            {
                if(listacarros[i].cavalos > maiornumcavalos)
                {
                    maiornumcavalos = listacarros[i].cavalos;                       //Comparar cavalos e guarda o maior
                    matriculamaiorcavalos = listacarros[i].matricula;

                }
                else if(listacarros[i].cavalos < menornumcavalos)
                {
                    menornumcavalos = listacarros[i].cavalos;                       //Comparar cavalos e guarda o menor
                    matriculamenorcavalos = listacarros[i].matricula;
                }
            }

            Console.WriteLine("A matricula do carro mais potente é " + matriculamaiorcavalos + " e conta com " + maiornumcavalos + " cavalos");
            Console.WriteLine("A matricula do carro menos potente é " + matriculamenorcavalos + " e conta com " + menornumcavalos + " cavalos");
        }
    }
}
