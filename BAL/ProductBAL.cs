using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;
namespace BAL
{
    public class ProductBAL
    {
        ProductDAL dal = new ProductDAL();
        public List<ProductBEL> ReadCustomer()
        {
            List<ProductBEL> lstPro = dal.ReadCustomer();
            return lstPro;
            
        }
        public void NewCustomer(ProductBEL cus)
        {
            dal.NewCustomer(cus);

        }
        public void DeleteCustomer(ProductBEL cus)
        {
            dal.DeleteCustomer(cus);

        }
        public void EditCustomer(ProductBEL cus)
        {
            dal.EditCustomer(cus);

        }
    
    }
}
