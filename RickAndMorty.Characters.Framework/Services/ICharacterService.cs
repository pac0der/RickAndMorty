using RickAndMorty.Characters.Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty.Characters.Framework.Services
{
    public interface ICharacterService
    {
        Task<FullRequest> GetByPageAsync(int page);
        Task<Character> GetByIdAsync(int id);
    }
}
