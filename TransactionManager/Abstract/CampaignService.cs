using Entity;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManager.Abstract
{
     interface CampaignService
    {
        void AddCampaign(Campaign Campaign);
        void UpdateCampaign(int Id , Campaign campaign);
        void DeleteCampaign(Campaign campaign);
    }
}
