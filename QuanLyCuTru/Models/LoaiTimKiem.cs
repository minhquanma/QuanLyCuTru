using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyCuTru.Models
{
    public class LoaiTimKiem
    {
        public byte Id { get; set; }
        public string Name { get; set; }

        public LoaiTimKiem()
        {

        }

        public LoaiTimKiem(byte Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}