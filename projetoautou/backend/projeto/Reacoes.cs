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
    class Reacoes
    {
        public long id {get; set;}
        public long like {get; set;}
        public long orgulho {get; set;}
        public long excelenteTrabalho {get; set;}
        public long colaboracao {get; set;}
    }
}