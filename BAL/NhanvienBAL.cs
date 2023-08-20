using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class NhanvienBAL
    {
        NhanvienDAL dal = new NhanvienDAL();
        public List<NhanvienBEL> ReadCustomer()
        {
            List<NhanvienBEL> lstNV = dal.ReadCustomer();
            return lstNV;

        }
        public void NewCustomer(NhanvienBEL cus)
        {
            dal.NewCustomer(cus);

        }
        public void DeleteCustomer(NhanvienBEL cus)
        {
            dal.DeleteCustomer(cus);

        }
        public void EditCustomer(NhanvienBEL cus)
        {
            dal.EditCustomer(cus);

        }
    }
}
