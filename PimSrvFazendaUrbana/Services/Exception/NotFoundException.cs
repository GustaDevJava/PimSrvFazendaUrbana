using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PimSrvFazendaUrbana.Services.Exception
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string messege) : base(messege)
        {
        }
    }
}