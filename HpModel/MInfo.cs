using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HpModel
{
    public class MInfo
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }

        public bool IsCtrl { get; set; }
        public bool IsAlt { get; set; }
        public bool IsShift { get; set; }

        //快捷键
        public string Key { get; set; }

        public string Title { get; set; }

        public int TypeId { get; set; }

        public string Content { get; set; }

        private int userId = -1;
        public int UserId { get { return userId; } set { userId = value; } }

        private DateTime createDateTime;
        public DateTime CreateDateTime { get { return createDateTime; } set { createDateTime = value; } }

    }
}
