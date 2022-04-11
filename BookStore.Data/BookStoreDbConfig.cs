using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Data
{
    public class BookStoreDbConfig
    {
        public string Database_Name { get; set; }
        public string Books_Collection_Name { get; set; }
        public string Connection_String { get; set; }
    }
}
