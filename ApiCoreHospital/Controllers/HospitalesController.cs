using ApiCoreHospital.Models;
using ApiCoreHospital.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCoreHospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalesController : ControllerBase
    {
        private RepositoryHospital repo;
        public HospitalesController(RepositoryHospital repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Hospital>>> GetHospitales()
        {
            var hospitales = await repo.GetHospitalesAsync();
            return hospitales;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Hospital>> FindHospital(int id)
        {
            var hospital = await repo.FindOneHospital(id);
            return hospital;
        }
    }
}
