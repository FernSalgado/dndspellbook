﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DndSpellbook.JWT
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public int ExpiraEm { get; set; }
        public string Emissor { get; set; }
        public string ValidoEm { get; set; }
    }
}
