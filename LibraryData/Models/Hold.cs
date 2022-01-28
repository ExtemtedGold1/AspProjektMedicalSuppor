﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryData.Models
{
    public class Hold
    {
        public int Id { get; set; }
        public virtual MedicineAsset MedicineAsset { get; set; }
        public virtual MedicineCard MedicineCard { get; set; }
        public DateTime HoldPlaced { get; set; }
    }
}
