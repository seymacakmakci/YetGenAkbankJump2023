﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHunter.Common
{
    public interface IModifiedByEntity
    {
        public DateTime? ModifiedOn { get; set; }

    }
}