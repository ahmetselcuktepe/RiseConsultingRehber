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
            _rehberKRepository.DeleteRehberK(guid);
        }

        public List<RehberK> GetAllRehberKs()
        {
            return _rehberKRepository.GetAllRehberKs();
        }

        public RehberK GetRehberKByGuid(Guid guid)
        {
            return _rehberKRepository.GetRehberKByGuid(guid);
        }

        public RehberK UptadeRehberK(RehberK rehberK)
        {
            return _rehberKRepository.UptadeRehberK(rehberK);
        }
    }
}
