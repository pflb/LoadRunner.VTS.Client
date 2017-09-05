//---------------------------------------------
//Script Title        :
//Script Description  :
//
//
//Recorder Version    : 
//---------------------------------------------

namespace Script
{
    public partial class VuserClass
    {
    	static readonly string columnCnum = "CNUM";
        static readonly string columnSurname = "SurName";
        static readonly string columnName = "Name";
        static readonly string columnMiddleName = "MiddleName";
        static readonly string columnBirthDay = "BirthDay";
        static readonly string columnCity = "City";
        
        static readonly string delimiter = ",";


        /// <summary>
        /// Get all columns from Virtual Table Server
        /// </summary>
        /// <returns></returns>
        string[] RotateAll()
        {
	        string columnsAll =
	            columnCnum + delimiter +
	            columnSurname + delimiter +
	        	columnName + delimiter +
	            columnMiddleName + delimiter +
	            columnBirthDay + delimiter +
	            columnCity
	        	;
        
            vts.rotate_messages(columnsAll, delimiter, LoadRunner.SendRow.Stacked);

            string[] data =
            {
                lr.eval_string(string.Format("{{{0}}}", columnCnum)),
                lr.eval_string(string.Format("{{{0}}}", columnSurname)),
                lr.eval_string(string.Format("{{{0}}}", columnName)),
                lr.eval_string(string.Format("{{{0}}}", columnMiddleName)),
                lr.eval_string(string.Format("{{{0}}}", columnBirthDay)),
                lr.eval_string(string.Format("{{{0}}}", columnCity)),
            };

            return data;
        }
        
        
        /// <summary>
        /// Get Surname, Name and MiddleName from Virtual Table Server
        /// </summary>
        /// <returns></returns>
        string[] RotateFIO()
        {
        	string columnsFIO = columnSurname + delimiter +
        	columnName + delimiter +
        	columnMiddleName;
        	
            vts.rotate_messages(columnsFIO, delimiter, LoadRunner.SendRow.Stacked);

            string[] data =
            {
                lr.eval_string(string.Format("{{{0}}}", columnSurname)),
                lr.eval_string(string.Format("{{{0}}}", columnName)),
                lr.eval_string(string.Format("{{{0}}}", columnMiddleName)),
            };

            return data;
        }
        
                /// <summary>
        /// Get CNUM, BirthDay and City from Virtual Table Server
        /// </summary>
        /// <returns></returns>
        string[] RotateOtherInfo()
        {
        	string columnsOther = columnCnum + delimiter +
        	columnBirthDay + delimiter +
        	columnCity;
        	
            vts.rotate_messages(columnsOther, delimiter, LoadRunner.SendRow.Stacked);

            string[] data =
            {
                lr.eval_string(string.Format("{{{0}}}", columnCnum)),
                lr.eval_string(string.Format("{{{0}}}", columnBirthDay)),
                lr.eval_string(string.Format("{{{0}}}", columnCity)),
            };

            return data;
        }
        
        
        public int Action()
        {
        	string[] names = RotateFIO();
        	
        	lr.message(names[0]);
        	lr.message(names[1]);
        	lr.message(names[2]);
        	
        	string[] info = RotateOtherInfo();
        	
        	lr.message(info[0]);
        	lr.message(info[1]);
        	lr.message(info[2]);

        	return 0;
        }
    }
}
