using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Web.DL
{
    public class DbRepository
    {
        //private const string ConnectionString = @"Data Source=.\sqlexpress;Initial Catalog=WebDB;Integrated Security=True";
        
        // HEADER
        public HeaderEntityDL GetHeaderData()
        {
            try
            {
                using (EntityFramework accessToDB = new EntityFramework())
                {
                    return accessToDB.HeaderEntityDLTable.SingleOrDefault();
                }
            }
            catch (Exception ex)
            {
                HeaderEntityDL error = new HeaderEntityDL();
                error.Title = "Die KopfSeite wurde nicht eingelesen";
                error.Text = "Unten Fehlerbeschreibung: \n";
                error.Link1.LinkText = ex.Message.ToString();
                return error;
                
            }
            //using (SqlConnection connection = new SqlConnection(ConnectionString))
            //{
            //    connection.Open();
            //    using (SqlCommand command = new SqlCommand("SELECT Title,Text,Link1Text,Link1Address,Link2Text,Link2Address FROM Header", connection))
            //    {
            //        using (SqlDataReader reader = command.ExecuteReader())
            //        {
            //            if (!reader.Read())
            //            {
            //                return null;
            //            }
            //            HeaderEntityDL headerEntityDL = new HeaderEntityDL(); headerEntityDL.Link1 = new LinkDL(); headerEntityDL.Link2 = new LinkDL();
            //            headerEntityDL.Title = reader.GetString(reader.GetOrdinal("Title"));
            //            headerEntityDL.Text = reader.GetString(reader.GetOrdinal("Text")) ?? string.Empty;
            //            headerEntityDL.Link1.LinkText = reader.GetString(reader.GetOrdinal("Link1Text")) ?? string.Empty;
            //            headerEntityDL.Link1.LinkAddress = reader.GetString(reader.GetOrdinal("Link1Address")) ?? string.Empty;
            //            headerEntityDL.Link2.LinkText = reader.GetString(reader.GetOrdinal("Link2Text")) ?? string.Empty;
            //            headerEntityDL.Link2.LinkAddress = reader.GetString(reader.GetOrdinal("Link2Address")) ?? string.Empty;
            //            return headerEntityDL;
            //        }
            //    }
            //}
        }

        public string UpDateHeader(HeaderEntityDL headerToDB)
        {
            try
            {
                using (EntityFramework accessToDB = new EntityFramework())
                {
                    accessToDB.Entry(headerToDB).State = EntityState.Modified;
                    accessToDB.SaveChanges();
                    return "Die Anforderung wurde erfüllt";
                }
            }
            catch (Exception ex)
            {
                string error = $"Die Anforderung wurde nicht erfüllt. Unten Fehlerbeschreibung: \n{ex.Message.ToString()}";
                return error;
            }

            //using (SqlConnection connection = new SqlConnection(ConnectionString))
            //{
            //    connection.Open();
            //    using (SqlCommand command = new SqlCommand("UPDATE Header SET Title=@Title, Text=@Text , Link1Text=@Link1Text, Link1Address=@Link1Address, Link2Text=@Link2Text, Link2Address=@Link2Address", connection))
            //    {
            //        command.Parameters.AddWithValue("@Title", headerToDB.Title);
            //        command.Parameters.AddWithValue("@Text", headerToDB.Text);
            //        command.Parameters.AddWithValue("@Link1Text", headerToDB.Link1.LinkText);
            //        command.Parameters.AddWithValue("@Link1Address", headerToDB.Link1.LinkAddress);
            //        command.Parameters.AddWithValue("@Link2Text", headerToDB.Link2.LinkText);
            //        command.Parameters.AddWithValue("@Link2Address", headerToDB.Link2.LinkAddress);
            //        command.ExecuteNonQuery();
            //    }
            //}
        }
        // Footer
        public FooterEntityDL GetFooterData()
        {
            try
            {
                using (EntityFramework accessToDB = new EntityFramework())
                {
                    return accessToDB.FooterEntityDLTable.SingleOrDefault();
                }
            }
            catch (Exception ex)
            {
                FooterEntityDL error = new FooterEntityDL();
                error.Title1 = "Die Fußseite wurde nicht eingelesen";
                error.Title2 = "Unten Fehlerbeschreibung: \n";
                error.Text1 = ex.Message.ToString();
                return error;
            }

            //using (SqlConnection connection = new SqlConnection(ConnectionString))
            //{
            //    connection.Open();
            //    using (SqlCommand command = new SqlCommand("SELECT Title1, Title2, Text1,LinkText1,LinkAddress1, Text2,LinkText2,LinkAddress2, Text3,LinkText3,LinkAddress3, Text4,LinkText4,LinkAddress4, Text5,LinkText5,LinkAddress5, Text6,LinkText6,LinkAddress6, Text7,LinkText7,LinkAddress7, Text8,LinkText8,LinkAddress8, Text9,LinkText9,LinkAddress9, Text10,LinkText10,LinkAddress10, Text11,LinkText11,LinkAddress11, Text12,LinkText12,LinkAddress12 FROM Footer", connection))
            //    {
            //        using (SqlDataReader reader = command.ExecuteReader())
            //        {
            //            if (!reader.Read())
            //            {
            //                return null;
            //            }
            //            FooterEntityDL footerEntityDL = new FooterEntityDL(); footerEntityDL.Link1 = new LinkDLFooter(); footerEntityDL.Link2 = new LinkDLFooter(); footerEntityDL.Link3 = new LinkDLFooter(); footerEntityDL.Link4 = new LinkDLFooter(); footerEntityDL.Link5 = new LinkDLFooter(); footerEntityDL.Link6 = new LinkDLFooter(); footerEntityDL.Link7 = new LinkDLFooter(); footerEntityDL.Link8 = new LinkDLFooter(); footerEntityDL.Link9 = new LinkDLFooter(); footerEntityDL.Link10 = new LinkDLFooter(); footerEntityDL.Link11 = new LinkDLFooter(); footerEntityDL.Link12 = new LinkDLFooter();
            //            footerEntityDL.Title1 = reader.GetString(reader.GetOrdinal("Title1"));
            //            footerEntityDL.Title2 = reader.GetString(reader.GetOrdinal("Title2"));

            //            footerEntityDL.Text1 = reader.GetString(reader.GetOrdinal("Text1")) ?? string.Empty; 
            //            footerEntityDL.Link1.LinkText = reader.GetString(reader.GetOrdinal("LinkText1")) ?? string.Empty;
            //            footerEntityDL.Link1.LinkAddress = reader.GetString(reader.GetOrdinal("LinkAddress1")) ?? string.Empty;

            //            footerEntityDL.Text2 = reader.GetString(reader.GetOrdinal("Text2")) ?? string.Empty;
            //            footerEntityDL.Link2.LinkText = reader.GetString(reader.GetOrdinal("LinkText2")) ?? string.Empty;
            //            footerEntityDL.Link2.LinkAddress = reader.GetString(reader.GetOrdinal("LinkAddress2")) ?? string.Empty;

            //            footerEntityDL.Text3 = reader.GetString(reader.GetOrdinal("Text3")) ?? string.Empty;
            //            footerEntityDL.Link3.LinkText = reader.GetString(reader.GetOrdinal("LinkText3")) ?? string.Empty;
            //            footerEntityDL.Link3.LinkAddress = reader.GetString(reader.GetOrdinal("LinkAddress3")) ?? string.Empty;

            //            footerEntityDL.Text4 = reader.GetString(reader.GetOrdinal("Text4")) ?? string.Empty;
            //            footerEntityDL.Link4.LinkText = reader.GetString(reader.GetOrdinal("LinkText4")) ?? string.Empty;
            //            footerEntityDL.Link4.LinkAddress = reader.GetString(reader.GetOrdinal("LinkAddress4")) ?? string.Empty;

            //            footerEntityDL.Text5 = reader.GetString(reader.GetOrdinal("Text5")) ?? string.Empty;
            //            footerEntityDL.Link5.LinkText = reader.GetString(reader.GetOrdinal("LinkText5")) ?? string.Empty;
            //            footerEntityDL.Link5.LinkAddress = reader.GetString(reader.GetOrdinal("LinkAddress5")) ?? string.Empty;

            //            footerEntityDL.Text6 = reader.GetString(reader.GetOrdinal("Text6")) ?? string.Empty;
            //            footerEntityDL.Link6.LinkText = reader.GetString(reader.GetOrdinal("LinkText6")) ?? string.Empty;
            //            footerEntityDL.Link6.LinkAddress = reader.GetString(reader.GetOrdinal("LinkAddress6")) ?? string.Empty;

            //            footerEntityDL.Text7 = reader.GetString(reader.GetOrdinal("Text7")) ?? string.Empty;
            //            footerEntityDL.Link7.LinkText = reader.GetString(reader.GetOrdinal("LinkText7")) ?? string.Empty;
            //            footerEntityDL.Link7.LinkAddress = reader.GetString(reader.GetOrdinal("LinkAddress7")) ?? string.Empty;

            //            footerEntityDL.Text8 = reader.GetString(reader.GetOrdinal("Text8")) ?? string.Empty;
            //            footerEntityDL.Link8.LinkText = reader.GetString(reader.GetOrdinal("LinkText8")) ?? string.Empty;
            //            footerEntityDL.Link8.LinkAddress = reader.GetString(reader.GetOrdinal("LinkAddress8")) ?? string.Empty;

            //            footerEntityDL.Text9 = reader.GetString(reader.GetOrdinal("Text9")) ?? string.Empty;
            //            footerEntityDL.Link9.LinkText = reader.GetString(reader.GetOrdinal("LinkText9")) ?? string.Empty;
            //            footerEntityDL.Link9.LinkAddress = reader.GetString(reader.GetOrdinal("LinkAddress9")) ?? string.Empty;

            //            footerEntityDL.Text10 = reader.GetString(reader.GetOrdinal("Text10")) ?? string.Empty;
            //            footerEntityDL.Link10.LinkText = reader.GetString(reader.GetOrdinal("LinkText10")) ?? string.Empty;
            //            footerEntityDL.Link10.LinkAddress = reader.GetString(reader.GetOrdinal("LinkAddress10")) ?? string.Empty;

            //            footerEntityDL.Text11 = reader.GetString(reader.GetOrdinal("Text11")) ?? string.Empty;
            //            footerEntityDL.Link11.LinkText = reader.GetString(reader.GetOrdinal("LinkText11")) ?? string.Empty;
            //            footerEntityDL.Link11.LinkAddress = reader.GetString(reader.GetOrdinal("LinkAddress11")) ?? string.Empty;

            //            footerEntityDL.Text12 = reader.GetString(reader.GetOrdinal("Text12")) ?? string.Empty;
            //            footerEntityDL.Link12.LinkText = reader.GetString(reader.GetOrdinal("LinkText12")) ?? string.Empty;
            //            footerEntityDL.Link12.LinkAddress = reader.GetString(reader.GetOrdinal("LinkAddress12")) ?? string.Empty;

            //            return footerEntityDL;
            //        }
            //    }
            //}
            }

        public string UpDateFooter(FooterEntityDL footerToDB)
        {
            try
            {
                using (EntityFramework accessToDB = new EntityFramework())
                {
                    accessToDB.Entry(footerToDB).State = EntityState.Modified;
                    accessToDB.SaveChanges();
                    return "Die Anforderung wurde erfüllt";
                }
            }
            catch (Exception ex)
            {
                string error = $"Die Anforderung wurde nicht erfüllt. Unten Fehlerbeschreibung: \n:{ex.Message.ToString()}";
                return error;
            }

            //using (SqlConnection connection = new SqlConnection(ConnectionString))
            //{
            //    connection.Open();
            //    using (SqlCommand command = new SqlCommand("UPDATE Footer SET Title1=@Title1, Title2=@Title2, Text1=@Text1, LinkText1=@LinkText1, LinkAddress1=@LinkAddress1, Text2=@Text2, LinkText2=@LinkText2, LinkAddress2=@LinkAddress2, Text3=@Text3, LinkText3=@LinkText3, LinkAddress3=@LinkAddress3, Text4=@Text4, LinkText4=@LinkText4, LinkAddress4=@LinkAddress4, Text5=@Text5, LinkText5=@LinkText5, LinkAddress5=@LinkAddress5, Text6=@Text6, LinkText6=@LinkText6, LinkAddress6=@LinkAddress6, Text7=@Text7, LinkText7=@LinkText7, LinkAddress7=@LinkAddress7, Text8=@Text8, LinkText8=@LinkText8, LinkAddress8=@LinkAddress8, Text9=@Text9, LinkText9=@LinkText9, LinkAddress9=@LinkAddress9, Text10=@Text10, LinkText10=@LinkText10, LinkAddress10=@LinkAddress10, Text11=@Text11, LinkText11=@LinkText11, LinkAddress11=@LinkAddress11, Text12=@Text12, LinkText12=@LinkText12, LinkAddress12=@LinkAddress12", connection))
            //    {
            //        command.Parameters.AddWithValue("@Title1", footerToDB.Title1);
            //        command.Parameters.AddWithValue("@Title2", footerToDB.Title2);

            //        command.Parameters.AddWithValue("@Text1", footerToDB.Text1);
            //        command.Parameters.AddWithValue("@LinkText1", footerToDB.Link1.LinkText);
            //        command.Parameters.AddWithValue("@LinkAddress1", footerToDB.Link1.LinkAddress);

            //        command.Parameters.AddWithValue("@Text2", footerToDB.Text2);
            //        command.Parameters.AddWithValue("@LinkText2", footerToDB.Link2.LinkText);
            //        command.Parameters.AddWithValue("@LinkAddress2", footerToDB.Link2.LinkAddress);

            //        command.Parameters.AddWithValue("@Text3", footerToDB.Text3);
            //        command.Parameters.AddWithValue("@LinkText3", footerToDB.Link3.LinkText);
            //        command.Parameters.AddWithValue("@LinkAddress3", footerToDB.Link3.LinkAddress);

            //        command.Parameters.AddWithValue("@Text4", footerToDB.Text4);
            //        command.Parameters.AddWithValue("@LinkText4", footerToDB.Link4.LinkText);
            //        command.Parameters.AddWithValue("@LinkAddress4", footerToDB.Link4.LinkAddress);

            //        command.Parameters.AddWithValue("@Text5", footerToDB.Text5);
            //        command.Parameters.AddWithValue("@LinkText5", footerToDB.Link5.LinkText);
            //        command.Parameters.AddWithValue("@LinkAddress5", footerToDB.Link5.LinkAddress);

            //        command.Parameters.AddWithValue("@Text6", footerToDB.Text6);
            //        command.Parameters.AddWithValue("@LinkText6", footerToDB.Link6.LinkText);
            //        command.Parameters.AddWithValue("@LinkAddress6", footerToDB.Link6.LinkAddress);

            //        command.Parameters.AddWithValue("@Text7", footerToDB.Text7);
            //        command.Parameters.AddWithValue("@LinkText7", footerToDB.Link7.LinkText);
            //        command.Parameters.AddWithValue("@LinkAddress7", footerToDB.Link7.LinkAddress);

            //        command.Parameters.AddWithValue("@Text8", footerToDB.Text8);
            //        command.Parameters.AddWithValue("@LinkText8", footerToDB.Link8.LinkText);
            //        command.Parameters.AddWithValue("@LinkAddress8", footerToDB.Link8.LinkAddress);

            //        command.Parameters.AddWithValue("@Text9", footerToDB.Text9);
            //        command.Parameters.AddWithValue("@LinkText9", footerToDB.Link9.LinkText);
            //        command.Parameters.AddWithValue("@LinkAddress9", footerToDB.Link9.LinkAddress);

            //        command.Parameters.AddWithValue("@Text10", footerToDB.Text10);
            //        command.Parameters.AddWithValue("@LinkText10", footerToDB.Link10.LinkText);
            //        command.Parameters.AddWithValue("@LinkAddress10", footerToDB.Link10.LinkAddress);

            //        command.Parameters.AddWithValue("@Text11", footerToDB.Text11);
            //        command.Parameters.AddWithValue("@LinkText11", footerToDB.Link11.LinkText);
            //        command.Parameters.AddWithValue("@LinkAddress11", footerToDB.Link11.LinkAddress);

            //        command.Parameters.AddWithValue("@Text12", footerToDB.Text12);
            //        command.Parameters.AddWithValue("@LinkText12", footerToDB.Link12.LinkText);
            //        command.Parameters.AddWithValue("@LinkAddress12", footerToDB.Link12.LinkAddress);

            //        command.ExecuteNonQuery();
            //    }
            //}
        }

        // TEASER
        //private TeaserEntityDL GetTeaserEntity(SqlDataReader reader)
        //{
        //    TeaserEntityDL teaserFromDB = new TeaserEntityDL();
        //    teaserFromDB.Id = reader.GetInt32(reader.GetOrdinal("iD"));
        //    teaserFromDB.Title = reader.GetString(reader.GetOrdinal("Title"));
        //    teaserFromDB.Text = reader.GetString(reader.GetOrdinal("Text")) ?? string.Empty;
        //    teaserFromDB.DateOfTeaser = reader.GetDateTime(reader.GetOrdinal("Date"));
        //    return teaserFromDB;
        //}
        
        // Teasers
        public List<TeaserEntityDL> GetAllTeasers()
        {
            try
            {
                using (EntityFramework accessToDB = new EntityFramework())
                {
                    return accessToDB.TeaserEntityDLTable.ToList();
                }
            }
            catch (Exception ex)
            {
                List<TeaserEntityDL> error = new List<TeaserEntityDL>();
                TeaserEntityDL error1 = new TeaserEntityDL();
                error1.ImageName = "Die Artikel wurden nicht eingelesen";
                error1.Text = "Unten Fehlerbeschreibung: \n";
                error1.ImageName = ex.Message.ToString();
                error.Add(error1);
                return error;
            }
        }
        //public IEnumerable<TeaserEntityDL> GetAllTeasers()
        //{
        //    using (SqlConnection connection = new SqlConnection(ConnectionString))
        //    {
        //        connection.Open();
        //        using (SqlCommand command = new SqlCommand("SELECT iD, Title, Text, Date FROM Teaser", connection))
        //        {
        //            SqlDataReader reader = command.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                yield return GetTeaserEntity(reader);
        //            }
        //        }
        //    }
        //}

        public TeaserEntityDL GetTeaserData (int iDteaser)
        {
            try
            {
                using (EntityFramework accessToDB = new EntityFramework())
                {
                    return accessToDB.TeaserEntityDLTable.Where(x => x.Id == iDteaser).SingleOrDefault();
                }
            }
            catch (Exception ex)
            {
                TeaserEntityDL error = new TeaserEntityDL();
                error.Title = $"Der Artikel Id={iDteaser} wurde nicht eingelesen";
                error.Text = "Fehlerbeschreibung:";
                error.ImageName = $"{ex.Message.ToString()}";
                return error;
            }
            //using (SqlConnection connection = new SqlConnection(ConnectionString))
            //{
            //    connection.Open();
            //    using (SqlCommand command = new SqlCommand("SELECT iD, Title, Text, Date FROM Teaser WHERE iD=@iDteaser", connection))
            //    {
            //        command.Parameters.AddWithValue("@iDteaser", iDteaser);
            //        SqlDataReader reader = command.ExecuteReader();
            //        if (!reader.Read())
            //        {
            //            return null;
            //        }
            //        return GetTeaserEntity(reader);
            //    }
            //}
        }

        public string UpdateTeaserData(TeaserEntityDL teaserToDB)
        {
            try
            {
                using (EntityFramework accessToDB = new EntityFramework())
                {
                    accessToDB.Entry(teaserToDB).State = EntityState.Modified;
                    accessToDB.SaveChanges();
                    return "Die Anforderung wurde erfüllt";
                }
            }
            catch (Exception ex)
            {
                string error= $"Die Anforderung wurde nicht erfüllt. Unten Fehlerbeschreibung:\n {ex.Message.ToString()}";
                return error;
            }

            //using (SqlConnection connection = new SqlConnection(ConnectionString))
            //{
            //    connection.Open();
            //    using (SqlCommand command = new SqlCommand("UPDATE Teaser SET Title=@Title, Text=@Text , Date=@Date WHERE id=@IdTeaser", connection))
            //    {
            //        command.Parameters.AddWithValue("@Title", teaserToDB.Title);
            //        command.Parameters.AddWithValue("@Text", teaserToDB.Text);
            //        command.Parameters.AddWithValue("@Date", teaserToDB.DateOfTeaser);
            //        command.Parameters.AddWithValue("@IdTeaser", teaserToDB.Id);
            //        command.ExecuteNonQuery();
            //    }
            //}
        }
    }
}
