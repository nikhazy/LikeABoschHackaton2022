﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandling.Model.ADMA
{
    public class AdmaModel
    {
        public List<AdmaData> AdmaDatas { get; set; }
        public AdmaModel()
        {
            AdmaDatas = new List<AdmaData>();
        }
    }
}
