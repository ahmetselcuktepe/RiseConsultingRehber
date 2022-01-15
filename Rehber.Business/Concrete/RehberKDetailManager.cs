using Rehber.Business.Abstract;
using Rehber.DataAccess.Abstract;
using Rehber.DataAccess.Concrete;
using Rehber.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Rehber.Business.Concrete
{
    public class RehberKDetailManager : IRehberKDetailService
    {
        private IRehberKDetailRepository _rehberKDetailRepository;

        public RehberKDetailManager(IRehberKDetailRepository rehberKDetailRepository)
        {
            _rehberKDetailRepository = rehberKDetailRepository;

        }
        public RehberKDetail CreateRehberKDetail(RehberKDetail rehberKDetail)
        {
            return _rehberKDetailRepository.CreateRehberKDetail(rehberKDetail);
        }

        public void DeleteRehberKDetail(Guid guid)
        {
            _rehberKDetailRepository.DeleteRehberKDetail(guid);
        }

        public List<RehberKDetail> GetAllRehberKDetails()
        {
            return _rehberKDetailRepository.GetAllRehberKDetails();
        }

        public RehberKDetail GetRehberKDetailByGuid(Guid guid)
        {
            return _rehberKDetailRepository.GetRehberKDetailByGuid(guid);
        }

        public RehberKDetail UptadeRehberKDetail(RehberKDetail rehberKDetail)
        {
           return _rehberKDetailRepository.UptadeRehberKDetail(rehberKDetail);
        }
    }
}
