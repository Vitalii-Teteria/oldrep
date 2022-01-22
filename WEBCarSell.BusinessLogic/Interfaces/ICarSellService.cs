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
        Task<IEnumerable<ModelDto>> AddModel(ModelDto model);
        Task<IEnumerable<ModelDto>> GetModelsList(ModelDto model);
        Task<IEnumerable<ModelDto>> GetModelById(int id);
        Task<IEnumerable<CommentDto>> GetComments(CommentDto model);
        Task<IEnumerable<ClientDto>> GetClient(ClientDto model);      
        Task<IEnumerable<OrderDto>> GetOrder(OrderDto model);
        Task<IEnumerable<RegionDto>> GetModelByRegion(RegionDto model);
        Task<IEnumerable<EmployeeDto>> GetEmployee(EmployeeDto model);
    }
}
