using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class ProofOfDelivery
    {
        /// <summary>
        /// Size of the POD in bytes.
        /// </summary>
        public int size { get; set; }

        /// <summary>
        /// File mime
        /// </summary>
        public string mime { get; set; }

        /// <summary>
        /// File Name
        /// </summary>
        public string filename { get; set; }

        /// <summary>
        ///  Base64 encoded file 
        /// </summary>
        public string file { get; set; }
    }
}
