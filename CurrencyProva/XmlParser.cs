using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Linq;

namespace CurrencyProva {
  public class XmlParser {


      ContextModel1 db= new ContextModel1();
      public XmlParser()
      {
          var currency = new Currency();
          var user = new User() {Id = 1,Name = "fabio" };

          string sampleXml= ("http://finance.yahoo.com/webservice/v1/symbols/allcurrencies/quote");
          var xDoc =new XmlDocument();
          xDoc.Load(sampleXml);

          var xp = xDoc.SelectNodes("list/resources/resource");

          
          //    var curr = new Currency() {Id = 1, Name = "EUR", UserId = 1, UcTime = DateTime.Now} ;
              db.Users.Add(user);
              var Id = 0;
          foreach (XmlNode node in xp)
          {

              Id++;
              currency.Id=Id;

              var name = node.SelectSingleNode("field[@name='name']").InnerText;

              currency.Name = name;

              //var price = node.SelectSingleNode("field[@name='price']").InnerText;
              
              //currency.Price = Decimal.Parse(price);

              var utctime = node.SelectSingleNode("field[@name='utctime']").InnerText;

              currency.UcTime=DateTime.Parse(utctime);

              db.Currencies.Add(currency);
              
          Console.WriteLine(db);  
          }
          db.SaveChanges();
          Console.ReadLine();

      }
      
 


        }
    }
