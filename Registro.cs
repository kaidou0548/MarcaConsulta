using System;
using System.Collections.Generic;
using System.Text;

namespace MarcaConsulta.Modelo
{
    public class Consulta
    {
        public string NomeCliente { get; set; }
        public string Registro { get; set; }
        public DateTime DataConsulta { get; set; }
        public string Especialidade { get; set; }

        public void ConfereNome()
        {
            if(NomeCliente == "")
            {
                Console.WriteLine("Nome inválido. Digite novamente");
                NomeCliente = Console.ReadLine();
                ConfereNome();
            }else
            {
                Console.Clear();
            }
        }

        public void ConfereRegistro()
        {
            if(Registro == "")
            {
                Console.WriteLine("Registro inválido. Digite novamente");
                Registro = Console.ReadLine();
                ConfereRegistro();
            }else
            {
                Console.Clear();
            }
        }

        public void ConfereEspecialidades()
        {
            Console.WriteLine("Especialidades:");
            Console.WriteLine("----------------");
            Console.WriteLine("Cardiologia -1");
            Console.WriteLine("---------------");
            Console.WriteLine("Pediatra -2");
            Console.WriteLine("------------");
            Console.WriteLine("Dermatologia -3");
            Console.WriteLine("---------------");

            string caso = Console.ReadLine();

            if ( caso == "1")
            {
                Especialidade = "Cardiologia";
                Console.Clear();                
            }else if ( caso == "2")
            {
                Especialidade = "Pediatra";
                Console.Clear();                 
            }else if ( caso == "3")
            {
                Especialidade = "Dermatologia";
                Console.Clear();                    
            }else
            {
                Console.Clear();
                Console.WriteLine("Opção de especialidade Invalida. Digite novamente");
                ConfereEspecialidades();
            }
        }
        public void ConfereData()
        {
                
            Console.WriteLine("Dias e Horarios:");
            Console.WriteLine("------------------");
            Console.WriteLine("30/01/2023 5hrs -1");
            Console.WriteLine("-----------------");
            Console.WriteLine("27/06/2023 12hrs -2");
            Console.WriteLine("-----------------");
            Console.WriteLine("28/02/2023 3hrs -3");
            Console.WriteLine("-----------------");
            Console.WriteLine("26/02/2023 22hrs -4");
            Console.WriteLine("-----------------");

            string casoo = Console.ReadLine();

            if ( casoo == "1")
            {
                DataConsulta = DateTime.Parse("30/01/2023 05:00:00");
                Console.Clear();                
            }else if ( casoo == "2")
            {
                DataConsulta = DateTime.Parse("27/06/2023 12:00:00");
                Console.Clear();                 
            }else if ( casoo == "3")
            {
                DataConsulta = DateTime.Parse("28/02/2023 03:00:00");
                Console.Clear();                    
            }else if ( casoo == "4")
            {
                DataConsulta = DateTime.Parse("26/02/2023 22:00:00");
                Console.Clear();                 
            }else
            {
                Console.Clear();
                Console.WriteLine("Data Invalida. Digite novamente");
                ConfereData();
            }

        }

        public void ConsultaMarcada()
        {
            Console.WriteLine("Consulta Marcada");
            Console.WriteLine("Cliente: " + NomeCliente);
            Console.WriteLine("Registro: " + Registro);
            Console.WriteLine("Especialidade: " + Especialidade);
            Console.WriteLine("Data : " + DataConsulta);
        }

    }

}

    
