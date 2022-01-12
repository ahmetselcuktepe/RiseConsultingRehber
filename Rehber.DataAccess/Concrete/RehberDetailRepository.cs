using Rehber.DataAccess.Abstract;
using Rehber.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rehber.DataAccess.Concrete
{
    class RehberDetailRepository : IRehberKDetailRepository
    {
        public RehberKDetail CreateRehberK(RehberKDetail rehberDetailK)
        {
            using (var RehberDBContext = new RehberDBContext())
            {
                RehberDBContext.RehberKDetails.Add(rehberDetailK);
                RehberDBContext.SaveChanges();
                return rehberDetailK;

            }
        }

        public void DeleteHotel(Guid guid)
        {
            throw new NotImplementedException();
        }

        public List<RehberKDetail> GetAllRehberKs()
        {
            throw new NotImplementedException();
        }

        public RehberKDetail GetRehberKByGuid(Guid guid)
        {
            throw new NotImplementedException();
        }

        public RehberKDetail UptadeRehberK(RehberKDetail rehberDetailK)
        {
            throw new NotImplementedException();
        }
    }
}
