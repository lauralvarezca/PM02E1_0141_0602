﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PM02E1_0141_0602.Models
{
    public class sitios
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public byte[] foto { get; set; }
        public string latitud { get; set; }
        public string longitud { get; set; }
        public string descripcion { get; set; }

    }
}
