using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
