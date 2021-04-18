
using Hst.ExtraMarksApp.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hst.ExtraMarksApp.Models
{
   public class BaseParametersModel
    {
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public string SortBy { get; set; } = "";
        public string SortDirection { get; set; } = "";
        public int UserId { get; set; } = UserHelper.UserId;
        public int UserTypeId { get; set; } = UserHelper.UserType;
        public Dictionary<string, string> OtherParams { get; set; }
    }
}
