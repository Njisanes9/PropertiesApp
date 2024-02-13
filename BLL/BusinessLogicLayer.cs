using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BusinessLogicLayer
    {
        DataAccessLayer dal = new DataAccessLayer();

        //Login

        public DataTable GetLogin(string email, string password)
        {
            return dal.GetLogin(email, password);
        }
        //public DataTable TenantLogin(string email, string password)
        //{
        //    return dal.TenantLogin(email, password);
        //}


        //User
        public int InsertUser(User user)
        {
            return dal.InsertUser(user);
        }
        public DataTable GetUser()
        {
            return dal.GetUser();
        }
        public int UpdateUser(User user)
        {
            return dal.UpdateUser(user);
        }
        public DataTable GetRole()
        {
            return dal.GetRole();
        }
        public DataTable GetInActive()
        {
            return dal.GetInActive();
        }
        public DataTable GetEmail(string Email)
        {
            return dal.GetEmail(Email);
        }

        //GET

        public DataTable GetAgent()
        {
            return dal.GetAgent();
        }
        public DataTable GetTenant()
        {
            return dal.GetTenant();
        }

        //PROVINCE

        public int InsertProvince(Province prov)
        {
            return dal.InsertProvince(prov);
        }

        public int UpdateProvince(Province prov)
        {
            return dal.UpdateProvince(prov);
        }

        public DataTable GetProvince()
        {
            return dal.GetProvince();
        }

        public int DeleteProvince(Province prov)
        {
            return dal.DeleteProvince(prov);
        }




        //SUBURB

        public int InsertSuburb(Suburb sub)
        {
            return dal.InsertSuburb(sub);
        }

        public int UpdateSuburb(Suburb sub)
        {
            return dal.UpdateSuburb(sub);
        }

        public DataTable GetSuburb()
        {
            return dal.GetSuburb();
        }

        public int DeleteSuburb(Suburb sub)
        {
            return dal.DeleteSuburb(sub);
        }

        //CITY
        public int InsertCity(City city)
        {
            return dal.InsertCity(city);
        }

        public int UpdateCity(City city)
        {
            return dal.UpdateCity(city);
        }

        public DataTable GetCity()
        {
            return dal.GetCity();
        }

        public int DeleteCity(City city)
        {
            return dal.DeleteCity(city);
        }

        //AGENCY

        public int InsertAgency(Agency agency)
        {
            return dal.InsertAgency(agency);
        }

        public int UpdateAgency(Agency agency)
        {
            return dal.UpdateAgency(agency);
        }

        public DataTable GetAgency()
        {
            return dal.GetAgency();
        }

        public int DeleteAgency(Agency agency)
        {
            return dal.DeleteAgency(agency);
        }

        //PROPERTY
        public int InsertProperty(Property prop)
        {
            return dal.InsertProperty(prop);
        }

        public int UpdateProperty(Property prop)
        {
            return dal.UpdateProperty(prop);
        }

        public DataTable GetProperty()
        {
            return dal.GetProperty();
        }

        public int DeleteProperty(Property prop)
        {
            return dal.DeleteProperty(prop);
        }



        //PROPERTY_TYPE

        public int InsertPropertyType(PropertyType propType)
        {
            return dal.InsertPropertyType(propType);
        }

        public int UpdatePropertyType(PropertyType propType)
        {
            return dal.UpdatePropertyType(propType);
        }

        public DataTable GetPropertyType()
        {
            return dal.GetPropertyType();
        }

        public int DeletePropertyType(PropertyType propType)
        {
            return dal.DeletePropType(propType);
        }


        //PROPERTY_AGENT
        public int InsertPropertyAgent(PropertyAgent propAgent)
        {
            return dal.InsertPropertyAgent(propAgent);
        }

        public int UpdatePropertyAgent(PropertyAgent propAgent)
        {
            return dal.UpdatePropertyAgent(propAgent);
        }

        public DataTable GetPropertyAgent()
        {
            return dal.GetPropertyAgent();
        }

        public int DeletePropertyAgent(PropertyAgent propAgent)
        {
            return dal.DeletePropAgent(propAgent);
        }

        //RENTAL
        public int InsertRental(Rental rent)
        {
            return dal.InsertRental(rent);
        }

        public int UpdateRental(Rental rent)
        {
            return dal.UpdateRental(rent);
        }

        public DataTable GetRental(int userID)
        {
            return dal.GetRental(userID);
        }

        public int DeleteRental(Rental rent)
        {
            return dal.DeleteRental(rent);
        }
        public int UpdateAllRentals(Rental rent)
        {
            return dal.UpdateAllRentals(rent);
        }
        public DataTable GetAllRentals(int userID)
        {
            return dal.GetAllRentals(userID);
        }
        public DataTable GetPropertiesByAgentID(int userID)
        {
            return dal.GetPropertiesByAgentID(userID);
        }

        public DataTable SearchByCity(string cityDesc)
        {
            return dal.SearchByCity(cityDesc);
        }
        //AgentAgency
        public DataTable GetAgentAgency()
        {
            return dal.GetAgentAgency();
        }
        public int InsertAgent(Agent ag)
        {
            return dal.InsertAgent(ag);
        }
        public int DeleteAgent(Agent ag)
        {
            return dal.DeleteAgent(ag);
        }
        public int UpdateAgent(Agent ag)
        {
            return dal.UpdateAgent(ag);
        }
        //AgencyProperty
        public int InsertAgencyProperty(AgencyProperty ap)
        {
            return dal.InsertAgencyProperty(ap);
        }
        public DataTable GetAgencyProperty()
        {
            return dal.GetAgencyProperty();
        }
        public int UpdateAgencyProperty(AgencyProperty ap)
        {
            return dal.UpdateAgencyProperty(ap);
        }
        public int DeleteAgencyProperty(AgencyProperty ap)
        {
            return dal.DeleteAgencyProperty(ap);
        }

        //REPORTS
        public DataTable GetAllUsers()
        {
            return dal.GetAllUsers();
        }
        public DataTable GetUserByID(int userID)
        {
            return dal.GetUserByID(userID);

        }
        public DataTable GetPropertyPropType()
        {
            return dal.GetPropertyPropType();
        }
        public DataTable GetCityProv()
        {
            return dal.GetCityProv();
        }
        public DataTable GetPropertyRental(int userID)
        {
            return dal.GetPropertyRental(userID);
        }
        public DataTable GetPriceRentals(decimal price1, decimal price2)
        {
            return dal.GetPriceRentals(price1,price2);
        }
        public DataTable GetRentedProperties()
        {
            return dal.GetRentedProperties();
        }
        public DataTable GetRentedByTenantID(int userID)
        {
            return dal.GetRentedByTenantID(userID);
        }
        public DataTable GetByAgencyID(int agencyID)
        {
            return dal.GetByAgencyID(agencyID);
        }
        public int ChangePassword(ChangePassword changePW)
        {
            return dal.ChangePassword(changePW);
        }
        //GETBYID
        //Play

    }
}
