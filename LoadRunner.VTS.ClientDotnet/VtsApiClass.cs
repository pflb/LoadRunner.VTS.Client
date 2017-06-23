using System;
using System.Collections.Generic;

namespace LoadRunner.VTSClientDotnet
{
    public class VtsApiClass : IVtsApi
    {
        Client VtsClient { get; set; }
        public VtsApiClass()
        {

        }

        public void clear_column(string columnName)
        {
            throw new NotImplementedException();
        }

        public void clear_message(string columnName, int index)
        {
            throw new NotImplementedException();
        }

        public void clear_row(int rowIndex)
        {
            throw new NotImplementedException();
        }

        public int column_size(string columnName)
        {
            throw new NotImplementedException();
        }

        public void connect(string servername, int portnum, ConnectionOptions options)
        {
            Uri vtsUriApi = new Uri($"http://{servername}:{portnum}/api");
            VtsClient = new Client(vtsUriApi);
            VtsClient.handshake();
        }

        public void create_column(string columnName)
        {
            throw new NotImplementedException();
        }

        public void disconnect()
        {
            VtsClient.disconnect();
        }

        public void drop_index(string columnName)
        {
            throw new NotImplementedException();
        }

        public void ensure_index(string columnName)
        {
            throw new NotImplementedException();
        }

        public int increment(string columnName, int index, int incrValue)
        {
            throw new NotImplementedException();
        }

        public void query_column(string columnName, int rowIndex)
        {
            throw new NotImplementedException();
        }

        public void query_row(int rowIndex)
        {
            throw new NotImplementedException();
        }

        public void retrieve_message(string columnName)
        {
            throw new NotImplementedException();
        }

        public void retrieve_messages(string columnNames, string delimiter)
        {
            throw new NotImplementedException();
        }

        public void retrieve_row()
        {
            throw new NotImplementedException();
        }

        public void rotate_row(SendRow sendflag)
        {
            throw new NotImplementedException();
        }

        public void send_if_unique(string columnName, string message)
        {
            throw new NotImplementedException();
        }

        public void send_message(string columnName, string message)
        {
            throw new NotImplementedException();
        }

        public void send_row(string columnNames, string messages, string delimiter, SendRow sendflag)
        {
            throw new NotImplementedException();
        }

        public void update_message(string columnName, int index, string message)
        {
            throw new NotImplementedException();
        }

        public void update_message_ifequals(string columnName, int index, string message, string ifmessage)
        {
            throw new NotImplementedException();
        }

        public void update_row(string columnNames, int index, string messages, string delimiter)
        {
            throw new NotImplementedException();
        }

        public string rotate_message(string columnName, SendRow sendflag)
        {
            List<string> columns = new List<string>();
            columns.Add(columnName);
            Dictionary<string, string> columnValue = VtsClient.rotate(columns, sendflag);
            return columnValue[columnName];
        }

        public Dictionary<string, string> rotate_messages(string columnNames, string delimiter, SendRow sendflag)
        {
            string[] separator = { delimiter };
            string[] columnArray = columnNames.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            return VtsClient.rotate(columnArray, sendflag);
        }

        public Dictionary<string, string> rotate_messages(IEnumerable<string> columnNames, SendRow sendflag)
        {
            return VtsClient.rotate(columnNames, sendflag);
        }
    }
}
