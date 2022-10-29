using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingForBeauty.Models.ViewModels
{
    public class AppuntamentoViewModel
    {
        public int IdAppuntamento { get; set; }

        //Nome Completo del cliente, es: Mario Rossi
        public string FullNameCliente { get; set; }
        public DateTime data { get; set; }

        //Descrizione relativa all'appuntamento
        public string Descrizione { get; set; }

    }
}