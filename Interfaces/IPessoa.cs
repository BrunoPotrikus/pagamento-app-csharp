﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devPoo.Interfaces
{
    public interface IPessoa
    {
        Guid Id { get; set; }
        string Nome { get; set; }
    }
}
