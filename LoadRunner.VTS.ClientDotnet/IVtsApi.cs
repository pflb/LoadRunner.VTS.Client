using System.Collections.Generic;

namespace LoadRunner.VTSClientDotnet
{
    interface IVtsApi
    {
        /// <summary>
        /// Clears all data in a column.
        /// </summary>
        /// <param name="columnName"></param>
        void clear_column(string columnName);


        /// <summary>
        /// Clears the data in a field.
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="index"></param>
        void clear_message(string columnName, int index);


        /// <summary>
        /// Clears the data in a row.
        /// </summary>
        /// <param name="rowIndex"></param>
        void clear_row(int rowIndex);


        /// <summary>
        /// Returns the number of fields that contain data in a column.
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns></returns>
        int column_size(string columnName);


        /// <summary>
        /// Creates a connection to the server.
        /// </summary>
        /// <param name="servername"></param>
        /// <param name="portnum"></param>
        /// <param name="options"></param>
        void connect(string servername, int portnum, ConnectionOptions options);


        /// <summary>
        /// Creates a column.
        /// </summary>
        /// <param name="columnName"></param>
        void create_column(string columnName);


        /// <summary>
        /// Disconnects from the server.
        /// </summary>
        void disconnect();


        /// <summary>
        /// Deletes the index on a column.
        /// </summary>
        /// <param name="columnName"></param>
        void drop_index(string columnName);


        /// <summary>
        /// Creates an index on a column.
        /// </summary>
        /// <param name="columnName"></param>
        void ensure_index(string columnName);


        /// <summary>
        /// Increments a counter stored in a field.
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="index"></param>
        /// <param name="incrValue"></param>
        /// <returns></returns>
        int increment(string columnName, int index, int incrValue);


        /// <summary>
        /// Retrieves the data in a field.
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="rowIndex"></param>
        void query_column(string columnName, int rowIndex);


        /// <summary>
        /// Retrieves the data in a row.
        /// </summary>
        /// <param name="rowIndex"></param>
        void query_row(int rowIndex);


        /// <summary>
        /// Pops the first field from a column.
        /// </summary>
        /// <param name="columnName"></param>
        void retrieve_message(string columnName);


        /// <summary>
        /// Pops the first fields from specified columns.
        /// </summary>
        /// <param name="columnNames"></param>
        /// <param name="delimiter"></param>
        void retrieve_messages(string columnNames, string delimiter);


        /// <summary>
        /// Pops the first fields from all columns.
        /// </summary>
        void retrieve_row();


        /// <summary>
        /// Retrieves the first field from the specified column and moves the value to the bottom.
        /// </summary>
        /// <remarks>Original method from HP company put result in test context, not return values</remarks>
        /// <param name="columnName"></param>
        /// <param name="sendflag"></param>
        /// <returns>Column value as text</returns>
        string rotate_message(string columnName, SendRow sendflag);


        /// <summary>
        /// Retrieves the first field from the specified column and moves the value to the bottom
        /// </summary>
        /// <remarks>Original method from HP company put result in test context, not return values</remarks>
        /// <param name="columnNames"></param>
        /// <param name="delimiter"></param>
        /// <param name="sendflag"></param>
        /// <returns>Dictionary where key - column name, value - column value as text</returns>
        Dictionary<string, string> rotate_messages(string columnNames, string delimiter, SendRow sendflag);


        /// <summary>
        /// Retrieves the first field from the specified column and moves the value to the bottom
        /// </summary>
        /// <remarks>Original method from HP company put result in test context, not return values</remarks>
        /// <param name="columnNames"></param>
        /// <param name="delimiter"></param>
        /// <param name="sendflag"></param>
        /// <returns>Dictionary where key - column name, value - column value as text</returns>
        Dictionary<string, string> rotate_messages(IEnumerable<string> columnNames, SendRow sendflag);


        /// <summary>
        /// Retrieves the first row and moves the values to the bottom.
        /// </summary>
        /// <param name="sendflag"></param>
        void rotate_row(SendRow sendflag);


        /// <summary>
        /// Sets the last field of a column to a value if the value does not exist in the column.
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="message"></param>
        void send_if_unique(string columnName, string message);


        /// <summary>
        /// Sets the last field of a column to a value.
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="message"></param>
        void send_message(string columnName, string message);


        /// <summary>
        /// Sets the data in multiple columns.
        /// </summary>
        /// <param name="columnNames"></param>
        /// <param name="messages"></param>
        /// <param name="delimiter"></param>
        /// <param name="sendflag"></param>
        void send_row(string columnNames, string messages, string delimiter, SendRow sendflag);


        /// <summary>
        /// Replaces the data in a field.
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="index"></param>
        /// <param name="message"></param>
        void update_message(string columnName, int index, string message);


        /// <summary>
        /// Replaces the data in a field if the current data equals a given value.
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="index"></param>
        /// <param name="message"></param>
        /// <param name="ifmessage"></param>
        void update_message_ifequals(string columnName, int index, string message, string ifmessage);


        /// <summary>
        /// Replaces the data in a row.
        /// </summary>
        /// <param name="columnNames"></param>
        /// <param name="index"></param>
        /// <param name="messages"></param>
        /// <param name="delimiter"></param>
        void update_row(string columnNames, int index, string messages, string delimiter);
    }
}
