using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace SalamaEnterprise.Models
{
    public class DBQueries
    {
        public static string getDDLQuery(string key,string param)
        {
            string query = "";
            switch (key)
            {
                case "ddlCarMake":query = getCarMakeQuery(param); break;
                case "ddlCarModel": query = getCarModelQuery(param); break;
                case "ddlCarBody": query = getCarBodyQuery(param); break;
                case "ddlTrim": query = getCarTrimQuery(param); break;
            }
            return query;
        }

        public static string getCarMakeQuery(string param)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select ID,BrandName from tblCarMake");
            return sb.ToString();
        }
        public static string getCarModelQuery(string param)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select ModelID,ModelName from tblCarModel");
            return sb.ToString();
        }
        public static string getCarBodyQuery(string param)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select BodyID,BodyType from tblCarBody");
            return sb.ToString();
        }
        public static string getCarTrimQuery(string param)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select TrimID,ModelVersion from tblCarTrim");
            return sb.ToString();
        }
    }
}