using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Factura.Services
{
    public class ReportServices
    {
        #region Instancias
        UserServices userServices = new UserServices();
        Usuarios user = new Usuarios();
        BillServices billServices = new BillServices();
        Factura bill = new Factura();
        CustomerServices customerServices = new CustomerServices();
        Cliente customer = new Cliente();
        SupplierServices supplierServices = new SupplierServices();
        Suplidor supplier = new Suplidor();
        BuyServices buyServices = new BuyServices();
        Compra buy = new Compra();
        Database database = new Database();
        #endregion

        public DataTable Get(int query)
        {
            DataTable result = new DataTable();
            switch (query)
            {
                case 1:
                    result = billServices.Get(0, "");
                    break;
                case 2:
                    result = customerServices.Get(0, "");
                    break;
                case 3:
                    result = supplierServices.Get(0, "");
                    break;
                case 4:
                    result = buyServices.Get(0, "");
                    break;
                case 5:
                    result = userServices.Get(0, "");
                    break;
            }
            return result;
        }
        public DataTable GetSpecific(int query, string id)
        {
            DataTable result = new DataTable();
            switch (query)
            {
                case 1:
                    result = billServices.Get(1, id);
                    break;
                case 2:
                    result = customerServices.Get(1, id);
                    break;
                case 3:
                    result = supplierServices.Get(1, id);
                    break;
                case 4:
                    result = buyServices.Get(1, id);
                    break;
                case 5:
                    result = userServices.Get(73, id);
                    break;
            }
            return result;
        }
        public DataTable GetWhateverYouWant(string Query)
        {
            return database.ExecuteRead(Query); //Esto es una malisima practica, nunca lo hagas, por esto me quitaron 4 pts de mi proyecto final el año pasado xd
        }
    }
}
