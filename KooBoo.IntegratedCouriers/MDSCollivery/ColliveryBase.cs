using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public abstract class ColliveryResponseBase
    {
        public ColliveryError error { get; set; }
    }
}
