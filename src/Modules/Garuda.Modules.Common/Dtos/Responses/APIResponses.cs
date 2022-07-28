using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garuda.Modules.Common.Dtos.Responses
{
    public class APIResponses
    {
        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Info Return
        /// </summary>
        public string Messages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Dat
        /// </summary>
        public List<object> Data { get; set; }
    }
}
