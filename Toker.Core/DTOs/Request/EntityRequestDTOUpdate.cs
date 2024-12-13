﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toker.Core.DTOs.Request
{
    public class EntityRequestDTOUpdate
    {
        public int Id { get; set; }
        public string Name { get; set; } // Nombre de la entidad
        public bool IsActive { get; set; } // Estado de la entidad, por defecto true
    }
}