﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatchlingCompany.Utils.Contracts
{
    public interface IImporter
    {
        string Import(string fileType);
    }
}
