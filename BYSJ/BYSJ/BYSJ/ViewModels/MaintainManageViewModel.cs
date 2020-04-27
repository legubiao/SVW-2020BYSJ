using BYSJ.Models;
using BYSJ.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace BYSJ.ViewModels
{
    class MaintainManageViewModel
    {
        IList<repairRecord> Records;

        public async void pageInit()
        {
            Records = await RestService.GetRecord();
        }
    }
}
