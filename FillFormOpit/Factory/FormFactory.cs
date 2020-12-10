using FillFormOpit.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FillFormOpit.Factory
{
    public static class FormFactory
    {
        
        public static FormModel Create()
        {

            return new FormModel
            {
                FullName = "Ivan Ivanov",
                EmailAdd = "example@emai.com",
                CurrentAddress = "Sofia,  Bulgaria",
                PermanentAddress = "Sofia, Bulgari, Bulgaria"
            };

        }


    }
}
