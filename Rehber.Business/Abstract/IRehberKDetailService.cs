using Rehber.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rehber.Business.Abstract
{
   public interface IRehberKDetailService
    {
        List<RehberKDetail> GetAllRehberKDetails();

        RehberKDetail GetRehberKDetailByGuid(Guid guid);

        RehberKDetail CreateRehberKDetail(RehberKDetail rehberKDetail);

        RehberKDetail UptadeRehberKDetail(RehberKDetail rehberKDetail);

        void DeleteRehberKDetail(Guid guid);

    }
}
