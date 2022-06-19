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
#region Delete_Features
[HttpPost]
[Route("Delete_Features")]
public Result_Delete_Features Delete_Features(Params_Delete_Features i_Params_Delete_Features)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Features oResult_Delete_Features = new Result_Delete_Features();
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
oBLC.Delete_Features(i_Params_Delete_Features);
oResult_Delete_Features.My_Params_Delete_Features = i_Params_Delete_Features;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Features.ExceptionMsg = string.Format("Delete_Features : {0}", ex.Message);
}
else
{
oResult_Delete_Features.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Features;
#endregion
}
#endregion
#region Delete_Includes
[HttpPost]
[Route("Delete_Includes")]
public Result_Delete_Includes Delete_Includes(Params_Delete_Includes i_Params_Delete_Includes)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Includes oResult_Delete_Includes = new Result_Delete_Includes();
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
oBLC.Delete_Includes(i_Params_Delete_Includes);
oResult_Delete_Includes.My_Params_Delete_Includes = i_Params_Delete_Includes;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Includes.ExceptionMsg = string.Format("Delete_Includes : {0}", ex.Message);
}
else
{
oResult_Delete_Includes.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Includes;
#endregion
}
#endregion
#region Delete_Social_media_links
[HttpPost]
[Route("Delete_Social_media_links")]
public Result_Delete_Social_media_links Delete_Social_media_links(Params_Delete_Social_media_links i_Params_Delete_Social_media_links)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Social_media_links oResult_Delete_Social_media_links = new Result_Delete_Social_media_links();
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
oBLC.Delete_Social_media_links(i_Params_Delete_Social_media_links);
oResult_Delete_Social_media_links.My_Params_Delete_Social_media_links = i_Params_Delete_Social_media_links;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Social_media_links.ExceptionMsg = string.Format("Delete_Social_media_links : {0}", ex.Message);
}
else
{
oResult_Delete_Social_media_links.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Social_media_links;
#endregion
}
#endregion
#region Delete_Staff
[HttpPost]
[Route("Delete_Staff")]
public Result_Delete_Staff Delete_Staff(Params_Delete_Staff i_Params_Delete_Staff)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Staff oResult_Delete_Staff = new Result_Delete_Staff();
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
oBLC.Delete_Staff(i_Params_Delete_Staff);
oResult_Delete_Staff.My_Params_Delete_Staff = i_Params_Delete_Staff;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Staff.ExceptionMsg = string.Format("Delete_Staff : {0}", ex.Message);
}
else
{
oResult_Delete_Staff.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Staff;
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Trip);
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
#region Delete_Uploaded_file
[HttpPost]
[Route("Delete_Uploaded_file")]
public Result_Delete_Uploaded_file Delete_Uploaded_file(Params_Delete_Uploaded_file i_Params_Delete_Uploaded_file)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Uploaded_file oResult_Delete_Uploaded_file = new Result_Delete_Uploaded_file();
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
oBLC.Delete_Uploaded_file(i_Params_Delete_Uploaded_file);
oResult_Delete_Uploaded_file.My_Params_Delete_Uploaded_file = i_Params_Delete_Uploaded_file;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Uploaded_file.ExceptionMsg = string.Format("Delete_Uploaded_file : {0}", ex.Message);
}
else
{
oResult_Delete_Uploaded_file.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Uploaded_file;
#endregion
}
#endregion
#region Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD
[HttpPost]
[Route("Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD")]
public Result_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD oResult_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD = new Result_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD();
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
oBLC.Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD);
oResult_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.My_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD = i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.ExceptionMsg = string.Format("Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD : {0}", ex.Message);
}
else
{
oResult_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD;
#endregion
}
#endregion
#region Edit_Features
[HttpPost]
[Route("Edit_Features")]
public Result_Edit_Features Edit_Features(Features i_Features)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Features oResult_Edit_Features = new Result_Edit_Features();
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
oBLC.Edit_Features(i_Features);
oResult_Edit_Features.My_Features = i_Features;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Features.ExceptionMsg = string.Format("Edit_Features : {0}", ex.Message);
}
else
{
oResult_Edit_Features.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Features;
#endregion
}
#endregion
#region Edit_Includes
[HttpPost]
[Route("Edit_Includes")]
public Result_Edit_Includes Edit_Includes(Includes i_Includes)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Includes oResult_Edit_Includes = new Result_Edit_Includes();
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
oBLC.Edit_Includes(i_Includes);
oResult_Edit_Includes.My_Includes = i_Includes;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Includes.ExceptionMsg = string.Format("Edit_Includes : {0}", ex.Message);
}
else
{
oResult_Edit_Includes.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Includes;
#endregion
}
#endregion
#region Edit_Social_media_links
[HttpPost]
[Route("Edit_Social_media_links")]
public Result_Edit_Social_media_links Edit_Social_media_links(Social_media_links i_Social_media_links)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Social_media_links oResult_Edit_Social_media_links = new Result_Edit_Social_media_links();
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
oBLC.Edit_Social_media_links(i_Social_media_links);
oResult_Edit_Social_media_links.My_Social_media_links = i_Social_media_links;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Social_media_links.ExceptionMsg = string.Format("Edit_Social_media_links : {0}", ex.Message);
}
else
{
oResult_Edit_Social_media_links.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Social_media_links;
#endregion
}
#endregion
#region Edit_Staff
[HttpPost]
[Route("Edit_Staff")]
public Result_Edit_Staff Edit_Staff(Staff i_Staff)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Staff oResult_Edit_Staff = new Result_Edit_Staff();
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
oBLC.Edit_Staff(i_Staff);
oResult_Edit_Staff.My_Staff = i_Staff;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Staff.ExceptionMsg = string.Format("Edit_Staff : {0}", ex.Message);
}
else
{
oResult_Edit_Staff.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Staff;
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Trip);
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
#region Edit_Uploaded_file
[HttpPost]
[Route("Edit_Uploaded_file")]
public Result_Edit_Uploaded_file Edit_Uploaded_file(Uploaded_file i_Uploaded_file)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Uploaded_file oResult_Edit_Uploaded_file = new Result_Edit_Uploaded_file();
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
oBLC.Edit_Uploaded_file(i_Uploaded_file);
oResult_Edit_Uploaded_file.My_Uploaded_file = i_Uploaded_file;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Uploaded_file.ExceptionMsg = string.Format("Edit_Uploaded_file : {0}", ex.Message);
}
else
{
oResult_Edit_Uploaded_file.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Uploaded_file;
#endregion
}
#endregion
#region Get_Features_By_Where
[HttpPost]
[Route("Get_Features_By_Where")]
public Result_Get_Features_By_Where Get_Features_By_Where(Params_Get_Features_By_Where i_Params_Get_Features_By_Where)
{
#region Declaration And Initialization Section.
List<Features>  oReturnValue = new List<Features> ();
string i_Ticket = string.Empty;
Result_Get_Features_By_Where oResult_Get_Features_By_Where = new Result_Get_Features_By_Where();
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
oReturnValue = oBLC.Get_Features_By_Where(i_Params_Get_Features_By_Where);
oResult_Get_Features_By_Where.My_Result = oReturnValue;
oResult_Get_Features_By_Where.My_Params_Get_Features_By_Where = i_Params_Get_Features_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Features_By_Where.ExceptionMsg = string.Format("Get_Features_By_Where : {0}", ex.Message);
}
else
{
oResult_Get_Features_By_Where.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Features_By_Where;
#endregion
}
#endregion
#region Get_Includes_By_Where
[HttpPost]
[Route("Get_Includes_By_Where")]
public Result_Get_Includes_By_Where Get_Includes_By_Where(Params_Get_Includes_By_Where i_Params_Get_Includes_By_Where)
{
#region Declaration And Initialization Section.
List<Includes>  oReturnValue = new List<Includes> ();
string i_Ticket = string.Empty;
Result_Get_Includes_By_Where oResult_Get_Includes_By_Where = new Result_Get_Includes_By_Where();
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
oReturnValue = oBLC.Get_Includes_By_Where(i_Params_Get_Includes_By_Where);
oResult_Get_Includes_By_Where.My_Result = oReturnValue;
oResult_Get_Includes_By_Where.My_Params_Get_Includes_By_Where = i_Params_Get_Includes_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Includes_By_Where.ExceptionMsg = string.Format("Get_Includes_By_Where : {0}", ex.Message);
}
else
{
oResult_Get_Includes_By_Where.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Includes_By_Where;
#endregion
}
#endregion
#region Get_Social_media_links_By_Where
[HttpPost]
[Route("Get_Social_media_links_By_Where")]
public Result_Get_Social_media_links_By_Where Get_Social_media_links_By_Where(Params_Get_Social_media_links_By_Where i_Params_Get_Social_media_links_By_Where)
{
#region Declaration And Initialization Section.
List<Social_media_links>  oReturnValue = new List<Social_media_links> ();
string i_Ticket = string.Empty;
Result_Get_Social_media_links_By_Where oResult_Get_Social_media_links_By_Where = new Result_Get_Social_media_links_By_Where();
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
oReturnValue = oBLC.Get_Social_media_links_By_Where(i_Params_Get_Social_media_links_By_Where);
oResult_Get_Social_media_links_By_Where.My_Result = oReturnValue;
oResult_Get_Social_media_links_By_Where.My_Params_Get_Social_media_links_By_Where = i_Params_Get_Social_media_links_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Social_media_links_By_Where.ExceptionMsg = string.Format("Get_Social_media_links_By_Where : {0}", ex.Message);
}
else
{
oResult_Get_Social_media_links_By_Where.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Social_media_links_By_Where;
#endregion
}
#endregion
#region Get_Staff_By_Where
[HttpPost]
[Route("Get_Staff_By_Where")]
public Result_Get_Staff_By_Where Get_Staff_By_Where(Params_Get_Staff_By_Where i_Params_Get_Staff_By_Where)
{
#region Declaration And Initialization Section.
List<Staff>  oReturnValue = new List<Staff> ();
string i_Ticket = string.Empty;
Result_Get_Staff_By_Where oResult_Get_Staff_By_Where = new Result_Get_Staff_By_Where();
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
oReturnValue = oBLC.Get_Staff_By_Where(i_Params_Get_Staff_By_Where);
oResult_Get_Staff_By_Where.My_Result = oReturnValue;
oResult_Get_Staff_By_Where.My_Params_Get_Staff_By_Where = i_Params_Get_Staff_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Staff_By_Where.ExceptionMsg = string.Format("Get_Staff_By_Where : {0}", ex.Message);
}
else
{
oResult_Get_Staff_By_Where.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Staff_By_Where;
#endregion
}
#endregion
#region Get_Trip_By_Criteria
[HttpPost]
[Route("Get_Trip_By_Criteria")]
public Result_Get_Trip_By_Criteria Get_Trip_By_Criteria(Params_Get_Trip_By_Criteria i_Params_Get_Trip_By_Criteria)
{
#region Declaration And Initialization Section.
List<Trip>  oReturnValue = new List<Trip> ();
string i_Ticket = string.Empty;
Result_Get_Trip_By_Criteria oResult_Get_Trip_By_Criteria = new Result_Get_Trip_By_Criteria();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Trip_By_Criteria);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Trip_By_Criteria(i_Params_Get_Trip_By_Criteria);
oResult_Get_Trip_By_Criteria.My_Result = oReturnValue;
oResult_Get_Trip_By_Criteria.My_Params_Get_Trip_By_Criteria = i_Params_Get_Trip_By_Criteria;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Trip_By_Criteria.ExceptionMsg = string.Format("Get_Trip_By_Criteria : {0}", ex.Message);
}
else
{
oResult_Get_Trip_By_Criteria.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Trip_By_Criteria;
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Trip_By_OWNER_ID);
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Trip_By_TRIP_ID);
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
#region Get_Trip_By_Where
[HttpPost]
[Route("Get_Trip_By_Where")]
public Result_Get_Trip_By_Where Get_Trip_By_Where(Params_Get_Trip_By_Where i_Params_Get_Trip_By_Where)
{
#region Declaration And Initialization Section.
List<Trip>  oReturnValue = new List<Trip> ();
string i_Ticket = string.Empty;
Result_Get_Trip_By_Where oResult_Get_Trip_By_Where = new Result_Get_Trip_By_Where();
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
oReturnValue = oBLC.Get_Trip_By_Where(i_Params_Get_Trip_By_Where);
oResult_Get_Trip_By_Where.My_Result = oReturnValue;
oResult_Get_Trip_By_Where.My_Params_Get_Trip_By_Where = i_Params_Get_Trip_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Trip_By_Where.ExceptionMsg = string.Format("Get_Trip_By_Where : {0}", ex.Message);
}
else
{
oResult_Get_Trip_By_Where.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Trip_By_Where;
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
#region Result_Delete_Features
public partial class Result_Delete_Features : Action_Result
{
#region Properties.
public Params_Delete_Features My_Params_Delete_Features { get; set; }
#endregion
}
#endregion
#region Result_Delete_Includes
public partial class Result_Delete_Includes : Action_Result
{
#region Properties.
public Params_Delete_Includes My_Params_Delete_Includes { get; set; }
#endregion
}
#endregion
#region Result_Delete_Social_media_links
public partial class Result_Delete_Social_media_links : Action_Result
{
#region Properties.
public Params_Delete_Social_media_links My_Params_Delete_Social_media_links { get; set; }
#endregion
}
#endregion
#region Result_Delete_Staff
public partial class Result_Delete_Staff : Action_Result
{
#region Properties.
public Params_Delete_Staff My_Params_Delete_Staff { get; set; }
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
#region Result_Delete_Uploaded_file
public partial class Result_Delete_Uploaded_file : Action_Result
{
#region Properties.
public Params_Delete_Uploaded_file My_Params_Delete_Uploaded_file { get; set; }
#endregion
}
#endregion
#region Result_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD
public partial class Result_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD : Action_Result
{
#region Properties.
public Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD My_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD { get; set; }
#endregion
}
#endregion
#region Result_Edit_Features
public partial class Result_Edit_Features : Action_Result
{
#region Properties.
public Features My_Features { get; set; }
#endregion
}
#endregion
#region Result_Edit_Includes
public partial class Result_Edit_Includes : Action_Result
{
#region Properties.
public Includes My_Includes { get; set; }
#endregion
}
#endregion
#region Result_Edit_Social_media_links
public partial class Result_Edit_Social_media_links : Action_Result
{
#region Properties.
public Social_media_links My_Social_media_links { get; set; }
#endregion
}
#endregion
#region Result_Edit_Staff
public partial class Result_Edit_Staff : Action_Result
{
#region Properties.
public Staff My_Staff { get; set; }
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
#region Result_Edit_Uploaded_file
public partial class Result_Edit_Uploaded_file : Action_Result
{
#region Properties.
public Uploaded_file My_Uploaded_file { get; set; }
#endregion
}
#endregion
#region Result_Get_Features_By_Where
public partial class Result_Get_Features_By_Where : Action_Result
{
#region Properties.
public List<Features>  My_Result { get; set; }
public Params_Get_Features_By_Where My_Params_Get_Features_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Includes_By_Where
public partial class Result_Get_Includes_By_Where : Action_Result
{
#region Properties.
public List<Includes>  My_Result { get; set; }
public Params_Get_Includes_By_Where My_Params_Get_Includes_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Social_media_links_By_Where
public partial class Result_Get_Social_media_links_By_Where : Action_Result
{
#region Properties.
public List<Social_media_links>  My_Result { get; set; }
public Params_Get_Social_media_links_By_Where My_Params_Get_Social_media_links_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Staff_By_Where
public partial class Result_Get_Staff_By_Where : Action_Result
{
#region Properties.
public List<Staff>  My_Result { get; set; }
public Params_Get_Staff_By_Where My_Params_Get_Staff_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Trip_By_Criteria
public partial class Result_Get_Trip_By_Criteria : Action_Result
{
#region Properties.
public List<Trip>  My_Result { get; set; }
public Params_Get_Trip_By_Criteria My_Params_Get_Trip_By_Criteria { get; set; }
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
#region Result_Get_Trip_By_Where
public partial class Result_Get_Trip_By_Where : Action_Result
{
#region Properties.
public List<Trip>  My_Result { get; set; }
public Params_Get_Trip_By_Where My_Params_Get_Trip_By_Where { get; set; }
#endregion
}
#endregion
