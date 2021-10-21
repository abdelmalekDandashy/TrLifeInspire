using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BLC;
[Route("api/[controller]")]
[ApiController]
public partial class DataController : ControllerBase
{
#region Members
#endregion
#region Extract_Ticket
private string Extract_Ticket()
{
#region Declaration And Initialization Section.
string str_Ticket = string.Empty;
#endregion
if(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null)
{
str_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
#region Return Section.
return str_Ticket;
#endregion
}
#endregion
#region IsValidWebTicket
private bool IsValidWebTicket(string i_Input)
{
#region Declaration And Initialization Section.
bool Is_Valid = false;
BLCInitializer oBLCInitializer = new BLCInitializer();
#endregion
#region Body Section.
BLC.BLC oBLC_Default = new BLC.BLC();
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
Is_Valid = oBLC.IsValidTicket(i_Input);
}
#endregion
#region Return Section.
return Is_Valid;
#endregion
}
#endregion
#region Delete_Trip
[HttpPost]
[Route("Delete_Trip")]
public Result_Delete_Trip Delete_Trip(Params_Delete_Trip i_Params_Delete_Trip)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Trip oResult_Delete_Trip = new Result_Delete_Trip();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Trip(i_Params_Delete_Trip);
oResult_Delete_Trip.My_Params_Delete_Trip = i_Params_Delete_Trip;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Trip.ExceptionMsg = string.Format("Delete_Trip : {0}", ex.Message);
}
else
{
oResult_Delete_Trip.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Trip;
#endregion
}
#endregion
#region Edit_Trip
[HttpPost]
[Route("Edit_Trip")]
public Result_Edit_Trip Edit_Trip(Trip i_Trip)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Trip oResult_Edit_Trip = new Result_Edit_Trip();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Trip(i_Trip);
oResult_Edit_Trip.My_Trip = i_Trip;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Trip.ExceptionMsg = string.Format("Edit_Trip : {0}", ex.Message);
}
else
{
oResult_Edit_Trip.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Trip;
#endregion
}
#endregion
#region Get_Trip_By_OWNER_ID
[HttpPost]
[Route("Get_Trip_By_OWNER_ID")]
public Result_Get_Trip_By_OWNER_ID Get_Trip_By_OWNER_ID(Params_Get_Trip_By_OWNER_ID i_Params_Get_Trip_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Trip>  oReturnValue = new List<Trip> ();
string i_Ticket = string.Empty;
Result_Get_Trip_By_OWNER_ID oResult_Get_Trip_By_OWNER_ID = new Result_Get_Trip_By_OWNER_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Trip_By_OWNER_ID(i_Params_Get_Trip_By_OWNER_ID);
oResult_Get_Trip_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Trip_By_OWNER_ID.My_Params_Get_Trip_By_OWNER_ID = i_Params_Get_Trip_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Trip_By_OWNER_ID.ExceptionMsg = string.Format("Get_Trip_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Trip_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Trip_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Trip_By_TRIP_ID
[HttpPost]
[Route("Get_Trip_By_TRIP_ID")]
public Result_Get_Trip_By_TRIP_ID Get_Trip_By_TRIP_ID(Params_Get_Trip_By_TRIP_ID i_Params_Get_Trip_By_TRIP_ID)
{
#region Declaration And Initialization Section.
Trip oReturnValue = new Trip();
string i_Ticket = string.Empty;
Result_Get_Trip_By_TRIP_ID oResult_Get_Trip_By_TRIP_ID = new Result_Get_Trip_By_TRIP_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Trip_By_TRIP_ID(i_Params_Get_Trip_By_TRIP_ID);
oResult_Get_Trip_By_TRIP_ID.My_Result = oReturnValue;
oResult_Get_Trip_By_TRIP_ID.My_Params_Get_Trip_By_TRIP_ID = i_Params_Get_Trip_By_TRIP_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Trip_By_TRIP_ID.ExceptionMsg = string.Format("Get_Trip_By_TRIP_ID : {0}", ex.Message);
}
else
{
oResult_Get_Trip_By_TRIP_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Trip_By_TRIP_ID;
#endregion
}
#endregion
}

#region Action_Result
public partial class Action_Result
{
#region Properties.
public string ExceptionMsg { get; set; }
#endregion
#region Constructor
public Action_Result()
{
#region Declaration And Initialization Section.
#endregion
#region Body Section.
this.ExceptionMsg = string.Empty;
#endregion
}
#endregion
}
#endregion
#region Result_Delete_Trip
public partial class Result_Delete_Trip : Action_Result
{
#region Properties.
public Params_Delete_Trip My_Params_Delete_Trip { get; set; }
#endregion
}
#endregion
#region Result_Edit_Trip
public partial class Result_Edit_Trip : Action_Result
{
#region Properties.
public Trip My_Trip { get; set; }
#endregion
}
#endregion
#region Result_Get_Trip_By_OWNER_ID
public partial class Result_Get_Trip_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Trip>  My_Result { get; set; }
public Params_Get_Trip_By_OWNER_ID My_Params_Get_Trip_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Trip_By_TRIP_ID
public partial class Result_Get_Trip_By_TRIP_ID : Action_Result
{
#region Properties.
public Trip My_Result { get; set; }
public Params_Get_Trip_By_TRIP_ID My_Params_Get_Trip_By_TRIP_ID { get; set; }
#endregion
}
#endregion
