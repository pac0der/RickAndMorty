using Newtonsoft.Json;
using RickAndMorty.Characters.Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty.Characters.Framework.Services
{
    public class CharacterService : ICharacterService
    {
        private HttpClient client;
        public CharacterService()
        {
            client = new HttpClient();
        }

        public async Task<FullRequest> GetByPageAsync(int page)
        {
            FullRequest fullRequest = null;
            var response = await client.GetAsync(string.Format("https://rickandmortyapi.com/api/character?page={0}", page));
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                fullRequest = JsonConvert.DeserializeObject<FullRequest>(content);
            }
            return fullRequest;
        }

        public async Task<Character> GetByIdAsync(int id)
        {
            Character character = null;
            var response = await client.GetAsync(string.Format("https://rickandmortyapi.com/api/character/{0}", id));
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                character = JsonConvert.DeserializeObject<Character>(content);
            }
            return character;
        }
    }
}
