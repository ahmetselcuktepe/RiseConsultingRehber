using Rehber.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rehber.DataAccess.Abstract
{
    public interface IRehberKDetailRepository
    {
        List<RehberKDetail> GetAllRehberKDetails();

        RehberKDetail GetRehberKDetailByGuid(Guid guid);

        RehberKDetail CreateRehberKDetail(RehberKDetail rehberKDetail);

        RehberKDetail UptadeRehberKDetail(RehberKDetail rehberKDetail);

        void DeleteRehberKDetail(Guid guid);


    }
}
