using Rehber.Business.Abstract;
using Rehber.DataAccess.Abstract;
using Rehber.DataAccess.Concrete;
using Rehber.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rehber.Business.Concrete
{
    public class RehberKManager : IRehberKService
    {
        private IRehberKRepository _rehberKRepository;

        public RehberKManager()
        {
            _rehberKRepository = new RehberKRepository();
        }
        public RehberK CreateRehberK(RehberK rehberK)
        {
            return _rehberKRepository.CreateRehberK(rehberK);
        }

        public void DeleteRehberK(Guid guid)
        {
            throw new NotImplementedException();
        }

        public List<RehberK> GetAllRehberKs()
        {
            throw new NotImplementedException();
        }

        public RehberK GetRehberKByGuid(Guid guid)
        {
            throw new NotImplementedException();
        }

        public RehberK UptadeRehberK(RehberK rehberK)
        {
            throw new NotImplementedException();
        }
    }
}
