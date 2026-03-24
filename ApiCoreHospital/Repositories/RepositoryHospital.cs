using ApiCoreHospital.Data;
using ApiCoreHospital.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCoreHospital.Repositories
{
    public class RepositoryHospital
    {
        private HospitalContext context;
        public RepositoryHospital(HospitalContext context)
        {
            this.context = context;
        }

        public async Task<List<Hospital>> GetHospitalesAsync()
        {
            return await context.Hospitales.ToListAsync();
        }

        public async Task<Hospital>FindOneHospital(int idHospital)
        {
            return await context.Hospitales.FirstOrDefaultAsync(x => x.IdHospital == idHospital);
        }

    }
}
