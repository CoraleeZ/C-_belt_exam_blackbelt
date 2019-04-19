using System.Collections.Generic;

namespace belt_exam.Models
{
    public class Display_one_plan
    {
        public List<Resevation> Guest { get; set; }
        public Plan Oneplan { get; set; }

        public int Userid { get; set; }
    }
}