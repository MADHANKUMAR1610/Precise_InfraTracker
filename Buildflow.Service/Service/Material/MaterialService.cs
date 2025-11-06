using Buildflow.Library.UOW;
using Buildflow.Utility.DTO;
using Buildflow.Library.Repository.Interfaces;

namespace Buildflow.Service.Service.Material
{
    public interface IMaterialService
    {
        Task<IEnumerable<MaterialDto>> GetMaterialsByProjectAsync(int projectId);
        Task<IEnumerable<MaterialDto>> GetLowStockAlertsAsync(int projectId);
    }

    public class MaterialService : IMaterialService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MaterialService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<MaterialDto>> GetMaterialsByProjectAsync(int projectId)
        {
            var materials = await _unitOfWork.MaterialRepository.GetMaterialsByProjectAsync(projectId);
            return materials;
        }

        public async Task<IEnumerable<MaterialDto>> GetLowStockAlertsAsync(int projectId)
        {
            var materials = await _unitOfWork.MaterialRepository.GetLowStockAlertsAsync(projectId);
            return materials.Select(m =>
            {
                m.Level = "Urgent";
                return m;
            });
        }
    }
}
