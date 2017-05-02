using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Web;
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
            httpWebRequest.ContentType = "application/x-www-form-urlencoded";
            httpWebRequest.KeepAlive = true;
            httpWebRequest.Method = "POST";
            serializer = new JavaScriptSerializer();
        }

        public TResponseData getResponse<T1, TResponseData>(T1 request)
        {
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                String json = serializer.Serialize(request);
                NameValueCollection outgoingQueryString = HttpUtility.ParseQueryString(String.Empty);
                outgoingQueryString.Add("request", json);

                streamWriter.Write(outgoingQueryString.ToString());
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            if(httpResponse.StatusCode == HttpStatusCode.OK)
            {
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    var response = serializer.Deserialize<JSON.AbstractResponse<TResponseData>>(result);
                    if (response.status.code == VtsErrorCode.OK)
                    {
                        return response.data;
                    }
                    else
                    {
                        throw new Exception(response.status.error);
                    }
                }
            }
            else
            {
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    throw new HttpException((int)httpResponse.StatusCode, result);
                }                    
            }
        }

        public string handshake()
        {
            var request = new JSON.HandshakeRequest();
            JSON.HandshakeRequestData data = getResponse<JSON.HandshakeRequest, JSON.HandshakeRequestData>(request);
            return data.version;
        }

        public Dictionary<string, string> rotate(List<string> columns = null, SendRow option = SendRow.Stacked)
        {
            var request = new JSON.RotateRequest(columns, option);
            Dictionary<string, string> data = getResponse<JSON.RotateRequest, Dictionary<string, string>>(request);
            return data;
        }


        Dictionary<string, string> get()
        {
            throw new NotImplementedException();
        }

        void retrieve()
        {
            throw new NotImplementedException();
        }

        void update()
        {
            throw new NotImplementedException();
        }

        void update_ifequals()
        {
            throw new NotImplementedException();
        }

        void clear()
        {
            throw new NotImplementedException();
        }

        void createColumn()
        {
            throw new NotImplementedException();
        }

        void clearColumn()
        {
            throw new NotImplementedException();
        }

        void getColumnSize()
        {
            throw new NotImplementedException();
        }

        void ensureIndex()
        {
            throw new NotImplementedException();
        }

        void dropIndex()
        {
            throw new NotImplementedException();
        }
    }
}
