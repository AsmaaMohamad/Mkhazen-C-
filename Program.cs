using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Makhazen
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login_frm());
            Context context = new Context();
            try
            {
                Suppliers sup = new Suppliers();
                Customer customer = new Customer();
                Representative representative = new Representative();
                Category category = new Category();
                Prouduct prouduct = new Prouduct();
                Receipt_to_suppliers receipt_to_suppliers = new Receipt_to_suppliers();
                ReturnToSupplier returnToSupplier = new ReturnToSupplier();
                SalesBill representativeBuyBill = new SalesBill();
                RepresentativeReturnBill representativeReturnBill = new RepresentativeReturnBill();
                ReceivePermission receivePermission = new ReceivePermission();


                Users user = new Users();

                context.Supplier.Add(sup);
                context.Representative.Add(representative);
                context.Customers.Add(customer);
                context.Category.Add(category);
                context.prouduct.Add(prouduct);
                context.receipt_To_Suppliers.Add(receipt_to_suppliers);
                context.ReturnToSupplier.Add(returnToSupplier);
                context.sellBill.Add(representativeBuyBill);
                context.RepresentativeReturnBills.Add(representativeReturnBill);
                context.receivePermissions.Add(receivePermission);


                context.user.Add(user);





                context.SaveChanges();
            }
            catch { }
        }
    }
}
