﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PCRApi.Models.Db
{
    public partial class EquipmentEnhanceDatum
    {
        public long PromotionLevel { get; set; }
        public long EquipmentEnhanceLevel { get; set; }
        public long NeededPoint { get; set; }
        public long TotalPoint { get; set; }
    }
}
