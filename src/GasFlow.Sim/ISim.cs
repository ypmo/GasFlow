
using System.Collections.Generic;
using System.Threading.Tasks;
using PRODML = Energistics.DataAccess.PRODML200;
namespace GasFlow.Sim
{
    public interface ISim
    {
        Task<PRODML.ProductVolume> CalcModel(PRODML.ProductFlowModel model, PRODML.ProductVolume volume);
    }
}