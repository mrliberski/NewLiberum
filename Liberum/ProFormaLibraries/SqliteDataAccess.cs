using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
//using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ProFormaLibraries
{
    public class SqliteDataAccess
    {
        public static List<InvoiceItem> PopulateItems(int invoice)
        {
            using (var cnn = new SQLiteConnection("Data Source=your_database.db"))
            {
                cnn.Open();
                var cmd = cnn.CreateCommand();
                cmd.CommandText = "select * from InvoiceItems where InvoiceNumber = @invoice";
                cmd.Parameters.AddWithValue("@invoice", invoice);
                var output = new List<InvoiceItem>();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new InvoiceItem();
                        // fill item properties from reader
                        output.Add(item);
                    }
                }
                return output;
            }
        }

        //public static List<InvoiceItem> PopulateItems(int invoice)
        //{
        //    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        //    {
        //        var output = cnn.Query<InvoiceItem>($"select * from InvoiceItems where InvoiceNumber = @invoice", new { invoice });
        //        return output.ToList();
        //    }
        //}

        public static List<ItemModel> LoadItems(string SelectedCustomer)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // did not work ;P var output = cnn.Query<ItemModel>($"select * from ItemsTable where Customer={SelectedCustomer}", new DynamicParameters());
                var output = cnn.Query<ItemModel>($"select * from ItemsTable where Customer = @SelectedCustomer", new { SelectedCustomer });
                return output.ToList();
            }
        }


        public static CustomerModel FetchCustomerInfo(string customer)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                CustomerModel output = new CustomerModel();

                var parameters = new DynamicParameters();
                parameters.Add("@customer", customer);

                output = cnn.Query<CustomerModel>("select id,* from Customers WHERE CustomerName = @customer", parameters).FirstOrDefault();
                return output;
            }


            //return new CustomerModel();
        }

        public static InvoiceItem SelectInvoiceCustomer(int SelectedInvoice)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@SelectedInvoice", SelectedInvoice);

                var output = cnn.Query<InvoiceItem>("SELECT CustomerName FROM InvoiceItems WHERE InvoiceNumber = @SelectedInvoice", parameters).FirstOrDefault();
                return output;
            }
        }

        public static List<string> LoadRequestType()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<string>("select RequestName from RequestType", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<string> LoadRecipients()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<string>("select Address from Recipients", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<string> LoadCC()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<string>("select Address from CClist", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<string> LoadTimeslots()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<string>("select Timeslot from Timeslots", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<string> LoadProcedures()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<string>("select Code from Procedurecodes", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<CustomerModel> LoadCustomers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CustomerModel>("select id,* from Customers", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void AddInvoiceItem(InvoiceItem item)
        {
            var connection = new SQLiteConnection(LoadConnectionString());

            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"insert into InvoiceItems 
                        (
                            InvoiceNumber,
                            CustomerName,
                            ItemQuantity, 
                            ItemName,
                            PartNumber,
                            CustomerNumber,
                            ItemNetWeight,
                            ItemGrossWeight,
                            ItemPrice,
                            ItemHScode,
                            ItemCOO,
                            ContainerName,
                            ContainersQuantity,
                            ContainerCode,
                            ContainerNetWeight,
                            ContainerGrossWeight,
                            ContainerPrice,
                            ContainerHSCode,
                            ContainerCOO,
                            PartsPerContainer,
                            ContainersPerPallet,
                            PalletsQuantity,
                            RequiresPackaging,
                            RequiresLid,
                            RequiresPallet,
                            CreatedDate,
                            CreatedBy
                        )
                        values 
                        (
                            @InvoiceNumber,
                            @CustomerName,
                            @ItemQuantity, 
                            @ItemName,
                            @PartNumber,
                            @CustomerNumber,
                            @ItemNetWeight,
                            @ItemGrossWeight,
                            @ItemPrice,
                            @ItemHScode,
                            @ItemCOO,
                            @ContainerName,
                            @ContainersQuantity,
                            @ContainerCode,
                            @ContainerNetWeight,
                            @ContainerGrossWeight,
                            @ContainerPrice,
                            @ContainerHSCode,
                            @ContainerCOO,
                            @PartsPerContainer,
                            @ContainersPerPallet,
                            @PalletsQuantity,
                            @RequiresPackaging,
                            @RequiresLid,
                            @RequiresPallet,
                            @CreatedDate,
                            @CreatedBy
                        )";
            cmd.Parameters.Add(new SQLiteParameter("@InvoiceNumber", item.InvoiceNumber));
            cmd.Parameters.Add(new SQLiteParameter("@CustomerName", item.CustomerName));
            cmd.Parameters.Add(new SQLiteParameter("@ItemQuantity", item.CustomerName));
            cmd.Parameters.Add(new SQLiteParameter("@ItemName", item.CustomerName));
            cmd.Parameters.Add(new SQLiteParameter("@PartNumber", item.CustomerName));
            cmd.Parameters.Add(new SQLiteParameter("@CustomerNumber", item.CustomerName));
            cmd.Parameters.Add(new SQLiteParameter("@ItemNetWeight", item.CustomerName));
            cmd.Parameters.Add(new SQLiteParameter("@ItemGrossWeight", item.CustomerName));
            cmd.Parameters.Add(new SQLiteParameter("@ItemPrice", item.CustomerName));
            cmd.Parameters.Add(new SQLiteParameter("@ItemHScode", item.CustomerName));
            cmd.Parameters.Add(new SQLiteParameter("@ItemCOO", item.CustomerName));
            cmd.Parameters.Add(new SQLiteParameter("@ContainerName", item.CustomerName));
            cmd.Parameters.Add(new SQLiteParameter("@ContainersQuantity", item.CustomerName));
            cmd.Parameters.Add(new SQLiteParameter("@ContainerCode", item.CustomerName));
            cmd.Parameters.Add(new SQLiteParameter("@ContainerNetWeight", item.CustomerName));
            cmd.Parameters.Add(new SQLiteParameter("@ContainerGrossWeight", item.CustomerName));
            cmd.Parameters.Add(new SQLiteParameter("@ContainerPrice", item.CustomerName));
            cmd.Parameters.Add(new SQLiteParameter("@ContainerHSCode", item.CustomerName));
            cmd.Parameters.Add(new SQLiteParameter("@ContainerCOO", item.CustomerName));
            cmd.Parameters.Add(new SQLiteParameter("@PartsPerContainer", item.CustomerName));
            cmd.Parameters.Add(new SQLiteParameter("@ContainersPerPallet", item.CustomerName));
            cmd.Parameters.Add(new SQLiteParameter("@PalletsQuantity", item.CustomerName));
            cmd.Parameters.Add(new SQLiteParameter("@RequiresPackaging", item.CustomerName));
            cmd.Parameters.Add(new SQLiteParameter("@RequiresLid", item.CustomerName));
            cmd.Parameters.Add(new SQLiteParameter("@RequiresPallet", item.CustomerName));
            cmd.Parameters.Add(new SQLiteParameter("@CreatedDate", item.CustomerName));
            cmd.Parameters.Add(new SQLiteParameter("@CreatedBy", item.CustomerName));

            // add other parameters for item properties

            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void AddInvoiceItem_Dapper(InvoiceItem item)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute(@"insert into InvoiceItems 
                        (
                            InvoiceNumber,
                            CustomerName,
                            ItemQuantity, 
                            ItemName,
                            PartNumber,
                            CustomerNumber,
                            ItemNetWeight,
                            ItemGrossWeight,
                            ItemPrice,
                            ItemHScode,
                            ItemCOO,
                            ContainerName,
                            ContainersQuantity,
                            ContainerCode,
                            ContainerNetWeight,
                            ContainerGrossWeight,
                            ContainerPrice,
                            ContainerHSCode,
                            ContainerCOO,
                            PartsPerContainer,
                            ContainersPerPallet,
                            PalletsQuantity,
                            RequiresPackaging,
                            RequiresLid,
                            RequiresPallet,
                            CreatedDate,
                            CreatedBy
                        )
                        values 
                        (
                            @InvoiceNumber,
                            @CustomerName,
                            @ItemQuantity, 
                            @ItemName,
                            @PartNumber,
                            @CustomerNumber,
                            @ItemNetWeight,
                            @ItemGrossWeight,
                            @ItemPrice,
                            @ItemHScode,
                            @ItemCOO,
                            @ContainerName,
                            @ContainersQuantity,
                            @ContainerCode,
                            @ContainerNetWeight,
                            @ContainerGrossWeight,
                            @ContainerPrice,
                            @ContainerHSCode,
                            @ContainerCOO,
                            @PartsPerContainer,
                            @ContainersPerPallet,
                            @PalletsQuantity,
                            @RequiresPackaging,
                            @RequiresLid,
                            @RequiresPallet,
                            @CreatedDate,
                            @CreatedBy
                        )", item);
            }
        }

        public static List<string> GetHighestInvoiceNumber()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query("select InvoiceNumber from Invoices", new DynamicParameters());

                List<string> invoices = new List<string>();
                foreach (var item in output)
                {
                    invoices.Add(item.InvoiceNumber.ToString());
                }

                return invoices;
            }
        }

        public static void CreateInvoice(InvoiceModel model)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute(@"insert into Invoices 
                        (
                            InvoiceNumber,
                            CMRnumber,
                            Created, 
                            Creator
                        )
                        values 
                        (
                            @InvoiceNumber,
                            @InvoiceNumber,
                            @Created,
                            @Creator
                        )", model);
            }
        }

        public static void SaveNewItem(ItemModel item)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute(@"insert into ItemsTable 
                        (
                            Customer,
                            ItemName,
                            PartNumber, 
                            CustomerNumber,
                            ItemNetWeight,
                            ItemPrice,
                            ItemHScode,
                            ItemCOO,
                            ContainerName,
                            ContainerNetWeight,
                            ContainerPrice,
                            ContainerHScode,
                            ContainerCOO,
                            PartsPerContainer,
                            Cpp,
                            CreatedBy,
                            CreatedDate,
                            RequiresPackaging,
                            RequiresLid,
                            RequiresPallet,
                            ContainerCode
                        )
                        values 
                        (
                            @ItemCustomer,
                            @ItemName,
                            @PartNumber,
                            @CustomerNumber,
                            @ItemNetWeight,
                            @ItemPrice,
                            @ItemHScode,
                            @ItemCOO,
                            @ContainerName,
                            @ContainerNetWeight,
                            @ContainerPrice,
                            @ContainerHSCode,
                            @ContainerCOO,
                            @PartsPerContainer,
                            @ContainersPerPallet,
                            @CreatedBy,
                            @CreatedDate,
                            @RequiresPackaging,
                            @RequiresLid,
                            @RequiresPallet,
                            @ContainerCode
                        )", item);
            }
        }



        public static void SaveNewCustomer(CustomerModel customer)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(@"insert into Customers 
                    (
                        CustomerName,
                        CustomerAddressLine1,
                        CustomerAddressLine2,
                        CustomerAddressLine3,
                        CustomerPhone,
                        CustomerCity,
                        CustomerCountry,
                        CustomerZipCode,
                        CustomerVAT,
                        CustomerEORI,
                        CustomerUKExitCode,
                        CustomerFinalCustomsCode,
                        CustomerFootNote,
                        CustomerContactPerson,
                        SAPnumber,
                        Haulier, 
                        Incoterms,
                        Currency
                    )   
                    values 
                    (
                        @CustomerName,
                        @CustomerAddressLine1,
                        @CustomerAddressLine2,
                        @CustomerAddressLine3,
                        @CustomerPhone,
                        @CustomerCity,
                        @CustomerCountry,
                        @CustomerZipCode,
                        @CustomerVAT,
                        @CustomerEORI,
                        @CustomerUKExitCode,
                        @CustomerFinalCustomsCode,
                        @CustomerFootNote,
                        @CustomerContactPerson,
                        @SAPnumber,
                        @Haulier,
                        @Incoterms,
                        @Currency
                    )
                    ", customer);
            }
        }

        public static void UpdateCustomer(CustomerModel customer)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(@"update Customers 
                    SET
                        CustomerAddressLine1=@CustomerAddressLine1,
                        CustomerAddressLine2=@CustomerAddressLine2,
                        CustomerAddressLine3=@CustomerAddressLine3,
                        CustomerPhone=@CustomerPhone,
                        CustomerCity=@CustomerCity,
                        CustomerCountry=@CustomerCountry,
                        CustomerZipCode=@CustomerZipCode,
                        CustomerVAT=@CustomerVAT,
                        CustomerEORI=@CustomerEORI,
                        CustomerUKExitCode=@CustomerUKExitCode,
                        CustomerFinalCustomsCode=@CustomerFinalCustomsCode,
                        CustomerFootNote=@CustomerFootNote,
                        CustomerContactPerson=@CustomerContactPerson,
                        SAPnumber=@SAPnumber,
                        Haulier=@Haulier,
                        Incoterms=@Incoterms,
                        Currency=@Currency
                    WHERE
                        CustomerName=@CustomerName
                    ", customer);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }   
    }
}
