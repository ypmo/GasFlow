using Core;
using Energistics.Etp.Common;
using System;

namespace Store
{
    public class Repository<Model> : IRepository<Model>
    {
        IEtpClient _client;
        public Repository(IEtpClient client)
        {
            _client = client;
        }

        public Model Get(string id)
        {
            throw new NotImplementedException();
        }
    }
}
