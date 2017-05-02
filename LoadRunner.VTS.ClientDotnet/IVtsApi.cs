using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadRunner.VTSClientDotnet
{
    interface IVtsApi
    {
        void clear_column(string columnName);
        void clear_message(string columnName, int index);
        void clear_row(int rowIndex);
        int column_size(string columnName);
        void connect(string servername, int portnum, ConnectionOptions options);
        void create_column(string columnName);
        void disconnect();
        void drop_index(string columnName);
        void ensure_index(string columnName);
        int increment(string columnName, int index, int incrValue);
        void query_column(string columnName, int rowIndex);
        void query_row(int rowIndex);
        void retrieve_message(string columnName);
        void retrieve_messages(string columnNames, string delimiter);
        void retrieve_row();
        void rotate_message(string columnName, SendRow sendflag);
        void rotate_messages(string columnNames, string delimiter, SendRow sendflag);
        void rotate_row(SendRow sendflag);
        void send_if_unique(string columnName, string message);
        void send_message(string columnName, string message);
        void send_row(string columnNames, string messages, string delimiter, SendRow sendflag);
        void update_message(string columnName, int index, string message);
        void update_message_ifequals(string columnName, int index, string message, string ifmessage);
        void update_row(string columnNames, int index, string messages, string delimiter);
    }
}
