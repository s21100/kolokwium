using kolokwium2b.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2b.Services
{
    public interface IDbService
    {
        Task<SomeSortOfMusician> getMusician(int id);
        Task<bool> deleteMusician(int id);
    }
}
