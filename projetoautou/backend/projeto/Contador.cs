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
    class Contador
    {
        public long id {get; set;}
        public long idColaborador {get; set;}
        public long idReacoes {get; set;}
    }
}