﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShannonAlgorithmApp
{
    class Letter
    {
        public char letter;
        public int count;
        public double interest;
        public string letterCode = "";

        public Letter(char letter,int count)
        {
            this.letter = letter;
            this.count = count;
        }

        public void SetInterest(double all)
        {
            interest = (count/all)*100.0;
        }
    }
}
