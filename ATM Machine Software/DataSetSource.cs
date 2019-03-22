using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine_Software
{
    class DataSetSource
    {
       public DataSet dataSet;
        DataRow drCurrent;
        SqlDataAdapter dataAdapter;
        public DataSetSource()
        {
            dataSet = new DataSet();
            var connectionSql = new SqlConnection(Properties.Settings.Default.ATMConnection);
            dataAdapter = new SqlDataAdapter("Select * from ATMData" , connectionSql);
            dataAdapter.Fill(dataSet, "ATMData");
            DataColumn[] keyColumns = new DataColumn[1];
            keyColumns[0] = dataSet.Tables[0].Columns["ATMDataID"];
            dataSet.Tables[0].PrimaryKey = keyColumns;
        }
        public void ChangePin(string newPIN)
        {
            drCurrent = dataSet.Tables[0].Rows.Find(EnterPin.accountNumber);
            drCurrent.BeginEdit();
            drCurrent["PIN"] = newPIN;
            drCurrent.EndEdit();
            SqlCommandBuilder objCommandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(dataSet, "ATMData");
        }

    }
}
