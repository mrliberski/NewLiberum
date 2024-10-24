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
using DocumentFormat.OpenXml.Spreadsheet;

namespace ProFormaLibraries
{
    public class SqliteDataAccess
    {
        public static void Insertdiscrepancy(PackagingTrackerItem item)
        {
            try
            {
                using (var connection = new SQLiteConnection(LoadConnectionString()))
                {
                    connection.Open();
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = @"insert into Discrepancies
                        (
                            Date,
                            DeliveryDate,
                            User, 
                            Registration, 
                            DeliveryNumber,
                            PackagingCode, 
                            AdvisedQty, 
                            ReceivedQty, 
                            Comment
                        )
                        values 
                        (
                            @Date,
                            @DeliveryDate,
                            @User, 
                            @Registration, 
                            @DeliveryNumber,
                            @PackagingCode, 
                            @AdvisedQty, 
                            @ReceivedQty, 
                            @Comment
                        )";
                    cmd.Parameters.Add(new SQLiteParameter("@Date", DateTime.Now.ToString()));
                    cmd.Parameters.Add(new SQLiteParameter("@DeliveryDate", item.DeliveryDate));
                    cmd.Parameters.Add(new SQLiteParameter("@User", Environment.UserName));
                    cmd.Parameters.Add(new SQLiteParameter("@Registration", item.RegNumber));
                    cmd.Parameters.Add(new SQLiteParameter("@DeliveryNumber", item.DeliveryNumber));
                    cmd.Parameters.Add(new SQLiteParameter("@PackagingCode", item.PackagingCode));
                    cmd.Parameters.Add(new SQLiteParameter("@AdvisedQty", item.AdvisedQty));
                    cmd.Parameters.Add(new SQLiteParameter("@ReceivedQty", item.ReceivedQty));
                    cmd.Parameters.Add(new SQLiteParameter("@Comment", item.Comment));

                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "damn");
            }
        }

        public static void SubmitBug(string Message)
        {
            try
            {
                using (var connection = new SQLiteConnection(LoadConnectionString()))
                {
                    connection.Open();
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = @"insert into Bugs 
                        (
                            Date,
                            Message
                        )
                        values 
                        (
                            @Date,
                            @Message
                        )";
                    cmd.Parameters.Add(new SQLiteParameter("@Date", DateTime.Now.ToString()));
                    cmd.Parameters.Add(new SQLiteParameter("@Message", Message));

                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message, "damn");
            }
        }

        // Inserts visitor for stats
        public static void InsertVisit()
        {
            try 
            {
                using (var connection = new SQLiteConnection(LoadConnectionString()))
                {
                    connection.Open();
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = @"insert into Visits 
                        (
                            Visitor,
                            VisitTime
                        )
                        values 
                        (
                            @Visitor,
                            @VisitTime
                        )";
                    cmd.Parameters.Add(new SQLiteParameter("@Visitor", Environment.UserName));
                    cmd.Parameters.Add(new SQLiteParameter("@VisitTime", DateTime.Now.ToString()));


                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e) 
            { 
                Console.WriteLine(e.ToString());
            }
        }

        public static string GetLastSubmittedUserName()
        {
            //checks who was the last person submitting handover
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<string>("select UserName from HandoverSubmissionStamp WHERE Id=1").FirstOrDefault();
                return output;
            }
        }

        public static string GetWhenLastHandoverWasSubmitted()
        {
            //checks when last handover was submitted
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<string>("select TimeSubmitted from HandoverSubmissionStamp WHERE Id=1").FirstOrDefault();
                return output;
            }
        }

        public static List<string> GetShifts()
        {
            //Populates list of available shifts for handover
            List<string> Shift = new List<string>();

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                Shift = cnn.Query<string>("SELECT ShitName FROM Shifts").ToList();
            }

            return Shift;
        }


        public static int CheckHandoverVersion()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<string>("select HandoverNumber from CurrentHandover WHERE Id=1").FirstOrDefault();
                if (output != null)
                {
                    return int.Parse(output);
                }
                else
 { return 0; }
            }
        }

        public static CurrentHandoverModel FetchCurrentState()
        {
            string connectionString = LoadConnectionString();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "select * from CurrentHandover WHERE Id = 1";

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //string _HandoverDate = reader.GetString(reader.GetOrdinal("HandoverDate"));
                            string _Shift = reader.GetString(reader.GetOrdinal("Shift"));
                            string _HealthAndSafety = reader.GetString(reader.GetOrdinal("HealthAndSafety"));
                            string _EquipmentIssues = reader.GetString(reader.GetOrdinal("EquipmentIssues"));
                            string _AssemblyLines = reader.GetString(reader.GetOrdinal("AssemblyLines"));
                            string _MouldShop = reader.GetString(reader.GetOrdinal("MouldShop"));
                            string _HangOnParts = reader.GetString(reader.GetOrdinal("HangOnParts"));
                            string _Warehouse = reader.GetString(reader.GetOrdinal("Warehouse"));
                            string _AOB = reader.GetString(reader.GetOrdinal("AOB"));

                            string _DespatchPlan1 = reader.GetString(reader.GetOrdinal("DespatchPlan1"));
                            string _Arrival1 = reader.GetString(reader.GetOrdinal("Arrival1"));
                            string _Departure1 = reader.GetString(reader.GetOrdinal("Departure1"));
                            string _FirstSeq1 = reader.GetString(reader.GetOrdinal("FirstSeq1"));
                            string _LastSeq1 = reader.GetString(reader.GetOrdinal("LastSeq1"));
                            string _RegNumber1 = reader.GetString(reader.GetOrdinal("RegNumber1"));
                            string _ToPlan1 = reader.GetString(reader.GetOrdinal("ToPlan1"));
                            string _Comment1 = reader.GetString(reader.GetOrdinal("Comment1"));


                            string _DespatchPlan2 = reader.GetString(reader.GetOrdinal("DespatchPlan2"));
                            string _Arrival2 = reader.GetString(reader.GetOrdinal("Arrival2"));
                            string _Departure2 = reader.GetString(reader.GetOrdinal("Departure2"));
                            string _FirstSeq2 = reader.GetString(reader.GetOrdinal("FirstSeq2"));
                            string _LastSeq2 = reader.GetString(reader.GetOrdinal("LastSeq2"));
                            string _RegNumber2 = reader.GetString(reader.GetOrdinal("RegNumber2"));
                            string _ToPlan2 = reader.GetString(reader.GetOrdinal("ToPlan2"));
                            string _Comment2 = reader.GetString(reader.GetOrdinal("Comment2"));

                            string _DespatchPlan3 = reader.GetString(reader.GetOrdinal("DespatchPlan3"));
                            string _Arrival3 = reader.GetString(reader.GetOrdinal("Arrival3"));
                            string _Departure3 = reader.GetString(reader.GetOrdinal("Departure3"));
                            string _FirstSeq3 = reader.GetString(reader.GetOrdinal("FirstSeq3"));
                            string _LastSeq3 = reader.GetString(reader.GetOrdinal("LastSeq3"));
                            string _RegNumber3 = reader.GetString(reader.GetOrdinal("RegNumber3"));
                            string _ToPlan3 = reader.GetString(reader.GetOrdinal("ToPlan3"));
                            string _Comment3 = reader.GetString(reader.GetOrdinal("Comment3"));

                            string _DespatchPlan4 = reader.GetString(reader.GetOrdinal("DespatchPlan4"));
                            string _Arrival4 = reader.GetString(reader.GetOrdinal("Arrival4"));
                            string _Departure4 = reader.GetString(reader.GetOrdinal("Departure4"));
                            string _FirstSeq4 = reader.GetString(reader.GetOrdinal("FirstSeq4"));
                            string _LastSeq4 = reader.GetString(reader.GetOrdinal("LastSeq4"));
                            string _RegNumber4 = reader.GetString(reader.GetOrdinal("RegNumber4"));
                            string _ToPlan4 = reader.GetString(reader.GetOrdinal("ToPlan4"));
                            string _Comment4 = reader.GetString(reader.GetOrdinal("Comment4"));


                            string _DespatchPlan5 = reader.GetString(reader.GetOrdinal("DespatchPlan5"));
                            string _Arrival5 = reader.GetString(reader.GetOrdinal("Arrival5"));
                            string _Departure5 = reader.GetString(reader.GetOrdinal("Departure5"));
                            string _FirstSeq5 = reader.GetString(reader.GetOrdinal("FirstSeq5"));
                            string _LastSeq5 = reader.GetString(reader.GetOrdinal("LastSeq5"));
                            string _RegNumber5 = reader.GetString(reader.GetOrdinal("RegNumber5"));
                            string _ToPlan5 = reader.GetString(reader.GetOrdinal("ToPlan5"));
                            string _Comment5 = reader.GetString(reader.GetOrdinal("Comment5"));

                            string _DespatchPlan6 = reader.GetString(reader.GetOrdinal("DespatchPlan6"));
                            string _Arrival6 = reader.GetString(reader.GetOrdinal("Arrival6"));
                            string _Departure6 = reader.GetString(reader.GetOrdinal("Departure6"));
                            string _FirstSeq6 = reader.GetString(reader.GetOrdinal("FirstSeq6"));
                            string _LastSeq6 = reader.GetString(reader.GetOrdinal("LastSeq6"));
                            string _RegNumber6 = reader.GetString(reader.GetOrdinal("RegNumber6"));
                            string _ToPlan6 = reader.GetString(reader.GetOrdinal("ToPlan6"));
                            string _Comment6 = reader.GetString(reader.GetOrdinal("Comment6"));

                            string _DespatchPlan7 = reader.GetString(reader.GetOrdinal("DespatchPlan7"));
                            string _Arrival7 = reader.GetString(reader.GetOrdinal("Arrival7"));
                            string _Departure7 = reader.GetString(reader.GetOrdinal("Departure7"));
                            string _FirstSeq7 = reader.GetString(reader.GetOrdinal("FirstSeq7"));
                            string _LastSeq7 = reader.GetString(reader.GetOrdinal("LastSeq7"));
                            string _RegNumber7 = reader.GetString(reader.GetOrdinal("RegNumber7"));
                            string _ToPlan7 = reader.GetString(reader.GetOrdinal("ToPlan7"));
                            string _Comment7 = reader.GetString(reader.GetOrdinal("Comment7"));

                            string _DespatchPlan8 = reader.GetString(reader.GetOrdinal("DespatchPlan8"));
                            string _Arrival8 = reader.GetString(reader.GetOrdinal("Arrival8"));
                            string _Departure8 = reader.GetString(reader.GetOrdinal("Departure8"));
                            string _FirstSeq8 = reader.GetString(reader.GetOrdinal("FirstSeq8"));
                            string _LastSeq8 = reader.GetString(reader.GetOrdinal("LastSeq8"));
                            string _RegNumber8 = reader.GetString(reader.GetOrdinal("RegNumber8"));
                            string _ToPlan8 = reader.GetString(reader.GetOrdinal("ToPlan8"));
                            string _Comment8 = reader.GetString(reader.GetOrdinal("Comment8"));

                            int _HandoverVersion = int.Parse(reader.GetString(reader.GetOrdinal("HandoverNumber")));

                            //DespatchPlan9,
                            //Arrival9,
                            //Departure9,
                            //FirstSeq9,
                            //LastSeq9,
                            //RegNumber9,
                            //ToPlan9,
                            //Comment9,
                            //DespatchPlan10,
                            //Arrival10,
                            //Departure10,
                            //FirstSeq10,
                            //LastSeq10,
                            //RegNumber10,
                            //ToPlan10,
                            //Comment10,

                            //string _SubmittedDate = reader.GetString(reader.GetOrdinal("SubmittedDate"));
                            //string _CreatedBy = reader.GetString(reader.GetOrdinal("CreatedBy"));

                            return new CurrentHandoverModel
                            {
                                //HandoverDate = _HandoverDate,
                                Shift = _Shift,
                                HealthAndSafety = _HealthAndSafety,
                                EquipmentIssues = _EquipmentIssues,
                                AssemblyLines = _AssemblyLines,
                                MouldShop = _MouldShop,
                                HangOnParts = _HangOnParts,
                                Warehouse = _Warehouse,
                                AOB = _AOB,

                                DespatchPlan1 = _DespatchPlan1,
                                Arrival1 = _Arrival1,
                                Departure1 = _Departure1,
                                FirstSeq1 = _FirstSeq1,
                                LastSeq1 = _LastSeq1,
                                RegNumber1 = _RegNumber1,
                                ToPlan1 = _ToPlan1,
                                Comment1 = _Comment1,

                                DespatchPlan2 = _DespatchPlan2,
                                Arrival2 = _Arrival2,
                                Departure2 = _Departure2,
                                FirstSeq2 = _FirstSeq2,
                                LastSeq2 = _LastSeq2,
                                RegNumber2 = _RegNumber2,
                                ToPlan2 = _ToPlan2,
                                Comment2 = _Comment2,

                                DespatchPlan3 = _DespatchPlan3,
                                Arrival3 = _Arrival3,
                                Departure3 = _Departure3,
                                FirstSeq3 = _FirstSeq3,
                                LastSeq3 = _LastSeq3,
                                RegNumber3 = _RegNumber3,
                                ToPlan3 = _ToPlan3,
                                Comment3 = _Comment3,

                                DespatchPlan4 = _DespatchPlan4,
                                Arrival4 = _Arrival4,
                                Departure4 = _Departure4,
                                FirstSeq4 = _FirstSeq4,
                                LastSeq4 = _LastSeq4,
                                RegNumber4 = _RegNumber4,
                                ToPlan4 = _ToPlan4,
                                Comment4 = _Comment4,

                                DespatchPlan5 = _DespatchPlan5,
                                Arrival5 = _Arrival5,
                                Departure5 = _Departure5,
                                FirstSeq5 = _FirstSeq5,
                                LastSeq5 = _LastSeq5,
                                RegNumber5 = _RegNumber5,
                                ToPlan5 = _ToPlan5,
                                Comment5 = _Comment5,

                                DespatchPlan6 = _DespatchPlan6,
                                Arrival6 = _Arrival6,
                                Departure6 = _Departure6,
                                FirstSeq6 = _FirstSeq6,
                                LastSeq6 = _LastSeq6,
                                RegNumber6 = _RegNumber6,
                                ToPlan6 = _ToPlan6,
                                Comment6 = _Comment6,

                                DespatchPlan7 = _DespatchPlan7,
                                Arrival7 = _Arrival7,
                                Departure7 = _Departure7,
                                FirstSeq7 = _FirstSeq7,
                                LastSeq7 = _LastSeq7,
                                RegNumber7 = _RegNumber7,
                                ToPlan7 = _ToPlan7,
                                Comment7 = _Comment7,

                                DespatchPlan8 = _DespatchPlan8,
                                Arrival8 = _Arrival8,
                                Departure8 = _Departure8,
                                FirstSeq8 = _FirstSeq8,
                                LastSeq8 = _LastSeq8,
                                RegNumber8 = _RegNumber8,
                                ToPlan8 = _ToPlan8,
                                Comment8 = _Comment8,

                                HandoverNumber = _HandoverVersion

                                //DespatchPlan9 = _,
                                //Arrival9 = _,
                                //Departure9 = _,
                                //FirstSeq9 = _,
                                //LastSeq9 = _,
                                //RegNumber9 = _,
                                //ToPlan9 = _,
                                //Comment9 = _,
                                //DespatchPlan10 = _,
                                //Arrival10 = _,
                                //Departure10 = _,
                                //FirstSeq10 = _,
                                //LastSeq10 = _,
                                //RegNumber10 = _,
                                //ToPlan10 = _,
                                //Comment10 = _
                                //SubmittedDate = _SubmittedDate
                                //CreatedBy = _CreatedBy

                            };
                        }
                    }
                }
            }

            return null; // in case of no results
        }

        /// <summary>
        /// Inserts record into current handover state table
        /// </summary>
        /// <param name="CurrentHandover">current state of handover</param>
        public static void InsertCurrentHandover(CurrentHandoverModel CurrentHandover)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(@"update CurrentHandover SET 

                            HandoverDate=@HandoverDate,
                            Shift=@Shift,
                            HealthAndSafety=@HealthAndSafety,
                            EquipmentIssues=@EquipmentIssues,
                            AssemblyLines=@AssemblyLines,
                            MouldShop=@MouldShop,
                            HangOnParts=@HangOnParts,
                            Warehouse=@Warehouse,
                            AOB=@AOB,
                            DespatchPlan1=@DespatchPlan1,
                            Arrival1=@Arrival1,
                            Departure1=@Departure1,
                            FirstSeq1=@FirstSeq1,
                            LastSeq1=@LastSeq1,
                            RegNumber1=@RegNumber1,
                            ToPlan1=@ToPlan1,
                            Comment1=@Comment1,
                            DespatchPlan2=@DespatchPlan2,
                            Arrival2=@Arrival2,
                            Departure2=@Departure2,
                            FirstSeq2=@FirstSeq2,
                            LastSeq2=@LastSeq2,
                            RegNumber2=@RegNumber2,
                            ToPlan2=@ToPlan2,
                            Comment2=@Comment2,
                            DespatchPlan3=@DespatchPlan3,
                            Arrival3=@Arrival3,
                            Departure3=@Departure3,
                            FirstSeq3=@FirstSeq3,
                            LastSeq3=@LastSeq3,
                            RegNumber3=@RegNumber3,
                            ToPlan3=@ToPlan3,
                            Comment3=@Comment3,
                            DespatchPlan4=@DespatchPlan4,
                            Arrival4=@Arrival4,
                            Departure4=@Departure4,
                            FirstSeq4=@FirstSeq4,
                            LastSeq4=@LastSeq4,
                            RegNumber4=@RegNumber4,
                            ToPlan4=@ToPlan4,
                            Comment4=@Comment4,
                            DespatchPlan5=@DespatchPlan5,
                            Arrival5=@Arrival5,
                            Departure5=@Departure5,
                            FirstSeq5=@FirstSeq5,
                            LastSeq5=@LastSeq5,
                            RegNumber5=@RegNumber5,
                            ToPlan5=@ToPlan5,
                            Comment5=@Comment5,
                            DespatchPlan6=@DespatchPlan6,
                            Arrival6=@Arrival6,
                            Departure6=@Departure6,
                            FirstSeq6=@FirstSeq6,
                            LastSeq6=@LastSeq6,
                            RegNumber6=@RegNumber6,
                            ToPlan6=@ToPlan6,
                            Comment6=@Comment6,
                            DespatchPlan7=@DespatchPlan7,
                            Arrival7=@Arrival7,
                            Departure7=@Departure7,
                            FirstSeq7=@FirstSeq7,
                            LastSeq7=@LastSeq7,
                            RegNumber7=@RegNumber7,
                            ToPlan7=@ToPlan7,
                            Comment7=@Comment7,
                            DespatchPlan8=@DespatchPlan8,
                            Arrival8=@Arrival8,
                            Departure8=@Departure8,
                            FirstSeq8=@FirstSeq8,
                            LastSeq8=@LastSeq8,
                            RegNumber8=@RegNumber8,
                            ToPlan8=@ToPlan8,
                            Comment8=@Comment8,
                            SubmittedDate=@SubmittedDate,
                            CreatedBy=@CreatedBy, 
                            HandoverNumber = @HandoverNumber

                            WHERE

                            Id = 1
                        ", new
                {

                    HandoverDate = CurrentHandover.HandoverDate,
                    Shift = CurrentHandover.Shift,
                    HealthAndSafety = CurrentHandover.HealthAndSafety,
                    EquipmentIssues = CurrentHandover.EquipmentIssues,
                    AssemblyLines = CurrentHandover.AssemblyLines,
                    MouldShop = CurrentHandover.MouldShop,
                    HangOnParts = CurrentHandover.HangOnParts,
                    Warehouse = CurrentHandover.Warehouse,
                    AOB = CurrentHandover.AOB,
                    DespatchPlan1 = CurrentHandover.DespatchPlan1,
                    Arrival1 = CurrentHandover.Arrival1,
                    Departure1 = CurrentHandover.Departure1,
                    FirstSeq1 = CurrentHandover.FirstSeq1,
                    LastSeq1 = CurrentHandover.LastSeq1,
                    RegNumber1 = CurrentHandover.RegNumber1,
                    ToPlan1 = CurrentHandover.ToPlan1,
                    Comment1 = CurrentHandover.Comment1,
                    DespatchPlan2 = CurrentHandover.DespatchPlan2,
                    Arrival2 = CurrentHandover.Arrival2,
                    Departure2 = CurrentHandover.Departure2,
                    FirstSeq2 = CurrentHandover.FirstSeq2,
                    LastSeq2 = CurrentHandover.LastSeq2,
                    RegNumber2 = CurrentHandover.RegNumber2,
                    ToPlan2 = CurrentHandover.ToPlan2,
                    Comment2 = CurrentHandover.Comment2,
                    DespatchPlan3 = CurrentHandover.DespatchPlan3,
                    Arrival3 = CurrentHandover.Arrival3,
                    Departure3 = CurrentHandover.Departure3,
                    FirstSeq3 = CurrentHandover.FirstSeq3,
                    LastSeq3 = CurrentHandover.LastSeq3,
                    RegNumber3 = CurrentHandover.RegNumber3,
                    ToPlan3 = CurrentHandover.ToPlan3,
                    Comment3 = CurrentHandover.Comment3,
                    DespatchPlan4 = CurrentHandover.DespatchPlan4,
                    Arrival4 = CurrentHandover.Arrival4,
                    Departure4 = CurrentHandover.Departure4,
                    FirstSeq4 = CurrentHandover.FirstSeq4,
                    LastSeq4 = CurrentHandover.LastSeq4,
                    RegNumber4 = CurrentHandover.RegNumber4,
                    ToPlan4 = CurrentHandover.ToPlan4,
                    Comment4 = CurrentHandover.Comment4,
                    DespatchPlan5 = CurrentHandover.DespatchPlan5,
                    Arrival5 = CurrentHandover.Arrival5,
                    Departure5 = CurrentHandover.Departure5,
                    FirstSeq5 = CurrentHandover.FirstSeq5,
                    LastSeq5 = CurrentHandover.LastSeq5,
                    RegNumber5 = CurrentHandover.RegNumber5,
                    ToPlan5 = CurrentHandover.ToPlan5,
                    Comment5 = CurrentHandover.Comment5,
                    DespatchPlan6 = CurrentHandover.DespatchPlan6,
                    Arrival6 = CurrentHandover.Arrival6,
                    Departure6 = CurrentHandover.Departure6,
                    FirstSeq6 = CurrentHandover.FirstSeq6,
                    LastSeq6 = CurrentHandover.LastSeq6,
                    RegNumber6 = CurrentHandover.RegNumber6,
                    ToPlan6 = CurrentHandover.ToPlan6,
                    Comment6 = CurrentHandover.Comment6,
                    DespatchPlan7 = CurrentHandover.DespatchPlan7,
                    Arrival7 = CurrentHandover.Arrival7,
                    Departure7 = CurrentHandover.Departure7,
                    FirstSeq7 = CurrentHandover.FirstSeq7,
                    LastSeq7 = CurrentHandover.LastSeq7,
                    RegNumber7 = CurrentHandover.RegNumber7,
                    ToPlan7 = CurrentHandover.ToPlan7,
                    Comment7 = CurrentHandover.Comment7,
                    DespatchPlan8 = CurrentHandover.DespatchPlan8,
                    Arrival8 = CurrentHandover.Arrival8,
                    Departure8 = CurrentHandover.Departure8,
                    FirstSeq8 = CurrentHandover.LastSeq8,
                    LastSeq8 = CurrentHandover.LastSeq8,
                    RegNumber8 = CurrentHandover.RegNumber8,
                    ToPlan8 = CurrentHandover.ToPlan8,
                    Comment8 = CurrentHandover.Comment8,
                    SubmittedDate = CurrentHandover.SubmittedDate,
                    CreatedBy = Environment.UserName,
                    HandoverNumber = CurrentHandover.HandoverNumber

                });
            }
                
        }

        public static void InsertHandoverArchive(CurrentHandoverModel CurrentHandover)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                //START
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = @"insert into CurrentHandover 
                        (
                            HandoverDate,
                            Shift,
                            HealthAndSafety,
                            EquipmentIssues,
                            MouldShop,
                            HangOnParts,
                            Warehouse,
                            AOB,
                            DespatchPlan1,
                            Arrival1,
                            Departure1,
                            FirstSeq1,
                            LastSeq1,
                            RegNumber1,
                            ToPlan1,
                            Comment1,
                            DespatchPlan2,
                            Arrival2,
                            Departure2,
                            FirstSeq2,
                            LastSeq2,
                            RegNumber2,
                            ToPlan2,
                            Comment2,
                            DespatchPlan3,
                            Arrival3,
                            Departure3,
                            FirstSeq3,
                            LastSeq3,
                            RegNumber3,
                            ToPlan3,
                            Comment3,
                            DespatchPlan4,
                            Arrival4,
                            Departure4,
                            FirstSeq4,
                            LastSeq4,
                            RegNumber4,
                            ToPlan4,
                            Comment4,
                            DespatchPlan5,
                            Arrival5,
                            Departure5,
                            FirstSeq5,
                            LastSeq5,
                            RegNumber5,
                            ToPlan5,
                            Comment5,
                            DespatchPlan6,
                            Arrival6,
                            Departure6,
                            FirstSeq6,
                            LastSeq6,
                            RegNumber6,
                            ToPlan6,
                            Comment6,
                            DespatchPlan7,
                            Arrival7,
                            Departure7,
                            FirstSeq7,
                            LastSeq7,
                            RegNumber7,
                            ToPlan7,
                            Comment7,
                            DespatchPlan8,
                            Arrival8,
                            Departure8,
                            FirstSeq8,
                            LastSeq8,
                            RegNumber8,
                            ToPlan8,
                            Comment8,
                            DespatchPlan9,
                            Arrival9,
                            Departure9,
                            FirstSeq9,
                            LastSeq9,
                            RegNumber9,
                            ToPlan9,
                            Comment9,
                            DespatchPlan10,
                            Arrival10,
                            Departure10,
                            FirstSeq10,
                            LastSeq10,
                            RegNumber10,
                            ToPlan10,
                            Comment10,
                            SubmittedDate,
                            CreatedBy, 
                            HandoverNumber
                        )
                        values 
                        (
                            @HandoverDate,
                            @Shift,
                            @HealthAndSafety,
                            @EquipmentIssues,
                            @MouldShop,
                            @HangOnParts,
                            @Warehouse,
                            @AOB,
                            @DespatchPlan1,
                            @Arrival1,
                            @Departure1,
                            @FirstSeq1,
                            @LastSeq1,
                            @RegNumber1,
                            @ToPlan1,
                            @Comment1,
                            @DespatchPlan2,
                            @Arrival2,
                            @Departure2,
                            @FirstSeq2,
                            @LastSeq2,
                            @RegNumber2,
                            @ToPlan2,
                            @Comment2,
                            @DespatchPlan3,
                            @Arrival3,
                            @Departure3,
                            @FirstSeq3,
                            @LastSeq3,
                            @RegNumber3,
                            @ToPlan3,
                            @Comment3,
                            @DespatchPlan4,
                            @Arrival4,
                            @Departure4,
                            @FirstSeq4,
                            @LastSeq4,
                            @RegNumber4,
                            @ToPlan4,
                            @Comment4,
                            @DespatchPlan5,
                            @Arrival5,
                            @Departure5,
                            @FirstSeq5,
                            @LastSeq5,
                            @RegNumber5,
                            @ToPlan5,
                            @Comment5,
                            @DespatchPlan6,
                            @Arrival6,
                            @Departure6,
                            @FirstSeq6,
                            @LastSeq6,
                            @RegNumber6,
                            @ToPlan6,
                            @Comment6,
                            @DespatchPlan7,
                            @Arrival7,
                            @Departure7,
                            @FirstSeq7,
                            @LastSeq7,
                            @RegNumber7,
                            @ToPlan7,
                            @Comment7,
                            @DespatchPlan8,
                            @Arrival8,
                            @Departure8,
                            @FirstSeq8,
                            @LastSeq8,
                            @RegNumber8,
                            @ToPlan8,
                            @Comment8,
                            @DespatchPlan9,
                            @Arrival9,
                            @Departure9,
                            @FirstSeq9,
                            @LastSeq9,
                            @RegNumber9,
                            @ToPlan9,
                            @Comment9,
                            @DespatchPlan10,
                            @Arrival10,
                            @Departure10,
                            @FirstSeq10,
                            @LastSeq10,
                            @RegNumber10,
                            @ToPlan10,
                            @Comment10,
                            @SubmittedDate,
                            @CreatedBy, 
                            @HandoverNumber
                        )"
                ;

                cmd.Parameters.Add(new SQLiteParameter("@HandoverDate", CurrentHandover.HandoverDate));
                cmd.Parameters.Add(new SQLiteParameter("@Shift", CurrentHandover.Shift));
                cmd.Parameters.Add(new SQLiteParameter("@HealthAndSafety", CurrentHandover.HealthAndSafety));
                cmd.Parameters.Add(new SQLiteParameter("@EquipmentIssues", CurrentHandover.EquipmentIssues));
                cmd.Parameters.Add(new SQLiteParameter("@MouldShop", CurrentHandover.MouldShop));
                cmd.Parameters.Add(new SQLiteParameter("@HangOnParts", CurrentHandover.HangOnParts));
                cmd.Parameters.Add(new SQLiteParameter("@Warehouse", CurrentHandover.Warehouse));
                cmd.Parameters.Add(new SQLiteParameter("@AOB", CurrentHandover.AOB));

                cmd.Parameters.Add(new SQLiteParameter("@DespatchPlan1", CurrentHandover.DespatchPlan1));
                cmd.Parameters.Add(new SQLiteParameter("@Arrival1", CurrentHandover.Arrival1));
                cmd.Parameters.Add(new SQLiteParameter("@Departure1", CurrentHandover.Departure1));
                cmd.Parameters.Add(new SQLiteParameter("@FirstSeq1", CurrentHandover.FirstSeq1));
                cmd.Parameters.Add(new SQLiteParameter("@LastSeq1", CurrentHandover.LastSeq1));
                cmd.Parameters.Add(new SQLiteParameter("@RegNumber1", CurrentHandover.RegNumber1));
                cmd.Parameters.Add(new SQLiteParameter("@ToPlan1", CurrentHandover.ToPlan1));
                cmd.Parameters.Add(new SQLiteParameter("@Comment1", CurrentHandover.Comment1));

                cmd.Parameters.Add(new SQLiteParameter("@DespatchPlan2", CurrentHandover.DespatchPlan2));
                cmd.Parameters.Add(new SQLiteParameter("@Arrival2", CurrentHandover.Arrival2));
                cmd.Parameters.Add(new SQLiteParameter("@Departure2", CurrentHandover.Departure2));
                cmd.Parameters.Add(new SQLiteParameter("@FirstSeq2", CurrentHandover.FirstSeq2));
                cmd.Parameters.Add(new SQLiteParameter("@LastSeq2", CurrentHandover.LastSeq2));
                cmd.Parameters.Add(new SQLiteParameter("@RegNumber2", CurrentHandover.RegNumber2));
                cmd.Parameters.Add(new SQLiteParameter("@ToPlan2", CurrentHandover.ToPlan2));
                cmd.Parameters.Add(new SQLiteParameter("@Comment2", CurrentHandover.Comment2));

                cmd.Parameters.Add(new SQLiteParameter("@DespatchPlan3", CurrentHandover.DespatchPlan3));
                cmd.Parameters.Add(new SQLiteParameter("@Arrival3", CurrentHandover.Arrival3));
                cmd.Parameters.Add(new SQLiteParameter("@Departure3", CurrentHandover.Departure3));
                cmd.Parameters.Add(new SQLiteParameter("@FirstSeq3", CurrentHandover.FirstSeq3));
                cmd.Parameters.Add(new SQLiteParameter("@LastSeq3", CurrentHandover.LastSeq3));
                cmd.Parameters.Add(new SQLiteParameter("@RegNumber3", CurrentHandover.RegNumber3));
                cmd.Parameters.Add(new SQLiteParameter("@ToPlan3", CurrentHandover.ToPlan3));
                cmd.Parameters.Add(new SQLiteParameter("@Comment3", CurrentHandover.Comment3));

                cmd.Parameters.Add(new SQLiteParameter("@DespatchPlan4", CurrentHandover.DespatchPlan4));
                cmd.Parameters.Add(new SQLiteParameter("@Arrival4", CurrentHandover.Arrival4));
                cmd.Parameters.Add(new SQLiteParameter("@Departure4", CurrentHandover.Departure4));
                cmd.Parameters.Add(new SQLiteParameter("@FirstSeq4", CurrentHandover.FirstSeq4));
                cmd.Parameters.Add(new SQLiteParameter("@LastSeq4", CurrentHandover.LastSeq4));
                cmd.Parameters.Add(new SQLiteParameter("@RegNumber4", CurrentHandover.RegNumber4));
                cmd.Parameters.Add(new SQLiteParameter("@ToPlan4", CurrentHandover.ToPlan4));
                cmd.Parameters.Add(new SQLiteParameter("@Comment4", CurrentHandover.Comment4));

                cmd.Parameters.Add(new SQLiteParameter("@DespatchPlan5", CurrentHandover.DespatchPlan5));
                cmd.Parameters.Add(new SQLiteParameter("@Arrival5", CurrentHandover.Arrival5));
                cmd.Parameters.Add(new SQLiteParameter("@Departure5", CurrentHandover.Departure5));
                cmd.Parameters.Add(new SQLiteParameter("@FirstSeq5", CurrentHandover.FirstSeq5));
                cmd.Parameters.Add(new SQLiteParameter("@LastSeq5", CurrentHandover.LastSeq5));
                cmd.Parameters.Add(new SQLiteParameter("@RegNumber5", CurrentHandover.RegNumber5));
                cmd.Parameters.Add(new SQLiteParameter("@ToPlan5", CurrentHandover.ToPlan5));
                cmd.Parameters.Add(new SQLiteParameter("@Comment5", CurrentHandover.Comment5));

                cmd.Parameters.Add(new SQLiteParameter("@DespatchPlan6", CurrentHandover.DespatchPlan6));
                cmd.Parameters.Add(new SQLiteParameter("@Arrival6", CurrentHandover.Arrival6));
                cmd.Parameters.Add(new SQLiteParameter("@Departure6", CurrentHandover.Departure6));
                cmd.Parameters.Add(new SQLiteParameter("@FirstSeq6", CurrentHandover.FirstSeq6));
                cmd.Parameters.Add(new SQLiteParameter("@LastSeq6", CurrentHandover.LastSeq6));
                cmd.Parameters.Add(new SQLiteParameter("@RegNumber6", CurrentHandover.RegNumber6));
                cmd.Parameters.Add(new SQLiteParameter("@ToPlan6", CurrentHandover.ToPlan6));
                cmd.Parameters.Add(new SQLiteParameter("@Comment6", CurrentHandover.Comment6));

                cmd.Parameters.Add(new SQLiteParameter("@DespatchPlan7", CurrentHandover.DespatchPlan7));
                cmd.Parameters.Add(new SQLiteParameter("@Arrival7", CurrentHandover.Arrival7));
                cmd.Parameters.Add(new SQLiteParameter("@Departure7", CurrentHandover.Departure7));
                cmd.Parameters.Add(new SQLiteParameter("@FirstSeq7", CurrentHandover.FirstSeq7));
                cmd.Parameters.Add(new SQLiteParameter("@LastSeq7", CurrentHandover.LastSeq7));
                cmd.Parameters.Add(new SQLiteParameter("@RegNumber7", CurrentHandover.RegNumber7));
                cmd.Parameters.Add(new SQLiteParameter("@ToPlan7", CurrentHandover.ToPlan7));
                cmd.Parameters.Add(new SQLiteParameter("@Comment7", CurrentHandover.Comment7));

                cmd.Parameters.Add(new SQLiteParameter("@DespatchPlan8", CurrentHandover.DespatchPlan8));
                cmd.Parameters.Add(new SQLiteParameter("@Arrival8", CurrentHandover.Arrival8));
                cmd.Parameters.Add(new SQLiteParameter("@Departure8", CurrentHandover.Departure8));
                cmd.Parameters.Add(new SQLiteParameter("@FirstSeq8", CurrentHandover.FirstSeq8));
                cmd.Parameters.Add(new SQLiteParameter("@LastSeq8", CurrentHandover.LastSeq8));
                cmd.Parameters.Add(new SQLiteParameter("@RegNumber8", CurrentHandover.RegNumber8));
                cmd.Parameters.Add(new SQLiteParameter("@ToPlan8", CurrentHandover.ToPlan8));
                cmd.Parameters.Add(new SQLiteParameter("@Comment8", CurrentHandover.Comment8));

                cmd.Parameters.Add(new SQLiteParameter("@DespatchPlan9", CurrentHandover.DespatchPlan9));
                cmd.Parameters.Add(new SQLiteParameter("@Arrival9", CurrentHandover.Arrival9));
                cmd.Parameters.Add(new SQLiteParameter("@Departure9", CurrentHandover.Departure9));
                cmd.Parameters.Add(new SQLiteParameter("@FirstSeq9", CurrentHandover.FirstSeq9));
                cmd.Parameters.Add(new SQLiteParameter("@LastSeq9", CurrentHandover.LastSeq9));
                cmd.Parameters.Add(new SQLiteParameter("@RegNumber9", CurrentHandover.RegNumber9));
                cmd.Parameters.Add(new SQLiteParameter("@ToPlan9", CurrentHandover.ToPlan9));
                cmd.Parameters.Add(new SQLiteParameter("@Comment9", CurrentHandover.Comment9));

                cmd.Parameters.Add(new SQLiteParameter("@DespatchPlan10", CurrentHandover.DespatchPlan10));
                cmd.Parameters.Add(new SQLiteParameter("@Arrival10", CurrentHandover.Arrival10));
                cmd.Parameters.Add(new SQLiteParameter("@Departure10", CurrentHandover.Departure10));
                cmd.Parameters.Add(new SQLiteParameter("@FirstSeq10", CurrentHandover.FirstSeq10));
                cmd.Parameters.Add(new SQLiteParameter("@LastSeq10", CurrentHandover.LastSeq10));
                cmd.Parameters.Add(new SQLiteParameter("@RegNumber10", CurrentHandover.RegNumber10));
                cmd.Parameters.Add(new SQLiteParameter("@ToPlan10", CurrentHandover.ToPlan10));
                cmd.Parameters.Add(new SQLiteParameter("@Comment10", CurrentHandover.Comment10));
                cmd.Parameters.Add(new SQLiteParameter("@HandoverNumber", CurrentHandover.HandoverNumber));
                cmd.Parameters.Add(new SQLiteParameter("@SubmittedDate", CurrentHandover.SubmittedDate));
                cmd.Parameters.Add(new SQLiteParameter("@CreatedBy", Environment.UserName));

                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static void InsertHandoverSubmissionStamp()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(@"UPDATE HandoverSubmissionStamp SET 
                        UserName = @UserName,
                        TimeSubmitted = @TimeSubmitted
                      WHERE
                        Id = 1",
                            new
                            {
                                UserName = Environment.UserName,
                                TimeSubmitted = DateTime.Now.ToString()
                            });
            }
        }


        public static void UpdateItem(ItemModel model, string OriginalItemName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {


                cnn.Execute(@"update ItemsTable SET 

                            ItemName = @ItemName,
                            PartNumber = @PartNumber,
                            CustomerNumber = @CustomerNumber,
                            ItemNetWeight = @ItemNetWeight,
                            ItemPrice = @ItemPrice,
                            ItemHScode = @ItemHScode,
                            ItemCOO = @ItemCOO,
                            ContainerName = @ContainerName,
                            ContainerNetWeight = @ContainerNetWeight,
                            ContainerPrice = @ContainerPrice,
                            ContainerHScode = @ContainerHSCode,
                            ContainerCOO = @ContainerCOO,
                            PartsPerContainer = @PartsPerContainer,
                            CPP = @ContainersPerPallet,
                            RequiresPackaging = @RequiresPackaging,
                            RequiresLid = @RequiresLid,
                            RequiresPallet = @RequiresPallet,
                            ContainerCode = @ContainerCode
                                WHERE
                            ItemName = @OriginalName
                        ", new 
                { 
                    ItemName = model.ItemName, 
                    PartNumber = model.PartNumber,
                    CustomerNumber = model.CustomerNumber,
                    ItemNetWeight = model.ItemNetWeight,
                    ItemPrice = model.ItemPrice,
                    ItemHScode = model.ItemHScode,
                    ItemCOO = model.ItemCOO,
                    ContainerName = model.ContainerName,
                    ContainerNetWeight = model.ContainerNetWeight,
                    ContainerPrice = model.ContainerPrice,
                    ContainerHSCode = model.ContainerHSCode,
                    ContainerCOO = model.ContainerCOO,
                    PartsPerContainer = model.PartsPerContainer,
                    ContainersPerPallet = model.Cpp,
                    RequiresPackaging = model.RequiresPackaging,
                    RequiresLid = model.RequiresLid,
                    RequiresPallet = model.RequiresPallet,
                    ContainerCode = model.ContainerCode,
                    OriginalName = OriginalItemName 
                });
            }
        }

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


        public static List<ItemModel> LoadItems(string SelectedCustomer)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // did not work ;P var output = cnn.Query<ItemModel>($"select * from ItemsTable where Customer={SelectedCustomer}", new DynamicParameters());
                var output = cnn.Query<ItemModel>($"select id, * from ItemsTable where Customer = @SelectedCustomer ORDER BY ItemName ASC" , new { SelectedCustomer });
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
                            string InvoiceType = reader.GetString(reader.GetOrdinal("InvoiceType"));

                            return new InvoiceModel
                            {
                                InvoiceNumber = invoiceNumber,
                                ReferenceNumber = poNumber,
                                KanbanNumber = kanbanNumber,
                                Created = created,
                                InvoiceType = InvoiceType
                            };
                        }
                    }
                }
            }

            return null; // in case of no results
        }

        public static List<PackagingTrackerItem> PullPackagingTracker()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PackagingTrackerItem>("select * from PackagingTracker ORDER BY Id DESC", new DynamicParameters());
                return output.ToList();
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
                var output = cnn.Query<string>("select InvoiceType from InvoiceTypes", new DynamicParameters());
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

        public static List<string> LoadHandoverRecipients()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<string>("select UserName from HandoverRecipients", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<string> LoadPackagingAlertRecipients()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<string>("select UserName from PackagingAlertRecipients", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<string> LoadPackagingCountRecipients()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<string>("select UserName from PackagingCountRecipients", new DynamicParameters());
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

        public static void InsertPackTrackerItem(PackagingTrackerItem item)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = @"insert into PackagingTracker 
                        (
                            DeliveryDate,
                            DeliveryTime,
                            DeliveryNumber, 
                            PackagingCode,
                            AdvisedQty,
                            ReceivedQty,
                            Comment,
                            EntryDate,
                            EnteredBy,
                            RegNumber
                        )
                        values 
                        (
                            @DeliveryDate,
                            @DeliveryTime,
                            @DeliveryNumber, 
                            @PackagingCode,
                            @AdvisedQty,
                            @ReceivedQty,
                            @Comment,
                            @EntryDate,
                            @CreatedBy,
                            @RegNumber
                        )";
                cmd.Parameters.Add(new SQLiteParameter("@DeliveryDate", item.DeliveryDate));
                cmd.Parameters.Add(new SQLiteParameter("@DeliveryTime", item.DeliveryTime));
                cmd.Parameters.Add(new SQLiteParameter("@DeliveryNumber", item.DeliveryNumber));
                cmd.Parameters.Add(new SQLiteParameter("@PackagingCode", item.PackagingCode));
                cmd.Parameters.Add(new SQLiteParameter("@AdvisedQty", item.AdvisedQty));
                cmd.Parameters.Add(new SQLiteParameter("@ReceivedQty", item.ReceivedQty));
                cmd.Parameters.Add(new SQLiteParameter("@Comment", item.Comment));
                cmd.Parameters.Add(new SQLiteParameter("@EntryDate", item.EntryDate));
                cmd.Parameters.Add(new SQLiteParameter("@CreatedBy", Environment.UserName));
                cmd.Parameters.Add(new SQLiteParameter("@RegNumber", item.RegNumber));

                cmd.ExecuteNonQuery();
                connection.Close();
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

        // Search items in the packaging tracker by delivery number
        public static List<PackagingTrackerItem> SearchByDelivery(string _deliveryQuery)
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@DeliveryNote", "%" + _deliveryQuery + "%");


                var output = cnn.Query<PackagingTrackerItem>("select * from PackagingTracker WHERE DeliveryNumber LIKE @DeliveryNote", parameters);
                return output.ToList();
            }
        }

        // Search items in the packaging tracker by packaging number
        public static List<PackagingTrackerItem> SearchByPackaging(string _deliveryQuery)
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@PackagingCode", "%" + _deliveryQuery + "%");


                var output = cnn.Query<PackagingTrackerItem>("select * from PackagingTracker WHERE PackagingCode LIKE @PackagingCode", parameters);
                return output.ToList();
            }
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
                            PONumber,
                            InvoiceType
                        )
                        values 
                        (
                            @InvoiceNumber,
                            @InvoiceNumber,
                            @Created,
                            @Creator,
                            @KanbanNumber,
                            @ReferenceNumber,
                            @InvoiceType
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

        public static void UpdateInvoice(InvoiceModel Invoice)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(@"update Invoices 
                    SET
                        PONumber=@ReferenceNumber,
                        KanbanNumber=@KanbanNumber,
                        Created=@Created,
                        Creator=@Creator,
                        InvoiceType=@InvoiceType
                    WHERE
                        InvoiceNumber=@InvoiceNumber
                    ", Invoice);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }   
    }
}
