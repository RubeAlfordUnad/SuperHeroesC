﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Interfaces
{
    internal interface ISuperHeroe
    {
        int Id { get; set; }
        string Name { get; set; }
        string SecretIdentify{ get; set; }

        string GetSuperHeroe()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Id: {Id}");
            sb.AppendLine($"Nombre: {Name}");
            sb.AppendLine($"Identidad secreta: {SecretIdentify}");
            return sb.ToString();
        }
    }
}
