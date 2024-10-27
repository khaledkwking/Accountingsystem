using System;
using System.Xml;
using System.Configuration;
using System.Collections;
using System.Reflection;
using System.Diagnostics;
using System.Data;

namespace ERPSYS
{
               

      public enum ConfigFileType
      {
            WebConfig ,
            AppConfig
      }
   
      public class AppConfig : System.Configuration.AppSettingsReader
      {
          public string docName = String.Empty;
          private XmlNode node = null;

          private int _configType;
          public int ConfigType
          {
              get
              {
                  return _configType;
              }
              set
              {
                  _configType = value;
              }
          }

          public  DataSet GetAppSettings()
          {
              XmlDocument cfgDoc = new XmlDocument();
              LoadConfigDoc(cfgDoc);

              // store it in a dataset
              DataSet ds = new DataSet();

              // create the dataset
              DataTable table = ds.Tables.Add();
              table.Columns.Add("Key");
              table.Columns.Add("Value");

              // retrieve the appSettings node 
              node = cfgDoc.SelectSingleNode("//appSettings");

              foreach (XmlElement elem in node.ChildNodes)
              {
                  string[] data = { elem.Attributes[0].Value, elem.Attributes[1].Value };
                  table.Rows.Add(data);
              }

              return ds;
          }

          public bool SetValue(string key, string value)
          {
              XmlDocument cfgDoc = new XmlDocument();
              LoadConfigDoc(cfgDoc);
              // retrieve the appSettings node 
              node = cfgDoc.SelectSingleNode("//connectionStrings");

              if (node == null)
              {
                  throw new System.InvalidOperationException("appSettings section not found");
              }

              try
              {
                  // XPath select setting "add" element that contains this key    
                  XmlElement addElem = (XmlElement)node.SelectSingleNode("//add[@name='" + key + "']");
                  if (addElem != null)
                  {
                      addElem.SetAttribute("connectionString", value);
                  }
                  // not found, so we need to add the element, key and value
                  else
                  {
                      XmlElement entry = cfgDoc.CreateElement("add");
                      entry.SetAttribute("name", key);
                      entry.SetAttribute("connectionString", value);
                      node.AppendChild(entry);
                  }
                  //save it
                  SaveConfigDoc(cfgDoc, docName);
                  return true;
              }
              catch
              {
                  return false;
              }
          }

          public bool CreateValue(string key, string value)
          {
              XmlDocument cfgDoc = new XmlDocument();
              LoadConfigDoc(cfgDoc);
              // retrieve the appSettings node 
              node = cfgDoc.SelectSingleNode("//appSettings");

              if (node == null)
              {
                  throw new System.InvalidOperationException("appSettings section not found");
              }

              try
              {
                  // XPath select setting "add" element that contains this key    
                  XmlElement addElem = (XmlElement)node.SelectSingleNode("//add[@key='" + key + "']");
                  // not found, so we need to add the element, key and value
                  if (addElem == null)
                  {
                      XmlElement entry = cfgDoc.CreateElement("add");
                      entry.SetAttribute("key", key);
                      entry.SetAttribute("value", value);
                      node.AppendChild(entry);
                  }
                  //save it
                  SaveConfigDoc(cfgDoc, docName);
                  return true;
              }
              catch
              {
                  return false;
              }
          }

          private void SaveConfigDoc(XmlDocument cfgDoc, string cfgDocPath)
          {
              try
              {
                  XmlTextWriter writer = new XmlTextWriter(cfgDocPath, null);
                  writer.Formatting = Formatting.Indented;
                  cfgDoc.WriteTo(writer);
                  writer.Flush();
                  writer.Close();
                  return;
              }
              catch
              {
                  throw;
              }
          }

          public bool RemoveElement(string elementKey)
          {
              try
              {
                  XmlDocument cfgDoc = new XmlDocument();
                  LoadConfigDoc(cfgDoc);
                  // retrieve the appSettings node 
                  node = cfgDoc.SelectSingleNode("//appSettings");
                  if (node == null)
                  {
                      throw new System.InvalidOperationException("appSettings section not found");
                  }
                  // XPath select setting "add" element that contains this key to remove   
                  node.RemoveChild(node.SelectSingleNode("//add[@key='" + elementKey + "']"));

                  SaveConfigDoc(cfgDoc, docName);
                  return true;
              }
              catch
              {
                  return false;
              }
          }


          private XmlDocument LoadConfigDoc(XmlDocument cfgDoc)
          {
              // load the config file 
              if (Convert.ToInt32(ConfigType) == Convert.ToInt32(ConfigFileType.AppConfig))
              {

                  docName = ((Assembly.GetEntryAssembly()).GetName()).Name;
                  docName += ".exe.config";
              }
              else
              {
                  docName = System.Web.HttpContext.Current.Server.MapPath("web.config");
              }
              cfgDoc.Load(docName);
              return cfgDoc;
          }
      }
    

   
}
