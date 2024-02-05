﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        void ApplyForMask(Person person); //Maske için başvur (Person başvuracak - parametre olarak person verilir)

        List<Person> GetList();

        bool CheckPerson(Person person);

    }
}

