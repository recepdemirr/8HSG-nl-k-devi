using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _8HSGunlukOdevi.Modal
{
    public class BaseModel
    {
        public int Id { get; set; }
        public bool IsDeleted  { get; set; }=false;
        public bool IsActive  { get; set; }=true;
        public DateTime DateModified { get; set; }=DateTime.Now;
        public DateTime DateCreated { get; set; } = DateTime.Now;

    }
}
