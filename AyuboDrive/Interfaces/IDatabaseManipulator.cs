﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyuboDrive.Interfaces
{
    public interface IDatabaseManipulator
    {
        bool Insert();

        bool Update(string ID);
    }
}
