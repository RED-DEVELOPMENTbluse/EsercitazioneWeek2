﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsercitazioneWeek2.Entities;

namespace EsercitazioneWeek2.Factory
{
    public class FactoryCompany
    {
        public ICompany CreateCompany(int numeroDipendenti)
        {
            ICompany company = null;
            if (numeroDipendenti > 0 && numeroDipendenti < 20)
                return new SmallCompany();
            else if (numeroDipendenti > 20 && numeroDipendenti < 100)
                return new MediumCompany();
            else if (numeroDipendenti > 100 && numeroDipendenti < 500)
                return new BigCompany();
            else if (numeroDipendenti > 500)
                return new InternationalCompany();
            return company;
        }
    }
}
