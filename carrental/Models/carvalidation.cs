using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace carrental.Models
{
    [MetadataType(typeof(carregMetaData))]
    public partial class carreg
    {
        public class carregMetaData
        {
            [DisplayName("CarNo")]
            public string carno { get; set; }

            [DisplayName("Make")]
            public string make { get; set; }

            [DisplayName("Model")]
            public string model { get; set; }

            [DisplayName("Available")]
            public string available { get; set; }
        }
    }
}