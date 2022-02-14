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

        public async Task<ModelDto> GetModelsList(int modelId)
        {
            //var models = (await _repository.GetWhere<Model>(g => g.Id == modelId, include: g => g.Include(g => g.Name).ThenInclude(g => g.Price))).Select(g => g.Name).FirstOrDefault();
            //return models.Select(q => q.ToDto()).ToList();
            throw new ArgumentNullException();
            
        }

        public async Task<ModelDto> GetModelById(int id)
        {
           // var result = await _repository.GetWhere<Model>(x => x.Id == id)
            throw new ArgumentNullException();
        }

        public async Task<CommentDto> GetComments()
        {
            //var result = await _repository.GetAll<Comment>
            throw new ArgumentNullException();
        }

        public async Task<ClientDto> GetClientById(int id)
        {
            //var result = await _repository.GetWhere<Client>(x => x.Id == id);
            throw new ArgumentNullException();
        }

        public async Task<RegionDto> GetModelByRegion(int id)
        {
            //var result = await _repository.GetWhere<Region>(x => x.Id == id);
            throw new ArgumentNullException();
        }

        public async Task<EmployeeDto> GetEmployee(int id)
        {
           // var employee = await _repository.GetWhere<Employee>(x => x.Id == id);
            throw new ArgumentNullException();
        }

        public async Task<bool> IfExist(Guid carId) 
        {
            return await _repository.IfExist<Model>(x => x.Id == carId);
        }
    }
}
