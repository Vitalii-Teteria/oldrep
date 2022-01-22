using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBCarSell.BusinessLogic.DTO;
using WEBCarSell.BusinessLogic.Interfaces;
using WEBCarSell.DataAccess.Interfaces;
using WEBCarSell.BusinessLogic.Extensions;
using WEBCarSell.DataAccess.Entities;

namespace WEBCarSell.BusinessLogic.Services
{
   public class CarSellService : ICarSellService
    {
        private readonly IRepository _repository;

        public async Task<ModelDto> AddModel(ModelDto model)
        {
            if (model == null) 
            {
                throw new ArgumentNullException(nameof(model), "model is empty");
            }

            //var models = model.ToEntity();
            //return (await _repository.Create(model)).ToDto(); 
        }

        public async Task<ModelDto> GetModelsList()
        {
            
            throw new ArgumentNullException();
            
        }

        public async Task<ModelDto> GetModelById(int id)
        {
           // var result = await _repository.GetWhere<Model>(x => x.Id == id)
            throw new ArgumentNullException();
        }

        public async Task<CommentDto> GetComments()
        {
            throw new ArgumentNullException();
        }

        public async Task<ClientDto> GetClient()
        {
            throw new ArgumentNullException();
        }

        public async Task<RegionDto> GetModelByRegion(int id)
        {
            throw new ArgumentNullException();
        }

        public async Task<EmployeeDto> GetEmployee()
        {
            throw new ArgumentNullException();
        }
    }
}
