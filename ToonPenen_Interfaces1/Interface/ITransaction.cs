﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToonPenen_Interfaces1
{
    public interface ITransaction
    {
        void ShowTransaction();
        double GetAmount();
        string ShowBankname();
    }
}
