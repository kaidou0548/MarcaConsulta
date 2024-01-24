using System;
using System.Collections.Generic;
using System.Text;
using MarcaConsulta.Modelo;

namespace MarcaConsulta.Classes
{
    public class Layout
    {
        public  static void Telapricipal()
        {

            Consulta consulta = new Consulta();

            Console.WriteLine("Digite seu nome:");
            consulta.NomeCliente = Console.ReadLine();

            consulta.ConfereNome();

            Console.WriteLine("Digite seu registro:");

            consulta.Registro = Console.ReadLine();

            consulta.ConfereRegistro();

            consulta.ConfereEspecialidades();

            consulta.ConfereData();

            consulta.ConsultaMarcada();

        }
    }
}