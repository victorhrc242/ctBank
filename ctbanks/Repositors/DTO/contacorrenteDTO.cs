﻿using ctBank.entidades;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctbanks.Repositors.DTO
{
    [Table("ContaCorrentes")]
    public class contacorrenteDTO
    {
        
        public int id { get; set; }
     public double LimiteDeCredito { get; set; }
        public  int IdConta { get; set; }
    }
}
