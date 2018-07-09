using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BMS.DAO;
using BMS.Entity;

namespace BMS.BLL
{
    public class BillBll
    {
        private static BillBll billBll;

        private BillBll()
        {
        }

        public static BillBll GetInstance()
        {
            if (billBll == null)
            {
                billBll=new BillBll();
            }
            return billBll;
        }

        public int addBill(Bill bill)
        {
            return BillDao.GetInstance().AddBill(bill);
        }

    }
}
