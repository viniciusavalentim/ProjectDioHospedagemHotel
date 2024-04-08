using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDioHospedagemHotel
{
    internal class Reserva
    {
        public List<Pessoa>? Hospedes { get; set; }
        public Suite? Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva()
        {
        }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public Reserva(List<Pessoa>? hospedes, Suite? suite, int diasReservados)
        {
            Hospedes = hospedes;
            Suite = suite;
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa>? hospedes)
        {

            try
            {
               if (hospedes.Count > 5)
               {
                    Console.WriteLine("Quantidade de pessoas indisponível nessa suite, volte novamente mais tarde.");
                }
               else
               {
                    Hospedes = hospedes;
               }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message); 
            }

        }

        public void CadastrarSuite(Suite? suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;
            if(DiasReservados >= 10)
            {
                decimal calc = valor - ((valor / 100)*10);
                return calc;
            }
            else
            {
                return valor;
            }
        }
    }
}
