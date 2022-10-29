using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingForBeauty.Models.ViewModels;

namespace BookingForBeauty.Models.Services
{
    public class EfCoreAppuntamentoService : AppuntamentoService
    {
        public Task<IEnumerable<AppuntamentoViewModel>> getAppuntamenti()
        {
            throw new NotImplementedException();
        }
    }
}