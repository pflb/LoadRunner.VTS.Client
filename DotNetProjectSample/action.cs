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
    	static readonly string columnCnum = "NPM5.Client.CNUM";
        static readonly string columnSurename = "NPM5.Client.Surename";
        static readonly string columnSurenameEN = "NPM5.Client.SurenameEN";
        static readonly string columnMiddleName = "NPM5.Client.MiddleName";
        static readonly string columnMiddleNameEN = "NPM5.Client.MiddleNameEN";
        static readonly string columnCompanyCNUM = "NPM5.Client.CompanyCNUM";
        static readonly string columnCompanyTitle = "NPM5.Client.CompanyTitle";
        static readonly string columnName = "NPM5.Name.Ru";
        static readonly string columnNameEN = "NPM5.Name.En";
        
        static readonly string delimiter = ",";

        static readonly string columnsCnumAndFIO =
            columnCnum + delimiter +
            columnSurename + delimiter +
            columnSurenameEN + delimiter +
            columnMiddleName + delimiter +
            columnMiddleNameEN + delimiter +
        	columnCompanyCNUM + delimiter +
        	columnCompanyTitle
        	;

        static readonly string columnsNames = columnName + delimiter + columnNameEN;
        
        /// <summary>
        /// Получение тестовых данных cnum, фамилии и отчества из Virtual Table Server
        /// </summary>
        /// <returns></returns>
        string[] GetCnumAndFIO()
        {
            vts.rotate_messages(columnsCnumAndFIO, delimiter, LoadRunner.SendRow.Stacked);

            string[] data =
            {
                lr.eval_string(string.Format("{{{0}}}", columnCnum)),
                lr.eval_string(string.Format("{{{0}}}", columnSurename)),
                lr.eval_string(string.Format("{{{0}}}", columnSurenameEN)),
                lr.eval_string(string.Format("{{{0}}}", columnMiddleName)),
                lr.eval_string(string.Format("{{{0}}}", columnMiddleNameEN)),
                lr.eval_string(string.Format("{{{0}}}", columnCompanyCNUM)),
                lr.eval_string(string.Format("{{{0}}}", columnCompanyTitle)),
            };

            return data;
        }
        
        
        /// <summary>
        /// Получение тестовых данных - имени из Virtual Table Server
        /// </summary>
        /// <returns></returns>
        string[] GetNames()
        {
            vts.rotate_messages(columnsNames, delimiter, LoadRunner.SendRow.Stacked);

            string[] data =
            {
                lr.eval_string(string.Format("{{{0}}}", columnName)),
                lr.eval_string(string.Format("{{{0}}}", columnNameEN)),
            };

            return data;
        }
        
        
        public int Action()
        {
        	string[] names = GetNames();
        	
        	lr.message(names[0]);
        	lr.message(names[1]);
        	
            return 0;
        }
    }
}
