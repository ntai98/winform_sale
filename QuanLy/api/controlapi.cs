using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.Serialization.Json;
using System.IO;

namespace QuanLy.api
{
    public class controlapi
    {
        private static controlapi instance;

        public static controlapi Instance
        {
            get
            {
                if (instance == null) { instance = new controlapi(); } return instance;
            }

            set
            {
                instance = value;
            }
        }

        private controlapi() { }
        
        public bool POSTPUTDELETE(string link,string link2, string phuongthuc ) //link goi den control,link2 doiso
        {
            bool kq = false;
            try
            {
                HttpWebRequest request = WebRequest.CreateHttp(link + link2);
                request.Method = phuongthuc;
                request.ContentType = "Application/json;charset=UTF-8";
                byte[] bytearr = Encoding.UTF8.GetBytes(link2);
                request.ContentLength = bytearr.Length;
                Stream datatstream = request.GetRequestStream();
                datatstream.Write(bytearr, 0, bytearr.Length);
                datatstream.Close();
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(bool));
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                object responsedata = jsonSerializer.ReadObject(response.GetResponseStream());
                kq = (bool)responsedata;
                
            }
            catch { };
            return kq;
        }
    }
}
