using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Ejercicio3
{
    public class Cuenta
    {
        public Cuenta()
        {

        }

        public double Saldo { get; set; }
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Retirar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                return $"se hizo un retiro de {valor} y su saldo es de {Saldo}";
     
            }
            return "saldo insuficiente";
        }
        public string Consignar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                return $"Se hizo una consignación de {valor} y su saldo es de {Saldo}";
            }
            return "no es posible realizar esta consignación";
        }
        public double ConsultarSaldo()
        {
            return Saldo;
        }
    }
}
