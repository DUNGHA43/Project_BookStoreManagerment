using DAL;
using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PublisherBLL
    {
        private readonly PublisherDAL _publisherDAL;

        public PublisherBLL()
        {
            _publisherDAL = new PublisherDAL(); 
        }

        public async Task<IEnumerable<PublisherDTO>> GetAllPublishersAsync()
        {
            return await _publisherDAL.GetAllAsync();
        }

        public async Task<IEnumerable<PublisherDTO>> SearchPublisherByNameAsync(string name)
        {
            return await _publisherDAL.SearchPublisherByNameAsync(name);
        }

        public async Task<bool> AddAsync(PublisherDTO publisher)
        {
            return await _publisherDAL.AddAsync(publisher);
        }

        public async Task<bool> UpdateAsync(PublisherDTO publisher)
        {
            return await _publisherDAL.UpdateAsync(publisher);
        }

        public async Task<bool> DeleteAsync(int? id)
        {
            return await _publisherDAL.DeleteAsync(id);
        }
    }
}
