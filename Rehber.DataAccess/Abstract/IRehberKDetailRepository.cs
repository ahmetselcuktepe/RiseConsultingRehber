using Rehber.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rehber.DataAccess.Abstract
{
    public interface IRehberKDetailRepository
    {
        List<RehberKDetail> GetAllRehberKs();

        RehberKDetail GetRehberKByGuid(Guid guid);

        RehberKDetail CreateRehberK(RehberKDetail rehberDetailK);

        RehberKDetail UptadeRehberK(RehberKDetail rehberDetailK);

        void DeleteHotel(Guid guid);


    }
}
