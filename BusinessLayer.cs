using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using System.Data.SqlClient;
using System.Configuration;
using BELayer;
using DataAccess;


namespace BusinessCls
{
    public class BusinessLayer
    {

        public BEL beobj = new BEL();
        public EmployeeData employeeData = new EmployeeData();
        public Vaccinated va = new Vaccinated();
        public DataAccessLayer objdal = new DataAccessLayer();
       

        public int affecteddetails(BEL beobj)
        {
            return objdal.AffectedInsert(beobj);
            
        }

        public int UpdatedAffect(BEL beobj)
        {
            return objdal.UpdateAffected(beobj);
        }

        public int VaccinatedDetailss(Vaccinated va)
        {
            return objdal.VaccintedInsert(va);
        }

        public DataSet EmployeeDetailss(EmployeeData employeeData)
        {
            return objdal.Read1( employeeData);
        }

        public DataSet AffectedDetailss(BEL beobj)
        {
            return objdal.Load(beobj);
        }

        //public class EmployeeData
        //{

        //    public DataAccessLayer objdal = new DataAccessLayer();
        //    VaccineEntites ve = new VaccineEntites();


        //    public int AddVaccinted()
        //    {

        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand("InsertVaccinated", con);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@emp_code", ve.emp_code);
        //            cmd.Parameters.AddWithValue("@Vaccine_Type", ve.Vaccine_Type);
        //            cmd.Parameters.AddWithValue("@Dose_No", ve.Dose_No);
        //            cmd.Parameters.AddWithValue("@Vaccine_Date", ve.Vaccine_Date);
        //            cmd.Parameters.AddWithValue("@Vaccine_Location", ve.Vaccine_Location);
        //            cmd.Parameters.AddWithValue("@Vaccine_Certificate", ve.Vaccine_Certificate);
        //            con.Open();
        //            int result = cmd.ExecuteNonQuery();

        //            return result;
        //        }
        //        catch (Exception ex)
        //        {
        //            throw;
        //        }
        //    }
        //}

        //public EmployeeData employeeData = new EmployeeData();
        //public int SaveData(EmployeeBO bo)
        //{
        //    try
        //    {
        //        return employeeData.AddVaccinted(bo);

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //public EmployeeData employeeData = new EmployeeData();
        //public int SaveData(EmployeeBO bo)
        //{
        //    try
        //    {
        //        return employeeData.AddVaccinted(bo);

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

    }

    



}

    

