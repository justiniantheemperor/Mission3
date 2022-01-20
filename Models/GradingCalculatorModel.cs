using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission3.Models
{
    public class GradingCalculatorModel
    {
        [Required][Range(0, 100)]
        public byte assignments {get;set;}
        [Required][Range(0, 100)]
        public byte projects {get;set;}
        [Required][Range(0, 100)]
        public byte quizzes {get;set;}
        [Required][Range(0, 100)]
        public byte exams {get;set;}
        [Required][Range(0, 100)]
        public byte intex {get;set;}
    }
}
