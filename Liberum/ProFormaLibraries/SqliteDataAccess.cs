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
        public static void RemoveItemFromInvoice(InvoiceItem item)
        {
            if (item != null)
            {
                var recordId = item.Id;

                using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        // Specify the SQL query with a parameter for the item ID
                        command.CommandText = "DELETE FROM InvoiceItems WHERE Id = @id";
                        command.Parameters.AddWithValue("@id", recordId);

                        // Execute the command
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public static List<InvoiceItem> PopulateItems(int invoice)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
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
                        item.Id = Convert.ToInt32(reader["Id"]);
                        item.InvoiceNumber = reader["InvoiceNumber"].ToString();
                        item.CustomerName = reader["CustomerName"].ToString();
                        item.ItemQuantity = Convert.ToInt32(reader["ItemQuantity"]);
                        item.ItemName = reader["ItemName"].ToString();
                        item.PartNumber = reader["PartNumber"].ToString();
                        item.CustomerNumber = reader["CustomerNumber"].ToString();
                        item.ItemNetWeight = Convert.ToDouble(reader["ItemNetWeight"]);
                        item.ItemGrossWeight = Convert.ToDouble(reader["ItemGrossWeight"]);
                        item.ItemPrice = Convert.ToDouble(reader["ItemPrice"]);
                        item.ItemHScode = Convert.ToInt64(reader["ItemHScode"]);
                        item.ItemCOO = reader["ItemCOO"].ToString();
                        item.ContainerName = reader["ContainerName"].ToString();
                        item.ContainersQuantity = Convert.ToInt32(reader["ContainersQuantity"]);
                        item.ContainerCode = reader["ContainerCode"].ToString();
                        item.ContainerNetWeight = Convert.ToDouble(reader["ContainerNetWeight"]);
                        item.ContainerGrossWeight = Convert.ToDouble(reader["ContainerGrossWeight"]);
                        item.ContainerPrice =  Convert.ToDouble(reader["ContainerPrice"]);
                        item.ContainerHSCode = Convert.ToInt64(reader["ContainerHSCode"]);
                        item.ContainerCOO = reader["ContainerCOO"].ToString();
                        item.PartsPerContainer = Convert.ToInt32(reader["PartsPerContainer"]);
                        item.ContainersPerPallet = Convert.ToInt32(reader["ContainersPerPallet"]);
                        item.PalletsQuantity = Convert.ToInt32(reader["PalletsQuantity"]);
                        item.RequiresPackaging = Convert.ToInt32(reader["RequiresPackaging"]);
                        item.RequiresLid = Convert.ToInt32(reader["RequiresLid"]);
                        item.RequiresPallet = Convert.ToInt32(reader["RequiresPallet"]);
                        item.CreatedDate = reader["CreatedDate"].ToString();

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
        }

        public static List<CustomerModel> FetchCustomerInfo()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CustomerModel>("SELECT * FROM Customers ORDER BY CustomerName ASC").ToList();
                return output;
            }
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

        public static InvoiceModel SelectInvoiceData(string InvoiceNumber)
        {
            string connectionString = LoadConnectionString();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Invoices WHERE InvoiceNumber = @InvoiceNumber";
                    command.Parameters.AddWithValue("@InvoiceNumber", InvoiceNumber);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string invoiceNumber = reader.GetString(reader.GetOrdinal("InvoiceNumber"));
                            string poNumber = reader.GetString(reader.GetOrdinal("PONumber"));
                            string kanbanNumber = reader.GetString(reader.GetOrdinal("KanbanNumber"));
                            string created = reader.GetString(reader.GetOrdinal("Created"));

                            return new InvoiceModel
                            {
                                InvoiceNumber = invoiceNumber,
                                ReferenceNumber = poNumber,
                                KanbanNumber = kanbanNumber,
                                Created = created
                            };
                        }
                    }
                }
            }

            return null; // in case of no results
        }

        public static InvoiceModel SelectInvoiceData_Dapper(string InvoiceNumber)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@InvoiceNumber", InvoiceNumber);

                var output = cnn.Query<InvoiceModel>("SELECT id, * FROM Invoices WHERE InvoiceNumber = @InvoiceNumber", parameters).FirstOrDefault();
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

        public static List<string> LoadInvoiceType()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<string>("select InvoiceType from InvoiceType", new DynamicParameters());
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
                var output = cnn.Query<CustomerModel>("select id,* from Customers ORDER BY CustomerName ASC", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void AddInvoiceItem(InvoiceItem item)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
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
                cmd.Parameters.Add(new SQLiteParameter("@ItemQuantity", item.ItemQuantity));
                cmd.Parameters.Add(new SQLiteParameter("@ItemName", item.ItemName));
                cmd.Parameters.Add(new SQLiteParameter("@PartNumber", item.PartNumber));
                cmd.Parameters.Add(new SQLiteParameter("@CustomerNumber", item.CustomerNumber));
                cmd.Parameters.Add(new SQLiteParameter("@ItemNetWeight", item.ItemNetWeight));
                cmd.Parameters.Add(new SQLiteParameter("@ItemGrossWeight", item.ItemGrossWeight));
                cmd.Parameters.Add(new SQLiteParameter("@ItemPrice", item.ItemPrice));
                cmd.Parameters.Add(new SQLiteParameter("@ItemHScode", item.ItemHScode));
                cmd.Parameters.Add(new SQLiteParameter("@ItemCOO", item.ItemCOO));
                cmd.Parameters.Add(new SQLiteParameter("@ContainerName", item.ContainerName));
                cmd.Parameters.Add(new SQLiteParameter("@ContainersQuantity", item.ContainersQuantity));
                cmd.Parameters.Add(new SQLiteParameter("@ContainerCode", item.ContainerCode));
                cmd.Parameters.Add(new SQLiteParameter("@ContainerNetWeight", item.ContainerNetWeight));
                cmd.Parameters.Add(new SQLiteParameter("@ContainerGrossWeight", item.ContainerNetWeight));
                cmd.Parameters.Add(new SQLiteParameter("@ContainerPrice", item.ContainerPrice));
                cmd.Parameters.Add(new SQLiteParameter("@ContainerHSCode", item.ContainerHSCode));
                cmd.Parameters.Add(new SQLiteParameter("@ContainerCOO", item.ContainerCOO));
                cmd.Parameters.Add(new SQLiteParameter("@PartsPerContainer", item.PartsPerContainer));
                cmd.Parameters.Add(new SQLiteParameter("@ContainersPerPallet", item.ContainersPerPallet));
                cmd.Parameters.Add(new SQLiteParameter("@PalletsQuantity", item.PalletsQuantity));
                cmd.Parameters.Add(new SQLiteParameter("@RequiresPackaging", item.RequiresPackaging));
                cmd.Parameters.Add(new SQLiteParameter("@RequiresLid", item.RequiresLid));
                cmd.Parameters.Add(new SQLiteParameter("@RequiresPallet", item.RequiresPallet));
                cmd.Parameters.Add(new SQLiteParameter("@CreatedDate", item.CreatedDate));
                cmd.Parameters.Add(new SQLiteParameter("@CreatedBy", Environment.UserName)); 

                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        // original method which started throuwing tantrum at some point. FFS
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
                            Creator, 
                            KanbanNumber, 
                            PONumber
                        )
                        values 
                        (
                            @InvoiceNumber,
                            @InvoiceNumber,
                            @Created,
                            @Creator,
                            @KanbanNumber,
                            @ReferenceNumber
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
