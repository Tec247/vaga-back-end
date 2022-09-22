using AutoBem.Domain.Contracts.Repositories;
using AutoBem.Domain.Entities;
using AutoBem.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace AutoBem.Repository.Repositories
{
    public class ProprietarioRepository : Repository<Proprietario>, IRepository<Proprietario>
    {
        public ProprietarioRepository(AutoBemContext context) : base(context) { }

        public async override Task<Proprietario> Consultar(int id)
        {
            var entity = await this.Consultar(x => x.Id ==id).Include(x => x.Veiculos).FirstOrDefaultAsync();
            return entity;
        }
    }
}
