﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainWindowsFormsApp
{
    class Exercise
    {     public string text { get; }
        public int repeat { get; set; }
        public bool status { get; set; }           // Выполнены все повторения или нет
        public string load;
        public string remark;

        public Exercise(string text, int repeat, bool status, string load, string remark)
        {
            this.text = text;
            this.repeat = repeat;
            this.status = status;
            this.load = load;
            this.remark = remark;
        }
    }
}