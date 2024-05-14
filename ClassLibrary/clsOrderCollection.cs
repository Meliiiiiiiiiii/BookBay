using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        public clsOrder ThisOrder { get; set; }
        public int Count { get; set; }
        public List<clsOrder> OrderList { get; set; }
    }
}