﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BatchProject
{
    public class Createbatch
    {
        
        public void Create()
        {
           
            string Dudse = "net user alberte nrt /fullname:\"Peter\" /passwordchg:no /add";
            StreamWriter sw = new StreamWriter("test.bat");
            sw.WriteLine("@ECHO Creating a new user");
            sw.WriteLine(Dudse);
            sw.WriteLine("@PAUSE");
            sw.Close();
        

 
        }
        public void Delete()
        {
            string query = "";
            StreamWriter sw = new StreamWriter("thatest.bat");
            sw.WriteLine(query);
            sw.WriteLine("@pause");
            sw.Close();
        }
    }
}

