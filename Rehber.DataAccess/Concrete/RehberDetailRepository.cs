using Rehber.DataAccess.Abstract;
using Rehber.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rehber.DataAccess.Concrete
{
    class RehberDetailRepository : IRehberKDetailRepository
    {
        public RehberKDetail CreateRehberKDetail(RehberKDetail rehberKDetail)
        {
            using (var RehberDBContext = new RehberDBContext())
            {
                RehberDBContext.RehberKDetails.Add(rehberKDetail);
                RehberDBContext.SaveChanges();
                return rehberKDetail;

            }
        }

        public void DeleteRehberKDetail(Guid guid)
        {
            using (var RehberDBContext = new RehberDBContext())
            {
                var RehberDetailDelete = GetRehberKDetailByGuid(guid);
                RehberDBContext.RehberKDetails.Remove(RehberDetailDelete);
                RehberDBContext.SaveChanges();

            }
        }

        public List<RehberKDetail> GetAllRehberKDetails()
        {
            using (var RehberDBContext = new RehberDBContext())
            {
                return RehberDBContext.RehberKDetails.ToList();
            }
        }

        public RehberKDetail GetRehberKDetailByGuid(Guid guid)
        {
            using (var RehberDBContext = new RehberDBContext())
            {
                return RehberDBContext.RehberKDetails.Find(guid);
            }
        }

        public RehberKDetail UptadeRehberKDetail(RehberKDetail rehberKDetail)
        {
            using (var RehberDBContext = new RehberDBContext())
            {
                RehberDBContext.RehberKDetails.Update(rehberKDetail);
                RehberDBContext.SaveChanges();
                return rehberKDetail;

            }
        }
    }
}
