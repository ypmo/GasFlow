using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
using Energistics.DataAccess.PRODML200;
using System.Collections.ObjectModel;
using Energistics.DataAccess.PRODML200.ComponentSchemas;
namespace Demo.Repositories
{
    public class ModelsRepository : IRepository<ProductFlowModel>
    {
        public ProductFlowModel Get(string id)
        {
            return ProductFlowModels.FirstOrDefault(t => t.Uuid == id);
        }

        private List<ProductFlowModel> ProductFlowModels = new List<ProductFlowModel> 
        { 
            new ProductFlowModel
            {
                Uuid="1",
                Network=new ObservableCollection<ProductFlowNetwork>
                {
                    new ProductFlowNetwork()
                    {

                    }
                }
            }
        };
    }
}
