using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class ColliveryError
    {
        public string error_id { get; set; }
        public string error { get; set; }

        public enum ErrorCodes
        {
            auth,
            disabled_account,
            disabled_user,
            incorrect_login,
            missing_data,
            invalid_data,
            invalid_data_type
        }
    }
}
