using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vips_ManageProgram_rev1
{
    class Table_Info
    {
        public int Table_num { get; set; } //테이블 번호
        public int Adult_People_num { get; set; } // 어른 인원 수
        public int Child_People_num { get; set; } // 아이 인원 수
        public DateTime Cus_Intime { get; set; } // 고객 입장 시간
        public int Cus_Outtime { get; set; } // 고객 퇴실 시간
        public int price { get; set; } // 금액
    }
    
}
