using System;
using System.Collections.Generic;

namespace BookingForBeauty.Models.Entities
{
    public partial class Appuntamenti
    {
        public int IdAppuntamento { get; set; }
        public string NomeCliente { get; set; } = null!;
        public string? Descrizione { get; set; }
        public DateTime Data { get; set; }
    }
}
