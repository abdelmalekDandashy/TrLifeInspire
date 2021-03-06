using BLC;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Declaration And Initialization Section.
            string _ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
            BLC.BLCInitializer oBLCInitializer = new BLC.BLCInitializer();
            oBLCInitializer.ConnectionString = _ConnectionString;
            oBLCInitializer.OwnerID = 1;
            oBLCInitializer.UserID = 1;
            oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
            BLC.BLC oBLC = new BLC.BLC(oBLCInitializer);
            string str_Option = string.Empty;
            string str_BH_ID = string.Empty;
            string str_AC_ID = string.Empty;
            string str_Bucket_Name = string.Empty;
            string str_Main_Folder_Path = string.Empty;
            Tools.Tools oTools = new Tools.Tools();
            #endregion

            #region TESTs

            #region getTrip
            Params_Get_Trip_By_OWNER_ID oParams_Get_Trip_By_OWNER_ID = new Params_Get_Trip_By_OWNER_ID();
            oParams_Get_Trip_By_OWNER_ID.OWNER_ID = 1;
            var result = oBLC.Get_Trip_By_OWNER_ID(oParams_Get_Trip_By_OWNER_ID);
            Console.WriteLine(result);
            Console.WriteLine(result);
            #endregion

            #endregion
        }
    }
}
