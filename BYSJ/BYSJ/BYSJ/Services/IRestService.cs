using BYSJ.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BYSJ.Services
{
    public interface IRestService
    {
        Task<string> GetToken(string username, string password);
        Task<List<repairRecord>> GetRecord();
    }
}
