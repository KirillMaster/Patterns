﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class WheatBreadBuilder : BreadBuilder
    {
        public override void SetAdditives()
        {
            Bread.Additives = new Additives { Name = "улучшитель хлебопекарный" };
        }

        public override void SetFlour()
        {
            Bread.Flour = new Flour { Sort = "Пшеничная мука высший сорт."};
        }

        public override void SetSalt()
        {
            Bread.Salt = new Salt();
        }
    }
}
