using ProvidersListApp.Data;
using ProvidersListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvidersListApp.Services
{
    public class PhoneService
    {
        private readonly ProvidersListAppContext _context;

        public PhoneService(ProvidersListAppContext context)
        {
            _context = context;
        }
        /*public async Task<List<Phone>> FindListPhoneAsync(Provider provider)
        {
            return await _context.Phones.Where(Phone => Phone.PersonId = provider.Id).ToListAsync();
        }*/

    }
}
