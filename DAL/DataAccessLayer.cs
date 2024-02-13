using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataAccessLayer
    {
        //DatabaseCoonection
        static string connString = "Data Source=localhost;Initial Catalog= PropertiesApp ;Integrated Security=True;";
        SqlConnection dbConn = new SqlConnection(connString);
        SqlDataAdapter dbAdapter;
        DataTable dt;
        SqlCommand dbComm;
        DataSet ds;

        //GetLogin
        public DataTable GetLogin(string email, string password)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_Login", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@Email", email);
            dbComm.Parameters.AddWithValue("@Password", password);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        

        //GetRole
        

        //Userforms
        public DataTable Userforms(string roleID)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetUserID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            //dbComm.Parameters.AddWithValue("@Email", email);
            //dbComm.Parameters.AddWithValue("@Password", password);
            dbComm.Parameters.AddWithValue("@RoleID", roleID);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int InsertUser(User user)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_InsertUser", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@Name", user.Name);
            dbComm.Parameters.AddWithValue("@Surname", user.surname);
            dbComm.Parameters.AddWithValue("@Email", user.email);
            dbComm.Parameters.AddWithValue("@Phone", user.phone);
            dbComm.Parameters.AddWithValue("@Password", user.password);
            dbComm.Parameters.AddWithValue("@Role", user.userType);
            dbComm.Parameters.AddWithValue("@Status", user.status);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetUser()
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetUser", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int UpdateUser(User user)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_UpdateUser", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@UserID", user.userID);
            dbComm.Parameters.AddWithValue("@Name", user.Name);
            dbComm.Parameters.AddWithValue("@Surname", user.surname);
            dbComm.Parameters.AddWithValue("@Email", user.email);
            dbComm.Parameters.AddWithValue("@Phone", user.phone);
            dbComm.Parameters.AddWithValue("@Password", user.password);
            dbComm.Parameters.AddWithValue("@Role", user.userType);
            dbComm.Parameters.AddWithValue("@Status", user.status);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetInActive()
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetInActive", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetEmail(string email)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetEmail", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Email", email);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetRole()
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetRole", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public int ChangePassword(ChangePassword changePW)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_ChangePassword", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Email", changePW.Email);
            dbComm.Parameters.AddWithValue("@Password", changePW.Password);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        //GET
        public DataTable GetAgent()
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetTenant()
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetTenant", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }


        //PROVINCE
        public int InsertProvince(Province province)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_InsertProvince", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@Description", province.description);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetProvince()
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetProvince", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public int UpdateProvince(Province province)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_UpdateProvince", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ProvinceID", province.id);
            dbComm.Parameters.AddWithValue("@Description", province.description);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public int DeleteProvince(Province province)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            dbComm = new SqlCommand("sp_DeleteProvince", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ProgLanguageID", province.id);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
            }

            //SUBURB
        public int InsertSuburb(Suburb sub)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_InsertSuburb", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@SuburbDescription", sub.subDescr);
            dbComm.Parameters.AddWithValue("@PostalCode", sub.postalCode);
            dbComm.Parameters.AddWithValue("@CityID", sub.cityID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetSuburb()
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetSuburb", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int UpdateSuburb(Suburb sub)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_UpdateSuburb", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@SuburbID", sub.suburbID);
            dbComm.Parameters.AddWithValue("@SuburbDescription", sub.subDescr);
            dbComm.Parameters.AddWithValue("@PostalCode", sub.postalCode);
            dbComm.Parameters.AddWithValue("@CityID", sub.cityID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteSuburb(Suburb sub)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            dbComm = new SqlCommand("sp_DeleteSuburb", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@SuburbID", sub.suburbID);
            dbComm.Parameters.AddWithValue("@SuburbDescription", sub.subDescr);
            dbComm.Parameters.AddWithValue("@PostalCode", sub.postalCode);
            dbComm.Parameters.AddWithValue("@CityID", sub.cityID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        //CITY
        public int InsertCity(City city)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_InsertCity", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@CityDescription", city.cityDesc);
            dbComm.Parameters.AddWithValue("@ProvinceID", city.provinceID);
            
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetCity()
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetCity", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int UpdateCity(City city)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_UpdateCity", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@CityID", city.cityID);
            dbComm.Parameters.AddWithValue("@CityDescription", city.cityDesc);
            dbComm.Parameters.AddWithValue("@ProvinceID", city.provinceID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteCity(City city)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            dbComm = new SqlCommand("sp_DeleteCity", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@CityID", city.cityID);
            
            
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        //AGENCY
        public int InsertAgency(Agency agency)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_InsertAgency", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@AgencyName", agency.agencyName);
            dbComm.Parameters.AddWithValue("@SuburbID", agency.suburbID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetAgency()
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetAgency", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int UpdateAgency(Agency agency)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_UpdateAgency", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgencyID", agency.agencyID);
            dbComm.Parameters.AddWithValue("@AgencyName", agency.agencyName);
            dbComm.Parameters.AddWithValue("@SuburbID", agency.suburbID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteAgency(Agency agency)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            dbComm = new SqlCommand("sp_DeleteAgency", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgencyID", agency.agencyID);
            
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        //PROPERTY
        public int InsertProperty(Property prop)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_InsertProperty", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@Description", prop.description);
            dbComm.Parameters.AddWithValue("@Price", prop.price);
            dbComm.Parameters.AddWithValue("@Image", prop.image);
            dbComm.Parameters.AddWithValue("@PropertyTypeID", prop.propTypeID);
            dbComm.Parameters.AddWithValue("@SuburbID", prop.subID);
            dbComm.Parameters.AddWithValue("@Status", prop.status);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetProperty()
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetProperty", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int UpdateProperty(Property prop)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_UpdateProperty", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyID", prop.propertyID);
            dbComm.Parameters.AddWithValue("@Description", prop.description);
            dbComm.Parameters.AddWithValue("@Price", prop.price);
            dbComm.Parameters.AddWithValue("@Image", prop.image);
            dbComm.Parameters.AddWithValue("@PropertyTypeID", prop.propTypeID);
            dbComm.Parameters.AddWithValue("@SuburbID", prop.subID);
            dbComm.Parameters.AddWithValue("@Status", prop.status);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteProperty(Property prop)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            dbComm = new SqlCommand("sp_DeleteProperty", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyID", prop.propertyID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        //PROPERTY_TYPE

        public int InsertPropertyType(PropertyType propType)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_InsertPropertyType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@PropertyTypeDescription", propType.description);
           

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetPropertyType()
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetPropertyType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int UpdatePropertyType(PropertyType propType)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_UpdatePropertyType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyTypeID", propType.propTypeID);
            dbComm.Parameters.AddWithValue("@Description", propType.description);
            

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeletePropType(PropertyType propType)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            dbComm = new SqlCommand("sp_DeletePropertyType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyTypeID", propType.propTypeID);
           
            


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        //PROPERTY_AGENT
        public int InsertPropertyAgent(PropertyAgent propAgent)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_InsertPropertyAgent", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@PropertyID", propAgent.propID);
            dbComm.Parameters.AddWithValue("@AgentID", propAgent.agentID);
            dbComm.Parameters.AddWithValue("@Date", propAgent.date);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetPropertyAgent()
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetPropertyAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int UpdatePropertyAgent(PropertyAgent propAgent)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_UpdatePropertyAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyAgentID", propAgent.propAgentID);
            dbComm.Parameters.AddWithValue("@PropertyID", propAgent.propID);
            dbComm.Parameters.AddWithValue("@AgentID", propAgent.agentID);
            dbComm.Parameters.AddWithValue("@Date", propAgent.date);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeletePropAgent(PropertyAgent propAgent)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            dbComm = new SqlCommand("sp_DeletePropertyAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyAgentID", propAgent.propAgentID);
            



            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        //RENTAL
        public int InsertRental(Rental rent)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_InsertRental", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;
                                    
            dbComm.Parameters.AddWithValue("@TenantID", rent.tenantID);
            dbComm.Parameters.AddWithValue("@PropertyID", rent.propID);
            dbComm.Parameters.AddWithValue("@StartDate", rent.startDate);
            dbComm.Parameters.AddWithValue("@EndDate", rent.endDate);
            dbComm.Parameters.AddWithValue("@Status", rent.status);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetRental(int userID)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetRental", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@UserID", userID);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int UpdateRental(Rental rent)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_UpdateRental", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@RentalID", rent.rentalID);
            dbComm.Parameters.AddWithValue("@PropertyID", rent.propID);
            dbComm.Parameters.AddWithValue("@StartDate", rent.startDate);
            dbComm.Parameters.AddWithValue("@EndDate", rent.endDate);
            dbComm.Parameters.AddWithValue("@Status", rent.status);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteRental(Rental rent)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            dbComm = new SqlCommand("sp_DeleteRental", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@RentalID", rent.rentalID);
            


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable SearchByCity(string cityDesc)
        {

            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_SearchByCity", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@CityDescription", cityDesc);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetAllRentals(int userID)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetAllRentals", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@UserID", userID);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int UpdateAllRentals(Rental rent)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_UpdateAllRentals", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@RentalID", rent.rentalID);
            dbComm.Parameters.AddWithValue("@Status", rent.status);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetPropertiesByAgentID(int userID)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetPropByAgentID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@UserID", userID);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }


        //AgentAgency
        public int InsertAgent(Agent ag)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_InsertAgent", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@AgentID", ag.AgentID);
            dbComm.Parameters.AddWithValue("@AgencyID", ag.AgencyID);
            


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetAgentAgency()
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetAgentAgency", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int UpdateAgent(Agent ag)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_UpdateAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgentAgency", ag.AgentAgencyID);
            dbComm.Parameters.AddWithValue("@AgentID", ag.AgentID);
            dbComm.Parameters.AddWithValue("@AgencyID", ag.AgencyID);
            

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public int DeleteAgent(Agent ag)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            dbComm = new SqlCommand("sp_DeleteAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgentAgency", ag.AgentAgencyID);
            


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        //AgencyProperty
        public int InsertAgencyProperty(AgencyProperty ap)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_InsertAgencyProperty", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgencyID", ap.agencyID);
            dbComm.Parameters.AddWithValue("@PropertyID", ap.propertyID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetAgencyProperty()
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetAgencyProperty", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int UpdateAgencyProperty(AgencyProperty ap)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_UpdateAgencyProperty", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgencyPropertyID", ap.AgencyPropertyID);
            dbComm.Parameters.AddWithValue("@AgencyID", ap.agencyID);
            dbComm.Parameters.AddWithValue("@PropertyID", ap.propertyID);
            
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public int DeleteAgencyProperty(AgencyProperty ap)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            dbComm = new SqlCommand("sp_DeleteAgencyProperty", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgencyPropertyID", ap.AgencyPropertyID);



            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        //REPORTS
        public DataTable GetAllUsers()
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetAllUsers", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetUserByID(int userID)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetUserByID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@UserID", userID);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetPropertyPropType()
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_PropertyPropType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetCityProv()
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetCityProv", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public DataTable GetPropertyRental(int userID)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetPropertyRental", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@UserID", userID);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetPriceRentals(decimal price1,decimal price2)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_PrinceRentals", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Price1", price1);
            dbComm.Parameters.AddWithValue("@Price2", price2);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetRentedProperties()
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetRentedProperties", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetRentedByTenantID(int userID)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetRentedByTenantID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@UserID", userID);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetByAgencyID(int agencyID)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetByAgencyID ", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgencyID", agencyID);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }




        //GetByID


    }
}
