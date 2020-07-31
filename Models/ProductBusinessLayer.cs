using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProductsProject.Models
{
    public class ProductBusinessLayer
    {
        public void AddProduct(Products product)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ProductContext"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddProduct", con);
                cmd.CommandType = CommandType.StoredProcedure;

                //SqlParameter paramName = new SqlParameter();
                //paramName.ParameterName = "@Name";
                //paramName.Value = product.ProductName;

                //SqlParameter paramGender = new SqlParameter();
                //paramGender.ParameterName = "@Price";
                //paramGender.Value = product.Price;
                //cmd.Parameters.Add(paramGender);

                //SqlParameter paramCity = new SqlParameter();
                //paramCity.ParameterName = "@Description";
                //paramCity.Value = product.Description;
                //cmd.Parameters.Add(paramCity);

                cmd.Parameters.AddWithValue("@Name", product.ProductName);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Description", product.Description);
                con.Open();
                cmd.ExecuteNonQuery();
                
            }
        }

    }
}