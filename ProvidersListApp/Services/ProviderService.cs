using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProvidersListApp.Data;
using ProvidersListApp.Models;

namespace ProvidersListApp.Services
{
    public class ProviderService
    {
        private readonly ProvidersListAppContext _context;



        public ProviderService(ProvidersListAppContext context)
        {
            _context = context;
        }

        public async Task<List<Provider>> FindAllAsync()
        {
            return await _context.Providers.ToListAsync();
        }

        public async Task<Provider> FindByIdAsync(int? id)
        {
            return await _context.Providers.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task<List<Provider>> FindByNameAsync()
        {
            return await _context.Providers.OrderBy(Provider => Provider.Name).ToListAsync();            
        }

        public async Task<List<Provider>> FindByDocument01Async()
        {
            return await _context.Providers.OrderBy(Provider => Provider.Document01).ToListAsync();
        }

        public async Task<List<Provider>> FindByDtRegistryAsync()
        {
            return await _context.Providers.OrderBy(Provider => Provider.DtTimeRegistry).ToListAsync();
        }
       

        public async Task InsertAsync(Provider obj, Company company)
        {

            bool fisica = obj.PersonType == PersonType.FISICA;

            if (fisica)
            {

                if (company.Uf == UF.PR && (DateTime.Now.Year-obj.DtBirthday.Year)<18)
                {
                    throw new NotFoundException("Não é permitido cadastrar menores de idade para este estado.");
                }

                if (obj.Document02.Length == 0 || obj.DtBirthday == null)
                {
                    throw new NotFoundException("Por favor informe RG e data de nascimento.");
                }
            }

            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

    }
}
