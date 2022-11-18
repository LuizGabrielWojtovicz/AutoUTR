using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Site
{
    class Colaborador
    {
        public long id {get; set;}
        public long matricula {get; set;}
        public string? nome {get; set;}
        public string? sobrenome {get; set;}
        public string? email {get; set;}
        public string? departamento {get; set;}
        public string? cargo {get; set;}
    }
}