using System;
using System.Collections.Generic;
using System.Text;

namespace eTracking.Model
{
    public class BorrowingType
    {
        public int ID { get; set; }
        public string Name_TH { get; set; }
        public string Name_EN { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
