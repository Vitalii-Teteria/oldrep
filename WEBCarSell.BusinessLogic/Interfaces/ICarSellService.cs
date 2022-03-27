using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBCarSell.BusinessLogic.DTO;

namespace WEBCarSell.BusinessLogic.Interfaces
{
    public interface ICarSellService
    {
        Task<ModelDto> AddModel(ModelDto model);
        Task<IEnumerable<ModelDto>> GetModelsList(ModelDto model);
        Task<ModelDto> GetModelById(int id);
        Task<CommentDto> GetComments(CommentDto model);
        Task<ClientDto> GetClient(ClientDto model);
        Task<OrderDto> GetOrder(OrderDto model);
        Task<RegionDto> GetModelByRegion(RegionDto model);
        Task<EmployeeDto> GetEmployee(EmployeeDto model);
        Task<ModelDto> IfExist(ModelDto model);
    }
}