using Rehber.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rehber.Business.Abstract
{
    public interface IRehberKService
    {
        List<RehberK> GetAllRehberKs();

        RehberK GetRehberKByGuid(Guid guid);

        RehberK CreateRehberK(RehberK rehberK);

        RehberK UptadeRehberK(RehberK rehberK);

        void DeleteRehberK(Guid guid);
    }
}
