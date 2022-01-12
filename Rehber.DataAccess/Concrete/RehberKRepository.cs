using Rehber.DataAccess.Abstract;
using Rehber.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rehber.DataAccess.Concrete
{
    public class RehberKRepository : IRehberKRepository
    {
        public RehberK CreateRehberK(RehberK rehberK)
        {
            using (var RehberDBContext = new RehberDBContext())
            {
                RehberDBContext.RehberKs.Add(rehberK);
                RehberDBContext.SaveChanges();
                return rehberK;

            }
        }

        public void DeleteRehberK(Guid guid)
        {
            using (var RehberDBContext = new RehberDBContext())
            {
                var RehberDelete = GetRehberKByGuid(guid);
                RehberDBContext.RehberKs.Remove(RehberDelete);
                RehberDBContext.SaveChanges();

            }
        }

        public List<RehberK> GetAllRehberKs()
        {
            using (var RehberDBContext = new RehberDBContext())
            {
                return RehberDBContext.RehberKs.ToList();
            }
        }

        public RehberK GetRehberKByGuid(Guid guid)
        {
            using (var RehberDBContext = new RehberDBContext())
            {
                return RehberDBContext.RehberKs.Find(guid);
            }
        }

        public RehberK UptadeRehberK(RehberK rehberK)
        {
            using (var RehberDBContext = new RehberDBContext())
            {
                RehberDBContext.RehberKs.Update(rehberK);
                RehberDBContext.SaveChanges();
                return rehberK;

            }
        }
    }
}
