using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BMS.Entity;
using BMS.Tools;
using BMS.Entity;

namespace BMS.DAO
{
    public class BillDao
    {
        private static BillDao billDao;

        private BillDao()
        {
        }

        public static BillDao GetInstance()
        {
            if (billDao == null)
            {
                billDao = new BillDao();
            }
            return billDao;
        }
        //ExecuteNonQuery
        public int AddBill(Bill bill)
        {
            string sql = "insert into bill(Company,Status,Phone,StarTime,Deadline,RealPayment,EveryMonthPayment,Balance,Note,RecordTime) values " +
                         "(@Company,@Status,@Phone,@StarTime,@Deadline,@RealPayment,@EveryMonthPayment,@Balance,@Note,@RecordTime)";
            return SQLiteHelper.ExecuteNonQuery("", sql, bill);
        }
    }
}
