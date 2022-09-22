using AutoBem.Domain.Contracts.Repositories;
using AutoBem.Domain.Entities;
using AutoBem.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace AutoBem.Repository.Repositories
{
    public class VeiculoRepository : Repository<Veiculo>, IRepository<Veiculo>
    {
        public VeiculoRepository(AutoBemContext context) : base(context) { }

        public async override Task<Veiculo> Consultar(int id)
        {
            var entity = await this.Consultar(x => x.Id ==id).Include(x => x.Proprietario).FirstOrDefaultAsync();
            return entity;
        }
    }
}
