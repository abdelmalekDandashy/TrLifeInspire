using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Configuration;
using DALC;
//using System.Data.Linq;
using System.Text.RegularExpressions;
using System.Transactions;
using System.Reflection;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Threading;







namespace BLC
{
public partial class BLC
{
#region Members
#region Used For Delete Operations
private Reservation_query _Reservation_query;
private Loc_l3 _Loc_l3;
private Review _Review;
private Trip _Trip;
private Loc_l4 _Loc_l4;
private Address _Address;
private Owner _Owner;
private Features _Features;
private User _User;
private Includes _Includes;
private Staff _Staff;
private Person _Person;
private Tags _Tags;
private Social_media_links _Social_media_links;
private Contact _Contact;
private Uploaded_file _Uploaded_file;
private Loc_l1 _Loc_l1;
private Loc_l2 _Loc_l2;
#endregion
#region Stop Executing Flags For Edit and Delete Operations
private bool _Stop_Edit_Reservation_query_Execution;
private bool _Stop_Delete_Reservation_query_Execution;
private bool _Stop_Edit_Loc_l3_Execution;
private bool _Stop_Delete_Loc_l3_Execution;
private bool _Stop_Edit_Review_Execution;
private bool _Stop_Delete_Review_Execution;
private bool _Stop_Edit_Trip_Execution;
private bool _Stop_Delete_Trip_Execution;
private bool _Stop_Edit_Loc_l4_Execution;
private bool _Stop_Delete_Loc_l4_Execution;
private bool _Stop_Edit_Address_Execution;
private bool _Stop_Delete_Address_Execution;
private bool _Stop_Edit_Owner_Execution;
private bool _Stop_Delete_Owner_Execution;
private bool _Stop_Edit_Features_Execution;
private bool _Stop_Delete_Features_Execution;
private bool _Stop_Edit_User_Execution;
private bool _Stop_Delete_User_Execution;
private bool _Stop_Edit_Includes_Execution;
private bool _Stop_Delete_Includes_Execution;
private bool _Stop_Edit_Staff_Execution;
private bool _Stop_Delete_Staff_Execution;
private bool _Stop_Edit_Person_Execution;
private bool _Stop_Delete_Person_Execution;
private bool _Stop_Edit_Tags_Execution;
private bool _Stop_Delete_Tags_Execution;
private bool _Stop_Edit_Social_media_links_Execution;
private bool _Stop_Delete_Social_media_links_Execution;
private bool _Stop_Edit_Contact_Execution;
private bool _Stop_Delete_Contact_Execution;
private bool _Stop_Edit_Uploaded_file_Execution;
private bool _Stop_Delete_Uploaded_file_Execution;
private bool _Stop_Edit_Loc_l1_Execution;
private bool _Stop_Delete_Loc_l1_Execution;
private bool _Stop_Edit_Loc_l2_Execution;
private bool _Stop_Delete_Loc_l2_Execution;
#endregion
#endregion
public Reservation_query Get_Reservation_query_By_RESERVATION_QUERY_ID(Params_Get_Reservation_query_By_RESERVATION_QUERY_ID i_Params_Get_Reservation_query_By_RESERVATION_QUERY_ID)
{
Reservation_query oReservation_query = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Reservation_query_By_RESERVATION_QUERY_ID");}
#region Body Section.
DALC.Reservation_query oDBEntry = _AppContext.Get_Reservation_query_By_RESERVATION_QUERY_ID(i_Params_Get_Reservation_query_By_RESERVATION_QUERY_ID.RESERVATION_QUERY_ID);
oReservation_query = new Reservation_query();
oTools.CopyPropValues(oDBEntry, oReservation_query);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Reservation_query_By_RESERVATION_QUERY_ID");}
return oReservation_query;
}
public Loc_l3 Get_Loc_l3_By_LOC_L3_ID(Params_Get_Loc_l3_By_LOC_L3_ID i_Params_Get_Loc_l3_By_LOC_L3_ID)
{
Loc_l3 oLoc_l3 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L3_ID");}
#region Body Section.
DALC.Loc_l3 oDBEntry = _AppContext.Get_Loc_l3_By_LOC_L3_ID(i_Params_Get_Loc_l3_By_LOC_L3_ID.LOC_L3_ID);
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L3_ID");}
return oLoc_l3;
}
public Review Get_Review_By_REVIEW_ID(Params_Get_Review_By_REVIEW_ID i_Params_Get_Review_By_REVIEW_ID)
{
Review oReview = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Review_By_REVIEW_ID");}
#region Body Section.
DALC.Review oDBEntry = _AppContext.Get_Review_By_REVIEW_ID(i_Params_Get_Review_By_REVIEW_ID.REVIEW_ID);
oReview = new Review();
oTools.CopyPropValues(oDBEntry, oReview);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Review_By_REVIEW_ID");}
return oReview;
}
public Trip Get_Trip_By_TRIP_ID(Params_Get_Trip_By_TRIP_ID i_Params_Get_Trip_By_TRIP_ID)
{
Trip oTrip = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Trip_By_TRIP_ID");}
#region Body Section.
DALC.Trip oDBEntry = _AppContext.Get_Trip_By_TRIP_ID(i_Params_Get_Trip_By_TRIP_ID.TRIP_ID);
oTrip = new Trip();
oTools.CopyPropValues(oDBEntry, oTrip);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Trip_By_TRIP_ID");}
return oTrip;
}
public Loc_l4 Get_Loc_l4_By_LOC_L4_ID(Params_Get_Loc_l4_By_LOC_L4_ID i_Params_Get_Loc_l4_By_LOC_L4_ID)
{
Loc_l4 oLoc_l4 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L4_ID");}
#region Body Section.
DALC.Loc_l4 oDBEntry = _AppContext.Get_Loc_l4_By_LOC_L4_ID(i_Params_Get_Loc_l4_By_LOC_L4_ID.LOC_L4_ID);
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L4_ID");}
return oLoc_l4;
}
public Address Get_Address_By_ADDRESS_ID(Params_Get_Address_By_ADDRESS_ID i_Params_Get_Address_By_ADDRESS_ID)
{
Address oAddress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_ADDRESS_ID");}
#region Body Section.
DALC.Address oDBEntry = _AppContext.Get_Address_By_ADDRESS_ID(i_Params_Get_Address_By_ADDRESS_ID.ADDRESS_ID);
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_ADDRESS_ID");}
return oAddress;
}
public Owner Get_Owner_By_OWNER_ID(Params_Get_Owner_By_OWNER_ID i_Params_Get_Owner_By_OWNER_ID)
{
Owner oOwner = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_OWNER_ID");}
#region Body Section.
DALC.Owner oDBEntry = _AppContext.Get_Owner_By_OWNER_ID(i_Params_Get_Owner_By_OWNER_ID.OWNER_ID);
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_OWNER_ID");}
return oOwner;
}
public Features Get_Features_By_FEATURES_ID(Params_Get_Features_By_FEATURES_ID i_Params_Get_Features_By_FEATURES_ID)
{
Features oFeatures = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Features_By_FEATURES_ID");}
#region Body Section.
DALC.Features oDBEntry = _AppContext.Get_Features_By_FEATURES_ID(i_Params_Get_Features_By_FEATURES_ID.FEATURES_ID);
oFeatures = new Features();
oTools.CopyPropValues(oDBEntry, oFeatures);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Features_By_FEATURES_ID");}
return oFeatures;
}
public User Get_User_By_USER_ID(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
{
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID");}
#region Body Section.
DALC.User oDBEntry = _AppContext.Get_User_By_USER_ID(i_Params_Get_User_By_USER_ID.USER_ID);
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID");}
return oUser;
}
public Includes Get_Includes_By_INCLUDES_ID(Params_Get_Includes_By_INCLUDES_ID i_Params_Get_Includes_By_INCLUDES_ID)
{
Includes oIncludes = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Includes_By_INCLUDES_ID");}
#region Body Section.
DALC.Includes oDBEntry = _AppContext.Get_Includes_By_INCLUDES_ID(i_Params_Get_Includes_By_INCLUDES_ID.INCLUDES_ID);
oIncludes = new Includes();
oTools.CopyPropValues(oDBEntry, oIncludes);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Includes_By_INCLUDES_ID");}
return oIncludes;
}
public Staff Get_Staff_By_STAFF_ID(Params_Get_Staff_By_STAFF_ID i_Params_Get_Staff_By_STAFF_ID)
{
Staff oStaff = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_STAFF_ID");}
#region Body Section.
DALC.Staff oDBEntry = _AppContext.Get_Staff_By_STAFF_ID(i_Params_Get_Staff_By_STAFF_ID.STAFF_ID);
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_STAFF_ID");}
return oStaff;
}
public Person Get_Person_By_PERSON_ID(Params_Get_Person_By_PERSON_ID i_Params_Get_Person_By_PERSON_ID)
{
Person oPerson = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_PERSON_ID");}
#region Body Section.
DALC.Person oDBEntry = _AppContext.Get_Person_By_PERSON_ID(i_Params_Get_Person_By_PERSON_ID.PERSON_ID);
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_PERSON_ID");}
return oPerson;
}
public Tags Get_Tags_By_TAGS_ID(Params_Get_Tags_By_TAGS_ID i_Params_Get_Tags_By_TAGS_ID)
{
Tags oTags = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Tags_By_TAGS_ID");}
#region Body Section.
DALC.Tags oDBEntry = _AppContext.Get_Tags_By_TAGS_ID(i_Params_Get_Tags_By_TAGS_ID.TAGS_ID);
oTags = new Tags();
oTools.CopyPropValues(oDBEntry, oTags);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Tags_By_TAGS_ID");}
return oTags;
}
public Social_media_links Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID(Params_Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID i_Params_Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID)
{
Social_media_links oSocial_media_links = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID");}
#region Body Section.
DALC.Social_media_links oDBEntry = _AppContext.Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID(i_Params_Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID.SOCIAL_MEDIA_LINKS_ID);
oSocial_media_links = new Social_media_links();
oTools.CopyPropValues(oDBEntry, oSocial_media_links);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID");}
return oSocial_media_links;
}
public Contact Get_Contact_By_CONTACT_ID(Params_Get_Contact_By_CONTACT_ID i_Params_Get_Contact_By_CONTACT_ID)
{
Contact oContact = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_CONTACT_ID");}
#region Body Section.
DALC.Contact oDBEntry = _AppContext.Get_Contact_By_CONTACT_ID(i_Params_Get_Contact_By_CONTACT_ID.CONTACT_ID);
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_CONTACT_ID");}
return oContact;
}
public Uploaded_file Get_Uploaded_file_By_UPLOADED_FILE_ID(Params_Get_Uploaded_file_By_UPLOADED_FILE_ID i_Params_Get_Uploaded_file_By_UPLOADED_FILE_ID)
{
Uploaded_file oUploaded_file = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_UPLOADED_FILE_ID");}
#region Body Section.
DALC.Uploaded_file oDBEntry = _AppContext.Get_Uploaded_file_By_UPLOADED_FILE_ID(i_Params_Get_Uploaded_file_By_UPLOADED_FILE_ID.UPLOADED_FILE_ID);
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_UPLOADED_FILE_ID");}
return oUploaded_file;
}
public Loc_l1 Get_Loc_l1_By_LOC_L1_ID(Params_Get_Loc_l1_By_LOC_L1_ID i_Params_Get_Loc_l1_By_LOC_L1_ID)
{
Loc_l1 oLoc_l1 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_LOC_L1_ID");}
#region Body Section.
DALC.Loc_l1 oDBEntry = _AppContext.Get_Loc_l1_By_LOC_L1_ID(i_Params_Get_Loc_l1_By_LOC_L1_ID.LOC_L1_ID);
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_LOC_L1_ID");}
return oLoc_l1;
}
public Loc_l2 Get_Loc_l2_By_LOC_L2_ID(Params_Get_Loc_l2_By_LOC_L2_ID i_Params_Get_Loc_l2_By_LOC_L2_ID)
{
Loc_l2 oLoc_l2 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L2_ID");}
#region Body Section.
DALC.Loc_l2 oDBEntry = _AppContext.Get_Loc_l2_By_LOC_L2_ID(i_Params_Get_Loc_l2_By_LOC_L2_ID.LOC_L2_ID);
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L2_ID");}
return oLoc_l2;
}
public List<Reservation_query> Get_Reservation_query_By_RESERVATION_QUERY_ID_List(Params_Get_Reservation_query_By_RESERVATION_QUERY_ID_List i_Params_Get_Reservation_query_By_RESERVATION_QUERY_ID_List)
{
Reservation_query oReservation_query = null;
List<Reservation_query> oList = new List<Reservation_query>();
Params_Get_Reservation_query_By_RESERVATION_QUERY_ID_List_SP oParams_Get_Reservation_query_By_RESERVATION_QUERY_ID_List_SP = new Params_Get_Reservation_query_By_RESERVATION_QUERY_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Reservation_query_By_RESERVATION_QUERY_ID_List");}
#region Body Section.
List<DALC.Reservation_query> oList_DBEntries = _AppContext.Get_Reservation_query_By_RESERVATION_QUERY_ID_List(i_Params_Get_Reservation_query_By_RESERVATION_QUERY_ID_List.RESERVATION_QUERY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oReservation_query = new Reservation_query();
oTools.CopyPropValues(oDBEntry, oReservation_query);
oList.Add(oReservation_query);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Reservation_query_By_RESERVATION_QUERY_ID_List");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List(Params_Get_Loc_l3_By_LOC_L3_ID_List i_Params_Get_Loc_l3_By_LOC_L3_ID_List)
{
Loc_l3 oLoc_l3 = null;
List<Loc_l3> oList = new List<Loc_l3>();
Params_Get_Loc_l3_By_LOC_L3_ID_List_SP oParams_Get_Loc_l3_By_LOC_L3_ID_List_SP = new Params_Get_Loc_l3_By_LOC_L3_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L3_ID_List");}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L3_ID_List(i_Params_Get_Loc_l3_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L3_ID_List");}
return oList;
}
public List<Review> Get_Review_By_REVIEW_ID_List(Params_Get_Review_By_REVIEW_ID_List i_Params_Get_Review_By_REVIEW_ID_List)
{
Review oReview = null;
List<Review> oList = new List<Review>();
Params_Get_Review_By_REVIEW_ID_List_SP oParams_Get_Review_By_REVIEW_ID_List_SP = new Params_Get_Review_By_REVIEW_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Review_By_REVIEW_ID_List");}
#region Body Section.
List<DALC.Review> oList_DBEntries = _AppContext.Get_Review_By_REVIEW_ID_List(i_Params_Get_Review_By_REVIEW_ID_List.REVIEW_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oReview = new Review();
oTools.CopyPropValues(oDBEntry, oReview);
oList.Add(oReview);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Review_By_REVIEW_ID_List");}
return oList;
}
public List<Trip> Get_Trip_By_TRIP_ID_List(Params_Get_Trip_By_TRIP_ID_List i_Params_Get_Trip_By_TRIP_ID_List)
{
Trip oTrip = null;
List<Trip> oList = new List<Trip>();
Params_Get_Trip_By_TRIP_ID_List_SP oParams_Get_Trip_By_TRIP_ID_List_SP = new Params_Get_Trip_By_TRIP_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Trip_By_TRIP_ID_List");}
#region Body Section.
List<DALC.Trip> oList_DBEntries = _AppContext.Get_Trip_By_TRIP_ID_List(i_Params_Get_Trip_By_TRIP_ID_List.TRIP_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTrip = new Trip();
oTools.CopyPropValues(oDBEntry, oTrip);
oList.Add(oTrip);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Trip_By_TRIP_ID_List");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List(Params_Get_Loc_l4_By_LOC_L4_ID_List i_Params_Get_Loc_l4_By_LOC_L4_ID_List)
{
Loc_l4 oLoc_l4 = null;
List<Loc_l4> oList = new List<Loc_l4>();
Params_Get_Loc_l4_By_LOC_L4_ID_List_SP oParams_Get_Loc_l4_By_LOC_L4_ID_List_SP = new Params_Get_Loc_l4_By_LOC_L4_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L4_ID_List");}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L4_ID_List(i_Params_Get_Loc_l4_By_LOC_L4_ID_List.LOC_L4_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L4_ID_List");}
return oList;
}
public List<Address> Get_Address_By_ADDRESS_ID_List(Params_Get_Address_By_ADDRESS_ID_List i_Params_Get_Address_By_ADDRESS_ID_List)
{
Address oAddress = null;
List<Address> oList = new List<Address>();
Params_Get_Address_By_ADDRESS_ID_List_SP oParams_Get_Address_By_ADDRESS_ID_List_SP = new Params_Get_Address_By_ADDRESS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_ADDRESS_ID_List");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_ADDRESS_ID_List(i_Params_Get_Address_By_ADDRESS_ID_List.ADDRESS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_ADDRESS_ID_List");}
return oList;
}
public List<Owner> Get_Owner_By_OWNER_ID_List(Params_Get_Owner_By_OWNER_ID_List i_Params_Get_Owner_By_OWNER_ID_List)
{
Owner oOwner = null;
List<Owner> oList = new List<Owner>();
Params_Get_Owner_By_OWNER_ID_List_SP oParams_Get_Owner_By_OWNER_ID_List_SP = new Params_Get_Owner_By_OWNER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_OWNER_ID_List");}
#region Body Section.
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_OWNER_ID_List(i_Params_Get_Owner_By_OWNER_ID_List.OWNER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_OWNER_ID_List");}
return oList;
}
public List<Features> Get_Features_By_FEATURES_ID_List(Params_Get_Features_By_FEATURES_ID_List i_Params_Get_Features_By_FEATURES_ID_List)
{
Features oFeatures = null;
List<Features> oList = new List<Features>();
Params_Get_Features_By_FEATURES_ID_List_SP oParams_Get_Features_By_FEATURES_ID_List_SP = new Params_Get_Features_By_FEATURES_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Features_By_FEATURES_ID_List");}
#region Body Section.
List<DALC.Features> oList_DBEntries = _AppContext.Get_Features_By_FEATURES_ID_List(i_Params_Get_Features_By_FEATURES_ID_List.FEATURES_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeatures = new Features();
oTools.CopyPropValues(oDBEntry, oFeatures);
oList.Add(oFeatures);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Features_By_FEATURES_ID_List");}
return oList;
}
public List<User> Get_User_By_USER_ID_List(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
{
User oUser = null;
List<User> oList = new List<User>();
Params_Get_User_By_USER_ID_List_SP oParams_Get_User_By_USER_ID_List_SP = new Params_Get_User_By_USER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID_List");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USER_ID_List(i_Params_Get_User_By_USER_ID_List.USER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID_List");}
return oList;
}
public List<Includes> Get_Includes_By_INCLUDES_ID_List(Params_Get_Includes_By_INCLUDES_ID_List i_Params_Get_Includes_By_INCLUDES_ID_List)
{
Includes oIncludes = null;
List<Includes> oList = new List<Includes>();
Params_Get_Includes_By_INCLUDES_ID_List_SP oParams_Get_Includes_By_INCLUDES_ID_List_SP = new Params_Get_Includes_By_INCLUDES_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Includes_By_INCLUDES_ID_List");}
#region Body Section.
List<DALC.Includes> oList_DBEntries = _AppContext.Get_Includes_By_INCLUDES_ID_List(i_Params_Get_Includes_By_INCLUDES_ID_List.INCLUDES_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oIncludes = new Includes();
oTools.CopyPropValues(oDBEntry, oIncludes);
oList.Add(oIncludes);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Includes_By_INCLUDES_ID_List");}
return oList;
}
public List<Staff> Get_Staff_By_STAFF_ID_List(Params_Get_Staff_By_STAFF_ID_List i_Params_Get_Staff_By_STAFF_ID_List)
{
Staff oStaff = null;
List<Staff> oList = new List<Staff>();
Params_Get_Staff_By_STAFF_ID_List_SP oParams_Get_Staff_By_STAFF_ID_List_SP = new Params_Get_Staff_By_STAFF_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_STAFF_ID_List");}
#region Body Section.
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_STAFF_ID_List(i_Params_Get_Staff_By_STAFF_ID_List.STAFF_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oList.Add(oStaff);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_STAFF_ID_List");}
return oList;
}
public List<Person> Get_Person_By_PERSON_ID_List(Params_Get_Person_By_PERSON_ID_List i_Params_Get_Person_By_PERSON_ID_List)
{
Person oPerson = null;
List<Person> oList = new List<Person>();
Params_Get_Person_By_PERSON_ID_List_SP oParams_Get_Person_By_PERSON_ID_List_SP = new Params_Get_Person_By_PERSON_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_PERSON_ID_List");}
#region Body Section.
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_PERSON_ID_List(i_Params_Get_Person_By_PERSON_ID_List.PERSON_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_PERSON_ID_List");}
return oList;
}
public List<Tags> Get_Tags_By_TAGS_ID_List(Params_Get_Tags_By_TAGS_ID_List i_Params_Get_Tags_By_TAGS_ID_List)
{
Tags oTags = null;
List<Tags> oList = new List<Tags>();
Params_Get_Tags_By_TAGS_ID_List_SP oParams_Get_Tags_By_TAGS_ID_List_SP = new Params_Get_Tags_By_TAGS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Tags_By_TAGS_ID_List");}
#region Body Section.
List<DALC.Tags> oList_DBEntries = _AppContext.Get_Tags_By_TAGS_ID_List(i_Params_Get_Tags_By_TAGS_ID_List.TAGS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTags = new Tags();
oTools.CopyPropValues(oDBEntry, oTags);
oList.Add(oTags);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Tags_By_TAGS_ID_List");}
return oList;
}
public List<Social_media_links> Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID_List(Params_Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID_List i_Params_Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID_List)
{
Social_media_links oSocial_media_links = null;
List<Social_media_links> oList = new List<Social_media_links>();
Params_Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID_List_SP oParams_Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID_List_SP = new Params_Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID_List");}
#region Body Section.
List<DALC.Social_media_links> oList_DBEntries = _AppContext.Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID_List(i_Params_Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID_List.SOCIAL_MEDIA_LINKS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSocial_media_links = new Social_media_links();
oTools.CopyPropValues(oDBEntry, oSocial_media_links);
oList.Add(oSocial_media_links);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID_List");}
return oList;
}
public List<Contact> Get_Contact_By_CONTACT_ID_List(Params_Get_Contact_By_CONTACT_ID_List i_Params_Get_Contact_By_CONTACT_ID_List)
{
Contact oContact = null;
List<Contact> oList = new List<Contact>();
Params_Get_Contact_By_CONTACT_ID_List_SP oParams_Get_Contact_By_CONTACT_ID_List_SP = new Params_Get_Contact_By_CONTACT_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_CONTACT_ID_List");}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_CONTACT_ID_List(i_Params_Get_Contact_By_CONTACT_ID_List.CONTACT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_CONTACT_ID_List");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_UPLOADED_FILE_ID_List(Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List i_Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List)
{
Uploaded_file oUploaded_file = null;
List<Uploaded_file> oList = new List<Uploaded_file>();
Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List_SP oParams_Get_Uploaded_file_By_UPLOADED_FILE_ID_List_SP = new Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_UPLOADED_FILE_ID_List");}
#region Body Section.
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_UPLOADED_FILE_ID_List(i_Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List.UPLOADED_FILE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_UPLOADED_FILE_ID_List");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List(Params_Get_Loc_l1_By_LOC_L1_ID_List i_Params_Get_Loc_l1_By_LOC_L1_ID_List)
{
Loc_l1 oLoc_l1 = null;
List<Loc_l1> oList = new List<Loc_l1>();
Params_Get_Loc_l1_By_LOC_L1_ID_List_SP oParams_Get_Loc_l1_By_LOC_L1_ID_List_SP = new Params_Get_Loc_l1_By_LOC_L1_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_LOC_L1_ID_List");}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_LOC_L1_ID_List(i_Params_Get_Loc_l1_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
oList.Add(oLoc_l1);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_LOC_L1_ID_List");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List(Params_Get_Loc_l2_By_LOC_L2_ID_List i_Params_Get_Loc_l2_By_LOC_L2_ID_List)
{
Loc_l2 oLoc_l2 = null;
List<Loc_l2> oList = new List<Loc_l2>();
Params_Get_Loc_l2_By_LOC_L2_ID_List_SP oParams_Get_Loc_l2_By_LOC_L2_ID_List_SP = new Params_Get_Loc_l2_By_LOC_L2_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L2_ID_List");}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L2_ID_List(i_Params_Get_Loc_l2_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L2_ID_List");}
return oList;
}
public List<Reservation_query> Get_Reservation_query_By_OWNER_ID(Params_Get_Reservation_query_By_OWNER_ID i_Params_Get_Reservation_query_By_OWNER_ID)
{
List<Reservation_query> oList = new List<Reservation_query>();
Reservation_query oReservation_query = new Reservation_query();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Reservation_query_By_OWNER_ID");}
#region Body Section.
List<DALC.Reservation_query> oList_DBEntries = _AppContext.Get_Reservation_query_By_OWNER_ID(i_Params_Get_Reservation_query_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oReservation_query = new Reservation_query();
oTools.CopyPropValues(oDBEntry, oReservation_query);
oList.Add(oReservation_query);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Reservation_query_By_OWNER_ID");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE(Params_Get_Loc_l3_By_LOC_L2_ID_CODE i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID_CODE");}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID_CODE(i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE.LOC_L2_ID,i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID_CODE");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID(Params_Get_Loc_l3_By_LOC_L2_ID i_Params_Get_Loc_l3_By_LOC_L2_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID");}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID(i_Params_Get_Loc_l3_By_LOC_L2_ID.LOC_L2_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_OWNER_ID(Params_Get_Loc_l3_By_OWNER_ID i_Params_Get_Loc_l3_By_OWNER_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_OWNER_ID");}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_OWNER_ID(i_Params_Get_Loc_l3_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_OWNER_ID");}
return oList;
}
public List<Review> Get_Review_By_OWNER_ID(Params_Get_Review_By_OWNER_ID i_Params_Get_Review_By_OWNER_ID)
{
List<Review> oList = new List<Review>();
Review oReview = new Review();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Review_By_OWNER_ID");}
#region Body Section.
List<DALC.Review> oList_DBEntries = _AppContext.Get_Review_By_OWNER_ID(i_Params_Get_Review_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oReview = new Review();
oTools.CopyPropValues(oDBEntry, oReview);
oList.Add(oReview);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Review_By_OWNER_ID");}
return oList;
}
public List<Trip> Get_Trip_By_OWNER_ID(Params_Get_Trip_By_OWNER_ID i_Params_Get_Trip_By_OWNER_ID)
{
List<Trip> oList = new List<Trip>();
Trip oTrip = new Trip();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Trip_By_OWNER_ID");}
#region Body Section.
List<DALC.Trip> oList_DBEntries = _AppContext.Get_Trip_By_OWNER_ID(i_Params_Get_Trip_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTrip = new Trip();
oTools.CopyPropValues(oDBEntry, oTrip);
oList.Add(oTrip);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Trip_By_OWNER_ID");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE(Params_Get_Loc_l4_By_LOC_L3_ID_CODE i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID_CODE");}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID_CODE(i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE.LOC_L3_ID,i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID_CODE");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID(Params_Get_Loc_l4_By_LOC_L3_ID i_Params_Get_Loc_l4_By_LOC_L3_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID");}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID(i_Params_Get_Loc_l4_By_LOC_L3_ID.LOC_L3_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_OWNER_ID(Params_Get_Loc_l4_By_OWNER_ID i_Params_Get_Loc_l4_By_OWNER_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_OWNER_ID");}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_OWNER_ID(i_Params_Get_Loc_l4_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_OWNER_ID");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID(Params_Get_Address_By_PERSON_ID i_Params_Get_Address_By_PERSON_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID(i_Params_Get_Address_By_PERSON_ID.PERSON_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID");}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID(Params_Get_Address_By_LOC_L1_ID i_Params_Get_Address_By_LOC_L1_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L1_ID");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L1_ID(i_Params_Get_Address_By_LOC_L1_ID.LOC_L1_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L1_ID");}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID(Params_Get_Address_By_LOC_L2_ID i_Params_Get_Address_By_LOC_L2_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L2_ID");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L2_ID(i_Params_Get_Address_By_LOC_L2_ID.LOC_L2_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L2_ID");}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID(Params_Get_Address_By_LOC_L3_ID i_Params_Get_Address_By_LOC_L3_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L3_ID");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L3_ID(i_Params_Get_Address_By_LOC_L3_ID.LOC_L3_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L3_ID");}
return oList;
}
public List<Address> Get_Address_By_OWNER_ID(Params_Get_Address_By_OWNER_ID i_Params_Get_Address_By_OWNER_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_OWNER_ID");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_OWNER_ID(i_Params_Get_Address_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_OWNER_ID");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE(Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE(i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.PERSON_ID,i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.ADDRESS_TYPE_CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE");}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID(Params_Get_Address_By_LOC_L4_ID i_Params_Get_Address_By_LOC_L4_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L4_ID");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L4_ID(i_Params_Get_Address_By_LOC_L4_ID.LOC_L4_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L4_ID");}
return oList;
}
public List<Features> Get_Features_By_OWNER_ID(Params_Get_Features_By_OWNER_ID i_Params_Get_Features_By_OWNER_ID)
{
List<Features> oList = new List<Features>();
Features oFeatures = new Features();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Features_By_OWNER_ID");}
#region Body Section.
List<DALC.Features> oList_DBEntries = _AppContext.Get_Features_By_OWNER_ID(i_Params_Get_Features_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeatures = new Features();
oTools.CopyPropValues(oDBEntry, oFeatures);
oList.Add(oFeatures);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Features_By_OWNER_ID");}
return oList;
}
public List<Features> Get_Features_By_TRIP_ID(Params_Get_Features_By_TRIP_ID i_Params_Get_Features_By_TRIP_ID)
{
List<Features> oList = new List<Features>();
Features oFeatures = new Features();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Features_By_TRIP_ID");}
#region PreEvent_Get_Features_By_TRIP_ID
if (OnPreEvent_Get_Features_By_TRIP_ID != null)
{
OnPreEvent_Get_Features_By_TRIP_ID(i_Params_Get_Features_By_TRIP_ID);
}
#endregion
#region Body Section.
List<DALC.Features> oList_DBEntries = _AppContext.Get_Features_By_TRIP_ID(i_Params_Get_Features_By_TRIP_ID.TRIP_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeatures = new Features();
oTools.CopyPropValues(oDBEntry, oFeatures);
oList.Add(oFeatures);
}
}
#endregion
#region PostEvent_Get_Features_By_TRIP_ID
if (OnPostEvent_Get_Features_By_TRIP_ID != null)
{
OnPostEvent_Get_Features_By_TRIP_ID(ref oList,i_Params_Get_Features_By_TRIP_ID);
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Features_By_TRIP_ID");}
return oList;
}
public List<User> Get_User_By_OWNER_ID(Params_Get_User_By_OWNER_ID i_Params_Get_User_By_OWNER_ID)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_OWNER_ID");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_OWNER_ID(i_Params_Get_User_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_OWNER_ID");}
return oList;
}
public List<User> Get_User_By_USERNAME(Params_Get_User_By_USERNAME i_Params_Get_User_By_USERNAME)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USERNAME");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USERNAME(i_Params_Get_User_By_USERNAME.USERNAME);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USERNAME");}
return oList;
}
public List<Includes> Get_Includes_By_OWNER_ID(Params_Get_Includes_By_OWNER_ID i_Params_Get_Includes_By_OWNER_ID)
{
List<Includes> oList = new List<Includes>();
Includes oIncludes = new Includes();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Includes_By_OWNER_ID");}
#region Body Section.
List<DALC.Includes> oList_DBEntries = _AppContext.Get_Includes_By_OWNER_ID(i_Params_Get_Includes_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oIncludes = new Includes();
oTools.CopyPropValues(oDBEntry, oIncludes);
oList.Add(oIncludes);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Includes_By_OWNER_ID");}
return oList;
}
public List<Includes> Get_Includes_By_TRIP_ID(Params_Get_Includes_By_TRIP_ID i_Params_Get_Includes_By_TRIP_ID)
{
List<Includes> oList = new List<Includes>();
Includes oIncludes = new Includes();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Includes_By_TRIP_ID");}
#region Body Section.
List<DALC.Includes> oList_DBEntries = _AppContext.Get_Includes_By_TRIP_ID(i_Params_Get_Includes_By_TRIP_ID.TRIP_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oIncludes = new Includes();
oTools.CopyPropValues(oDBEntry, oIncludes);
oList.Add(oIncludes);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Includes_By_TRIP_ID");}
return oList;
}
public List<Staff> Get_Staff_By_OWNER_ID(Params_Get_Staff_By_OWNER_ID i_Params_Get_Staff_By_OWNER_ID)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_OWNER_ID");}
#region Body Section.
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_OWNER_ID(i_Params_Get_Staff_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oList.Add(oStaff);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_OWNER_ID");}
return oList;
}
public List<Person> Get_Person_By_OWNER_ID(Params_Get_Person_By_OWNER_ID i_Params_Get_Person_By_OWNER_ID)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_OWNER_ID");}
#region Body Section.
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_OWNER_ID(i_Params_Get_Person_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_OWNER_ID");}
return oList;
}
public List<Tags> Get_Tags_By_OWNER_ID(Params_Get_Tags_By_OWNER_ID i_Params_Get_Tags_By_OWNER_ID)
{
List<Tags> oList = new List<Tags>();
Tags oTags = new Tags();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Tags_By_OWNER_ID");}
#region Body Section.
List<DALC.Tags> oList_DBEntries = _AppContext.Get_Tags_By_OWNER_ID(i_Params_Get_Tags_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTags = new Tags();
oTools.CopyPropValues(oDBEntry, oTags);
oList.Add(oTags);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Tags_By_OWNER_ID");}
return oList;
}
public List<Tags> Get_Tags_By_TRIP_ID(Params_Get_Tags_By_TRIP_ID i_Params_Get_Tags_By_TRIP_ID)
{
List<Tags> oList = new List<Tags>();
Tags oTags = new Tags();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Tags_By_TRIP_ID");}
#region Body Section.
List<DALC.Tags> oList_DBEntries = _AppContext.Get_Tags_By_TRIP_ID(i_Params_Get_Tags_By_TRIP_ID.TRIP_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTags = new Tags();
oTools.CopyPropValues(oDBEntry, oTags);
oList.Add(oTags);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Tags_By_TRIP_ID");}
return oList;
}
public List<Social_media_links> Get_Social_media_links_By_OWNER_ID(Params_Get_Social_media_links_By_OWNER_ID i_Params_Get_Social_media_links_By_OWNER_ID)
{
List<Social_media_links> oList = new List<Social_media_links>();
Social_media_links oSocial_media_links = new Social_media_links();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Social_media_links_By_OWNER_ID");}
#region Body Section.
List<DALC.Social_media_links> oList_DBEntries = _AppContext.Get_Social_media_links_By_OWNER_ID(i_Params_Get_Social_media_links_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSocial_media_links = new Social_media_links();
oTools.CopyPropValues(oDBEntry, oSocial_media_links);
oList.Add(oSocial_media_links);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Social_media_links_By_OWNER_ID");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID(Params_Get_Contact_By_PERSON_ID i_Params_Get_Contact_By_PERSON_ID)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID");}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID(i_Params_Get_Contact_By_PERSON_ID.PERSON_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT(Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT");}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT(i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.PERSON_ID,i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT");}
return oList;
}
public List<Contact> Get_Contact_By_OWNER_ID(Params_Get_Contact_By_OWNER_ID i_Params_Get_Contact_By_OWNER_ID)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_OWNER_ID");}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_OWNER_ID(i_Params_Get_Contact_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_OWNER_ID");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_OWNER_ID(Params_Get_Uploaded_file_By_OWNER_ID i_Params_Get_Uploaded_file_By_OWNER_ID)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
Uploaded_file oUploaded_file = new Uploaded_file();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_OWNER_ID");}
#region Body Section.
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_OWNER_ID(i_Params_Get_Uploaded_file_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_OWNER_ID");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY(Params_Get_Uploaded_file_By_REL_ENTITY i_Params_Get_Uploaded_file_By_REL_ENTITY)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
Uploaded_file oUploaded_file = new Uploaded_file();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_REL_ENTITY");}
#region Body Section.
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_REL_ENTITY(i_Params_Get_Uploaded_file_By_REL_ENTITY.REL_ENTITY);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_REL_ENTITY");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY_REL_KEY(Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
Uploaded_file oUploaded_file = new Uploaded_file();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_REL_ENTITY_REL_KEY");}
#region Body Section.
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_REL_ENTITY_REL_KEY(i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY.REL_ENTITY,i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY.REL_KEY);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_REL_ENTITY_REL_KEY");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
Uploaded_file oUploaded_file = new Uploaded_file();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD");}
#region Body Section.
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_ENTITY,i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_KEY,i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_FIELD);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_CODE(Params_Get_Loc_l1_By_CODE i_Params_Get_Loc_l1_By_CODE)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_CODE");}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_CODE(i_Params_Get_Loc_l1_By_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
oList.Add(oLoc_l1);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_CODE");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_OWNER_ID(Params_Get_Loc_l1_By_OWNER_ID i_Params_Get_Loc_l1_By_OWNER_ID)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_OWNER_ID");}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_OWNER_ID(i_Params_Get_Loc_l1_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
oList.Add(oLoc_l1);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_OWNER_ID");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE(Params_Get_Loc_l2_By_LOC_L1_ID_CODE i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID_CODE");}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID_CODE(i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE.LOC_L1_ID,i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID_CODE");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID(Params_Get_Loc_l2_By_LOC_L1_ID i_Params_Get_Loc_l2_By_LOC_L1_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID");}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID(i_Params_Get_Loc_l2_By_LOC_L1_ID.LOC_L1_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_OWNER_ID(Params_Get_Loc_l2_By_OWNER_ID i_Params_Get_Loc_l2_By_OWNER_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_OWNER_ID");}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_OWNER_ID(i_Params_Get_Loc_l2_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_OWNER_ID");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List(Params_Get_Loc_l3_By_LOC_L2_ID_List i_Params_Get_Loc_l3_By_LOC_L2_ID_List)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID_List");}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID_List(i_Params_Get_Loc_l3_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID_List");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List(Params_Get_Loc_l4_By_LOC_L3_ID_List i_Params_Get_Loc_l4_By_LOC_L3_ID_List)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID_List");}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID_List(i_Params_Get_Loc_l4_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID_List");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_List(Params_Get_Address_By_PERSON_ID_List i_Params_Get_Address_By_PERSON_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID_List");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID_List(i_Params_Get_Address_By_PERSON_ID_List.PERSON_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID_List");}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_List(Params_Get_Address_By_LOC_L1_ID_List i_Params_Get_Address_By_LOC_L1_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L1_ID_List");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L1_ID_List(i_Params_Get_Address_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L1_ID_List");}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_List(Params_Get_Address_By_LOC_L2_ID_List i_Params_Get_Address_By_LOC_L2_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L2_ID_List");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L2_ID_List(i_Params_Get_Address_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L2_ID_List");}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_List(Params_Get_Address_By_LOC_L3_ID_List i_Params_Get_Address_By_LOC_L3_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L3_ID_List");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L3_ID_List(i_Params_Get_Address_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L3_ID_List");}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_List(Params_Get_Address_By_LOC_L4_ID_List i_Params_Get_Address_By_LOC_L4_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L4_ID_List");}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L4_ID_List(i_Params_Get_Address_By_LOC_L4_ID_List.LOC_L4_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L4_ID_List");}
return oList;
}
public List<Features> Get_Features_By_TRIP_ID_List(Params_Get_Features_By_TRIP_ID_List i_Params_Get_Features_By_TRIP_ID_List)
{
List<Features> oList = new List<Features>();
Features oFeatures = new Features();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Features_By_TRIP_ID_List");}
#region Body Section.
List<DALC.Features> oList_DBEntries = _AppContext.Get_Features_By_TRIP_ID_List(i_Params_Get_Features_By_TRIP_ID_List.TRIP_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeatures = new Features();
oTools.CopyPropValues(oDBEntry, oFeatures);
oList.Add(oFeatures);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Features_By_TRIP_ID_List");}
return oList;
}
public List<Includes> Get_Includes_By_TRIP_ID_List(Params_Get_Includes_By_TRIP_ID_List i_Params_Get_Includes_By_TRIP_ID_List)
{
List<Includes> oList = new List<Includes>();
Includes oIncludes = new Includes();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Includes_By_TRIP_ID_List");}
#region Body Section.
List<DALC.Includes> oList_DBEntries = _AppContext.Get_Includes_By_TRIP_ID_List(i_Params_Get_Includes_By_TRIP_ID_List.TRIP_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oIncludes = new Includes();
oTools.CopyPropValues(oDBEntry, oIncludes);
oList.Add(oIncludes);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Includes_By_TRIP_ID_List");}
return oList;
}
public List<Tags> Get_Tags_By_TRIP_ID_List(Params_Get_Tags_By_TRIP_ID_List i_Params_Get_Tags_By_TRIP_ID_List)
{
List<Tags> oList = new List<Tags>();
Tags oTags = new Tags();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Tags_By_TRIP_ID_List");}
#region Body Section.
List<DALC.Tags> oList_DBEntries = _AppContext.Get_Tags_By_TRIP_ID_List(i_Params_Get_Tags_By_TRIP_ID_List.TRIP_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTags = new Tags();
oTools.CopyPropValues(oDBEntry, oTags);
oList.Add(oTags);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Tags_By_TRIP_ID_List");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_List(Params_Get_Contact_By_PERSON_ID_List i_Params_Get_Contact_By_PERSON_ID_List)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID_List");}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID_List(i_Params_Get_Contact_By_PERSON_ID_List.PERSON_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID_List");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List(Params_Get_Loc_l2_By_LOC_L1_ID_List i_Params_Get_Loc_l2_By_LOC_L1_ID_List)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID_List");}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID_List(i_Params_Get_Loc_l2_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID_List");}
return oList;
}
public List<Reservation_query> Get_Reservation_query_By_Criteria(Params_Get_Reservation_query_By_Criteria i_Params_Get_Reservation_query_By_Criteria)
{
List<Reservation_query> oList = new List<Reservation_query>();
Reservation_query oReservation_query = new Reservation_query();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Reservation_query_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Reservation_query_By_Criteria.OWNER_ID == null) || (i_Params_Get_Reservation_query_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Reservation_query_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Reservation_query_By_Criteria.START_ROW == null) { i_Params_Get_Reservation_query_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Reservation_query_By_Criteria.END_ROW == null) || (i_Params_Get_Reservation_query_By_Criteria.END_ROW == 0)) { i_Params_Get_Reservation_query_By_Criteria.END_ROW = 1000000; }
List<DALC.Reservation_query> oList_DBEntries = _AppContext.Get_Reservation_query_By_Criteria(i_Params_Get_Reservation_query_By_Criteria.PICK_UP_ADDRESS,i_Params_Get_Reservation_query_By_Criteria.TRIP_DATE,i_Params_Get_Reservation_query_By_Criteria.QUERY_DESCRIPTION,i_Params_Get_Reservation_query_By_Criteria.OWNER_ID,i_Params_Get_Reservation_query_By_Criteria.START_ROW,i_Params_Get_Reservation_query_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oReservation_query = new Reservation_query();
oTools.CopyPropValues(oDBEntry, oReservation_query);
oList.Add(oReservation_query);
}
}
i_Params_Get_Reservation_query_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Reservation_query_By_Criteria");}
return oList;
}
public List<Reservation_query> Get_Reservation_query_By_Where(Params_Get_Reservation_query_By_Where i_Params_Get_Reservation_query_By_Where)
{
List<Reservation_query> oList = new List<Reservation_query>();
Reservation_query oReservation_query = new Reservation_query();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Reservation_query_By_Where");}
#region Body Section.
if ((i_Params_Get_Reservation_query_By_Where.OWNER_ID == null) || (i_Params_Get_Reservation_query_By_Where.OWNER_ID == 0)) { i_Params_Get_Reservation_query_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Reservation_query_By_Where.START_ROW == null) { i_Params_Get_Reservation_query_By_Where.START_ROW = 0; }
if ((i_Params_Get_Reservation_query_By_Where.END_ROW == null) || (i_Params_Get_Reservation_query_By_Where.END_ROW == 0)) { i_Params_Get_Reservation_query_By_Where.END_ROW = 1000000; }
List<DALC.Reservation_query> oList_DBEntries = _AppContext.Get_Reservation_query_By_Where(i_Params_Get_Reservation_query_By_Where.PICK_UP_ADDRESS,i_Params_Get_Reservation_query_By_Where.TRIP_DATE,i_Params_Get_Reservation_query_By_Where.QUERY_DESCRIPTION,i_Params_Get_Reservation_query_By_Where.OWNER_ID,i_Params_Get_Reservation_query_By_Where.START_ROW,i_Params_Get_Reservation_query_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oReservation_query = new Reservation_query();
oTools.CopyPropValues(oDBEntry, oReservation_query);
oList.Add(oReservation_query);
}
}
i_Params_Get_Reservation_query_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Reservation_query_By_Where");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria(Params_Get_Loc_l3_By_Criteria i_Params_Get_Loc_l3_By_Criteria)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l3_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l3_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Criteria(i_Params_Get_Loc_l3_By_Criteria.CODE,i_Params_Get_Loc_l3_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l3_By_Criteria.OWNER_ID,i_Params_Get_Loc_l3_By_Criteria.START_ROW,i_Params_Get_Loc_l3_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Criteria");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where(Params_Get_Loc_l3_By_Where i_Params_Get_Loc_l3_By_Where)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Where");}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Where.START_ROW == null) { i_Params_Get_Loc_l3_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Where.END_ROW == null) || (i_Params_Get_Loc_l3_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Where(i_Params_Get_Loc_l3_By_Where.CODE,i_Params_Get_Loc_l3_By_Where.DESCRIPTION,i_Params_Get_Loc_l3_By_Where.OWNER_ID,i_Params_Get_Loc_l3_By_Where.START_ROW,i_Params_Get_Loc_l3_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Where");}
return oList;
}
public List<Review> Get_Review_By_Criteria(Params_Get_Review_By_Criteria i_Params_Get_Review_By_Criteria)
{
List<Review> oList = new List<Review>();
Review oReview = new Review();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Review_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Review_By_Criteria.OWNER_ID == null) || (i_Params_Get_Review_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Review_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Review_By_Criteria.START_ROW == null) { i_Params_Get_Review_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Review_By_Criteria.END_ROW == null) || (i_Params_Get_Review_By_Criteria.END_ROW == 0)) { i_Params_Get_Review_By_Criteria.END_ROW = 1000000; }
List<DALC.Review> oList_DBEntries = _AppContext.Get_Review_By_Criteria(i_Params_Get_Review_By_Criteria.TITLE,i_Params_Get_Review_By_Criteria.REVIEW_TEXT,i_Params_Get_Review_By_Criteria.OWNER_ID,i_Params_Get_Review_By_Criteria.START_ROW,i_Params_Get_Review_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oReview = new Review();
oTools.CopyPropValues(oDBEntry, oReview);
oList.Add(oReview);
}
}
i_Params_Get_Review_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Review_By_Criteria");}
return oList;
}
public List<Review> Get_Review_By_Where(Params_Get_Review_By_Where i_Params_Get_Review_By_Where)
{
List<Review> oList = new List<Review>();
Review oReview = new Review();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Review_By_Where");}
#region Body Section.
if ((i_Params_Get_Review_By_Where.OWNER_ID == null) || (i_Params_Get_Review_By_Where.OWNER_ID == 0)) { i_Params_Get_Review_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Review_By_Where.START_ROW == null) { i_Params_Get_Review_By_Where.START_ROW = 0; }
if ((i_Params_Get_Review_By_Where.END_ROW == null) || (i_Params_Get_Review_By_Where.END_ROW == 0)) { i_Params_Get_Review_By_Where.END_ROW = 1000000; }
List<DALC.Review> oList_DBEntries = _AppContext.Get_Review_By_Where(i_Params_Get_Review_By_Where.TITLE,i_Params_Get_Review_By_Where.REVIEW_TEXT,i_Params_Get_Review_By_Where.OWNER_ID,i_Params_Get_Review_By_Where.START_ROW,i_Params_Get_Review_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oReview = new Review();
oTools.CopyPropValues(oDBEntry, oReview);
oList.Add(oReview);
}
}
i_Params_Get_Review_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Review_By_Where");}
return oList;
}
public List<Trip> Get_Trip_By_Criteria(Params_Get_Trip_By_Criteria i_Params_Get_Trip_By_Criteria)
{
List<Trip> oList = new List<Trip>();
Trip oTrip = new Trip();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Trip_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Trip_By_Criteria.OWNER_ID == null) || (i_Params_Get_Trip_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Trip_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Trip_By_Criteria.START_ROW == null) { i_Params_Get_Trip_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Trip_By_Criteria.END_ROW == null) || (i_Params_Get_Trip_By_Criteria.END_ROW == 0)) { i_Params_Get_Trip_By_Criteria.END_ROW = 1000000; }
List<DALC.Trip> oList_DBEntries = _AppContext.Get_Trip_By_Criteria(i_Params_Get_Trip_By_Criteria.TITLE,i_Params_Get_Trip_By_Criteria.SUB_TITLE,i_Params_Get_Trip_By_Criteria.DETAILS,i_Params_Get_Trip_By_Criteria.CITY,i_Params_Get_Trip_By_Criteria.PRICE,i_Params_Get_Trip_By_Criteria.DISCOUNT_PRICE,i_Params_Get_Trip_By_Criteria.VIDEO_URL,i_Params_Get_Trip_By_Criteria.OFFER_HIGHLIGHT_TEXT,i_Params_Get_Trip_By_Criteria.OWNER_ID,i_Params_Get_Trip_By_Criteria.START_ROW,i_Params_Get_Trip_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTrip = new Trip();
oTools.CopyPropValues(oDBEntry, oTrip);
oList.Add(oTrip);
}
}
i_Params_Get_Trip_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Trip_By_Criteria");}
return oList;
}
public List<Trip> Get_Trip_By_Where(Params_Get_Trip_By_Where i_Params_Get_Trip_By_Where)
{
List<Trip> oList = new List<Trip>();
Trip oTrip = new Trip();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Trip_By_Where");}
#region PreEvent_Get_Trip_By_Where
if (OnPreEvent_Get_Trip_By_Where != null)
{
OnPreEvent_Get_Trip_By_Where(i_Params_Get_Trip_By_Where);
}
#endregion
#region Body Section.
if ((i_Params_Get_Trip_By_Where.OWNER_ID == null) || (i_Params_Get_Trip_By_Where.OWNER_ID == 0)) { i_Params_Get_Trip_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Trip_By_Where.START_ROW == null) { i_Params_Get_Trip_By_Where.START_ROW = 0; }
if ((i_Params_Get_Trip_By_Where.END_ROW == null) || (i_Params_Get_Trip_By_Where.END_ROW == 0)) { i_Params_Get_Trip_By_Where.END_ROW = 1000000; }
List<DALC.Trip> oList_DBEntries = _AppContext.Get_Trip_By_Where(i_Params_Get_Trip_By_Where.TITLE,i_Params_Get_Trip_By_Where.SUB_TITLE,i_Params_Get_Trip_By_Where.DETAILS,i_Params_Get_Trip_By_Where.CITY,i_Params_Get_Trip_By_Where.PRICE,i_Params_Get_Trip_By_Where.DISCOUNT_PRICE,i_Params_Get_Trip_By_Where.VIDEO_URL,i_Params_Get_Trip_By_Where.OFFER_HIGHLIGHT_TEXT,i_Params_Get_Trip_By_Where.OWNER_ID,i_Params_Get_Trip_By_Where.START_ROW,i_Params_Get_Trip_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTrip = new Trip();
oTools.CopyPropValues(oDBEntry, oTrip);
oList.Add(oTrip);
}
}
i_Params_Get_Trip_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
#region PostEvent_Get_Trip_By_Where
if (OnPostEvent_Get_Trip_By_Where != null)
{
OnPostEvent_Get_Trip_By_Where(ref oList,i_Params_Get_Trip_By_Where);
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Trip_By_Where");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria(Params_Get_Loc_l4_By_Criteria i_Params_Get_Loc_l4_By_Criteria)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l4_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l4_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Criteria(i_Params_Get_Loc_l4_By_Criteria.CODE,i_Params_Get_Loc_l4_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l4_By_Criteria.OWNER_ID,i_Params_Get_Loc_l4_By_Criteria.START_ROW,i_Params_Get_Loc_l4_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Criteria");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where(Params_Get_Loc_l4_By_Where i_Params_Get_Loc_l4_By_Where)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Where");}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Where.START_ROW == null) { i_Params_Get_Loc_l4_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Where.END_ROW == null) || (i_Params_Get_Loc_l4_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Where(i_Params_Get_Loc_l4_By_Where.CODE,i_Params_Get_Loc_l4_By_Where.DESCRIPTION,i_Params_Get_Loc_l4_By_Where.OWNER_ID,i_Params_Get_Loc_l4_By_Where.START_ROW,i_Params_Get_Loc_l4_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Where");}
return oList;
}
public List<Address> Get_Address_By_Criteria(Params_Get_Address_By_Criteria i_Params_Get_Address_By_Criteria)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria.START_ROW == null) { i_Params_Get_Address_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria.END_ROW == null) || (i_Params_Get_Address_By_Criteria.END_ROW == 0)) { i_Params_Get_Address_By_Criteria.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria(i_Params_Get_Address_By_Criteria.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria.STREET,i_Params_Get_Address_By_Criteria.BUILDING,i_Params_Get_Address_By_Criteria.FLOOR,i_Params_Get_Address_By_Criteria.POBOX,i_Params_Get_Address_By_Criteria.OWNER_ID,i_Params_Get_Address_By_Criteria.START_ROW,i_Params_Get_Address_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria");}
return oList;
}
public List<Address> Get_Address_By_Where(Params_Get_Address_By_Where i_Params_Get_Address_By_Where)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where");}
#region Body Section.
if ((i_Params_Get_Address_By_Where.OWNER_ID == null) || (i_Params_Get_Address_By_Where.OWNER_ID == 0)) { i_Params_Get_Address_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where.START_ROW == null) { i_Params_Get_Address_By_Where.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where.END_ROW == null) || (i_Params_Get_Address_By_Where.END_ROW == 0)) { i_Params_Get_Address_By_Where.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where(i_Params_Get_Address_By_Where.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where.STREET,i_Params_Get_Address_By_Where.BUILDING,i_Params_Get_Address_By_Where.FLOOR,i_Params_Get_Address_By_Where.POBOX,i_Params_Get_Address_By_Where.OWNER_ID,i_Params_Get_Address_By_Where.START_ROW,i_Params_Get_Address_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where");}
return oList;
}
public List<Address> Get_Address_By_Criteria_V2(Params_Get_Address_By_Criteria_V2 i_Params_Get_Address_By_Criteria_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_V2");}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria_V2.START_ROW == null) { i_Params_Get_Address_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Address_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Address_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_V2(i_Params_Get_Address_By_Criteria_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_V2.STREET,i_Params_Get_Address_By_Criteria_V2.BUILDING,i_Params_Get_Address_By_Criteria_V2.FLOOR,i_Params_Get_Address_By_Criteria_V2.POBOX,i_Params_Get_Address_By_Criteria_V2.VALID_DATE_START,i_Params_Get_Address_By_Criteria_V2.VALID_DATE_END,i_Params_Get_Address_By_Criteria_V2.OWNER_ID,i_Params_Get_Address_By_Criteria_V2.START_ROW,i_Params_Get_Address_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_V2");}
return oList;
}
public List<Address> Get_Address_By_Where_V2(Params_Get_Address_By_Where_V2 i_Params_Get_Address_By_Where_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_V2");}
#region Body Section.
if ((i_Params_Get_Address_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where_V2.START_ROW == null) { i_Params_Get_Address_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where_V2.END_ROW == null) || (i_Params_Get_Address_By_Where_V2.END_ROW == 0)) { i_Params_Get_Address_By_Where_V2.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_V2(i_Params_Get_Address_By_Where_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_V2.STREET,i_Params_Get_Address_By_Where_V2.BUILDING,i_Params_Get_Address_By_Where_V2.FLOOR,i_Params_Get_Address_By_Where_V2.POBOX,i_Params_Get_Address_By_Where_V2.VALID_DATE_START,i_Params_Get_Address_By_Where_V2.VALID_DATE_END,i_Params_Get_Address_By_Where_V2.OWNER_ID,i_Params_Get_Address_By_Where_V2.START_ROW,i_Params_Get_Address_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_V2");}
return oList;
}
public List<Owner> Get_Owner_By_Criteria(Params_Get_Owner_By_Criteria i_Params_Get_Owner_By_Criteria)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Owner_By_Criteria.OWNER_ID == null) || (i_Params_Get_Owner_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Owner_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Criteria.START_ROW == null) { i_Params_Get_Owner_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Criteria.END_ROW == null) || (i_Params_Get_Owner_By_Criteria.END_ROW == 0)) { i_Params_Get_Owner_By_Criteria.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Criteria(i_Params_Get_Owner_By_Criteria.CODE,i_Params_Get_Owner_By_Criteria.DESCRIPTION,i_Params_Get_Owner_By_Criteria.OWNER_ID,i_Params_Get_Owner_By_Criteria.START_ROW,i_Params_Get_Owner_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Criteria");}
return oList;
}
public List<Owner> Get_Owner_By_Where(Params_Get_Owner_By_Where i_Params_Get_Owner_By_Where)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Where");}
#region Body Section.
if ((i_Params_Get_Owner_By_Where.OWNER_ID == null) || (i_Params_Get_Owner_By_Where.OWNER_ID == 0)) { i_Params_Get_Owner_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Where.START_ROW == null) { i_Params_Get_Owner_By_Where.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Where.END_ROW == null) || (i_Params_Get_Owner_By_Where.END_ROW == 0)) { i_Params_Get_Owner_By_Where.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Where(i_Params_Get_Owner_By_Where.CODE,i_Params_Get_Owner_By_Where.DESCRIPTION,i_Params_Get_Owner_By_Where.OWNER_ID,i_Params_Get_Owner_By_Where.START_ROW,i_Params_Get_Owner_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Where");}
return oList;
}
public List<Owner> Get_Owner_By_Criteria_V2(Params_Get_Owner_By_Criteria_V2 i_Params_Get_Owner_By_Criteria_V2)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Criteria_V2");}
#region Body Section.
if ((i_Params_Get_Owner_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Owner_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Owner_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Criteria_V2.START_ROW == null) { i_Params_Get_Owner_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Owner_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Owner_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Criteria_V2(i_Params_Get_Owner_By_Criteria_V2.CODE,i_Params_Get_Owner_By_Criteria_V2.MAINTENANCE_DUE_DATE,i_Params_Get_Owner_By_Criteria_V2.DESCRIPTION,i_Params_Get_Owner_By_Criteria_V2.OWNER_ID,i_Params_Get_Owner_By_Criteria_V2.START_ROW,i_Params_Get_Owner_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Criteria_V2");}
return oList;
}
public List<Owner> Get_Owner_By_Where_V2(Params_Get_Owner_By_Where_V2 i_Params_Get_Owner_By_Where_V2)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Where_V2");}
#region Body Section.
if ((i_Params_Get_Owner_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Owner_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Owner_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Where_V2.START_ROW == null) { i_Params_Get_Owner_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Where_V2.END_ROW == null) || (i_Params_Get_Owner_By_Where_V2.END_ROW == 0)) { i_Params_Get_Owner_By_Where_V2.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Where_V2(i_Params_Get_Owner_By_Where_V2.CODE,i_Params_Get_Owner_By_Where_V2.MAINTENANCE_DUE_DATE,i_Params_Get_Owner_By_Where_V2.DESCRIPTION,i_Params_Get_Owner_By_Where_V2.OWNER_ID,i_Params_Get_Owner_By_Where_V2.START_ROW,i_Params_Get_Owner_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Where_V2");}
return oList;
}
public List<Features> Get_Features_By_Criteria(Params_Get_Features_By_Criteria i_Params_Get_Features_By_Criteria)
{
List<Features> oList = new List<Features>();
Features oFeatures = new Features();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Features_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Features_By_Criteria.OWNER_ID == null) || (i_Params_Get_Features_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Features_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Features_By_Criteria.START_ROW == null) { i_Params_Get_Features_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Features_By_Criteria.END_ROW == null) || (i_Params_Get_Features_By_Criteria.END_ROW == 0)) { i_Params_Get_Features_By_Criteria.END_ROW = 1000000; }
List<DALC.Features> oList_DBEntries = _AppContext.Get_Features_By_Criteria(i_Params_Get_Features_By_Criteria.TITLE,i_Params_Get_Features_By_Criteria.DESCRIPTION,i_Params_Get_Features_By_Criteria.OWNER_ID,i_Params_Get_Features_By_Criteria.START_ROW,i_Params_Get_Features_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeatures = new Features();
oTools.CopyPropValues(oDBEntry, oFeatures);
oList.Add(oFeatures);
}
}
i_Params_Get_Features_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Features_By_Criteria");}
return oList;
}
public List<Features> Get_Features_By_Where(Params_Get_Features_By_Where i_Params_Get_Features_By_Where)
{
List<Features> oList = new List<Features>();
Features oFeatures = new Features();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Features_By_Where");}
#region PreEvent_Get_Features_By_Where
if (OnPreEvent_Get_Features_By_Where != null)
{
OnPreEvent_Get_Features_By_Where(i_Params_Get_Features_By_Where);
}
#endregion
#region Body Section.
if ((i_Params_Get_Features_By_Where.OWNER_ID == null) || (i_Params_Get_Features_By_Where.OWNER_ID == 0)) { i_Params_Get_Features_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Features_By_Where.START_ROW == null) { i_Params_Get_Features_By_Where.START_ROW = 0; }
if ((i_Params_Get_Features_By_Where.END_ROW == null) || (i_Params_Get_Features_By_Where.END_ROW == 0)) { i_Params_Get_Features_By_Where.END_ROW = 1000000; }
List<DALC.Features> oList_DBEntries = _AppContext.Get_Features_By_Where(i_Params_Get_Features_By_Where.TITLE,i_Params_Get_Features_By_Where.DESCRIPTION,i_Params_Get_Features_By_Where.OWNER_ID,i_Params_Get_Features_By_Where.START_ROW,i_Params_Get_Features_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeatures = new Features();
oTools.CopyPropValues(oDBEntry, oFeatures);
oList.Add(oFeatures);
}
}
i_Params_Get_Features_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
#region PostEvent_Get_Features_By_Where
if (OnPostEvent_Get_Features_By_Where != null)
{
OnPostEvent_Get_Features_By_Where(ref oList,i_Params_Get_Features_By_Where);
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Features_By_Where");}
return oList;
}
public List<User> Get_User_By_Criteria(Params_Get_User_By_Criteria i_Params_Get_User_By_Criteria)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Criteria");}
#region Body Section.
if ((i_Params_Get_User_By_Criteria.OWNER_ID == null) || (i_Params_Get_User_By_Criteria.OWNER_ID == 0)) { i_Params_Get_User_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Criteria.START_ROW == null) { i_Params_Get_User_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_User_By_Criteria.END_ROW == null) || (i_Params_Get_User_By_Criteria.END_ROW == 0)) { i_Params_Get_User_By_Criteria.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Criteria(i_Params_Get_User_By_Criteria.USERNAME,i_Params_Get_User_By_Criteria.PASSWORD,i_Params_Get_User_By_Criteria.USER_TYPE_CODE,i_Params_Get_User_By_Criteria.OWNER_ID,i_Params_Get_User_By_Criteria.START_ROW,i_Params_Get_User_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Criteria");}
return oList;
}
public List<User> Get_User_By_Where(Params_Get_User_By_Where i_Params_Get_User_By_Where)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Where");}
#region Body Section.
if ((i_Params_Get_User_By_Where.OWNER_ID == null) || (i_Params_Get_User_By_Where.OWNER_ID == 0)) { i_Params_Get_User_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Where.START_ROW == null) { i_Params_Get_User_By_Where.START_ROW = 0; }
if ((i_Params_Get_User_By_Where.END_ROW == null) || (i_Params_Get_User_By_Where.END_ROW == 0)) { i_Params_Get_User_By_Where.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Where(i_Params_Get_User_By_Where.USERNAME,i_Params_Get_User_By_Where.PASSWORD,i_Params_Get_User_By_Where.USER_TYPE_CODE,i_Params_Get_User_By_Where.OWNER_ID,i_Params_Get_User_By_Where.START_ROW,i_Params_Get_User_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Where");}
return oList;
}
public List<Includes> Get_Includes_By_Criteria(Params_Get_Includes_By_Criteria i_Params_Get_Includes_By_Criteria)
{
List<Includes> oList = new List<Includes>();
Includes oIncludes = new Includes();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Includes_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Includes_By_Criteria.OWNER_ID == null) || (i_Params_Get_Includes_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Includes_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Includes_By_Criteria.START_ROW == null) { i_Params_Get_Includes_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Includes_By_Criteria.END_ROW == null) || (i_Params_Get_Includes_By_Criteria.END_ROW == 0)) { i_Params_Get_Includes_By_Criteria.END_ROW = 1000000; }
List<DALC.Includes> oList_DBEntries = _AppContext.Get_Includes_By_Criteria(i_Params_Get_Includes_By_Criteria.TITLE,i_Params_Get_Includes_By_Criteria.DESCRIPTION,i_Params_Get_Includes_By_Criteria.OWNER_ID,i_Params_Get_Includes_By_Criteria.START_ROW,i_Params_Get_Includes_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oIncludes = new Includes();
oTools.CopyPropValues(oDBEntry, oIncludes);
oList.Add(oIncludes);
}
}
i_Params_Get_Includes_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Includes_By_Criteria");}
return oList;
}
public List<Includes> Get_Includes_By_Where(Params_Get_Includes_By_Where i_Params_Get_Includes_By_Where)
{
List<Includes> oList = new List<Includes>();
Includes oIncludes = new Includes();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Includes_By_Where");}
#region PreEvent_Get_Includes_By_Where
if (OnPreEvent_Get_Includes_By_Where != null)
{
OnPreEvent_Get_Includes_By_Where(i_Params_Get_Includes_By_Where);
}
#endregion
#region Body Section.
if ((i_Params_Get_Includes_By_Where.OWNER_ID == null) || (i_Params_Get_Includes_By_Where.OWNER_ID == 0)) { i_Params_Get_Includes_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Includes_By_Where.START_ROW == null) { i_Params_Get_Includes_By_Where.START_ROW = 0; }
if ((i_Params_Get_Includes_By_Where.END_ROW == null) || (i_Params_Get_Includes_By_Where.END_ROW == 0)) { i_Params_Get_Includes_By_Where.END_ROW = 1000000; }
List<DALC.Includes> oList_DBEntries = _AppContext.Get_Includes_By_Where(i_Params_Get_Includes_By_Where.TITLE,i_Params_Get_Includes_By_Where.DESCRIPTION,i_Params_Get_Includes_By_Where.OWNER_ID,i_Params_Get_Includes_By_Where.START_ROW,i_Params_Get_Includes_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oIncludes = new Includes();
oTools.CopyPropValues(oDBEntry, oIncludes);
oList.Add(oIncludes);
}
}
i_Params_Get_Includes_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
#region PostEvent_Get_Includes_By_Where
if (OnPostEvent_Get_Includes_By_Where != null)
{
OnPostEvent_Get_Includes_By_Where(ref oList,i_Params_Get_Includes_By_Where);
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Includes_By_Where");}
return oList;
}
public List<Staff> Get_Staff_By_Criteria(Params_Get_Staff_By_Criteria i_Params_Get_Staff_By_Criteria)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Staff_By_Criteria.OWNER_ID == null) || (i_Params_Get_Staff_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Staff_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_By_Criteria.START_ROW == null) { i_Params_Get_Staff_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Staff_By_Criteria.END_ROW == null) || (i_Params_Get_Staff_By_Criteria.END_ROW == 0)) { i_Params_Get_Staff_By_Criteria.END_ROW = 1000000; }
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_Criteria(i_Params_Get_Staff_By_Criteria.TITLE,i_Params_Get_Staff_By_Criteria.DESCRIPTION,i_Params_Get_Staff_By_Criteria.EMAIL,i_Params_Get_Staff_By_Criteria.PHONE,i_Params_Get_Staff_By_Criteria.OWNER_ID,i_Params_Get_Staff_By_Criteria.START_ROW,i_Params_Get_Staff_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oList.Add(oStaff);
}
}
i_Params_Get_Staff_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_Criteria");}
return oList;
}
public List<Staff> Get_Staff_By_Where(Params_Get_Staff_By_Where i_Params_Get_Staff_By_Where)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_Where");}
#region Body Section.
if ((i_Params_Get_Staff_By_Where.OWNER_ID == null) || (i_Params_Get_Staff_By_Where.OWNER_ID == 0)) { i_Params_Get_Staff_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_By_Where.START_ROW == null) { i_Params_Get_Staff_By_Where.START_ROW = 0; }
if ((i_Params_Get_Staff_By_Where.END_ROW == null) || (i_Params_Get_Staff_By_Where.END_ROW == 0)) { i_Params_Get_Staff_By_Where.END_ROW = 1000000; }
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_Where(i_Params_Get_Staff_By_Where.TITLE,i_Params_Get_Staff_By_Where.DESCRIPTION,i_Params_Get_Staff_By_Where.EMAIL,i_Params_Get_Staff_By_Where.PHONE,i_Params_Get_Staff_By_Where.OWNER_ID,i_Params_Get_Staff_By_Where.START_ROW,i_Params_Get_Staff_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oList.Add(oStaff);
}
}
i_Params_Get_Staff_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_Where");}
return oList;
}
public List<Person> Get_Person_By_Criteria(Params_Get_Person_By_Criteria i_Params_Get_Person_By_Criteria)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Person_By_Criteria.OWNER_ID == null) || (i_Params_Get_Person_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Person_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Criteria.START_ROW == null) { i_Params_Get_Person_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Person_By_Criteria.END_ROW == null) || (i_Params_Get_Person_By_Criteria.END_ROW == 0)) { i_Params_Get_Person_By_Criteria.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Criteria(i_Params_Get_Person_By_Criteria.FIRST_NAME,i_Params_Get_Person_By_Criteria.LAST_NAME,i_Params_Get_Person_By_Criteria.FATHER_NAME,i_Params_Get_Person_By_Criteria.MOTHER_NAME,i_Params_Get_Person_By_Criteria.TITLE_CODE,i_Params_Get_Person_By_Criteria.GENDER_CODE,i_Params_Get_Person_By_Criteria.RELIGION_CODE,i_Params_Get_Person_By_Criteria.DESCRIPTION,i_Params_Get_Person_By_Criteria.OWNER_ID,i_Params_Get_Person_By_Criteria.START_ROW,i_Params_Get_Person_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
i_Params_Get_Person_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Criteria");}
return oList;
}
public List<Person> Get_Person_By_Where(Params_Get_Person_By_Where i_Params_Get_Person_By_Where)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Where");}
#region Body Section.
if ((i_Params_Get_Person_By_Where.OWNER_ID == null) || (i_Params_Get_Person_By_Where.OWNER_ID == 0)) { i_Params_Get_Person_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Where.START_ROW == null) { i_Params_Get_Person_By_Where.START_ROW = 0; }
if ((i_Params_Get_Person_By_Where.END_ROW == null) || (i_Params_Get_Person_By_Where.END_ROW == 0)) { i_Params_Get_Person_By_Where.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Where(i_Params_Get_Person_By_Where.FIRST_NAME,i_Params_Get_Person_By_Where.LAST_NAME,i_Params_Get_Person_By_Where.FATHER_NAME,i_Params_Get_Person_By_Where.MOTHER_NAME,i_Params_Get_Person_By_Where.TITLE_CODE,i_Params_Get_Person_By_Where.GENDER_CODE,i_Params_Get_Person_By_Where.RELIGION_CODE,i_Params_Get_Person_By_Where.DESCRIPTION,i_Params_Get_Person_By_Where.OWNER_ID,i_Params_Get_Person_By_Where.START_ROW,i_Params_Get_Person_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
i_Params_Get_Person_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Where");}
return oList;
}
public List<Person> Get_Person_By_Criteria_V2(Params_Get_Person_By_Criteria_V2 i_Params_Get_Person_By_Criteria_V2)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Criteria_V2");}
#region Body Section.
if ((i_Params_Get_Person_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Person_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Person_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Criteria_V2.START_ROW == null) { i_Params_Get_Person_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Person_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Person_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Person_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Criteria_V2(i_Params_Get_Person_By_Criteria_V2.FIRST_NAME,i_Params_Get_Person_By_Criteria_V2.LAST_NAME,i_Params_Get_Person_By_Criteria_V2.FATHER_NAME,i_Params_Get_Person_By_Criteria_V2.MOTHER_NAME,i_Params_Get_Person_By_Criteria_V2.TITLE_CODE,i_Params_Get_Person_By_Criteria_V2.GENDER_CODE,i_Params_Get_Person_By_Criteria_V2.RELIGION_CODE,i_Params_Get_Person_By_Criteria_V2.BIRTH_DATE,i_Params_Get_Person_By_Criteria_V2.DESCRIPTION,i_Params_Get_Person_By_Criteria_V2.OWNER_ID,i_Params_Get_Person_By_Criteria_V2.START_ROW,i_Params_Get_Person_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
i_Params_Get_Person_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Criteria_V2");}
return oList;
}
public List<Person> Get_Person_By_Where_V2(Params_Get_Person_By_Where_V2 i_Params_Get_Person_By_Where_V2)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Where_V2");}
#region Body Section.
if ((i_Params_Get_Person_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Person_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Person_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Where_V2.START_ROW == null) { i_Params_Get_Person_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Person_By_Where_V2.END_ROW == null) || (i_Params_Get_Person_By_Where_V2.END_ROW == 0)) { i_Params_Get_Person_By_Where_V2.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Where_V2(i_Params_Get_Person_By_Where_V2.FIRST_NAME,i_Params_Get_Person_By_Where_V2.LAST_NAME,i_Params_Get_Person_By_Where_V2.FATHER_NAME,i_Params_Get_Person_By_Where_V2.MOTHER_NAME,i_Params_Get_Person_By_Where_V2.TITLE_CODE,i_Params_Get_Person_By_Where_V2.GENDER_CODE,i_Params_Get_Person_By_Where_V2.RELIGION_CODE,i_Params_Get_Person_By_Where_V2.BIRTH_DATE,i_Params_Get_Person_By_Where_V2.DESCRIPTION,i_Params_Get_Person_By_Where_V2.OWNER_ID,i_Params_Get_Person_By_Where_V2.START_ROW,i_Params_Get_Person_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
i_Params_Get_Person_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Where_V2");}
return oList;
}
public List<Tags> Get_Tags_By_Criteria(Params_Get_Tags_By_Criteria i_Params_Get_Tags_By_Criteria)
{
List<Tags> oList = new List<Tags>();
Tags oTags = new Tags();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Tags_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Tags_By_Criteria.OWNER_ID == null) || (i_Params_Get_Tags_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Tags_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Tags_By_Criteria.START_ROW == null) { i_Params_Get_Tags_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Tags_By_Criteria.END_ROW == null) || (i_Params_Get_Tags_By_Criteria.END_ROW == 0)) { i_Params_Get_Tags_By_Criteria.END_ROW = 1000000; }
List<DALC.Tags> oList_DBEntries = _AppContext.Get_Tags_By_Criteria(i_Params_Get_Tags_By_Criteria.TAG,i_Params_Get_Tags_By_Criteria.OWNER_ID,i_Params_Get_Tags_By_Criteria.START_ROW,i_Params_Get_Tags_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTags = new Tags();
oTools.CopyPropValues(oDBEntry, oTags);
oList.Add(oTags);
}
}
i_Params_Get_Tags_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Tags_By_Criteria");}
return oList;
}
public List<Tags> Get_Tags_By_Where(Params_Get_Tags_By_Where i_Params_Get_Tags_By_Where)
{
List<Tags> oList = new List<Tags>();
Tags oTags = new Tags();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Tags_By_Where");}
#region Body Section.
if ((i_Params_Get_Tags_By_Where.OWNER_ID == null) || (i_Params_Get_Tags_By_Where.OWNER_ID == 0)) { i_Params_Get_Tags_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Tags_By_Where.START_ROW == null) { i_Params_Get_Tags_By_Where.START_ROW = 0; }
if ((i_Params_Get_Tags_By_Where.END_ROW == null) || (i_Params_Get_Tags_By_Where.END_ROW == 0)) { i_Params_Get_Tags_By_Where.END_ROW = 1000000; }
List<DALC.Tags> oList_DBEntries = _AppContext.Get_Tags_By_Where(i_Params_Get_Tags_By_Where.TAG,i_Params_Get_Tags_By_Where.OWNER_ID,i_Params_Get_Tags_By_Where.START_ROW,i_Params_Get_Tags_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTags = new Tags();
oTools.CopyPropValues(oDBEntry, oTags);
oList.Add(oTags);
}
}
i_Params_Get_Tags_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Tags_By_Where");}
return oList;
}
public List<Social_media_links> Get_Social_media_links_By_Criteria(Params_Get_Social_media_links_By_Criteria i_Params_Get_Social_media_links_By_Criteria)
{
List<Social_media_links> oList = new List<Social_media_links>();
Social_media_links oSocial_media_links = new Social_media_links();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Social_media_links_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Social_media_links_By_Criteria.OWNER_ID == null) || (i_Params_Get_Social_media_links_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Social_media_links_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Social_media_links_By_Criteria.START_ROW == null) { i_Params_Get_Social_media_links_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Social_media_links_By_Criteria.END_ROW == null) || (i_Params_Get_Social_media_links_By_Criteria.END_ROW == 0)) { i_Params_Get_Social_media_links_By_Criteria.END_ROW = 1000000; }
List<DALC.Social_media_links> oList_DBEntries = _AppContext.Get_Social_media_links_By_Criteria(i_Params_Get_Social_media_links_By_Criteria.TITLE,i_Params_Get_Social_media_links_By_Criteria.URL,i_Params_Get_Social_media_links_By_Criteria.OWNER_ID,i_Params_Get_Social_media_links_By_Criteria.START_ROW,i_Params_Get_Social_media_links_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSocial_media_links = new Social_media_links();
oTools.CopyPropValues(oDBEntry, oSocial_media_links);
oList.Add(oSocial_media_links);
}
}
i_Params_Get_Social_media_links_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Social_media_links_By_Criteria");}
return oList;
}
public List<Social_media_links> Get_Social_media_links_By_Where(Params_Get_Social_media_links_By_Where i_Params_Get_Social_media_links_By_Where)
{
List<Social_media_links> oList = new List<Social_media_links>();
Social_media_links oSocial_media_links = new Social_media_links();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Social_media_links_By_Where");}
#region PreEvent_Get_Social_media_links_By_Where
if (OnPreEvent_Get_Social_media_links_By_Where != null)
{
OnPreEvent_Get_Social_media_links_By_Where(i_Params_Get_Social_media_links_By_Where);
}
#endregion
#region Body Section.
if ((i_Params_Get_Social_media_links_By_Where.OWNER_ID == null) || (i_Params_Get_Social_media_links_By_Where.OWNER_ID == 0)) { i_Params_Get_Social_media_links_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Social_media_links_By_Where.START_ROW == null) { i_Params_Get_Social_media_links_By_Where.START_ROW = 0; }
if ((i_Params_Get_Social_media_links_By_Where.END_ROW == null) || (i_Params_Get_Social_media_links_By_Where.END_ROW == 0)) { i_Params_Get_Social_media_links_By_Where.END_ROW = 1000000; }
List<DALC.Social_media_links> oList_DBEntries = _AppContext.Get_Social_media_links_By_Where(i_Params_Get_Social_media_links_By_Where.TITLE,i_Params_Get_Social_media_links_By_Where.URL,i_Params_Get_Social_media_links_By_Where.OWNER_ID,i_Params_Get_Social_media_links_By_Where.START_ROW,i_Params_Get_Social_media_links_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSocial_media_links = new Social_media_links();
oTools.CopyPropValues(oDBEntry, oSocial_media_links);
oList.Add(oSocial_media_links);
}
}
i_Params_Get_Social_media_links_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
#region PostEvent_Get_Social_media_links_By_Where
if (OnPostEvent_Get_Social_media_links_By_Where != null)
{
OnPostEvent_Get_Social_media_links_By_Where(ref oList,i_Params_Get_Social_media_links_By_Where);
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Social_media_links_By_Where");}
return oList;
}
public List<Contact> Get_Contact_By_Criteria(Params_Get_Contact_By_Criteria i_Params_Get_Contact_By_Criteria)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Contact_By_Criteria.OWNER_ID == null) || (i_Params_Get_Contact_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Contact_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Criteria.START_ROW == null) { i_Params_Get_Contact_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Criteria.END_ROW == null) || (i_Params_Get_Contact_By_Criteria.END_ROW == 0)) { i_Params_Get_Contact_By_Criteria.END_ROW = 1000000; }
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Criteria(i_Params_Get_Contact_By_Criteria.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Criteria.CONTACT,i_Params_Get_Contact_By_Criteria.DESCRIPTION,i_Params_Get_Contact_By_Criteria.OWNER_ID,i_Params_Get_Contact_By_Criteria.START_ROW,i_Params_Get_Contact_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Criteria");}
return oList;
}
public List<Contact> Get_Contact_By_Where(Params_Get_Contact_By_Where i_Params_Get_Contact_By_Where)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Where");}
#region Body Section.
if ((i_Params_Get_Contact_By_Where.OWNER_ID == null) || (i_Params_Get_Contact_By_Where.OWNER_ID == 0)) { i_Params_Get_Contact_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Where.START_ROW == null) { i_Params_Get_Contact_By_Where.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Where.END_ROW == null) || (i_Params_Get_Contact_By_Where.END_ROW == 0)) { i_Params_Get_Contact_By_Where.END_ROW = 1000000; }
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Where(i_Params_Get_Contact_By_Where.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Where.CONTACT,i_Params_Get_Contact_By_Where.DESCRIPTION,i_Params_Get_Contact_By_Where.OWNER_ID,i_Params_Get_Contact_By_Where.START_ROW,i_Params_Get_Contact_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Where");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_Criteria(Params_Get_Uploaded_file_By_Criteria i_Params_Get_Uploaded_file_By_Criteria)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
Uploaded_file oUploaded_file = new Uploaded_file();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Uploaded_file_By_Criteria.OWNER_ID == null) || (i_Params_Get_Uploaded_file_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Uploaded_file_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Uploaded_file_By_Criteria.START_ROW == null) { i_Params_Get_Uploaded_file_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Uploaded_file_By_Criteria.END_ROW == null) || (i_Params_Get_Uploaded_file_By_Criteria.END_ROW == 0)) { i_Params_Get_Uploaded_file_By_Criteria.END_ROW = 1000000; }
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_Criteria(i_Params_Get_Uploaded_file_By_Criteria.REL_ENTITY,i_Params_Get_Uploaded_file_By_Criteria.REL_FIELD,i_Params_Get_Uploaded_file_By_Criteria.EXTENSION,i_Params_Get_Uploaded_file_By_Criteria.STAMP,i_Params_Get_Uploaded_file_By_Criteria.OWNER_ID,i_Params_Get_Uploaded_file_By_Criteria.START_ROW,i_Params_Get_Uploaded_file_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
i_Params_Get_Uploaded_file_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_Criteria");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_Where(Params_Get_Uploaded_file_By_Where i_Params_Get_Uploaded_file_By_Where)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
Uploaded_file oUploaded_file = new Uploaded_file();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_Where");}
#region Body Section.
if ((i_Params_Get_Uploaded_file_By_Where.OWNER_ID == null) || (i_Params_Get_Uploaded_file_By_Where.OWNER_ID == 0)) { i_Params_Get_Uploaded_file_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Uploaded_file_By_Where.START_ROW == null) { i_Params_Get_Uploaded_file_By_Where.START_ROW = 0; }
if ((i_Params_Get_Uploaded_file_By_Where.END_ROW == null) || (i_Params_Get_Uploaded_file_By_Where.END_ROW == 0)) { i_Params_Get_Uploaded_file_By_Where.END_ROW = 1000000; }
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_Where(i_Params_Get_Uploaded_file_By_Where.REL_ENTITY,i_Params_Get_Uploaded_file_By_Where.REL_FIELD,i_Params_Get_Uploaded_file_By_Where.EXTENSION,i_Params_Get_Uploaded_file_By_Where.STAMP,i_Params_Get_Uploaded_file_By_Where.OWNER_ID,i_Params_Get_Uploaded_file_By_Where.START_ROW,i_Params_Get_Uploaded_file_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
i_Params_Get_Uploaded_file_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_Where");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Criteria(Params_Get_Loc_l1_By_Criteria i_Params_Get_Loc_l1_By_Criteria)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Loc_l1_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l1_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l1_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l1_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l1_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l1_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l1_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l1_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_Criteria(i_Params_Get_Loc_l1_By_Criteria.CODE,i_Params_Get_Loc_l1_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l1_By_Criteria.OWNER_ID,i_Params_Get_Loc_l1_By_Criteria.START_ROW,i_Params_Get_Loc_l1_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
oList.Add(oLoc_l1);
}
}
i_Params_Get_Loc_l1_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_Criteria");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Where(Params_Get_Loc_l1_By_Where i_Params_Get_Loc_l1_By_Where)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_Where");}
#region Body Section.
if ((i_Params_Get_Loc_l1_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l1_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l1_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l1_By_Where.START_ROW == null) { i_Params_Get_Loc_l1_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l1_By_Where.END_ROW == null) || (i_Params_Get_Loc_l1_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l1_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_Where(i_Params_Get_Loc_l1_By_Where.CODE,i_Params_Get_Loc_l1_By_Where.DESCRIPTION,i_Params_Get_Loc_l1_By_Where.OWNER_ID,i_Params_Get_Loc_l1_By_Where.START_ROW,i_Params_Get_Loc_l1_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
oList.Add(oLoc_l1);
}
}
i_Params_Get_Loc_l1_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_Where");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria(Params_Get_Loc_l2_By_Criteria i_Params_Get_Loc_l2_By_Criteria)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l2_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l2_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Criteria(i_Params_Get_Loc_l2_By_Criteria.CODE,i_Params_Get_Loc_l2_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l2_By_Criteria.OWNER_ID,i_Params_Get_Loc_l2_By_Criteria.START_ROW,i_Params_Get_Loc_l2_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Criteria");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where(Params_Get_Loc_l2_By_Where i_Params_Get_Loc_l2_By_Where)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Where");}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Where.START_ROW == null) { i_Params_Get_Loc_l2_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Where.END_ROW == null) || (i_Params_Get_Loc_l2_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Where(i_Params_Get_Loc_l2_By_Where.CODE,i_Params_Get_Loc_l2_By_Where.DESCRIPTION,i_Params_Get_Loc_l2_By_Where.OWNER_ID,i_Params_Get_Loc_l2_By_Where.START_ROW,i_Params_Get_Loc_l2_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Where");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_InList(Params_Get_Loc_l3_By_Criteria_InList i_Params_Get_Loc_l3_By_Criteria_InList)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l3_By_Criteria_InList_SP oParams_Get_Loc_l3_By_Criteria_InList_SP = new Params_Get_Loc_l3_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Criteria_InList.START_ROW == null) { i_Params_Get_Loc_l3_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Loc_l3_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID;
oParams_Get_Loc_l3_By_Criteria_InList_SP.CODE = i_Params_Get_Loc_l3_By_Criteria_InList.CODE;
oParams_Get_Loc_l3_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Loc_l3_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l3_By_Criteria_InList.LOC_L2_ID_LIST == null)
{
i_Params_Get_Loc_l3_By_Criteria_InList.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l3_By_Criteria_InList_SP.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l3_By_Criteria_InList.LOC_L2_ID_LIST);
oParams_Get_Loc_l3_By_Criteria_InList_SP.START_ROW = i_Params_Get_Loc_l3_By_Criteria_InList.START_ROW;
oParams_Get_Loc_l3_By_Criteria_InList_SP.END_ROW = i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW;
oParams_Get_Loc_l3_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l3_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Criteria_InList(i_Params_Get_Loc_l3_By_Criteria_InList.CODE,i_Params_Get_Loc_l3_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l3_By_Criteria_InList.LOC_L2_ID_LIST,i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l3_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l3_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l3_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Criteria_InList");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_InList(Params_Get_Loc_l3_By_Where_InList i_Params_Get_Loc_l3_By_Where_InList)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l3_By_Where_InList_SP oParams_Get_Loc_l3_By_Where_InList_SP = new Params_Get_Loc_l3_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Where_InList.START_ROW == null) { i_Params_Get_Loc_l3_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Where_InList.END_ROW == null) || (i_Params_Get_Loc_l3_By_Where_InList.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Loc_l3_By_Where_InList_SP.OWNER_ID = i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID;
oParams_Get_Loc_l3_By_Where_InList_SP.CODE = i_Params_Get_Loc_l3_By_Where_InList.CODE;
oParams_Get_Loc_l3_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Loc_l3_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l3_By_Where_InList.LOC_L2_ID_LIST == null)
{
i_Params_Get_Loc_l3_By_Where_InList.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l3_By_Where_InList_SP.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l3_By_Where_InList.LOC_L2_ID_LIST);
oParams_Get_Loc_l3_By_Where_InList_SP.START_ROW = i_Params_Get_Loc_l3_By_Where_InList.START_ROW;
oParams_Get_Loc_l3_By_Where_InList_SP.END_ROW = i_Params_Get_Loc_l3_By_Where_InList.END_ROW;
oParams_Get_Loc_l3_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l3_By_Where_InList.TOTAL_COUNT;
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Where_InList(i_Params_Get_Loc_l3_By_Where_InList.CODE,i_Params_Get_Loc_l3_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l3_By_Where_InList.LOC_L2_ID_LIST,i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l3_By_Where_InList.START_ROW,i_Params_Get_Loc_l3_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l3_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l3_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Where_InList");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_InList(Params_Get_Loc_l4_By_Criteria_InList i_Params_Get_Loc_l4_By_Criteria_InList)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l4_By_Criteria_InList_SP oParams_Get_Loc_l4_By_Criteria_InList_SP = new Params_Get_Loc_l4_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Criteria_InList.START_ROW == null) { i_Params_Get_Loc_l4_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Loc_l4_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID;
oParams_Get_Loc_l4_By_Criteria_InList_SP.CODE = i_Params_Get_Loc_l4_By_Criteria_InList.CODE;
oParams_Get_Loc_l4_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Loc_l4_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l4_By_Criteria_InList.LOC_L3_ID_LIST == null)
{
i_Params_Get_Loc_l4_By_Criteria_InList.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l4_By_Criteria_InList_SP.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l4_By_Criteria_InList.LOC_L3_ID_LIST);
oParams_Get_Loc_l4_By_Criteria_InList_SP.START_ROW = i_Params_Get_Loc_l4_By_Criteria_InList.START_ROW;
oParams_Get_Loc_l4_By_Criteria_InList_SP.END_ROW = i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW;
oParams_Get_Loc_l4_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l4_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Criteria_InList(i_Params_Get_Loc_l4_By_Criteria_InList.CODE,i_Params_Get_Loc_l4_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l4_By_Criteria_InList.LOC_L3_ID_LIST,i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l4_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l4_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l4_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Criteria_InList");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_InList(Params_Get_Loc_l4_By_Where_InList i_Params_Get_Loc_l4_By_Where_InList)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l4_By_Where_InList_SP oParams_Get_Loc_l4_By_Where_InList_SP = new Params_Get_Loc_l4_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Where_InList.START_ROW == null) { i_Params_Get_Loc_l4_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Where_InList.END_ROW == null) || (i_Params_Get_Loc_l4_By_Where_InList.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Loc_l4_By_Where_InList_SP.OWNER_ID = i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID;
oParams_Get_Loc_l4_By_Where_InList_SP.CODE = i_Params_Get_Loc_l4_By_Where_InList.CODE;
oParams_Get_Loc_l4_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Loc_l4_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l4_By_Where_InList.LOC_L3_ID_LIST == null)
{
i_Params_Get_Loc_l4_By_Where_InList.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l4_By_Where_InList_SP.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l4_By_Where_InList.LOC_L3_ID_LIST);
oParams_Get_Loc_l4_By_Where_InList_SP.START_ROW = i_Params_Get_Loc_l4_By_Where_InList.START_ROW;
oParams_Get_Loc_l4_By_Where_InList_SP.END_ROW = i_Params_Get_Loc_l4_By_Where_InList.END_ROW;
oParams_Get_Loc_l4_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l4_By_Where_InList.TOTAL_COUNT;
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Where_InList(i_Params_Get_Loc_l4_By_Where_InList.CODE,i_Params_Get_Loc_l4_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l4_By_Where_InList.LOC_L3_ID_LIST,i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l4_By_Where_InList.START_ROW,i_Params_Get_Loc_l4_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l4_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l4_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Where_InList");}
return oList;
}
public List<Address> Get_Address_By_Criteria_InList(Params_Get_Address_By_Criteria_InList i_Params_Get_Address_By_Criteria_InList)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Address_By_Criteria_InList_SP oParams_Get_Address_By_Criteria_InList_SP = new Params_Get_Address_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria_InList.START_ROW == null) { i_Params_Get_Address_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Address_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Address_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Address_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Address_By_Criteria_InList.OWNER_ID;
oParams_Get_Address_By_Criteria_InList_SP.ADDRESS_TYPE_CODE = i_Params_Get_Address_By_Criteria_InList.ADDRESS_TYPE_CODE;
oParams_Get_Address_By_Criteria_InList_SP.STREET = i_Params_Get_Address_By_Criteria_InList.STREET;
oParams_Get_Address_By_Criteria_InList_SP.BUILDING = i_Params_Get_Address_By_Criteria_InList.BUILDING;
oParams_Get_Address_By_Criteria_InList_SP.FLOOR = i_Params_Get_Address_By_Criteria_InList.FLOOR;
oParams_Get_Address_By_Criteria_InList_SP.POBOX = i_Params_Get_Address_By_Criteria_InList.POBOX;
if ( i_Params_Get_Address_By_Criteria_InList.PERSON_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList.PERSON_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList.LOC_L1_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList.LOC_L1_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList.LOC_L2_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList.LOC_L2_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList.LOC_L3_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList.LOC_L3_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList.LOC_L4_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList.LOC_L4_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP.LOC_L4_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList.LOC_L4_ID_LIST);
oParams_Get_Address_By_Criteria_InList_SP.START_ROW = i_Params_Get_Address_By_Criteria_InList.START_ROW;
oParams_Get_Address_By_Criteria_InList_SP.END_ROW = i_Params_Get_Address_By_Criteria_InList.END_ROW;
oParams_Get_Address_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Address_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_InList(i_Params_Get_Address_By_Criteria_InList.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_InList.STREET,i_Params_Get_Address_By_Criteria_InList.BUILDING,i_Params_Get_Address_By_Criteria_InList.FLOOR,i_Params_Get_Address_By_Criteria_InList.POBOX,i_Params_Get_Address_By_Criteria_InList.PERSON_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L1_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L2_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L3_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L4_ID_LIST,i_Params_Get_Address_By_Criteria_InList.OWNER_ID,i_Params_Get_Address_By_Criteria_InList.START_ROW,i_Params_Get_Address_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Address_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Address_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_InList");}
return oList;
}
public List<Address> Get_Address_By_Where_InList(Params_Get_Address_By_Where_InList i_Params_Get_Address_By_Where_InList)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Address_By_Where_InList_SP oParams_Get_Address_By_Where_InList_SP = new Params_Get_Address_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Address_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Address_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Address_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where_InList.START_ROW == null) { i_Params_Get_Address_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where_InList.END_ROW == null) || (i_Params_Get_Address_By_Where_InList.END_ROW == 0)) { i_Params_Get_Address_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Address_By_Where_InList_SP.OWNER_ID = i_Params_Get_Address_By_Where_InList.OWNER_ID;
oParams_Get_Address_By_Where_InList_SP.ADDRESS_TYPE_CODE = i_Params_Get_Address_By_Where_InList.ADDRESS_TYPE_CODE;
oParams_Get_Address_By_Where_InList_SP.STREET = i_Params_Get_Address_By_Where_InList.STREET;
oParams_Get_Address_By_Where_InList_SP.BUILDING = i_Params_Get_Address_By_Where_InList.BUILDING;
oParams_Get_Address_By_Where_InList_SP.FLOOR = i_Params_Get_Address_By_Where_InList.FLOOR;
oParams_Get_Address_By_Where_InList_SP.POBOX = i_Params_Get_Address_By_Where_InList.POBOX;
if ( i_Params_Get_Address_By_Where_InList.PERSON_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList.PERSON_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList.LOC_L1_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList.LOC_L1_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList.LOC_L2_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList.LOC_L2_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList.LOC_L3_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList.LOC_L3_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList.LOC_L4_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList.LOC_L4_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP.LOC_L4_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList.LOC_L4_ID_LIST);
oParams_Get_Address_By_Where_InList_SP.START_ROW = i_Params_Get_Address_By_Where_InList.START_ROW;
oParams_Get_Address_By_Where_InList_SP.END_ROW = i_Params_Get_Address_By_Where_InList.END_ROW;
oParams_Get_Address_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Address_By_Where_InList.TOTAL_COUNT;
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_InList(i_Params_Get_Address_By_Where_InList.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_InList.STREET,i_Params_Get_Address_By_Where_InList.BUILDING,i_Params_Get_Address_By_Where_InList.FLOOR,i_Params_Get_Address_By_Where_InList.POBOX,i_Params_Get_Address_By_Where_InList.PERSON_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L1_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L2_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L3_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L4_ID_LIST,i_Params_Get_Address_By_Where_InList.OWNER_ID,i_Params_Get_Address_By_Where_InList.START_ROW,i_Params_Get_Address_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_InList.TOTAL_COUNT = oParams_Get_Address_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Address_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_InList");}
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_V2(Params_Get_Address_By_Criteria_InList_V2 i_Params_Get_Address_By_Criteria_InList_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Address_By_Criteria_InList_SP_V2 oParams_Get_Address_By_Criteria_InList_SP_V2 = new Params_Get_Address_By_Criteria_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_InList_V2");}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_Address_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_Address_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_Address_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_Address_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_Address_By_Criteria_InList_SP_V2.ADDRESS_TYPE_CODE = i_Params_Get_Address_By_Criteria_InList_V2.ADDRESS_TYPE_CODE;
oParams_Get_Address_By_Criteria_InList_SP_V2.STREET = i_Params_Get_Address_By_Criteria_InList_V2.STREET;
oParams_Get_Address_By_Criteria_InList_SP_V2.BUILDING = i_Params_Get_Address_By_Criteria_InList_V2.BUILDING;
oParams_Get_Address_By_Criteria_InList_SP_V2.FLOOR = i_Params_Get_Address_By_Criteria_InList_V2.FLOOR;
oParams_Get_Address_By_Criteria_InList_SP_V2.POBOX = i_Params_Get_Address_By_Criteria_InList_V2.POBOX;
oParams_Get_Address_By_Criteria_InList_SP_V2.VALID_DATE_START = i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_START;
oParams_Get_Address_By_Criteria_InList_SP_V2.VALID_DATE_END = i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_END;
if ( i_Params_Get_Address_By_Criteria_InList_V2.PERSON_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList_V2.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP_V2.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList_V2.PERSON_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList_V2.LOC_L1_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList_V2.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP_V2.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList_V2.LOC_L1_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList_V2.LOC_L2_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList_V2.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP_V2.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList_V2.LOC_L2_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList_V2.LOC_L3_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList_V2.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP_V2.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList_V2.LOC_L3_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList_V2.LOC_L4_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList_V2.LOC_L4_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP_V2.LOC_L4_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList_V2.LOC_L4_ID_LIST);
oParams_Get_Address_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_Address_By_Criteria_InList_V2.START_ROW;
oParams_Get_Address_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_Address_By_Criteria_InList_V2.END_ROW;
oParams_Get_Address_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Address_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_InList_V2(i_Params_Get_Address_By_Criteria_InList_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_InList_V2.STREET,i_Params_Get_Address_By_Criteria_InList_V2.BUILDING,i_Params_Get_Address_By_Criteria_InList_V2.FLOOR,i_Params_Get_Address_By_Criteria_InList_V2.POBOX,i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_START,i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_END,i_Params_Get_Address_By_Criteria_InList_V2.PERSON_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L1_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L2_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L3_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L4_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Address_By_Criteria_InList_V2.START_ROW,i_Params_Get_Address_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Address_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Address_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_InList_V2");}
return oList;
}
public List<Address> Get_Address_By_Where_InList_V2(Params_Get_Address_By_Where_InList_V2 i_Params_Get_Address_By_Where_InList_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Address_By_Where_InList_SP_V2 oParams_Get_Address_By_Where_InList_SP_V2 = new Params_Get_Address_By_Where_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_InList_V2");}
#region Body Section.
if ((i_Params_Get_Address_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where_InList_V2.START_ROW == null) { i_Params_Get_Address_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_Address_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_Address_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_Address_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_Address_By_Where_InList_V2.OWNER_ID;
oParams_Get_Address_By_Where_InList_SP_V2.ADDRESS_TYPE_CODE = i_Params_Get_Address_By_Where_InList_V2.ADDRESS_TYPE_CODE;
oParams_Get_Address_By_Where_InList_SP_V2.STREET = i_Params_Get_Address_By_Where_InList_V2.STREET;
oParams_Get_Address_By_Where_InList_SP_V2.BUILDING = i_Params_Get_Address_By_Where_InList_V2.BUILDING;
oParams_Get_Address_By_Where_InList_SP_V2.FLOOR = i_Params_Get_Address_By_Where_InList_V2.FLOOR;
oParams_Get_Address_By_Where_InList_SP_V2.POBOX = i_Params_Get_Address_By_Where_InList_V2.POBOX;
oParams_Get_Address_By_Where_InList_SP_V2.VALID_DATE_START = i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_START;
oParams_Get_Address_By_Where_InList_SP_V2.VALID_DATE_END = i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_END;
if ( i_Params_Get_Address_By_Where_InList_V2.PERSON_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList_V2.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP_V2.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList_V2.PERSON_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList_V2.LOC_L1_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList_V2.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP_V2.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList_V2.LOC_L1_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList_V2.LOC_L2_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList_V2.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP_V2.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList_V2.LOC_L2_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList_V2.LOC_L3_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList_V2.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP_V2.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList_V2.LOC_L3_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList_V2.LOC_L4_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList_V2.LOC_L4_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP_V2.LOC_L4_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList_V2.LOC_L4_ID_LIST);
oParams_Get_Address_By_Where_InList_SP_V2.START_ROW = i_Params_Get_Address_By_Where_InList_V2.START_ROW;
oParams_Get_Address_By_Where_InList_SP_V2.END_ROW = i_Params_Get_Address_By_Where_InList_V2.END_ROW;
oParams_Get_Address_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Address_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_InList_V2(i_Params_Get_Address_By_Where_InList_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_InList_V2.STREET,i_Params_Get_Address_By_Where_InList_V2.BUILDING,i_Params_Get_Address_By_Where_InList_V2.FLOOR,i_Params_Get_Address_By_Where_InList_V2.POBOX,i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_START,i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_END,i_Params_Get_Address_By_Where_InList_V2.PERSON_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L1_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L2_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L3_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L4_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.OWNER_ID,i_Params_Get_Address_By_Where_InList_V2.START_ROW,i_Params_Get_Address_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Address_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Address_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_InList_V2");}
return oList;
}
public List<Features> Get_Features_By_Criteria_InList(Params_Get_Features_By_Criteria_InList i_Params_Get_Features_By_Criteria_InList)
{
List<Features> oList = new List<Features>();
Features oFeatures = new Features();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Features_By_Criteria_InList_SP oParams_Get_Features_By_Criteria_InList_SP = new Params_Get_Features_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Features_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Features_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Features_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Features_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Features_By_Criteria_InList.START_ROW == null) { i_Params_Get_Features_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Features_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Features_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Features_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Features_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Features_By_Criteria_InList.OWNER_ID;
oParams_Get_Features_By_Criteria_InList_SP.TITLE = i_Params_Get_Features_By_Criteria_InList.TITLE;
oParams_Get_Features_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Features_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Features_By_Criteria_InList.TRIP_ID_LIST == null)
{
i_Params_Get_Features_By_Criteria_InList.TRIP_ID_LIST = new List<Int32?>();
}
oParams_Get_Features_By_Criteria_InList_SP.TRIP_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Features_By_Criteria_InList.TRIP_ID_LIST);
oParams_Get_Features_By_Criteria_InList_SP.START_ROW = i_Params_Get_Features_By_Criteria_InList.START_ROW;
oParams_Get_Features_By_Criteria_InList_SP.END_ROW = i_Params_Get_Features_By_Criteria_InList.END_ROW;
oParams_Get_Features_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Features_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Features> oList_DBEntries = _AppContext.Get_Features_By_Criteria_InList(i_Params_Get_Features_By_Criteria_InList.TITLE,i_Params_Get_Features_By_Criteria_InList.DESCRIPTION,i_Params_Get_Features_By_Criteria_InList.TRIP_ID_LIST,i_Params_Get_Features_By_Criteria_InList.OWNER_ID,i_Params_Get_Features_By_Criteria_InList.START_ROW,i_Params_Get_Features_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeatures = new Features();
oTools.CopyPropValues(oDBEntry, oFeatures);
oList.Add(oFeatures);
}
}
i_Params_Get_Features_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Features_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Features_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Features_By_Criteria_InList");}
return oList;
}
public List<Features> Get_Features_By_Where_InList(Params_Get_Features_By_Where_InList i_Params_Get_Features_By_Where_InList)
{
List<Features> oList = new List<Features>();
Features oFeatures = new Features();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Features_By_Where_InList_SP oParams_Get_Features_By_Where_InList_SP = new Params_Get_Features_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Features_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Features_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Features_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Features_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Features_By_Where_InList.START_ROW == null) { i_Params_Get_Features_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Features_By_Where_InList.END_ROW == null) || (i_Params_Get_Features_By_Where_InList.END_ROW == 0)) { i_Params_Get_Features_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Features_By_Where_InList_SP.OWNER_ID = i_Params_Get_Features_By_Where_InList.OWNER_ID;
oParams_Get_Features_By_Where_InList_SP.TITLE = i_Params_Get_Features_By_Where_InList.TITLE;
oParams_Get_Features_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Features_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Features_By_Where_InList.TRIP_ID_LIST == null)
{
i_Params_Get_Features_By_Where_InList.TRIP_ID_LIST = new List<Int32?>();
}
oParams_Get_Features_By_Where_InList_SP.TRIP_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Features_By_Where_InList.TRIP_ID_LIST);
oParams_Get_Features_By_Where_InList_SP.START_ROW = i_Params_Get_Features_By_Where_InList.START_ROW;
oParams_Get_Features_By_Where_InList_SP.END_ROW = i_Params_Get_Features_By_Where_InList.END_ROW;
oParams_Get_Features_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Features_By_Where_InList.TOTAL_COUNT;
List<DALC.Features> oList_DBEntries = _AppContext.Get_Features_By_Where_InList(i_Params_Get_Features_By_Where_InList.TITLE,i_Params_Get_Features_By_Where_InList.DESCRIPTION,i_Params_Get_Features_By_Where_InList.TRIP_ID_LIST,i_Params_Get_Features_By_Where_InList.OWNER_ID,i_Params_Get_Features_By_Where_InList.START_ROW,i_Params_Get_Features_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeatures = new Features();
oTools.CopyPropValues(oDBEntry, oFeatures);
oList.Add(oFeatures);
}
}
i_Params_Get_Features_By_Where_InList.TOTAL_COUNT = oParams_Get_Features_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Features_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Features_By_Where_InList");}
return oList;
}
public List<Includes> Get_Includes_By_Criteria_InList(Params_Get_Includes_By_Criteria_InList i_Params_Get_Includes_By_Criteria_InList)
{
List<Includes> oList = new List<Includes>();
Includes oIncludes = new Includes();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Includes_By_Criteria_InList_SP oParams_Get_Includes_By_Criteria_InList_SP = new Params_Get_Includes_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Includes_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Includes_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Includes_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Includes_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Includes_By_Criteria_InList.START_ROW == null) { i_Params_Get_Includes_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Includes_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Includes_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Includes_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Includes_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Includes_By_Criteria_InList.OWNER_ID;
oParams_Get_Includes_By_Criteria_InList_SP.TITLE = i_Params_Get_Includes_By_Criteria_InList.TITLE;
oParams_Get_Includes_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Includes_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Includes_By_Criteria_InList.TRIP_ID_LIST == null)
{
i_Params_Get_Includes_By_Criteria_InList.TRIP_ID_LIST = new List<Int32?>();
}
oParams_Get_Includes_By_Criteria_InList_SP.TRIP_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Includes_By_Criteria_InList.TRIP_ID_LIST);
oParams_Get_Includes_By_Criteria_InList_SP.START_ROW = i_Params_Get_Includes_By_Criteria_InList.START_ROW;
oParams_Get_Includes_By_Criteria_InList_SP.END_ROW = i_Params_Get_Includes_By_Criteria_InList.END_ROW;
oParams_Get_Includes_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Includes_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Includes> oList_DBEntries = _AppContext.Get_Includes_By_Criteria_InList(i_Params_Get_Includes_By_Criteria_InList.TITLE,i_Params_Get_Includes_By_Criteria_InList.DESCRIPTION,i_Params_Get_Includes_By_Criteria_InList.TRIP_ID_LIST,i_Params_Get_Includes_By_Criteria_InList.OWNER_ID,i_Params_Get_Includes_By_Criteria_InList.START_ROW,i_Params_Get_Includes_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oIncludes = new Includes();
oTools.CopyPropValues(oDBEntry, oIncludes);
oList.Add(oIncludes);
}
}
i_Params_Get_Includes_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Includes_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Includes_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Includes_By_Criteria_InList");}
return oList;
}
public List<Includes> Get_Includes_By_Where_InList(Params_Get_Includes_By_Where_InList i_Params_Get_Includes_By_Where_InList)
{
List<Includes> oList = new List<Includes>();
Includes oIncludes = new Includes();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Includes_By_Where_InList_SP oParams_Get_Includes_By_Where_InList_SP = new Params_Get_Includes_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Includes_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Includes_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Includes_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Includes_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Includes_By_Where_InList.START_ROW == null) { i_Params_Get_Includes_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Includes_By_Where_InList.END_ROW == null) || (i_Params_Get_Includes_By_Where_InList.END_ROW == 0)) { i_Params_Get_Includes_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Includes_By_Where_InList_SP.OWNER_ID = i_Params_Get_Includes_By_Where_InList.OWNER_ID;
oParams_Get_Includes_By_Where_InList_SP.TITLE = i_Params_Get_Includes_By_Where_InList.TITLE;
oParams_Get_Includes_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Includes_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Includes_By_Where_InList.TRIP_ID_LIST == null)
{
i_Params_Get_Includes_By_Where_InList.TRIP_ID_LIST = new List<Int32?>();
}
oParams_Get_Includes_By_Where_InList_SP.TRIP_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Includes_By_Where_InList.TRIP_ID_LIST);
oParams_Get_Includes_By_Where_InList_SP.START_ROW = i_Params_Get_Includes_By_Where_InList.START_ROW;
oParams_Get_Includes_By_Where_InList_SP.END_ROW = i_Params_Get_Includes_By_Where_InList.END_ROW;
oParams_Get_Includes_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Includes_By_Where_InList.TOTAL_COUNT;
List<DALC.Includes> oList_DBEntries = _AppContext.Get_Includes_By_Where_InList(i_Params_Get_Includes_By_Where_InList.TITLE,i_Params_Get_Includes_By_Where_InList.DESCRIPTION,i_Params_Get_Includes_By_Where_InList.TRIP_ID_LIST,i_Params_Get_Includes_By_Where_InList.OWNER_ID,i_Params_Get_Includes_By_Where_InList.START_ROW,i_Params_Get_Includes_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oIncludes = new Includes();
oTools.CopyPropValues(oDBEntry, oIncludes);
oList.Add(oIncludes);
}
}
i_Params_Get_Includes_By_Where_InList.TOTAL_COUNT = oParams_Get_Includes_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Includes_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Includes_By_Where_InList");}
return oList;
}
public List<Tags> Get_Tags_By_Criteria_InList(Params_Get_Tags_By_Criteria_InList i_Params_Get_Tags_By_Criteria_InList)
{
List<Tags> oList = new List<Tags>();
Tags oTags = new Tags();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Tags_By_Criteria_InList_SP oParams_Get_Tags_By_Criteria_InList_SP = new Params_Get_Tags_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Tags_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Tags_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Tags_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Tags_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Tags_By_Criteria_InList.START_ROW == null) { i_Params_Get_Tags_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Tags_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Tags_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Tags_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Tags_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Tags_By_Criteria_InList.OWNER_ID;
oParams_Get_Tags_By_Criteria_InList_SP.TAG = i_Params_Get_Tags_By_Criteria_InList.TAG;
if ( i_Params_Get_Tags_By_Criteria_InList.TRIP_ID_LIST == null)
{
i_Params_Get_Tags_By_Criteria_InList.TRIP_ID_LIST = new List<Int32?>();
}
oParams_Get_Tags_By_Criteria_InList_SP.TRIP_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Tags_By_Criteria_InList.TRIP_ID_LIST);
oParams_Get_Tags_By_Criteria_InList_SP.START_ROW = i_Params_Get_Tags_By_Criteria_InList.START_ROW;
oParams_Get_Tags_By_Criteria_InList_SP.END_ROW = i_Params_Get_Tags_By_Criteria_InList.END_ROW;
oParams_Get_Tags_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Tags_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Tags> oList_DBEntries = _AppContext.Get_Tags_By_Criteria_InList(i_Params_Get_Tags_By_Criteria_InList.TAG,i_Params_Get_Tags_By_Criteria_InList.TRIP_ID_LIST,i_Params_Get_Tags_By_Criteria_InList.OWNER_ID,i_Params_Get_Tags_By_Criteria_InList.START_ROW,i_Params_Get_Tags_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTags = new Tags();
oTools.CopyPropValues(oDBEntry, oTags);
oList.Add(oTags);
}
}
i_Params_Get_Tags_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Tags_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Tags_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Tags_By_Criteria_InList");}
return oList;
}
public List<Tags> Get_Tags_By_Where_InList(Params_Get_Tags_By_Where_InList i_Params_Get_Tags_By_Where_InList)
{
List<Tags> oList = new List<Tags>();
Tags oTags = new Tags();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Tags_By_Where_InList_SP oParams_Get_Tags_By_Where_InList_SP = new Params_Get_Tags_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Tags_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Tags_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Tags_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Tags_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Tags_By_Where_InList.START_ROW == null) { i_Params_Get_Tags_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Tags_By_Where_InList.END_ROW == null) || (i_Params_Get_Tags_By_Where_InList.END_ROW == 0)) { i_Params_Get_Tags_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Tags_By_Where_InList_SP.OWNER_ID = i_Params_Get_Tags_By_Where_InList.OWNER_ID;
oParams_Get_Tags_By_Where_InList_SP.TAG = i_Params_Get_Tags_By_Where_InList.TAG;
if ( i_Params_Get_Tags_By_Where_InList.TRIP_ID_LIST == null)
{
i_Params_Get_Tags_By_Where_InList.TRIP_ID_LIST = new List<Int32?>();
}
oParams_Get_Tags_By_Where_InList_SP.TRIP_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Tags_By_Where_InList.TRIP_ID_LIST);
oParams_Get_Tags_By_Where_InList_SP.START_ROW = i_Params_Get_Tags_By_Where_InList.START_ROW;
oParams_Get_Tags_By_Where_InList_SP.END_ROW = i_Params_Get_Tags_By_Where_InList.END_ROW;
oParams_Get_Tags_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Tags_By_Where_InList.TOTAL_COUNT;
List<DALC.Tags> oList_DBEntries = _AppContext.Get_Tags_By_Where_InList(i_Params_Get_Tags_By_Where_InList.TAG,i_Params_Get_Tags_By_Where_InList.TRIP_ID_LIST,i_Params_Get_Tags_By_Where_InList.OWNER_ID,i_Params_Get_Tags_By_Where_InList.START_ROW,i_Params_Get_Tags_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTags = new Tags();
oTools.CopyPropValues(oDBEntry, oTags);
oList.Add(oTags);
}
}
i_Params_Get_Tags_By_Where_InList.TOTAL_COUNT = oParams_Get_Tags_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Tags_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Tags_By_Where_InList");}
return oList;
}
public List<Contact> Get_Contact_By_Criteria_InList(Params_Get_Contact_By_Criteria_InList i_Params_Get_Contact_By_Criteria_InList)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Contact_By_Criteria_InList_SP oParams_Get_Contact_By_Criteria_InList_SP = new Params_Get_Contact_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Contact_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Contact_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Contact_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Criteria_InList.START_ROW == null) { i_Params_Get_Contact_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Contact_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Contact_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Contact_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Contact_By_Criteria_InList.OWNER_ID;
oParams_Get_Contact_By_Criteria_InList_SP.CONTACT_TYPE_CODE = i_Params_Get_Contact_By_Criteria_InList.CONTACT_TYPE_CODE;
oParams_Get_Contact_By_Criteria_InList_SP.CONTACT = i_Params_Get_Contact_By_Criteria_InList.CONTACT;
oParams_Get_Contact_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Contact_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Contact_By_Criteria_InList.PERSON_ID_LIST == null)
{
i_Params_Get_Contact_By_Criteria_InList.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Contact_By_Criteria_InList_SP.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Contact_By_Criteria_InList.PERSON_ID_LIST);
oParams_Get_Contact_By_Criteria_InList_SP.START_ROW = i_Params_Get_Contact_By_Criteria_InList.START_ROW;
oParams_Get_Contact_By_Criteria_InList_SP.END_ROW = i_Params_Get_Contact_By_Criteria_InList.END_ROW;
oParams_Get_Contact_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Contact_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Criteria_InList(i_Params_Get_Contact_By_Criteria_InList.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Criteria_InList.CONTACT,i_Params_Get_Contact_By_Criteria_InList.DESCRIPTION,i_Params_Get_Contact_By_Criteria_InList.PERSON_ID_LIST,i_Params_Get_Contact_By_Criteria_InList.OWNER_ID,i_Params_Get_Contact_By_Criteria_InList.START_ROW,i_Params_Get_Contact_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Contact_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Contact_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Criteria_InList");}
return oList;
}
public List<Contact> Get_Contact_By_Where_InList(Params_Get_Contact_By_Where_InList i_Params_Get_Contact_By_Where_InList)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Contact_By_Where_InList_SP oParams_Get_Contact_By_Where_InList_SP = new Params_Get_Contact_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Contact_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Contact_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Contact_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Where_InList.START_ROW == null) { i_Params_Get_Contact_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Where_InList.END_ROW == null) || (i_Params_Get_Contact_By_Where_InList.END_ROW == 0)) { i_Params_Get_Contact_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Contact_By_Where_InList_SP.OWNER_ID = i_Params_Get_Contact_By_Where_InList.OWNER_ID;
oParams_Get_Contact_By_Where_InList_SP.CONTACT_TYPE_CODE = i_Params_Get_Contact_By_Where_InList.CONTACT_TYPE_CODE;
oParams_Get_Contact_By_Where_InList_SP.CONTACT = i_Params_Get_Contact_By_Where_InList.CONTACT;
oParams_Get_Contact_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Contact_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Contact_By_Where_InList.PERSON_ID_LIST == null)
{
i_Params_Get_Contact_By_Where_InList.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Contact_By_Where_InList_SP.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Contact_By_Where_InList.PERSON_ID_LIST);
oParams_Get_Contact_By_Where_InList_SP.START_ROW = i_Params_Get_Contact_By_Where_InList.START_ROW;
oParams_Get_Contact_By_Where_InList_SP.END_ROW = i_Params_Get_Contact_By_Where_InList.END_ROW;
oParams_Get_Contact_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Contact_By_Where_InList.TOTAL_COUNT;
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Where_InList(i_Params_Get_Contact_By_Where_InList.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Where_InList.CONTACT,i_Params_Get_Contact_By_Where_InList.DESCRIPTION,i_Params_Get_Contact_By_Where_InList.PERSON_ID_LIST,i_Params_Get_Contact_By_Where_InList.OWNER_ID,i_Params_Get_Contact_By_Where_InList.START_ROW,i_Params_Get_Contact_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Where_InList.TOTAL_COUNT = oParams_Get_Contact_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Contact_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Where_InList");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_InList(Params_Get_Loc_l2_By_Criteria_InList i_Params_Get_Loc_l2_By_Criteria_InList)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l2_By_Criteria_InList_SP oParams_Get_Loc_l2_By_Criteria_InList_SP = new Params_Get_Loc_l2_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Criteria_InList.START_ROW == null) { i_Params_Get_Loc_l2_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Loc_l2_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID;
oParams_Get_Loc_l2_By_Criteria_InList_SP.CODE = i_Params_Get_Loc_l2_By_Criteria_InList.CODE;
oParams_Get_Loc_l2_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Loc_l2_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l2_By_Criteria_InList.LOC_L1_ID_LIST == null)
{
i_Params_Get_Loc_l2_By_Criteria_InList.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l2_By_Criteria_InList_SP.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l2_By_Criteria_InList.LOC_L1_ID_LIST);
oParams_Get_Loc_l2_By_Criteria_InList_SP.START_ROW = i_Params_Get_Loc_l2_By_Criteria_InList.START_ROW;
oParams_Get_Loc_l2_By_Criteria_InList_SP.END_ROW = i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW;
oParams_Get_Loc_l2_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l2_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Criteria_InList(i_Params_Get_Loc_l2_By_Criteria_InList.CODE,i_Params_Get_Loc_l2_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l2_By_Criteria_InList.LOC_L1_ID_LIST,i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l2_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l2_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l2_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Criteria_InList");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_InList(Params_Get_Loc_l2_By_Where_InList i_Params_Get_Loc_l2_By_Where_InList)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l2_By_Where_InList_SP oParams_Get_Loc_l2_By_Where_InList_SP = new Params_Get_Loc_l2_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Where_InList.START_ROW == null) { i_Params_Get_Loc_l2_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Where_InList.END_ROW == null) || (i_Params_Get_Loc_l2_By_Where_InList.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Loc_l2_By_Where_InList_SP.OWNER_ID = i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID;
oParams_Get_Loc_l2_By_Where_InList_SP.CODE = i_Params_Get_Loc_l2_By_Where_InList.CODE;
oParams_Get_Loc_l2_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Loc_l2_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l2_By_Where_InList.LOC_L1_ID_LIST == null)
{
i_Params_Get_Loc_l2_By_Where_InList.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l2_By_Where_InList_SP.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l2_By_Where_InList.LOC_L1_ID_LIST);
oParams_Get_Loc_l2_By_Where_InList_SP.START_ROW = i_Params_Get_Loc_l2_By_Where_InList.START_ROW;
oParams_Get_Loc_l2_By_Where_InList_SP.END_ROW = i_Params_Get_Loc_l2_By_Where_InList.END_ROW;
oParams_Get_Loc_l2_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l2_By_Where_InList.TOTAL_COUNT;
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Where_InList(i_Params_Get_Loc_l2_By_Where_InList.CODE,i_Params_Get_Loc_l2_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l2_By_Where_InList.LOC_L1_ID_LIST,i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l2_By_Where_InList.START_ROW,i_Params_Get_Loc_l2_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l2_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l2_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Where_InList");}
return oList;
}
public void Delete_Reservation_query(Params_Delete_Reservation_query i_Params_Delete_Reservation_query)
{
Params_Get_Reservation_query_By_RESERVATION_QUERY_ID oParams_Get_Reservation_query_By_RESERVATION_QUERY_ID = new Params_Get_Reservation_query_By_RESERVATION_QUERY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Reservation_query");}
#region Body Section.
try
{
oParams_Get_Reservation_query_By_RESERVATION_QUERY_ID.RESERVATION_QUERY_ID = i_Params_Delete_Reservation_query.RESERVATION_QUERY_ID;
_Reservation_query = Get_Reservation_query_By_RESERVATION_QUERY_ID_Adv(oParams_Get_Reservation_query_By_RESERVATION_QUERY_ID);
if (_Reservation_query != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Reservation_query_Execution)
{
_Stop_Delete_Reservation_query_Execution = false;
return;
}
_AppContext.Delete_Reservation_query(i_Params_Delete_Reservation_query.RESERVATION_QUERY_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Reservation_query");}
}
public void Delete_Loc_l3(Params_Delete_Loc_l3 i_Params_Delete_Loc_l3)
{
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l3");}
#region Body Section.
try
{
oParams_Get_Loc_l3_By_LOC_L3_ID.LOC_L3_ID = i_Params_Delete_Loc_l3.LOC_L3_ID;
_Loc_l3 = Get_Loc_l3_By_LOC_L3_ID_Adv(oParams_Get_Loc_l3_By_LOC_L3_ID);
if (_Loc_l3 != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l3_Execution)
{
_Stop_Delete_Loc_l3_Execution = false;
return;
}
_AppContext.Delete_Loc_l3(i_Params_Delete_Loc_l3.LOC_L3_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l3");}
}
public void Delete_Review(Params_Delete_Review i_Params_Delete_Review)
{
Params_Get_Review_By_REVIEW_ID oParams_Get_Review_By_REVIEW_ID = new Params_Get_Review_By_REVIEW_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Review");}
#region Body Section.
try
{
oParams_Get_Review_By_REVIEW_ID.REVIEW_ID = i_Params_Delete_Review.REVIEW_ID;
_Review = Get_Review_By_REVIEW_ID_Adv(oParams_Get_Review_By_REVIEW_ID);
if (_Review != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Review_Execution)
{
_Stop_Delete_Review_Execution = false;
return;
}
_AppContext.Delete_Review(i_Params_Delete_Review.REVIEW_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Review");}
}
public void Delete_Trip(Params_Delete_Trip i_Params_Delete_Trip)
{
Params_Get_Trip_By_TRIP_ID oParams_Get_Trip_By_TRIP_ID = new Params_Get_Trip_By_TRIP_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Trip");}
#region Body Section.
try
{
oParams_Get_Trip_By_TRIP_ID.TRIP_ID = i_Params_Delete_Trip.TRIP_ID;
_Trip = Get_Trip_By_TRIP_ID_Adv(oParams_Get_Trip_By_TRIP_ID);
if (_Trip != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Trip_Execution)
{
_Stop_Delete_Trip_Execution = false;
return;
}
_AppContext.Delete_Trip(i_Params_Delete_Trip.TRIP_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Trip");}
}
public void Delete_Loc_l4(Params_Delete_Loc_l4 i_Params_Delete_Loc_l4)
{
Params_Get_Loc_l4_By_LOC_L4_ID oParams_Get_Loc_l4_By_LOC_L4_ID = new Params_Get_Loc_l4_By_LOC_L4_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l4");}
#region Body Section.
try
{
oParams_Get_Loc_l4_By_LOC_L4_ID.LOC_L4_ID = i_Params_Delete_Loc_l4.LOC_L4_ID;
_Loc_l4 = Get_Loc_l4_By_LOC_L4_ID_Adv(oParams_Get_Loc_l4_By_LOC_L4_ID);
if (_Loc_l4 != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l4_Execution)
{
_Stop_Delete_Loc_l4_Execution = false;
return;
}
_AppContext.Delete_Loc_l4(i_Params_Delete_Loc_l4.LOC_L4_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l4");}
}
public void Delete_Address(Params_Delete_Address i_Params_Delete_Address)
{
Params_Get_Address_By_ADDRESS_ID oParams_Get_Address_By_ADDRESS_ID = new Params_Get_Address_By_ADDRESS_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address");}
#region Body Section.
try
{
oParams_Get_Address_By_ADDRESS_ID.ADDRESS_ID = i_Params_Delete_Address.ADDRESS_ID;
_Address = Get_Address_By_ADDRESS_ID_Adv(oParams_Get_Address_By_ADDRESS_ID);
if (_Address != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address(i_Params_Delete_Address.ADDRESS_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address");}
}
public void Delete_Owner(Params_Delete_Owner i_Params_Delete_Owner)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Owner");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Owner_Execution)
{
_Stop_Delete_Owner_Execution = false;
return;
}
_AppContext.Delete_Owner(i_Params_Delete_Owner.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Owner");}
}
public void Delete_Features(Params_Delete_Features i_Params_Delete_Features)
{
Params_Get_Features_By_FEATURES_ID oParams_Get_Features_By_FEATURES_ID = new Params_Get_Features_By_FEATURES_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Features");}
#region Body Section.
try
{
oParams_Get_Features_By_FEATURES_ID.FEATURES_ID = i_Params_Delete_Features.FEATURES_ID;
_Features = Get_Features_By_FEATURES_ID_Adv(oParams_Get_Features_By_FEATURES_ID);
if (_Features != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Features_Execution)
{
_Stop_Delete_Features_Execution = false;
return;
}
_AppContext.Delete_Features(i_Params_Delete_Features.FEATURES_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Features");}
}
public void Delete_User(Params_Delete_User i_Params_Delete_User)
{
Params_Get_User_By_USER_ID oParams_Get_User_By_USER_ID = new Params_Get_User_By_USER_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User");}
#region Body Section.
try
{
oParams_Get_User_By_USER_ID.USER_ID = i_Params_Delete_User.USER_ID;
_User = Get_User_By_USER_ID_Adv(oParams_Get_User_By_USER_ID);
if (_User != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User(i_Params_Delete_User.USER_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User");}
}
public void Delete_Includes(Params_Delete_Includes i_Params_Delete_Includes)
{
Params_Get_Includes_By_INCLUDES_ID oParams_Get_Includes_By_INCLUDES_ID = new Params_Get_Includes_By_INCLUDES_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Includes");}
#region Body Section.
try
{
oParams_Get_Includes_By_INCLUDES_ID.INCLUDES_ID = i_Params_Delete_Includes.INCLUDES_ID;
_Includes = Get_Includes_By_INCLUDES_ID_Adv(oParams_Get_Includes_By_INCLUDES_ID);
if (_Includes != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Includes_Execution)
{
_Stop_Delete_Includes_Execution = false;
return;
}
_AppContext.Delete_Includes(i_Params_Delete_Includes.INCLUDES_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Includes");}
}
public void Delete_Staff(Params_Delete_Staff i_Params_Delete_Staff)
{
Params_Get_Staff_By_STAFF_ID oParams_Get_Staff_By_STAFF_ID = new Params_Get_Staff_By_STAFF_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Staff");}
#region Body Section.
try
{
oParams_Get_Staff_By_STAFF_ID.STAFF_ID = i_Params_Delete_Staff.STAFF_ID;
_Staff = Get_Staff_By_STAFF_ID_Adv(oParams_Get_Staff_By_STAFF_ID);
if (_Staff != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Staff_Execution)
{
_Stop_Delete_Staff_Execution = false;
return;
}
_AppContext.Delete_Staff(i_Params_Delete_Staff.STAFF_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Staff");}
}
public void Delete_Person(Params_Delete_Person i_Params_Delete_Person)
{
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Person");}
#region Body Section.
try
{
oParams_Get_Person_By_PERSON_ID.PERSON_ID = i_Params_Delete_Person.PERSON_ID;
_Person = Get_Person_By_PERSON_ID_Adv(oParams_Get_Person_By_PERSON_ID);
if (_Person != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Person_Execution)
{
_Stop_Delete_Person_Execution = false;
return;
}
_AppContext.Delete_Person(i_Params_Delete_Person.PERSON_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Person");}
}
public void Delete_Tags(Params_Delete_Tags i_Params_Delete_Tags)
{
Params_Get_Tags_By_TAGS_ID oParams_Get_Tags_By_TAGS_ID = new Params_Get_Tags_By_TAGS_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Tags");}
#region Body Section.
try
{
oParams_Get_Tags_By_TAGS_ID.TAGS_ID = i_Params_Delete_Tags.TAGS_ID;
_Tags = Get_Tags_By_TAGS_ID_Adv(oParams_Get_Tags_By_TAGS_ID);
if (_Tags != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Tags_Execution)
{
_Stop_Delete_Tags_Execution = false;
return;
}
_AppContext.Delete_Tags(i_Params_Delete_Tags.TAGS_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Tags");}
}
public void Delete_Social_media_links(Params_Delete_Social_media_links i_Params_Delete_Social_media_links)
{
Params_Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID oParams_Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID = new Params_Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Social_media_links");}
#region Body Section.
try
{
oParams_Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID.SOCIAL_MEDIA_LINKS_ID = i_Params_Delete_Social_media_links.SOCIAL_MEDIA_LINKS_ID;
_Social_media_links = Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID_Adv(oParams_Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID);
if (_Social_media_links != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Social_media_links_Execution)
{
_Stop_Delete_Social_media_links_Execution = false;
return;
}
_AppContext.Delete_Social_media_links(i_Params_Delete_Social_media_links.SOCIAL_MEDIA_LINKS_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Social_media_links");}
}
public void Delete_Contact(Params_Delete_Contact i_Params_Delete_Contact)
{
Params_Get_Contact_By_CONTACT_ID oParams_Get_Contact_By_CONTACT_ID = new Params_Get_Contact_By_CONTACT_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Contact");}
#region Body Section.
try
{
oParams_Get_Contact_By_CONTACT_ID.CONTACT_ID = i_Params_Delete_Contact.CONTACT_ID;
_Contact = Get_Contact_By_CONTACT_ID_Adv(oParams_Get_Contact_By_CONTACT_ID);
if (_Contact != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Contact_Execution)
{
_Stop_Delete_Contact_Execution = false;
return;
}
_AppContext.Delete_Contact(i_Params_Delete_Contact.CONTACT_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Contact");}
}
public void Delete_Uploaded_file(Params_Delete_Uploaded_file i_Params_Delete_Uploaded_file)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Uploaded_file");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Delete_Uploaded_file
if (OnPreEvent_Delete_Uploaded_file != null)
{
OnPreEvent_Delete_Uploaded_file(i_Params_Delete_Uploaded_file);
}
#endregion
if (_Stop_Delete_Uploaded_file_Execution)
{
_Stop_Delete_Uploaded_file_Execution = false;
return;
}
_AppContext.Delete_Uploaded_file(i_Params_Delete_Uploaded_file.UPLOADED_FILE_ID);
#region PostEvent_Delete_Uploaded_file
if (OnPostEvent_Delete_Uploaded_file != null)
{
OnPostEvent_Delete_Uploaded_file(i_Params_Delete_Uploaded_file);
}
#endregion
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Uploaded_file");}
}
public void Delete_Loc_l1(Params_Delete_Loc_l1 i_Params_Delete_Loc_l1)
{
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l1");}
#region Body Section.
try
{
oParams_Get_Loc_l1_By_LOC_L1_ID.LOC_L1_ID = i_Params_Delete_Loc_l1.LOC_L1_ID;
_Loc_l1 = Get_Loc_l1_By_LOC_L1_ID_Adv(oParams_Get_Loc_l1_By_LOC_L1_ID);
if (_Loc_l1 != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l1_Execution)
{
_Stop_Delete_Loc_l1_Execution = false;
return;
}
_AppContext.Delete_Loc_l1(i_Params_Delete_Loc_l1.LOC_L1_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l1");}
}
public void Delete_Loc_l2(Params_Delete_Loc_l2 i_Params_Delete_Loc_l2)
{
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l2");}
#region Body Section.
try
{
oParams_Get_Loc_l2_By_LOC_L2_ID.LOC_L2_ID = i_Params_Delete_Loc_l2.LOC_L2_ID;
_Loc_l2 = Get_Loc_l2_By_LOC_L2_ID_Adv(oParams_Get_Loc_l2_By_LOC_L2_ID);
if (_Loc_l2 != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l2_Execution)
{
_Stop_Delete_Loc_l2_Execution = false;
return;
}
_AppContext.Delete_Loc_l2(i_Params_Delete_Loc_l2.LOC_L2_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l2");}
}
public void Delete_Reservation_query_By_OWNER_ID(Params_Delete_Reservation_query_By_OWNER_ID i_Params_Delete_Reservation_query_By_OWNER_ID)
{
Params_Get_Reservation_query_By_OWNER_ID oParams_Get_Reservation_query_By_OWNER_ID = new Params_Get_Reservation_query_By_OWNER_ID();
List<Reservation_query> _List_Reservation_query = new List<Reservation_query>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Reservation_query_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Reservation_query_Execution)
{
_Stop_Delete_Reservation_query_Execution = false;
return;
}
_AppContext.Delete_Reservation_query_By_OWNER_ID(i_Params_Delete_Reservation_query_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Reservation_query_By_OWNER_ID");}
}
public void Delete_Loc_l3_By_LOC_L2_ID_CODE(Params_Delete_Loc_l3_By_LOC_L2_ID_CODE i_Params_Delete_Loc_l3_By_LOC_L2_ID_CODE)
{
Params_Get_Loc_l3_By_LOC_L2_ID_CODE oParams_Get_Loc_l3_By_LOC_L2_ID_CODE = new Params_Get_Loc_l3_By_LOC_L2_ID_CODE();
List<Loc_l3> _List_Loc_l3 = new List<Loc_l3>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l3_By_LOC_L2_ID_CODE");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l3_Execution)
{
_Stop_Delete_Loc_l3_Execution = false;
return;
}
_AppContext.Delete_Loc_l3_By_LOC_L2_ID_CODE(i_Params_Delete_Loc_l3_By_LOC_L2_ID_CODE.LOC_L2_ID,i_Params_Delete_Loc_l3_By_LOC_L2_ID_CODE.CODE);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l3_By_LOC_L2_ID_CODE");}
}
public void Delete_Loc_l3_By_LOC_L2_ID(Params_Delete_Loc_l3_By_LOC_L2_ID i_Params_Delete_Loc_l3_By_LOC_L2_ID)
{
Params_Get_Loc_l3_By_LOC_L2_ID oParams_Get_Loc_l3_By_LOC_L2_ID = new Params_Get_Loc_l3_By_LOC_L2_ID();
List<Loc_l3> _List_Loc_l3 = new List<Loc_l3>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l3_By_LOC_L2_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l3_Execution)
{
_Stop_Delete_Loc_l3_Execution = false;
return;
}
_AppContext.Delete_Loc_l3_By_LOC_L2_ID(i_Params_Delete_Loc_l3_By_LOC_L2_ID.LOC_L2_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l3_By_LOC_L2_ID");}
}
public void Delete_Loc_l3_By_OWNER_ID(Params_Delete_Loc_l3_By_OWNER_ID i_Params_Delete_Loc_l3_By_OWNER_ID)
{
Params_Get_Loc_l3_By_OWNER_ID oParams_Get_Loc_l3_By_OWNER_ID = new Params_Get_Loc_l3_By_OWNER_ID();
List<Loc_l3> _List_Loc_l3 = new List<Loc_l3>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l3_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l3_Execution)
{
_Stop_Delete_Loc_l3_Execution = false;
return;
}
_AppContext.Delete_Loc_l3_By_OWNER_ID(i_Params_Delete_Loc_l3_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l3_By_OWNER_ID");}
}
public void Delete_Review_By_OWNER_ID(Params_Delete_Review_By_OWNER_ID i_Params_Delete_Review_By_OWNER_ID)
{
Params_Get_Review_By_OWNER_ID oParams_Get_Review_By_OWNER_ID = new Params_Get_Review_By_OWNER_ID();
List<Review> _List_Review = new List<Review>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Review_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Review_Execution)
{
_Stop_Delete_Review_Execution = false;
return;
}
_AppContext.Delete_Review_By_OWNER_ID(i_Params_Delete_Review_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Review_By_OWNER_ID");}
}
public void Delete_Trip_By_OWNER_ID(Params_Delete_Trip_By_OWNER_ID i_Params_Delete_Trip_By_OWNER_ID)
{
Params_Get_Trip_By_OWNER_ID oParams_Get_Trip_By_OWNER_ID = new Params_Get_Trip_By_OWNER_ID();
List<Trip> _List_Trip = new List<Trip>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Trip_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Trip_Execution)
{
_Stop_Delete_Trip_Execution = false;
return;
}
_AppContext.Delete_Trip_By_OWNER_ID(i_Params_Delete_Trip_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Trip_By_OWNER_ID");}
}
public void Delete_Loc_l4_By_LOC_L3_ID_CODE(Params_Delete_Loc_l4_By_LOC_L3_ID_CODE i_Params_Delete_Loc_l4_By_LOC_L3_ID_CODE)
{
Params_Get_Loc_l4_By_LOC_L3_ID_CODE oParams_Get_Loc_l4_By_LOC_L3_ID_CODE = new Params_Get_Loc_l4_By_LOC_L3_ID_CODE();
List<Loc_l4> _List_Loc_l4 = new List<Loc_l4>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l4_By_LOC_L3_ID_CODE");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l4_Execution)
{
_Stop_Delete_Loc_l4_Execution = false;
return;
}
_AppContext.Delete_Loc_l4_By_LOC_L3_ID_CODE(i_Params_Delete_Loc_l4_By_LOC_L3_ID_CODE.LOC_L3_ID,i_Params_Delete_Loc_l4_By_LOC_L3_ID_CODE.CODE);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l4_By_LOC_L3_ID_CODE");}
}
public void Delete_Loc_l4_By_LOC_L3_ID(Params_Delete_Loc_l4_By_LOC_L3_ID i_Params_Delete_Loc_l4_By_LOC_L3_ID)
{
Params_Get_Loc_l4_By_LOC_L3_ID oParams_Get_Loc_l4_By_LOC_L3_ID = new Params_Get_Loc_l4_By_LOC_L3_ID();
List<Loc_l4> _List_Loc_l4 = new List<Loc_l4>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l4_By_LOC_L3_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l4_Execution)
{
_Stop_Delete_Loc_l4_Execution = false;
return;
}
_AppContext.Delete_Loc_l4_By_LOC_L3_ID(i_Params_Delete_Loc_l4_By_LOC_L3_ID.LOC_L3_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l4_By_LOC_L3_ID");}
}
public void Delete_Loc_l4_By_OWNER_ID(Params_Delete_Loc_l4_By_OWNER_ID i_Params_Delete_Loc_l4_By_OWNER_ID)
{
Params_Get_Loc_l4_By_OWNER_ID oParams_Get_Loc_l4_By_OWNER_ID = new Params_Get_Loc_l4_By_OWNER_ID();
List<Loc_l4> _List_Loc_l4 = new List<Loc_l4>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l4_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l4_Execution)
{
_Stop_Delete_Loc_l4_Execution = false;
return;
}
_AppContext.Delete_Loc_l4_By_OWNER_ID(i_Params_Delete_Loc_l4_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l4_By_OWNER_ID");}
}
public void Delete_Address_By_PERSON_ID(Params_Delete_Address_By_PERSON_ID i_Params_Delete_Address_By_PERSON_ID)
{
Params_Get_Address_By_PERSON_ID oParams_Get_Address_By_PERSON_ID = new Params_Get_Address_By_PERSON_ID();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_PERSON_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_PERSON_ID(i_Params_Delete_Address_By_PERSON_ID.PERSON_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_PERSON_ID");}
}
public void Delete_Address_By_LOC_L1_ID(Params_Delete_Address_By_LOC_L1_ID i_Params_Delete_Address_By_LOC_L1_ID)
{
Params_Get_Address_By_LOC_L1_ID oParams_Get_Address_By_LOC_L1_ID = new Params_Get_Address_By_LOC_L1_ID();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_LOC_L1_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_LOC_L1_ID(i_Params_Delete_Address_By_LOC_L1_ID.LOC_L1_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_LOC_L1_ID");}
}
public void Delete_Address_By_LOC_L2_ID(Params_Delete_Address_By_LOC_L2_ID i_Params_Delete_Address_By_LOC_L2_ID)
{
Params_Get_Address_By_LOC_L2_ID oParams_Get_Address_By_LOC_L2_ID = new Params_Get_Address_By_LOC_L2_ID();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_LOC_L2_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_LOC_L2_ID(i_Params_Delete_Address_By_LOC_L2_ID.LOC_L2_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_LOC_L2_ID");}
}
public void Delete_Address_By_LOC_L3_ID(Params_Delete_Address_By_LOC_L3_ID i_Params_Delete_Address_By_LOC_L3_ID)
{
Params_Get_Address_By_LOC_L3_ID oParams_Get_Address_By_LOC_L3_ID = new Params_Get_Address_By_LOC_L3_ID();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_LOC_L3_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_LOC_L3_ID(i_Params_Delete_Address_By_LOC_L3_ID.LOC_L3_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_LOC_L3_ID");}
}
public void Delete_Address_By_OWNER_ID(Params_Delete_Address_By_OWNER_ID i_Params_Delete_Address_By_OWNER_ID)
{
Params_Get_Address_By_OWNER_ID oParams_Get_Address_By_OWNER_ID = new Params_Get_Address_By_OWNER_ID();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_OWNER_ID(i_Params_Delete_Address_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_OWNER_ID");}
}
public void Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE(Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE i_Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE)
{
Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE oParams_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE = new Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE(i_Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.PERSON_ID,i_Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.ADDRESS_TYPE_CODE);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE");}
}
public void Delete_Address_By_LOC_L4_ID(Params_Delete_Address_By_LOC_L4_ID i_Params_Delete_Address_By_LOC_L4_ID)
{
Params_Get_Address_By_LOC_L4_ID oParams_Get_Address_By_LOC_L4_ID = new Params_Get_Address_By_LOC_L4_ID();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_LOC_L4_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_LOC_L4_ID(i_Params_Delete_Address_By_LOC_L4_ID.LOC_L4_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_LOC_L4_ID");}
}
public void Delete_Features_By_OWNER_ID(Params_Delete_Features_By_OWNER_ID i_Params_Delete_Features_By_OWNER_ID)
{
Params_Get_Features_By_OWNER_ID oParams_Get_Features_By_OWNER_ID = new Params_Get_Features_By_OWNER_ID();
List<Features> _List_Features = new List<Features>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Features_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Features_Execution)
{
_Stop_Delete_Features_Execution = false;
return;
}
_AppContext.Delete_Features_By_OWNER_ID(i_Params_Delete_Features_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Features_By_OWNER_ID");}
}
public void Delete_Features_By_TRIP_ID(Params_Delete_Features_By_TRIP_ID i_Params_Delete_Features_By_TRIP_ID)
{
Params_Get_Features_By_TRIP_ID oParams_Get_Features_By_TRIP_ID = new Params_Get_Features_By_TRIP_ID();
List<Features> _List_Features = new List<Features>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Features_By_TRIP_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Features_Execution)
{
_Stop_Delete_Features_Execution = false;
return;
}
_AppContext.Delete_Features_By_TRIP_ID(i_Params_Delete_Features_By_TRIP_ID.TRIP_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Features_By_TRIP_ID");}
}
public void Delete_User_By_OWNER_ID(Params_Delete_User_By_OWNER_ID i_Params_Delete_User_By_OWNER_ID)
{
Params_Get_User_By_OWNER_ID oParams_Get_User_By_OWNER_ID = new Params_Get_User_By_OWNER_ID();
List<User> _List_User = new List<User>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User_By_OWNER_ID(i_Params_Delete_User_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_By_OWNER_ID");}
}
public void Delete_User_By_USERNAME(Params_Delete_User_By_USERNAME i_Params_Delete_User_By_USERNAME)
{
Params_Get_User_By_USERNAME oParams_Get_User_By_USERNAME = new Params_Get_User_By_USERNAME();
List<User> _List_User = new List<User>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_By_USERNAME");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User_By_USERNAME(i_Params_Delete_User_By_USERNAME.USERNAME);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_By_USERNAME");}
}
public void Delete_Includes_By_OWNER_ID(Params_Delete_Includes_By_OWNER_ID i_Params_Delete_Includes_By_OWNER_ID)
{
Params_Get_Includes_By_OWNER_ID oParams_Get_Includes_By_OWNER_ID = new Params_Get_Includes_By_OWNER_ID();
List<Includes> _List_Includes = new List<Includes>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Includes_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Includes_Execution)
{
_Stop_Delete_Includes_Execution = false;
return;
}
_AppContext.Delete_Includes_By_OWNER_ID(i_Params_Delete_Includes_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Includes_By_OWNER_ID");}
}
public void Delete_Includes_By_TRIP_ID(Params_Delete_Includes_By_TRIP_ID i_Params_Delete_Includes_By_TRIP_ID)
{
Params_Get_Includes_By_TRIP_ID oParams_Get_Includes_By_TRIP_ID = new Params_Get_Includes_By_TRIP_ID();
List<Includes> _List_Includes = new List<Includes>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Includes_By_TRIP_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Includes_Execution)
{
_Stop_Delete_Includes_Execution = false;
return;
}
_AppContext.Delete_Includes_By_TRIP_ID(i_Params_Delete_Includes_By_TRIP_ID.TRIP_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Includes_By_TRIP_ID");}
}
public void Delete_Staff_By_OWNER_ID(Params_Delete_Staff_By_OWNER_ID i_Params_Delete_Staff_By_OWNER_ID)
{
Params_Get_Staff_By_OWNER_ID oParams_Get_Staff_By_OWNER_ID = new Params_Get_Staff_By_OWNER_ID();
List<Staff> _List_Staff = new List<Staff>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Staff_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Staff_Execution)
{
_Stop_Delete_Staff_Execution = false;
return;
}
_AppContext.Delete_Staff_By_OWNER_ID(i_Params_Delete_Staff_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Staff_By_OWNER_ID");}
}
public void Delete_Person_By_OWNER_ID(Params_Delete_Person_By_OWNER_ID i_Params_Delete_Person_By_OWNER_ID)
{
Params_Get_Person_By_OWNER_ID oParams_Get_Person_By_OWNER_ID = new Params_Get_Person_By_OWNER_ID();
List<Person> _List_Person = new List<Person>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Person_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Person_Execution)
{
_Stop_Delete_Person_Execution = false;
return;
}
_AppContext.Delete_Person_By_OWNER_ID(i_Params_Delete_Person_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Person_By_OWNER_ID");}
}
public void Delete_Tags_By_OWNER_ID(Params_Delete_Tags_By_OWNER_ID i_Params_Delete_Tags_By_OWNER_ID)
{
Params_Get_Tags_By_OWNER_ID oParams_Get_Tags_By_OWNER_ID = new Params_Get_Tags_By_OWNER_ID();
List<Tags> _List_Tags = new List<Tags>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Tags_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Tags_Execution)
{
_Stop_Delete_Tags_Execution = false;
return;
}
_AppContext.Delete_Tags_By_OWNER_ID(i_Params_Delete_Tags_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Tags_By_OWNER_ID");}
}
public void Delete_Tags_By_TRIP_ID(Params_Delete_Tags_By_TRIP_ID i_Params_Delete_Tags_By_TRIP_ID)
{
Params_Get_Tags_By_TRIP_ID oParams_Get_Tags_By_TRIP_ID = new Params_Get_Tags_By_TRIP_ID();
List<Tags> _List_Tags = new List<Tags>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Tags_By_TRIP_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Tags_Execution)
{
_Stop_Delete_Tags_Execution = false;
return;
}
_AppContext.Delete_Tags_By_TRIP_ID(i_Params_Delete_Tags_By_TRIP_ID.TRIP_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Tags_By_TRIP_ID");}
}
public void Delete_Social_media_links_By_OWNER_ID(Params_Delete_Social_media_links_By_OWNER_ID i_Params_Delete_Social_media_links_By_OWNER_ID)
{
Params_Get_Social_media_links_By_OWNER_ID oParams_Get_Social_media_links_By_OWNER_ID = new Params_Get_Social_media_links_By_OWNER_ID();
List<Social_media_links> _List_Social_media_links = new List<Social_media_links>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Social_media_links_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Social_media_links_Execution)
{
_Stop_Delete_Social_media_links_Execution = false;
return;
}
_AppContext.Delete_Social_media_links_By_OWNER_ID(i_Params_Delete_Social_media_links_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Social_media_links_By_OWNER_ID");}
}
public void Delete_Contact_By_PERSON_ID(Params_Delete_Contact_By_PERSON_ID i_Params_Delete_Contact_By_PERSON_ID)
{
Params_Get_Contact_By_PERSON_ID oParams_Get_Contact_By_PERSON_ID = new Params_Get_Contact_By_PERSON_ID();
List<Contact> _List_Contact = new List<Contact>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Contact_By_PERSON_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Contact_Execution)
{
_Stop_Delete_Contact_Execution = false;
return;
}
_AppContext.Delete_Contact_By_PERSON_ID(i_Params_Delete_Contact_By_PERSON_ID.PERSON_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Contact_By_PERSON_ID");}
}
public void Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT(Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT i_Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT)
{
Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT oParams_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT = new Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT();
List<Contact> _List_Contact = new List<Contact>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Contact_Execution)
{
_Stop_Delete_Contact_Execution = false;
return;
}
_AppContext.Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT(i_Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.PERSON_ID,i_Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT_TYPE_CODE,i_Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT");}
}
public void Delete_Contact_By_OWNER_ID(Params_Delete_Contact_By_OWNER_ID i_Params_Delete_Contact_By_OWNER_ID)
{
Params_Get_Contact_By_OWNER_ID oParams_Get_Contact_By_OWNER_ID = new Params_Get_Contact_By_OWNER_ID();
List<Contact> _List_Contact = new List<Contact>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Contact_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Contact_Execution)
{
_Stop_Delete_Contact_Execution = false;
return;
}
_AppContext.Delete_Contact_By_OWNER_ID(i_Params_Delete_Contact_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Contact_By_OWNER_ID");}
}
public void Delete_Uploaded_file_By_OWNER_ID(Params_Delete_Uploaded_file_By_OWNER_ID i_Params_Delete_Uploaded_file_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Uploaded_file_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Uploaded_file_Execution)
{
_Stop_Delete_Uploaded_file_Execution = false;
return;
}
_AppContext.Delete_Uploaded_file_By_OWNER_ID(i_Params_Delete_Uploaded_file_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Uploaded_file_By_OWNER_ID");}
}
public void Delete_Uploaded_file_By_REL_ENTITY(Params_Delete_Uploaded_file_By_REL_ENTITY i_Params_Delete_Uploaded_file_By_REL_ENTITY)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Uploaded_file_By_REL_ENTITY");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Uploaded_file_Execution)
{
_Stop_Delete_Uploaded_file_Execution = false;
return;
}
_AppContext.Delete_Uploaded_file_By_REL_ENTITY(i_Params_Delete_Uploaded_file_By_REL_ENTITY.REL_ENTITY);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Uploaded_file_By_REL_ENTITY");}
}
public void Delete_Uploaded_file_By_REL_ENTITY_REL_KEY(Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Uploaded_file_By_REL_ENTITY_REL_KEY");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Uploaded_file_Execution)
{
_Stop_Delete_Uploaded_file_Execution = false;
return;
}
_AppContext.Delete_Uploaded_file_By_REL_ENTITY_REL_KEY(i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY.REL_ENTITY,i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY.REL_KEY);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Uploaded_file_By_REL_ENTITY_REL_KEY");}
}
public void Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD
if (OnPreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD != null)
{
OnPreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD);
}
#endregion
if (_Stop_Delete_Uploaded_file_Execution)
{
_Stop_Delete_Uploaded_file_Execution = false;
return;
}
_AppContext.Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_ENTITY,i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_KEY,i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_FIELD);
#region PostEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD
if (OnPostEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD != null)
{
OnPostEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD);
}
#endregion
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD");}
}
public void Delete_Loc_l1_By_CODE(Params_Delete_Loc_l1_By_CODE i_Params_Delete_Loc_l1_By_CODE)
{
Params_Get_Loc_l1_By_CODE oParams_Get_Loc_l1_By_CODE = new Params_Get_Loc_l1_By_CODE();
List<Loc_l1> _List_Loc_l1 = new List<Loc_l1>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l1_By_CODE");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l1_Execution)
{
_Stop_Delete_Loc_l1_Execution = false;
return;
}
_AppContext.Delete_Loc_l1_By_CODE(i_Params_Delete_Loc_l1_By_CODE.CODE);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l1_By_CODE");}
}
public void Delete_Loc_l1_By_OWNER_ID(Params_Delete_Loc_l1_By_OWNER_ID i_Params_Delete_Loc_l1_By_OWNER_ID)
{
Params_Get_Loc_l1_By_OWNER_ID oParams_Get_Loc_l1_By_OWNER_ID = new Params_Get_Loc_l1_By_OWNER_ID();
List<Loc_l1> _List_Loc_l1 = new List<Loc_l1>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l1_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l1_Execution)
{
_Stop_Delete_Loc_l1_Execution = false;
return;
}
_AppContext.Delete_Loc_l1_By_OWNER_ID(i_Params_Delete_Loc_l1_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l1_By_OWNER_ID");}
}
public void Delete_Loc_l2_By_LOC_L1_ID_CODE(Params_Delete_Loc_l2_By_LOC_L1_ID_CODE i_Params_Delete_Loc_l2_By_LOC_L1_ID_CODE)
{
Params_Get_Loc_l2_By_LOC_L1_ID_CODE oParams_Get_Loc_l2_By_LOC_L1_ID_CODE = new Params_Get_Loc_l2_By_LOC_L1_ID_CODE();
List<Loc_l2> _List_Loc_l2 = new List<Loc_l2>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l2_By_LOC_L1_ID_CODE");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l2_Execution)
{
_Stop_Delete_Loc_l2_Execution = false;
return;
}
_AppContext.Delete_Loc_l2_By_LOC_L1_ID_CODE(i_Params_Delete_Loc_l2_By_LOC_L1_ID_CODE.LOC_L1_ID,i_Params_Delete_Loc_l2_By_LOC_L1_ID_CODE.CODE);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l2_By_LOC_L1_ID_CODE");}
}
public void Delete_Loc_l2_By_LOC_L1_ID(Params_Delete_Loc_l2_By_LOC_L1_ID i_Params_Delete_Loc_l2_By_LOC_L1_ID)
{
Params_Get_Loc_l2_By_LOC_L1_ID oParams_Get_Loc_l2_By_LOC_L1_ID = new Params_Get_Loc_l2_By_LOC_L1_ID();
List<Loc_l2> _List_Loc_l2 = new List<Loc_l2>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l2_By_LOC_L1_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l2_Execution)
{
_Stop_Delete_Loc_l2_Execution = false;
return;
}
_AppContext.Delete_Loc_l2_By_LOC_L1_ID(i_Params_Delete_Loc_l2_By_LOC_L1_ID.LOC_L1_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l2_By_LOC_L1_ID");}
}
public void Delete_Loc_l2_By_OWNER_ID(Params_Delete_Loc_l2_By_OWNER_ID i_Params_Delete_Loc_l2_By_OWNER_ID)
{
Params_Get_Loc_l2_By_OWNER_ID oParams_Get_Loc_l2_By_OWNER_ID = new Params_Get_Loc_l2_By_OWNER_ID();
List<Loc_l2> _List_Loc_l2 = new List<Loc_l2>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l2_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l2_Execution)
{
_Stop_Delete_Loc_l2_Execution = false;
return;
}
_AppContext.Delete_Loc_l2_By_OWNER_ID(i_Params_Delete_Loc_l2_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l2_By_OWNER_ID");}
}
public void Edit_Reservation_query(Reservation_query i_Reservation_query) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Reservation_query.RESERVATION_QUERY_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Reservation_query");}
#region Body Section.
if ((i_Reservation_query.RESERVATION_QUERY_ID == null) || (i_Reservation_query.RESERVATION_QUERY_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Reservation_query"); }
i_Reservation_query.ENTRY_USER_ID = this.UserID;
i_Reservation_query.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Reservation_query.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Reservation_query_Execution)
{
_Stop_Edit_Reservation_query_Execution = false;
return;
}
i_Reservation_query.RESERVATION_QUERY_ID = _AppContext.Edit_Reservation_query
(
i_Reservation_query.RESERVATION_QUERY_ID
,i_Reservation_query.NB_OF_ADULTS
,i_Reservation_query.NB_OF_CHILDREN
,i_Reservation_query.PICK_UP_ADDRESS
,i_Reservation_query.TRIP_DATE
,i_Reservation_query.QUERY_DESCRIPTION
,i_Reservation_query.ENTRY_USER_ID
,i_Reservation_query.ENTRY_DATE
,i_Reservation_query.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Reservation_query");}
}
public void Edit_Loc_l3(Loc_l3 i_Loc_l3) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Loc_l3.LOC_L3_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3");}
#region Body Section.
if ((i_Loc_l3.LOC_L3_ID == null) || (i_Loc_l3.LOC_L3_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Loc_l3"); }
i_Loc_l3.ENTRY_USER_ID = this.UserID;
i_Loc_l3.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Loc_l3.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Loc_l3_Execution)
{
_Stop_Edit_Loc_l3_Execution = false;
return;
}
i_Loc_l3.LOC_L3_ID = _AppContext.Edit_Loc_l3
(
i_Loc_l3.LOC_L3_ID
,i_Loc_l3.CODE
,i_Loc_l3.DESCRIPTION
,i_Loc_l3.LOC_L2_ID
,i_Loc_l3.NOTES
,i_Loc_l3.ENTRY_DATE
,i_Loc_l3.ENTRY_USER_ID
,i_Loc_l3.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3");}
}
public void Edit_Review(Review i_Review) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Review.REVIEW_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Review");}
#region Body Section.
if ((i_Review.REVIEW_ID == null) || (i_Review.REVIEW_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Review"); }
i_Review.ENTRY_USER_ID = this.UserID;
i_Review.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Review.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Review_Execution)
{
_Stop_Edit_Review_Execution = false;
return;
}
i_Review.REVIEW_ID = _AppContext.Edit_Review
(
i_Review.REVIEW_ID
,i_Review.TITLE
,i_Review.REVIEW_TEXT
,i_Review.ENTRY_USER_ID
,i_Review.ENTRY_DATE
,i_Review.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Review");}
}
public void Edit_Trip(Trip i_Trip) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Trip.TRIP_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Trip");}
#region Body Section.
if ((i_Trip.TRIP_ID == null) || (i_Trip.TRIP_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Trip"); }
i_Trip.ENTRY_USER_ID = this.UserID;
i_Trip.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Trip.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Trip_Execution)
{
_Stop_Edit_Trip_Execution = false;
return;
}
i_Trip.TRIP_ID = _AppContext.Edit_Trip
(
i_Trip.TRIP_ID
,i_Trip.TITLE
,i_Trip.SUB_TITLE
,i_Trip.DETAILS
,i_Trip.CITY
,i_Trip.PRICE
,i_Trip.DISCOUNT_PRICE
,i_Trip.VIDEO_URL
,i_Trip.IS_AVAILABLE_OR_COMING_SOON
,i_Trip.OFFER_HIGHLIGHT_TEXT
,i_Trip.ENTRY_USER_ID
,i_Trip.ENTRY_DATE
,i_Trip.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Trip");}
}
public void Edit_Loc_l4(Loc_l4 i_Loc_l4) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Loc_l4.LOC_L4_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l4");}
#region Body Section.
if ((i_Loc_l4.LOC_L4_ID == null) || (i_Loc_l4.LOC_L4_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Loc_l4"); }
i_Loc_l4.ENTRY_USER_ID = this.UserID;
i_Loc_l4.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Loc_l4.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Loc_l4_Execution)
{
_Stop_Edit_Loc_l4_Execution = false;
return;
}
i_Loc_l4.LOC_L4_ID = _AppContext.Edit_Loc_l4
(
i_Loc_l4.LOC_L4_ID
,i_Loc_l4.CODE
,i_Loc_l4.DESCRIPTION
,i_Loc_l4.LOC_L3_ID
,i_Loc_l4.NOTES
,i_Loc_l4.ENTRY_DATE
,i_Loc_l4.ENTRY_USER_ID
,i_Loc_l4.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l4");}
}
public void Edit_Address(Address i_Address) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Address.ADDRESS_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Address");}
#region Body Section.
if ((i_Address.ADDRESS_ID == null) || (i_Address.ADDRESS_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Address"); }
i_Address.ENTRY_USER_ID = this.UserID;
i_Address.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Address.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Address_Execution)
{
_Stop_Edit_Address_Execution = false;
return;
}
i_Address.ADDRESS_ID = _AppContext.Edit_Address
(
i_Address.ADDRESS_ID
,i_Address.PERSON_ID
,i_Address.ADDRESS_TYPE_CODE
,i_Address.LOC_L1_ID
,i_Address.LOC_L2_ID
,i_Address.LOC_L3_ID
,i_Address.LOC_L4_ID
,i_Address.STREET
,i_Address.BUILDING
,i_Address.FLOOR
,i_Address.POBOX
,i_Address.VALID_DATE_START
,i_Address.VALID_DATE_END
,i_Address.NOTES
,i_Address.ENTRY_DATE
,i_Address.ENTRY_USER_ID
,i_Address.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Address");}
}
public void Edit_Owner(Owner i_Owner) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Owner.OWNER_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner");}
#region Body Section.
if ((i_Owner.OWNER_ID == null) || (i_Owner.OWNER_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Owner"); }
i_Owner.ENTRY_DATE    = oTools.GetDateTimeString(DateTime.Now);
i_Owner.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Owner_Execution)
{
_Stop_Edit_Owner_Execution = false;
return;
}
i_Owner.OWNER_ID = _AppContext.Edit_Owner
(
i_Owner.OWNER_ID
,i_Owner.CODE
,i_Owner.MAINTENANCE_DUE_DATE
,i_Owner.DESCRIPTION
,i_Owner.ENTRY_DATE
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner");}
}
public void Edit_Features(Features i_Features) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Features.FEATURES_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Features");}
#region Body Section.
if ((i_Features.FEATURES_ID == null) || (i_Features.FEATURES_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Features"); }
i_Features.ENTRY_USER_ID = this.UserID;
i_Features.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Features.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Features_Execution)
{
_Stop_Edit_Features_Execution = false;
return;
}
i_Features.FEATURES_ID = _AppContext.Edit_Features
(
i_Features.FEATURES_ID
,i_Features.TRIP_ID
,i_Features.TITLE
,i_Features.DESCRIPTION
,i_Features.ENTRY_USER_ID
,i_Features.ENTRY_DATE
,i_Features.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Features");}
}
public void Edit_User(User i_User) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_User.USER_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User");}
#region Body Section.
if ((i_User.USER_ID == null) || (i_User.USER_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_User"); }
i_User.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_User.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_User_Execution)
{
_Stop_Edit_User_Execution = false;
return;
}
i_User.USER_ID = _AppContext.Edit_User
(
i_User.USER_ID
,i_User.OWNER_ID
,i_User.USERNAME
,i_User.PASSWORD
,i_User.USER_TYPE_CODE
,i_User.IS_ACTIVE
,i_User.ENTRY_DATE
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User");}
}
public void Edit_Includes(Includes i_Includes) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Includes.INCLUDES_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Includes");}
#region Body Section.
if ((i_Includes.INCLUDES_ID == null) || (i_Includes.INCLUDES_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Includes"); }
i_Includes.ENTRY_USER_ID = this.UserID;
i_Includes.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Includes.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Includes_Execution)
{
_Stop_Edit_Includes_Execution = false;
return;
}
i_Includes.INCLUDES_ID = _AppContext.Edit_Includes
(
i_Includes.INCLUDES_ID
,i_Includes.TRIP_ID
,i_Includes.TITLE
,i_Includes.DESCRIPTION
,i_Includes.ENTRY_USER_ID
,i_Includes.ENTRY_DATE
,i_Includes.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Includes");}
}
public void Edit_Staff(Staff i_Staff) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Staff.STAFF_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Staff");}
#region Body Section.
if ((i_Staff.STAFF_ID == null) || (i_Staff.STAFF_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Staff"); }
i_Staff.ENTRY_USER_ID = this.UserID;
i_Staff.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Staff.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Staff_Execution)
{
_Stop_Edit_Staff_Execution = false;
return;
}
i_Staff.STAFF_ID = _AppContext.Edit_Staff
(
i_Staff.STAFF_ID
,i_Staff.TITLE
,i_Staff.DESCRIPTION
,i_Staff.EMAIL
,i_Staff.PHONE
,i_Staff.ENTRY_USER_ID
,i_Staff.ENTRY_DATE
,i_Staff.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Staff");}
}
public void Edit_Person(Person i_Person) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Person.PERSON_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person");}
#region Body Section.
if ((i_Person.PERSON_ID == null) || (i_Person.PERSON_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Person"); }
i_Person.ENTRY_USER_ID = this.UserID;
i_Person.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Person.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Person_Execution)
{
_Stop_Edit_Person_Execution = false;
return;
}
i_Person.PERSON_ID = _AppContext.Edit_Person
(
i_Person.PERSON_ID
,i_Person.FIRST_NAME
,i_Person.LAST_NAME
,i_Person.FATHER_NAME
,i_Person.MOTHER_NAME
,i_Person.TITLE_CODE
,i_Person.GENDER_CODE
,i_Person.RELIGION_CODE
,i_Person.BIRTH_DATE
,i_Person.IS_BLOCKED
,i_Person.DESCRIPTION
,i_Person.OWNER_ID
,i_Person.ENTRY_USER_ID
,i_Person.ENTRY_DATE
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person");}
}
public void Edit_Tags(Tags i_Tags) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Tags.TAGS_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Tags");}
#region Body Section.
if ((i_Tags.TAGS_ID == null) || (i_Tags.TAGS_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Tags"); }
i_Tags.ENTRY_USER_ID = this.UserID;
i_Tags.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Tags.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Tags_Execution)
{
_Stop_Edit_Tags_Execution = false;
return;
}
i_Tags.TAGS_ID = _AppContext.Edit_Tags
(
i_Tags.TAGS_ID
,i_Tags.TRIP_ID
,i_Tags.TAG
,i_Tags.ENTRY_USER_ID
,i_Tags.ENTRY_DATE
,i_Tags.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Tags");}
}
public void Edit_Social_media_links(Social_media_links i_Social_media_links) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Social_media_links.SOCIAL_MEDIA_LINKS_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Social_media_links");}
#region Body Section.
if ((i_Social_media_links.SOCIAL_MEDIA_LINKS_ID == null) || (i_Social_media_links.SOCIAL_MEDIA_LINKS_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Social_media_links"); }
i_Social_media_links.ENTRY_USER_ID = this.UserID;
i_Social_media_links.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Social_media_links.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Social_media_links_Execution)
{
_Stop_Edit_Social_media_links_Execution = false;
return;
}
i_Social_media_links.SOCIAL_MEDIA_LINKS_ID = _AppContext.Edit_Social_media_links
(
i_Social_media_links.SOCIAL_MEDIA_LINKS_ID
,i_Social_media_links.TITLE
,i_Social_media_links.URL
,i_Social_media_links.ENTRY_USER_ID
,i_Social_media_links.ENTRY_DATE
,i_Social_media_links.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Social_media_links");}
}
public void Edit_Contact(Contact i_Contact) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Contact.CONTACT_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Contact");}
#region Body Section.
if ((i_Contact.CONTACT_ID == null) || (i_Contact.CONTACT_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Contact"); }
i_Contact.ENTRY_USER_ID = this.UserID;
i_Contact.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Contact.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Contact_Execution)
{
_Stop_Edit_Contact_Execution = false;
return;
}
i_Contact.CONTACT_ID = _AppContext.Edit_Contact
(
i_Contact.CONTACT_ID
,i_Contact.PERSON_ID
,i_Contact.CONTACT_TYPE_CODE
,i_Contact.CONTACT
,i_Contact.DESCRIPTION
,i_Contact.ENTRY_USER_ID
,i_Contact.ENTRY_DATE
,i_Contact.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Contact");}
}
public void Edit_Uploaded_file(Uploaded_file i_Uploaded_file) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Uploaded_file.UPLOADED_FILE_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Uploaded_file");}
#region Body Section.
if ((i_Uploaded_file.UPLOADED_FILE_ID == null) || (i_Uploaded_file.UPLOADED_FILE_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Uploaded_file"); }
i_Uploaded_file.ENTRY_USER_ID = this.UserID;
i_Uploaded_file.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Uploaded_file.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Edit_Uploaded_file
if (OnPreEvent_Edit_Uploaded_file != null)
{
OnPreEvent_Edit_Uploaded_file(i_Uploaded_file,oEditMode_Flag);
}
#endregion
if (_Stop_Edit_Uploaded_file_Execution)
{
_Stop_Edit_Uploaded_file_Execution = false;
return;
}
i_Uploaded_file.UPLOADED_FILE_ID = _AppContext.Edit_Uploaded_file
(
i_Uploaded_file.UPLOADED_FILE_ID
,i_Uploaded_file.REL_ENTITY
,i_Uploaded_file.REL_KEY
,i_Uploaded_file.REL_FIELD
,i_Uploaded_file.SIZE
,i_Uploaded_file.EXTENSION
,i_Uploaded_file.STAMP
,i_Uploaded_file.ENTRY_USER_ID
,i_Uploaded_file.ENTRY_DATE
,i_Uploaded_file.OWNER_ID
);
#region PostEvent_Edit_Uploaded_file
if (OnPostEvent_Edit_Uploaded_file != null)
{
OnPostEvent_Edit_Uploaded_file(i_Uploaded_file,oEditMode_Flag);
}
#endregion
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Uploaded_file");}
}
public void Edit_Loc_l1(Loc_l1 i_Loc_l1) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Loc_l1.LOC_L1_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1");}
#region Body Section.
if ((i_Loc_l1.LOC_L1_ID == null) || (i_Loc_l1.LOC_L1_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Loc_l1"); }
i_Loc_l1.ENTRY_USER_ID = this.UserID;
i_Loc_l1.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Loc_l1.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Loc_l1_Execution)
{
_Stop_Edit_Loc_l1_Execution = false;
return;
}
i_Loc_l1.LOC_L1_ID = _AppContext.Edit_Loc_l1
(
i_Loc_l1.LOC_L1_ID
,i_Loc_l1.CODE
,i_Loc_l1.DESCRIPTION
,i_Loc_l1.NOTES
,i_Loc_l1.ENTRY_DATE
,i_Loc_l1.ENTRY_USER_ID
,i_Loc_l1.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1");}
}
public void Edit_Loc_l2(Loc_l2 i_Loc_l2) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Loc_l2.LOC_L2_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2");}
#region Body Section.
if ((i_Loc_l2.LOC_L2_ID == null) || (i_Loc_l2.LOC_L2_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Loc_l2"); }
i_Loc_l2.ENTRY_USER_ID = this.UserID;
i_Loc_l2.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Loc_l2.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Loc_l2_Execution)
{
_Stop_Edit_Loc_l2_Execution = false;
return;
}
i_Loc_l2.LOC_L2_ID = _AppContext.Edit_Loc_l2
(
i_Loc_l2.LOC_L2_ID
,i_Loc_l2.CODE
,i_Loc_l2.DESCRIPTION
,i_Loc_l2.LOC_L1_ID
,i_Loc_l2.NOTES
,i_Loc_l2.ENTRY_DATE
,i_Loc_l2.ENTRY_USER_ID
,i_Loc_l2.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2");}
}
public void Edit_Reservation_query_List(List<Reservation_query> i_List_Reservation_query)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Reservation_query_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Reservation_query != null)
{
foreach (var oRow in i_List_Reservation_query)
{
Edit_Reservation_query(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Reservation_query_List");}
}
public void Edit_Reservation_query_List(Params_Edit_Reservation_query_List i_Params_Edit_Reservation_query_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Reservation_query_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Reservation_query_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Reservation_query_List.My_List_To_Delete)
{
Delete_Reservation_query(new Params_Delete_Reservation_query() { RESERVATION_QUERY_ID = oRow.RESERVATION_QUERY_ID });
}
}
if (i_Params_Edit_Reservation_query_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Reservation_query_List.My_List_To_Edit)
{
Edit_Reservation_query(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Reservation_query_List");}
}
public void Edit_Loc_l3_List(List<Loc_l3> i_List_Loc_l3)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Loc_l3 != null)
{
foreach (var oRow in i_List_Loc_l3)
{
Edit_Loc_l3(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3_List");}
}
public void Edit_Loc_l3_List(Params_Edit_Loc_l3_List i_Params_Edit_Loc_l3_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Loc_l3_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Loc_l3_List.My_List_To_Delete)
{
Delete_Loc_l3(new Params_Delete_Loc_l3() { LOC_L3_ID = oRow.LOC_L3_ID });
}
}
if (i_Params_Edit_Loc_l3_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Loc_l3_List.My_List_To_Edit)
{
Edit_Loc_l3(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3_List");}
}
public void Edit_Review_List(List<Review> i_List_Review)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Review_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Review != null)
{
foreach (var oRow in i_List_Review)
{
Edit_Review(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Review_List");}
}
public void Edit_Review_List(Params_Edit_Review_List i_Params_Edit_Review_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Review_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Review_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Review_List.My_List_To_Delete)
{
Delete_Review(new Params_Delete_Review() { REVIEW_ID = oRow.REVIEW_ID });
}
}
if (i_Params_Edit_Review_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Review_List.My_List_To_Edit)
{
Edit_Review(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Review_List");}
}
public void Edit_Trip_List(List<Trip> i_List_Trip)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Trip_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Trip != null)
{
foreach (var oRow in i_List_Trip)
{
Edit_Trip(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Trip_List");}
}
public void Edit_Trip_List(Params_Edit_Trip_List i_Params_Edit_Trip_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Trip_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Trip_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Trip_List.My_List_To_Delete)
{
Delete_Trip(new Params_Delete_Trip() { TRIP_ID = oRow.TRIP_ID });
}
}
if (i_Params_Edit_Trip_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Trip_List.My_List_To_Edit)
{
Edit_Trip(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Trip_List");}
}
public void Edit_Loc_l4_List(List<Loc_l4> i_List_Loc_l4)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l4_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Loc_l4 != null)
{
foreach (var oRow in i_List_Loc_l4)
{
Edit_Loc_l4(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l4_List");}
}
public void Edit_Loc_l4_List(Params_Edit_Loc_l4_List i_Params_Edit_Loc_l4_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l4_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Loc_l4_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Loc_l4_List.My_List_To_Delete)
{
Delete_Loc_l4(new Params_Delete_Loc_l4() { LOC_L4_ID = oRow.LOC_L4_ID });
}
}
if (i_Params_Edit_Loc_l4_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Loc_l4_List.My_List_To_Edit)
{
Edit_Loc_l4(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l4_List");}
}
public void Edit_Address_List(List<Address> i_List_Address)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Address_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Address != null)
{
foreach (var oRow in i_List_Address)
{
Edit_Address(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Address_List");}
}
public void Edit_Address_List(Params_Edit_Address_List i_Params_Edit_Address_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Address_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Address_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Address_List.My_List_To_Delete)
{
Delete_Address(new Params_Delete_Address() { ADDRESS_ID = oRow.ADDRESS_ID });
}
}
if (i_Params_Edit_Address_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Address_List.My_List_To_Edit)
{
Edit_Address(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Address_List");}
}
public void Edit_Owner_List(List<Owner> i_List_Owner)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Owner != null)
{
foreach (var oRow in i_List_Owner)
{
Edit_Owner(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner_List");}
}
public void Edit_Owner_List(Params_Edit_Owner_List i_Params_Edit_Owner_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Owner_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Owner_List.My_List_To_Delete)
{
Delete_Owner(new Params_Delete_Owner() { OWNER_ID = oRow.OWNER_ID });
}
}
if (i_Params_Edit_Owner_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Owner_List.My_List_To_Edit)
{
Edit_Owner(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner_List");}
}
public void Edit_Features_List(List<Features> i_List_Features)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Features_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Features != null)
{
foreach (var oRow in i_List_Features)
{
Edit_Features(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Features_List");}
}
public void Edit_Features_List(Params_Edit_Features_List i_Params_Edit_Features_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Features_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Features_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Features_List.My_List_To_Delete)
{
Delete_Features(new Params_Delete_Features() { FEATURES_ID = oRow.FEATURES_ID });
}
}
if (i_Params_Edit_Features_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Features_List.My_List_To_Edit)
{
Edit_Features(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Features_List");}
}
public void Edit_User_List(List<User> i_List_User)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_User != null)
{
foreach (var oRow in i_List_User)
{
Edit_User(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_List");}
}
public void Edit_User_List(Params_Edit_User_List i_Params_Edit_User_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_User_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_User_List.My_List_To_Delete)
{
Delete_User(new Params_Delete_User() { USER_ID = oRow.USER_ID });
}
}
if (i_Params_Edit_User_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_User_List.My_List_To_Edit)
{
Edit_User(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_List");}
}
public void Edit_Includes_List(List<Includes> i_List_Includes)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Includes_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Includes != null)
{
foreach (var oRow in i_List_Includes)
{
Edit_Includes(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Includes_List");}
}
public void Edit_Includes_List(Params_Edit_Includes_List i_Params_Edit_Includes_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Includes_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Includes_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Includes_List.My_List_To_Delete)
{
Delete_Includes(new Params_Delete_Includes() { INCLUDES_ID = oRow.INCLUDES_ID });
}
}
if (i_Params_Edit_Includes_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Includes_List.My_List_To_Edit)
{
Edit_Includes(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Includes_List");}
}
public void Edit_Staff_List(List<Staff> i_List_Staff)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Staff_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Staff != null)
{
foreach (var oRow in i_List_Staff)
{
Edit_Staff(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Staff_List");}
}
public void Edit_Staff_List(Params_Edit_Staff_List i_Params_Edit_Staff_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Staff_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Staff_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Staff_List.My_List_To_Delete)
{
Delete_Staff(new Params_Delete_Staff() { STAFF_ID = oRow.STAFF_ID });
}
}
if (i_Params_Edit_Staff_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Staff_List.My_List_To_Edit)
{
Edit_Staff(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Staff_List");}
}
public void Edit_Person_List(List<Person> i_List_Person)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Person != null)
{
foreach (var oRow in i_List_Person)
{
Edit_Person(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person_List");}
}
public void Edit_Person_List(Params_Edit_Person_List i_Params_Edit_Person_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Person_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Person_List.My_List_To_Delete)
{
Delete_Person(new Params_Delete_Person() { PERSON_ID = oRow.PERSON_ID });
}
}
if (i_Params_Edit_Person_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Person_List.My_List_To_Edit)
{
Edit_Person(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person_List");}
}
public void Edit_Tags_List(List<Tags> i_List_Tags)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Tags_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Tags != null)
{
foreach (var oRow in i_List_Tags)
{
Edit_Tags(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Tags_List");}
}
public void Edit_Tags_List(Params_Edit_Tags_List i_Params_Edit_Tags_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Tags_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Tags_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Tags_List.My_List_To_Delete)
{
Delete_Tags(new Params_Delete_Tags() { TAGS_ID = oRow.TAGS_ID });
}
}
if (i_Params_Edit_Tags_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Tags_List.My_List_To_Edit)
{
Edit_Tags(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Tags_List");}
}
public void Edit_Social_media_links_List(List<Social_media_links> i_List_Social_media_links)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Social_media_links_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Social_media_links != null)
{
foreach (var oRow in i_List_Social_media_links)
{
Edit_Social_media_links(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Social_media_links_List");}
}
public void Edit_Social_media_links_List(Params_Edit_Social_media_links_List i_Params_Edit_Social_media_links_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Social_media_links_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Social_media_links_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Social_media_links_List.My_List_To_Delete)
{
Delete_Social_media_links(new Params_Delete_Social_media_links() { SOCIAL_MEDIA_LINKS_ID = oRow.SOCIAL_MEDIA_LINKS_ID });
}
}
if (i_Params_Edit_Social_media_links_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Social_media_links_List.My_List_To_Edit)
{
Edit_Social_media_links(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Social_media_links_List");}
}
public void Edit_Contact_List(List<Contact> i_List_Contact)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Contact_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Contact != null)
{
foreach (var oRow in i_List_Contact)
{
Edit_Contact(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Contact_List");}
}
public void Edit_Contact_List(Params_Edit_Contact_List i_Params_Edit_Contact_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Contact_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Contact_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Contact_List.My_List_To_Delete)
{
Delete_Contact(new Params_Delete_Contact() { CONTACT_ID = oRow.CONTACT_ID });
}
}
if (i_Params_Edit_Contact_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Contact_List.My_List_To_Edit)
{
Edit_Contact(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Contact_List");}
}
public void Edit_Uploaded_file_List(List<Uploaded_file> i_List_Uploaded_file)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Uploaded_file_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Uploaded_file != null)
{
foreach (var oRow in i_List_Uploaded_file)
{
Edit_Uploaded_file(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Uploaded_file_List");}
}
public void Edit_Uploaded_file_List(Params_Edit_Uploaded_file_List i_Params_Edit_Uploaded_file_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Uploaded_file_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Uploaded_file_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Uploaded_file_List.My_List_To_Delete)
{
Delete_Uploaded_file(new Params_Delete_Uploaded_file() { UPLOADED_FILE_ID = oRow.UPLOADED_FILE_ID });
}
}
if (i_Params_Edit_Uploaded_file_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Uploaded_file_List.My_List_To_Edit)
{
Edit_Uploaded_file(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Uploaded_file_List");}
}
public void Edit_Loc_l1_List(List<Loc_l1> i_List_Loc_l1)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Loc_l1 != null)
{
foreach (var oRow in i_List_Loc_l1)
{
Edit_Loc_l1(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1_List");}
}
public void Edit_Loc_l1_List(Params_Edit_Loc_l1_List i_Params_Edit_Loc_l1_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Loc_l1_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Loc_l1_List.My_List_To_Delete)
{
Delete_Loc_l1(new Params_Delete_Loc_l1() { LOC_L1_ID = oRow.LOC_L1_ID });
}
}
if (i_Params_Edit_Loc_l1_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Loc_l1_List.My_List_To_Edit)
{
Edit_Loc_l1(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1_List");}
}
public void Edit_Loc_l2_List(List<Loc_l2> i_List_Loc_l2)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Loc_l2 != null)
{
foreach (var oRow in i_List_Loc_l2)
{
Edit_Loc_l2(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2_List");}
}
public void Edit_Loc_l2_List(Params_Edit_Loc_l2_List i_Params_Edit_Loc_l2_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Loc_l2_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Loc_l2_List.My_List_To_Delete)
{
Delete_Loc_l2(new Params_Delete_Loc_l2() { LOC_L2_ID = oRow.LOC_L2_ID });
}
}
if (i_Params_Edit_Loc_l2_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Loc_l2_List.My_List_To_Edit)
{
Edit_Loc_l2(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2_List");}
}
}
}
