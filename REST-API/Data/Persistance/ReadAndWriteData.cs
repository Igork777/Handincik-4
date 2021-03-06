﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Exercise1.Models;
using Hand_In_2.Data.Model;
using Microsoft.Extensions.FileSystemGlobbing.Abstractions;
using Microsoft.VisualBasic.CompilerServices;

namespace Hand_In_2.Data.Persistance
{
    public class ReadAndWriteData <T> : IReadAndWriteData<T>
    {
        private IList<T> list { get;  }
        private string pathToFile = "";
        
      

        public ReadAndWriteData() {
            
            pathToFile = getName().ToString();
            list = File.Exists(pathToFile) ? ReadData() : new List<T>();
           
        }
        
        public IList<T> ReadData()
        {
            string content = File.ReadAllText(pathToFile);
            return JsonSerializer.Deserialize<List<T>>(content);
        }

        private object getName()
        {
            Type typeParameterType = typeof(T);
            object instance = Activator.CreateInstance(typeParameterType);
            PropertyInfo propertyInfo = typeParameterType.GetProperty("Path");
            if (propertyInfo == null)
            {
                throw new RuntimeWrappedException("Exception, can't be null");
            }

            object obj = propertyInfo.GetValue(instance, null);
           
            return obj.ToString();
        }

        public void SaveChanges(string json)
        {
            File.WriteAllText(pathToFile,json);
        }
    }
}