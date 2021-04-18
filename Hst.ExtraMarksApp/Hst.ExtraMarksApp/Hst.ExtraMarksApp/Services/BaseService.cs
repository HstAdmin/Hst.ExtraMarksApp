using System;
using System.Collections.Generic;
using System.Text;

namespace Hst.ExtraMarksApp.Services
{
   public class BaseService
    {
        protected readonly ApiClient _ApiClient;
        public BaseService()
        {
            _ApiClient = new ApiClient();
        }

    }
}
