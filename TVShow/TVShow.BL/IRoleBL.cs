﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVShows.Domain;

namespace TVShows.BL
{
    public interface IRoleBL : IBaseBL
    {
        IList<Role> GetList();
    }
}
