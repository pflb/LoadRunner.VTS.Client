using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace LoadRunner.VTSClientDotnet
{
    public class Client
    {
        HttpWebRequest httpWebRequest;
        JavaScriptSerializer serializer;

        public Client(Uri vtsApiUri)
        {
            httpWebRequest = HttpWebRequest.CreateHttp(vtsApiUri);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            serializer = new JavaScriptSerializer();
        }

        public string handshake()
        {
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var request = new JSON.HandshakeRequest();

                String json = serializer.Serialize(request);
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                var handshakeResponse = serializer.Deserialize<JSON.HandshakeResponse>(result);
                if(handshakeResponse.status.code == VtsErrorCode.OK)
                {
                    return handshakeResponse.data.version;
                }
                else
                {
                    throw new Exception(handshakeResponse.status.error);
                }
            }
        }

        Dictionary<string, string> get()
        {

        }

        void retrieve()
        {

        }

        void update()
        {

        }

        void update_ifequals()
        {

        }

        void clear()
        {

        }

        void createColumn()
        {

        }

        void clearColumn()
        {

        }

        void getColumnSize()
        {

        }

        void ensureIndex()
        {

        }

        void dropIndex()
        {

        }
    }
}
