using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Dynamic;
namespace DALC
{
public partial class MSSQL_DALC : IDALC
{
public Address Get_Address_By_ADDRESS_ID ( long? ADDRESS_ID)
{
Address o = new Address();
dynamic p = new ExpandoObject();
p.ADDRESS_ID = ADDRESS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_ADDRESS_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Contact Get_Contact_By_CONTACT_ID ( Int32? CONTACT_ID)
{
Contact o = new Contact();
dynamic p = new ExpandoObject();
p.CONTACT_ID = CONTACT_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CONTACT_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Features Get_Features_By_FEATURES_ID ( Int32? FEATURES_ID)
{
Features o = new Features();
dynamic p = new ExpandoObject();
p.FEATURES_ID = FEATURES_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_FEATURES_BY_FEATURES_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Includes Get_Includes_By_INCLUDES_ID ( Int32? INCLUDES_ID)
{
Includes o = new Includes();
dynamic p = new ExpandoObject();
p.INCLUDES_ID = INCLUDES_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_INCLUDES_BY_INCLUDES_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Loc_l1 Get_Loc_l1_By_LOC_L1_ID ( long? LOC_L1_ID)
{
Loc_l1 o = new Loc_l1();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_LOC_L1_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Loc_l2 Get_Loc_l2_By_LOC_L2_ID ( long? LOC_L2_ID)
{
Loc_l2 o = new Loc_l2();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L2_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Loc_l3 Get_Loc_l3_By_LOC_L3_ID ( long? LOC_L3_ID)
{
Loc_l3 o = new Loc_l3();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L3_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Loc_l4 Get_Loc_l4_By_LOC_L4_ID ( long? LOC_L4_ID)
{
Loc_l4 o = new Loc_l4();
dynamic p = new ExpandoObject();
p.LOC_L4_ID = LOC_L4_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L4_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Owner Get_Owner_By_OWNER_ID ( Int32? OWNER_ID)
{
Owner o = new Owner();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_OWNER_BY_OWNER_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Person Get_Person_By_PERSON_ID ( long? PERSON_ID)
{
Person o = new Person();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_PERSON_BY_PERSON_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Reservation_query Get_Reservation_query_By_RESERVATION_QUERY_ID ( long? RESERVATION_QUERY_ID)
{
Reservation_query o = new Reservation_query();
dynamic p = new ExpandoObject();
p.RESERVATION_QUERY_ID = RESERVATION_QUERY_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_RESERVATION_QUERY_BY_RESERVATION_QUERY_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Review Get_Review_By_REVIEW_ID ( Int32? REVIEW_ID)
{
Review o = new Review();
dynamic p = new ExpandoObject();
p.REVIEW_ID = REVIEW_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_REVIEW_BY_REVIEW_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Social_media_links Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID ( Int32? SOCIAL_MEDIA_LINKS_ID)
{
Social_media_links o = new Social_media_links();
dynamic p = new ExpandoObject();
p.SOCIAL_MEDIA_LINKS_ID = SOCIAL_MEDIA_LINKS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_SOCIAL_MEDIA_LINKS_BY_SOCIAL_MEDIA_LINKS_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Staff Get_Staff_By_STAFF_ID ( Int32? STAFF_ID)
{
Staff o = new Staff();
dynamic p = new ExpandoObject();
p.STAFF_ID = STAFF_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_STAFF_BY_STAFF_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Tags Get_Tags_By_TAGS_ID ( long? TAGS_ID)
{
Tags o = new Tags();
dynamic p = new ExpandoObject();
p.TAGS_ID = TAGS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_TAGS_BY_TAGS_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Trip Get_Trip_By_TRIP_ID ( Int32? TRIP_ID)
{
Trip o = new Trip();
dynamic p = new ExpandoObject();
p.TRIP_ID = TRIP_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_TRIP_BY_TRIP_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public User Get_User_By_USER_ID ( long? USER_ID)
{
User o = new User();
dynamic p = new ExpandoObject();
p.USER_ID = USER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Address Get_Address_By_ADDRESS_ID_Adv ( long? ADDRESS_ID)
{
Address o = new Address();
dynamic p = new ExpandoObject();
p.ADDRESS_ID = ADDRESS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_ADDRESS_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(R["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(R["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(R["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(R["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(R["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(R["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(R["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(R["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(R["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(R["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(R["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(R["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(R["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(R["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(R["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(R["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(R["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(R["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(R["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(R["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(R["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(R["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(R["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(R["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(R["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(R["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(R["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(R["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(R["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(R["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(R["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(R["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(R["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(R["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(R["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(R["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(R["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(R["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(R["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(R["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(R["T_LOC_L4_OWNER_ID"]);
}
return o;
}
public Contact Get_Contact_By_CONTACT_ID_Adv ( Int32? CONTACT_ID)
{
Contact o = new Contact();
dynamic p = new ExpandoObject();
p.CONTACT_ID = CONTACT_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CONTACT_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(R["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(R["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(R["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(R["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(R["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(R["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(R["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(R["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(R["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(R["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(R["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(R["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(R["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(R["T_PERSON_ENTRY_DATE"]);
}
return o;
}
public Features Get_Features_By_FEATURES_ID_Adv ( Int32? FEATURES_ID)
{
Features o = new Features();
dynamic p = new ExpandoObject();
p.FEATURES_ID = FEATURES_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_FEATURES_BY_FEATURES_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(R["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(R["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(R["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(R["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(R["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(R["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(R["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(R["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(R["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(R["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(R["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(R["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(R["T_TRIP_OWNER_ID"]);
}
return o;
}
public Includes Get_Includes_By_INCLUDES_ID_Adv ( Int32? INCLUDES_ID)
{
Includes o = new Includes();
dynamic p = new ExpandoObject();
p.INCLUDES_ID = INCLUDES_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_INCLUDES_BY_INCLUDES_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(R["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(R["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(R["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(R["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(R["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(R["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(R["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(R["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(R["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(R["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(R["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(R["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(R["T_TRIP_OWNER_ID"]);
}
return o;
}
public Loc_l1 Get_Loc_l1_By_LOC_L1_ID_Adv ( long? LOC_L1_ID)
{
Loc_l1 o = new Loc_l1();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_LOC_L1_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Loc_l2 Get_Loc_l2_By_LOC_L2_ID_Adv ( long? LOC_L2_ID)
{
Loc_l2 o = new Loc_l2();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L2_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(R["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(R["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(R["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(R["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(R["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(R["T_LOC_L1_OWNER_ID"]);
}
return o;
}
public Loc_l3 Get_Loc_l3_By_LOC_L3_ID_Adv ( long? LOC_L3_ID)
{
Loc_l3 o = new Loc_l3();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L3_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(R["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(R["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(R["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(R["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(R["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(R["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(R["T_LOC_L2_OWNER_ID"]);
}
return o;
}
public Loc_l4 Get_Loc_l4_By_LOC_L4_ID_Adv ( long? LOC_L4_ID)
{
Loc_l4 o = new Loc_l4();
dynamic p = new ExpandoObject();
p.LOC_L4_ID = LOC_L4_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L4_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(R["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(R["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(R["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(R["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(R["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(R["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(R["T_LOC_L3_OWNER_ID"]);
}
return o;
}
public Person Get_Person_By_PERSON_ID_Adv ( long? PERSON_ID)
{
Person o = new Person();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_PERSON_BY_PERSON_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Reservation_query Get_Reservation_query_By_RESERVATION_QUERY_ID_Adv ( long? RESERVATION_QUERY_ID)
{
Reservation_query o = new Reservation_query();
dynamic p = new ExpandoObject();
p.RESERVATION_QUERY_ID = RESERVATION_QUERY_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_RESERVATION_QUERY_BY_RESERVATION_QUERY_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Review Get_Review_By_REVIEW_ID_Adv ( Int32? REVIEW_ID)
{
Review o = new Review();
dynamic p = new ExpandoObject();
p.REVIEW_ID = REVIEW_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_REVIEW_BY_REVIEW_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Social_media_links Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID_Adv ( Int32? SOCIAL_MEDIA_LINKS_ID)
{
Social_media_links o = new Social_media_links();
dynamic p = new ExpandoObject();
p.SOCIAL_MEDIA_LINKS_ID = SOCIAL_MEDIA_LINKS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_SOCIAL_MEDIA_LINKS_BY_SOCIAL_MEDIA_LINKS_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Staff Get_Staff_By_STAFF_ID_Adv ( Int32? STAFF_ID)
{
Staff o = new Staff();
dynamic p = new ExpandoObject();
p.STAFF_ID = STAFF_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_STAFF_BY_STAFF_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Tags Get_Tags_By_TAGS_ID_Adv ( long? TAGS_ID)
{
Tags o = new Tags();
dynamic p = new ExpandoObject();
p.TAGS_ID = TAGS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_TAGS_BY_TAGS_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(R["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(R["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(R["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(R["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(R["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(R["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(R["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(R["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(R["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(R["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(R["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(R["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(R["T_TRIP_OWNER_ID"]);
}
return o;
}
public Trip Get_Trip_By_TRIP_ID_Adv ( Int32? TRIP_ID)
{
Trip o = new Trip();
dynamic p = new ExpandoObject();
p.TRIP_ID = TRIP_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_TRIP_BY_TRIP_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public User Get_User_By_USER_ID_Adv ( long? USER_ID)
{
User o = new User();
dynamic p = new ExpandoObject();
p.USER_ID = USER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public List<Address> Get_Address_By_ADDRESS_ID_List ( List<long?> ADDRESS_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_ID_LIST = string.Join(",", ADDRESS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_ADDRESS_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_CONTACT_ID_List ( List<Int32?> CONTACT_ID_LIST)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_ID_LIST = string.Join(",", CONTACT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CONTACT_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Features> Get_Features_By_FEATURES_ID_List ( List<Int32?> FEATURES_ID_LIST)
{
List<Features> oList = new List<Features>();
dynamic p = new ExpandoObject();
p.FEATURES_ID_LIST = string.Join(",", FEATURES_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEATURES_BY_FEATURES_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Features o = new Features();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Includes> Get_Includes_By_INCLUDES_ID_List ( List<Int32?> INCLUDES_ID_LIST)
{
List<Includes> oList = new List<Includes>();
dynamic p = new ExpandoObject();
p.INCLUDES_ID_LIST = string.Join(",", INCLUDES_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INCLUDES_BY_INCLUDES_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Includes o = new Includes();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_LOC_L1_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L2_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L3_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List ( List<long?> LOC_L4_ID_LIST)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L4_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Owner> Get_Owner_By_OWNER_ID_List ( List<Int32?> OWNER_ID_LIST)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.OWNER_ID_LIST = string.Join(",", OWNER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_OWNER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Person> Get_Person_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_PERSON_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Reservation_query> Get_Reservation_query_By_RESERVATION_QUERY_ID_List ( List<long?> RESERVATION_QUERY_ID_LIST)
{
List<Reservation_query> oList = new List<Reservation_query>();
dynamic p = new ExpandoObject();
p.RESERVATION_QUERY_ID_LIST = string.Join(",", RESERVATION_QUERY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_RESERVATION_QUERY_BY_RESERVATION_QUERY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Reservation_query o = new Reservation_query();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Review> Get_Review_By_REVIEW_ID_List ( List<Int32?> REVIEW_ID_LIST)
{
List<Review> oList = new List<Review>();
dynamic p = new ExpandoObject();
p.REVIEW_ID_LIST = string.Join(",", REVIEW_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REVIEW_BY_REVIEW_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Review o = new Review();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Social_media_links> Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID_List ( List<Int32?> SOCIAL_MEDIA_LINKS_ID_LIST)
{
List<Social_media_links> oList = new List<Social_media_links>();
dynamic p = new ExpandoObject();
p.SOCIAL_MEDIA_LINKS_ID_LIST = string.Join(",", SOCIAL_MEDIA_LINKS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SOCIAL_MEDIA_LINKS_BY_SOCIAL_MEDIA_LINKS_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Social_media_links o = new Social_media_links();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Staff> Get_Staff_By_STAFF_ID_List ( List<Int32?> STAFF_ID_LIST)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_STAFF_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Tags> Get_Tags_By_TAGS_ID_List ( List<long?> TAGS_ID_LIST)
{
List<Tags> oList = new List<Tags>();
dynamic p = new ExpandoObject();
p.TAGS_ID_LIST = string.Join(",", TAGS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TAGS_BY_TAGS_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Tags o = new Tags();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Trip> Get_Trip_By_TRIP_ID_List ( List<Int32?> TRIP_ID_LIST)
{
List<Trip> oList = new List<Trip>();
dynamic p = new ExpandoObject();
p.TRIP_ID_LIST = string.Join(",", TRIP_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TRIP_BY_TRIP_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Trip o = new Trip();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USER_ID_List ( List<long?> USER_ID_LIST)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_ADDRESS_ID_List_Adv ( List<long?> ADDRESS_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_ID_LIST = string.Join(",", ADDRESS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_ADDRESS_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_CONTACT_ID_List_Adv ( List<Int32?> CONTACT_ID_LIST)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_ID_LIST = string.Join(",", CONTACT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CONTACT_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Features> Get_Features_By_FEATURES_ID_List_Adv ( List<Int32?> FEATURES_ID_LIST)
{
List<Features> oList = new List<Features>();
dynamic p = new ExpandoObject();
p.FEATURES_ID_LIST = string.Join(",", FEATURES_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEATURES_BY_FEATURES_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Features o = new Features();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(X["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(X["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(X["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(X["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(X["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(X["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(X["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(X["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(X["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(X["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(X["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(X["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(X["T_TRIP_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Includes> Get_Includes_By_INCLUDES_ID_List_Adv ( List<Int32?> INCLUDES_ID_LIST)
{
List<Includes> oList = new List<Includes>();
dynamic p = new ExpandoObject();
p.INCLUDES_ID_LIST = string.Join(",", INCLUDES_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INCLUDES_BY_INCLUDES_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Includes o = new Includes();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(X["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(X["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(X["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(X["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(X["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(X["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(X["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(X["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(X["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(X["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(X["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(X["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(X["T_TRIP_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_LOC_L1_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L2_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L3_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List_Adv ( List<long?> LOC_L4_ID_LIST)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L4_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Person> Get_Person_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_PERSON_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Reservation_query> Get_Reservation_query_By_RESERVATION_QUERY_ID_List_Adv ( List<long?> RESERVATION_QUERY_ID_LIST)
{
List<Reservation_query> oList = new List<Reservation_query>();
dynamic p = new ExpandoObject();
p.RESERVATION_QUERY_ID_LIST = string.Join(",", RESERVATION_QUERY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_RESERVATION_QUERY_BY_RESERVATION_QUERY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Reservation_query o = new Reservation_query();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Review> Get_Review_By_REVIEW_ID_List_Adv ( List<Int32?> REVIEW_ID_LIST)
{
List<Review> oList = new List<Review>();
dynamic p = new ExpandoObject();
p.REVIEW_ID_LIST = string.Join(",", REVIEW_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REVIEW_BY_REVIEW_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Review o = new Review();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Social_media_links> Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID_List_Adv ( List<Int32?> SOCIAL_MEDIA_LINKS_ID_LIST)
{
List<Social_media_links> oList = new List<Social_media_links>();
dynamic p = new ExpandoObject();
p.SOCIAL_MEDIA_LINKS_ID_LIST = string.Join(",", SOCIAL_MEDIA_LINKS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SOCIAL_MEDIA_LINKS_BY_SOCIAL_MEDIA_LINKS_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Social_media_links o = new Social_media_links();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Staff> Get_Staff_By_STAFF_ID_List_Adv ( List<Int32?> STAFF_ID_LIST)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_STAFF_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Tags> Get_Tags_By_TAGS_ID_List_Adv ( List<long?> TAGS_ID_LIST)
{
List<Tags> oList = new List<Tags>();
dynamic p = new ExpandoObject();
p.TAGS_ID_LIST = string.Join(",", TAGS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TAGS_BY_TAGS_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Tags o = new Tags();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(X["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(X["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(X["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(X["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(X["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(X["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(X["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(X["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(X["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(X["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(X["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(X["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(X["T_TRIP_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Trip> Get_Trip_By_TRIP_ID_List_Adv ( List<Int32?> TRIP_ID_LIST)
{
List<Trip> oList = new List<Trip>();
dynamic p = new ExpandoObject();
p.TRIP_ID_LIST = string.Join(",", TRIP_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TRIP_BY_TRIP_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Trip o = new Trip();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID ( long? PERSON_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID ( long? LOC_L1_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L1_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID ( long? LOC_L2_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L2_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID ( long? LOC_L3_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L3_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE ( long? PERSON_ID, string ADDRESS_TYPE_CODE)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID; p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID_ADDRESS_TYPE_CODE", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID ( long? LOC_L4_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID = LOC_L4_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L4_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID ( long? PERSON_ID)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID; p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID_CONTACT_TYPE_CODE_CONTACT", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Features> Get_Features_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Features> oList = new List<Features>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEATURES_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Features o = new Features();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Features> Get_Features_By_TRIP_ID ( Int32? TRIP_ID)
{
List<Features> oList = new List<Features>();
dynamic p = new ExpandoObject();
p.TRIP_ID = TRIP_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEATURES_BY_TRIP_ID", p);
if (R != null) {foreach (var X in R) {
Features o = new Features();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Includes> Get_Includes_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Includes> oList = new List<Includes>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INCLUDES_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Includes o = new Includes();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Includes> Get_Includes_By_TRIP_ID ( Int32? TRIP_ID)
{
List<Includes> oList = new List<Includes>();
dynamic p = new ExpandoObject();
p.TRIP_ID = TRIP_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INCLUDES_BY_TRIP_ID", p);
if (R != null) {foreach (var X in R) {
Includes o = new Includes();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_CODE ( string CODE)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_CODE", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE ( long? LOC_L1_ID, string CODE)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID_CODE", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID ( long? LOC_L1_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE ( long? LOC_L2_ID, string CODE)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID_CODE", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID ( long? LOC_L2_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE ( long? LOC_L3_ID, string CODE)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID_CODE", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID ( long? LOC_L3_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Person> Get_Person_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Reservation_query> Get_Reservation_query_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Reservation_query> oList = new List<Reservation_query>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_RESERVATION_QUERY_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Reservation_query o = new Reservation_query();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Review> Get_Review_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Review> oList = new List<Review>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REVIEW_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Review o = new Review();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Social_media_links> Get_Social_media_links_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Social_media_links> oList = new List<Social_media_links>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SOCIAL_MEDIA_LINKS_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Social_media_links o = new Social_media_links();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Staff> Get_Staff_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Tags> Get_Tags_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Tags> oList = new List<Tags>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TAGS_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Tags o = new Tags();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Tags> Get_Tags_By_TRIP_ID ( Int32? TRIP_ID)
{
List<Tags> oList = new List<Tags>();
dynamic p = new ExpandoObject();
p.TRIP_ID = TRIP_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TAGS_BY_TRIP_ID", p);
if (R != null) {foreach (var X in R) {
Tags o = new Tags();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Trip> Get_Trip_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Trip> oList = new List<Trip>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TRIP_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Trip o = new Trip();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_OWNER_ID ( Int32? OWNER_ID)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USERNAME ( string USERNAME)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USERNAME", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_Adv ( long? PERSON_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_Adv ( long? LOC_L1_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L1_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_Adv ( long? LOC_L2_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L2_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_Adv ( long? LOC_L3_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L3_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv ( long? PERSON_ID, string ADDRESS_TYPE_CODE)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID; p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID_ADDRESS_TYPE_CODE_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_Adv ( long? LOC_L4_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID = LOC_L4_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L4_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_Adv ( long? PERSON_ID)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID; p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Features> Get_Features_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Features> oList = new List<Features>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEATURES_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Features o = new Features();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(X["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(X["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(X["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(X["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(X["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(X["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(X["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(X["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(X["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(X["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(X["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(X["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(X["T_TRIP_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Features> Get_Features_By_TRIP_ID_Adv ( Int32? TRIP_ID)
{
List<Features> oList = new List<Features>();
dynamic p = new ExpandoObject();
p.TRIP_ID = TRIP_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEATURES_BY_TRIP_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Features o = new Features();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(X["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(X["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(X["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(X["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(X["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(X["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(X["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(X["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(X["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(X["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(X["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(X["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(X["T_TRIP_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Includes> Get_Includes_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Includes> oList = new List<Includes>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INCLUDES_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Includes o = new Includes();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(X["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(X["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(X["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(X["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(X["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(X["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(X["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(X["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(X["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(X["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(X["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(X["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(X["T_TRIP_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Includes> Get_Includes_By_TRIP_ID_Adv ( Int32? TRIP_ID)
{
List<Includes> oList = new List<Includes>();
dynamic p = new ExpandoObject();
p.TRIP_ID = TRIP_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INCLUDES_BY_TRIP_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Includes o = new Includes();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(X["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(X["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(X["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(X["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(X["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(X["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(X["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(X["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(X["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(X["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(X["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(X["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(X["T_TRIP_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_CODE_Adv ( string CODE)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_CODE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE_Adv ( long? LOC_L1_ID, string CODE)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID_CODE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_Adv ( long? LOC_L1_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE_Adv ( long? LOC_L2_ID, string CODE)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID_CODE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_Adv ( long? LOC_L2_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE_Adv ( long? LOC_L3_ID, string CODE)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID_CODE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_Adv ( long? LOC_L3_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Person> Get_Person_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Reservation_query> Get_Reservation_query_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Reservation_query> oList = new List<Reservation_query>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_RESERVATION_QUERY_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Reservation_query o = new Reservation_query();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Review> Get_Review_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Review> oList = new List<Review>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REVIEW_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Review o = new Review();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Social_media_links> Get_Social_media_links_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Social_media_links> oList = new List<Social_media_links>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SOCIAL_MEDIA_LINKS_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Social_media_links o = new Social_media_links();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Staff> Get_Staff_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Tags> Get_Tags_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Tags> oList = new List<Tags>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TAGS_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Tags o = new Tags();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(X["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(X["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(X["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(X["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(X["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(X["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(X["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(X["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(X["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(X["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(X["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(X["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(X["T_TRIP_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Tags> Get_Tags_By_TRIP_ID_Adv ( Int32? TRIP_ID)
{
List<Tags> oList = new List<Tags>();
dynamic p = new ExpandoObject();
p.TRIP_ID = TRIP_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TAGS_BY_TRIP_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Tags o = new Tags();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(X["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(X["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(X["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(X["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(X["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(X["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(X["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(X["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(X["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(X["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(X["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(X["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(X["T_TRIP_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Trip> Get_Trip_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Trip> oList = new List<Trip>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TRIP_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Trip o = new Trip();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USERNAME_Adv ( string USERNAME)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USERNAME_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L1_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L2_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L3_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_List ( List<long?> LOC_L4_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L4_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Features> Get_Features_By_TRIP_ID_List ( List<Int32?> TRIP_ID_LIST)
{
List<Features> oList = new List<Features>();
dynamic p = new ExpandoObject();
p.TRIP_ID_LIST = string.Join(",", TRIP_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEATURES_BY_TRIP_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Features o = new Features();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Includes> Get_Includes_By_TRIP_ID_List ( List<Int32?> TRIP_ID_LIST)
{
List<Includes> oList = new List<Includes>();
dynamic p = new ExpandoObject();
p.TRIP_ID_LIST = string.Join(",", TRIP_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INCLUDES_BY_TRIP_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Includes o = new Includes();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Tags> Get_Tags_By_TRIP_ID_List ( List<Int32?> TRIP_ID_LIST)
{
List<Tags> oList = new List<Tags>();
dynamic p = new ExpandoObject();
p.TRIP_ID_LIST = string.Join(",", TRIP_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TAGS_BY_TRIP_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Tags o = new Tags();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L1_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L2_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L3_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_List_Adv ( List<long?> LOC_L4_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L4_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Features> Get_Features_By_TRIP_ID_List_Adv ( List<Int32?> TRIP_ID_LIST)
{
List<Features> oList = new List<Features>();
dynamic p = new ExpandoObject();
p.TRIP_ID_LIST = string.Join(",", TRIP_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEATURES_BY_TRIP_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Features o = new Features();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(X["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(X["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(X["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(X["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(X["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(X["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(X["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(X["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(X["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(X["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(X["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(X["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(X["T_TRIP_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Includes> Get_Includes_By_TRIP_ID_List_Adv ( List<Int32?> TRIP_ID_LIST)
{
List<Includes> oList = new List<Includes>();
dynamic p = new ExpandoObject();
p.TRIP_ID_LIST = string.Join(",", TRIP_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INCLUDES_BY_TRIP_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Includes o = new Includes();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(X["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(X["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(X["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(X["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(X["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(X["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(X["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(X["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(X["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(X["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(X["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(X["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(X["T_TRIP_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Tags> Get_Tags_By_TRIP_ID_List_Adv ( List<Int32?> TRIP_ID_LIST)
{
List<Tags> oList = new List<Tags>();
dynamic p = new ExpandoObject();
p.TRIP_ID_LIST = string.Join(",", TRIP_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TAGS_BY_TRIP_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Tags o = new Tags();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(X["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(X["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(X["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(X["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(X["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(X["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(X["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(X["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(X["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(X["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(X["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(X["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(X["T_TRIP_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_Criteria ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Criteria ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Where ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Features> Get_Features_By_Criteria ( string TITLE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Features> oList = new List<Features>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEATURES_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Features o = new Features();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Features> Get_Features_By_Where ( string TITLE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Features> oList = new List<Features>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEATURES_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Features o = new Features();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Includes> Get_Includes_By_Criteria ( string TITLE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Includes> oList = new List<Includes>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INCLUDES_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Includes o = new Includes();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Includes> Get_Includes_By_Where ( string TITLE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Includes> oList = new List<Includes>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INCLUDES_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Includes o = new Includes();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Criteria_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Where_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Criteria ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Where ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Criteria_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.BIRTH_DATE = BIRTH_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Where_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.BIRTH_DATE = BIRTH_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Reservation_query> Get_Reservation_query_By_Criteria ( string PICK_UP_ADDRESS, string TRIP_DATE, string QUERY_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Reservation_query> oList = new List<Reservation_query>();
dynamic p = new ExpandoObject();
p.PICK_UP_ADDRESS = PICK_UP_ADDRESS; p.TRIP_DATE = TRIP_DATE; p.QUERY_DESCRIPTION = QUERY_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_RESERVATION_QUERY_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Reservation_query o = new Reservation_query();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Reservation_query> Get_Reservation_query_By_Where ( string PICK_UP_ADDRESS, string TRIP_DATE, string QUERY_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Reservation_query> oList = new List<Reservation_query>();
dynamic p = new ExpandoObject();
p.PICK_UP_ADDRESS = PICK_UP_ADDRESS; p.TRIP_DATE = TRIP_DATE; p.QUERY_DESCRIPTION = QUERY_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_RESERVATION_QUERY_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Reservation_query o = new Reservation_query();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Review> Get_Review_By_Criteria ( string TITLE, string REVIEW_TEXT, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Review> oList = new List<Review>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.REVIEW_TEXT = REVIEW_TEXT; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REVIEW_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Review o = new Review();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Review> Get_Review_By_Where ( string TITLE, string REVIEW_TEXT, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Review> oList = new List<Review>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.REVIEW_TEXT = REVIEW_TEXT; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REVIEW_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Review o = new Review();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Social_media_links> Get_Social_media_links_By_Criteria ( string TITLE, string URL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Social_media_links> oList = new List<Social_media_links>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.URL = URL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SOCIAL_MEDIA_LINKS_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Social_media_links o = new Social_media_links();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Social_media_links> Get_Social_media_links_By_Where ( string TITLE, string URL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Social_media_links> oList = new List<Social_media_links>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.URL = URL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SOCIAL_MEDIA_LINKS_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Social_media_links o = new Social_media_links();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Criteria ( string TITLE, string DESCRIPTION, string EMAIL, string PHONE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.DESCRIPTION = DESCRIPTION; p.EMAIL = EMAIL; p.PHONE = PHONE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Where ( string TITLE, string DESCRIPTION, string EMAIL, string PHONE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.DESCRIPTION = DESCRIPTION; p.EMAIL = EMAIL; p.PHONE = PHONE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Tags> Get_Tags_By_Criteria ( string TAG, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Tags> oList = new List<Tags>();
dynamic p = new ExpandoObject();
p.TAG = TAG; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TAGS_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Tags o = new Tags();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Tags> Get_Tags_By_Where ( string TAG, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Tags> oList = new List<Tags>();
dynamic p = new ExpandoObject();
p.TAG = TAG; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TAGS_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Tags o = new Tags();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Trip> Get_Trip_By_Criteria ( string TITLE, string SUB_TITLE, string DETAILS, string CITY, string PRICE, string DISCOUNT_PRICE, string VIDEO_URL, string OFFER_HIGHLIGHT_TEXT, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Trip> oList = new List<Trip>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.SUB_TITLE = SUB_TITLE; p.DETAILS = DETAILS; p.CITY = CITY; p.PRICE = PRICE; p.DISCOUNT_PRICE = DISCOUNT_PRICE; p.VIDEO_URL = VIDEO_URL; p.OFFER_HIGHLIGHT_TEXT = OFFER_HIGHLIGHT_TEXT; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TRIP_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Trip o = new Trip();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Trip> Get_Trip_By_Where ( string TITLE, string SUB_TITLE, string DETAILS, string CITY, string PRICE, string DISCOUNT_PRICE, string VIDEO_URL, string OFFER_HIGHLIGHT_TEXT, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Trip> oList = new List<Trip>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.SUB_TITLE = SUB_TITLE; p.DETAILS = DETAILS; p.CITY = CITY; p.PRICE = PRICE; p.DISCOUNT_PRICE = DISCOUNT_PRICE; p.VIDEO_URL = VIDEO_URL; p.OFFER_HIGHLIGHT_TEXT = OFFER_HIGHLIGHT_TEXT; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TRIP_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Trip o = new Trip();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Criteria ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Where ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Criteria_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Where_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Features> Get_Features_By_Criteria_Adv ( string TITLE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Features> oList = new List<Features>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEATURES_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Features o = new Features();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(X["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(X["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(X["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(X["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(X["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(X["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(X["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(X["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(X["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(X["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(X["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(X["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(X["T_TRIP_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Features> Get_Features_By_Where_Adv ( string TITLE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Features> oList = new List<Features>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEATURES_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Features o = new Features();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(X["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(X["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(X["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(X["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(X["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(X["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(X["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(X["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(X["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(X["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(X["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(X["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(X["T_TRIP_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Includes> Get_Includes_By_Criteria_Adv ( string TITLE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Includes> oList = new List<Includes>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INCLUDES_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Includes o = new Includes();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(X["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(X["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(X["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(X["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(X["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(X["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(X["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(X["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(X["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(X["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(X["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(X["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(X["T_TRIP_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Includes> Get_Includes_By_Where_Adv ( string TITLE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Includes> oList = new List<Includes>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INCLUDES_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Includes o = new Includes();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(X["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(X["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(X["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(X["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(X["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(X["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(X["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(X["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(X["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(X["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(X["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(X["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(X["T_TRIP_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Criteria_Adv ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Where_Adv ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Criteria_Adv_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.BIRTH_DATE = BIRTH_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Where_Adv_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.BIRTH_DATE = BIRTH_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Reservation_query> Get_Reservation_query_By_Criteria_Adv ( string PICK_UP_ADDRESS, string TRIP_DATE, string QUERY_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Reservation_query> oList = new List<Reservation_query>();
dynamic p = new ExpandoObject();
p.PICK_UP_ADDRESS = PICK_UP_ADDRESS; p.TRIP_DATE = TRIP_DATE; p.QUERY_DESCRIPTION = QUERY_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_RESERVATION_QUERY_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Reservation_query o = new Reservation_query();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Reservation_query> Get_Reservation_query_By_Where_Adv ( string PICK_UP_ADDRESS, string TRIP_DATE, string QUERY_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Reservation_query> oList = new List<Reservation_query>();
dynamic p = new ExpandoObject();
p.PICK_UP_ADDRESS = PICK_UP_ADDRESS; p.TRIP_DATE = TRIP_DATE; p.QUERY_DESCRIPTION = QUERY_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_RESERVATION_QUERY_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Reservation_query o = new Reservation_query();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Review> Get_Review_By_Criteria_Adv ( string TITLE, string REVIEW_TEXT, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Review> oList = new List<Review>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.REVIEW_TEXT = REVIEW_TEXT; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REVIEW_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Review o = new Review();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Review> Get_Review_By_Where_Adv ( string TITLE, string REVIEW_TEXT, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Review> oList = new List<Review>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.REVIEW_TEXT = REVIEW_TEXT; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REVIEW_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Review o = new Review();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Social_media_links> Get_Social_media_links_By_Criteria_Adv ( string TITLE, string URL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Social_media_links> oList = new List<Social_media_links>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.URL = URL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SOCIAL_MEDIA_LINKS_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Social_media_links o = new Social_media_links();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Social_media_links> Get_Social_media_links_By_Where_Adv ( string TITLE, string URL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Social_media_links> oList = new List<Social_media_links>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.URL = URL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SOCIAL_MEDIA_LINKS_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Social_media_links o = new Social_media_links();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Criteria_Adv ( string TITLE, string DESCRIPTION, string EMAIL, string PHONE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.DESCRIPTION = DESCRIPTION; p.EMAIL = EMAIL; p.PHONE = PHONE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Where_Adv ( string TITLE, string DESCRIPTION, string EMAIL, string PHONE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.DESCRIPTION = DESCRIPTION; p.EMAIL = EMAIL; p.PHONE = PHONE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Tags> Get_Tags_By_Criteria_Adv ( string TAG, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Tags> oList = new List<Tags>();
dynamic p = new ExpandoObject();
p.TAG = TAG; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TAGS_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Tags o = new Tags();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(X["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(X["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(X["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(X["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(X["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(X["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(X["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(X["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(X["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(X["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(X["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(X["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(X["T_TRIP_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Tags> Get_Tags_By_Where_Adv ( string TAG, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Tags> oList = new List<Tags>();
dynamic p = new ExpandoObject();
p.TAG = TAG; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TAGS_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Tags o = new Tags();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(X["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(X["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(X["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(X["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(X["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(X["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(X["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(X["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(X["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(X["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(X["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(X["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(X["T_TRIP_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Trip> Get_Trip_By_Criteria_Adv ( string TITLE, string SUB_TITLE, string DETAILS, string CITY, string PRICE, string DISCOUNT_PRICE, string VIDEO_URL, string OFFER_HIGHLIGHT_TEXT, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Trip> oList = new List<Trip>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.SUB_TITLE = SUB_TITLE; p.DETAILS = DETAILS; p.CITY = CITY; p.PRICE = PRICE; p.DISCOUNT_PRICE = DISCOUNT_PRICE; p.VIDEO_URL = VIDEO_URL; p.OFFER_HIGHLIGHT_TEXT = OFFER_HIGHLIGHT_TEXT; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TRIP_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Trip o = new Trip();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Trip> Get_Trip_By_Where_Adv ( string TITLE, string SUB_TITLE, string DETAILS, string CITY, string PRICE, string DISCOUNT_PRICE, string VIDEO_URL, string OFFER_HIGHLIGHT_TEXT, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Trip> oList = new List<Trip>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.SUB_TITLE = SUB_TITLE; p.DETAILS = DETAILS; p.CITY = CITY; p.PRICE = PRICE; p.DISCOUNT_PRICE = DISCOUNT_PRICE; p.VIDEO_URL = VIDEO_URL; p.OFFER_HIGHLIGHT_TEXT = OFFER_HIGHLIGHT_TEXT; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TRIP_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Trip o = new Trip();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Criteria_Adv ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Where_Adv ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_InList ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_InList ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_InList_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Criteria_InList ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Where_InList ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Features> Get_Features_By_Criteria_InList ( string TITLE, string DESCRIPTION, List<Int32?> TRIP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Features> oList = new List<Features>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.DESCRIPTION = DESCRIPTION; p.TRIP_ID_LIST = string.Join(",", TRIP_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEATURES_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Features o = new Features();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Features> Get_Features_By_Where_InList ( string TITLE, string DESCRIPTION, List<Int32?> TRIP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Features> oList = new List<Features>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.DESCRIPTION = DESCRIPTION; p.TRIP_ID_LIST = string.Join(",", TRIP_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEATURES_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Features o = new Features();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Includes> Get_Includes_By_Criteria_InList ( string TITLE, string DESCRIPTION, List<Int32?> TRIP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Includes> oList = new List<Includes>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.DESCRIPTION = DESCRIPTION; p.TRIP_ID_LIST = string.Join(",", TRIP_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INCLUDES_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Includes o = new Includes();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Includes> Get_Includes_By_Where_InList ( string TITLE, string DESCRIPTION, List<Int32?> TRIP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Includes> oList = new List<Includes>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.DESCRIPTION = DESCRIPTION; p.TRIP_ID_LIST = string.Join(",", TRIP_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INCLUDES_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Includes o = new Includes();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Tags> Get_Tags_By_Criteria_InList ( string TAG, List<Int32?> TRIP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Tags> oList = new List<Tags>();
dynamic p = new ExpandoObject();
p.TAG = TAG; p.TRIP_ID_LIST = string.Join(",", TRIP_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TAGS_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Tags o = new Tags();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Tags> Get_Tags_By_Where_InList ( string TAG, List<Int32?> TRIP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Tags> oList = new List<Tags>();
dynamic p = new ExpandoObject();
p.TAG = TAG; p.TRIP_ID_LIST = string.Join(",", TRIP_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TAGS_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Tags o = new Tags();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_InList_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_InList_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Criteria_InList_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Where_InList_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Features> Get_Features_By_Criteria_InList_Adv ( string TITLE, string DESCRIPTION, List<Int32?> TRIP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Features> oList = new List<Features>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.DESCRIPTION = DESCRIPTION; p.TRIP_ID_LIST = string.Join(",", TRIP_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEATURES_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Features o = new Features();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(X["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(X["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(X["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(X["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(X["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(X["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(X["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(X["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(X["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(X["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(X["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(X["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(X["T_TRIP_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Features> Get_Features_By_Where_InList_Adv ( string TITLE, string DESCRIPTION, List<Int32?> TRIP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Features> oList = new List<Features>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.DESCRIPTION = DESCRIPTION; p.TRIP_ID_LIST = string.Join(",", TRIP_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEATURES_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Features o = new Features();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(X["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(X["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(X["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(X["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(X["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(X["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(X["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(X["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(X["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(X["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(X["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(X["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(X["T_TRIP_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Includes> Get_Includes_By_Criteria_InList_Adv ( string TITLE, string DESCRIPTION, List<Int32?> TRIP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Includes> oList = new List<Includes>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.DESCRIPTION = DESCRIPTION; p.TRIP_ID_LIST = string.Join(",", TRIP_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INCLUDES_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Includes o = new Includes();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(X["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(X["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(X["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(X["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(X["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(X["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(X["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(X["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(X["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(X["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(X["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(X["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(X["T_TRIP_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Includes> Get_Includes_By_Where_InList_Adv ( string TITLE, string DESCRIPTION, List<Int32?> TRIP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Includes> oList = new List<Includes>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.DESCRIPTION = DESCRIPTION; p.TRIP_ID_LIST = string.Join(",", TRIP_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INCLUDES_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Includes o = new Includes();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(X["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(X["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(X["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(X["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(X["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(X["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(X["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(X["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(X["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(X["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(X["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(X["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(X["T_TRIP_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Tags> Get_Tags_By_Criteria_InList_Adv ( string TAG, List<Int32?> TRIP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Tags> oList = new List<Tags>();
dynamic p = new ExpandoObject();
p.TAG = TAG; p.TRIP_ID_LIST = string.Join(",", TRIP_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TAGS_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Tags o = new Tags();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(X["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(X["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(X["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(X["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(X["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(X["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(X["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(X["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(X["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(X["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(X["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(X["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(X["T_TRIP_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Tags> Get_Tags_By_Where_InList_Adv ( string TAG, List<Int32?> TRIP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Tags> oList = new List<Tags>();
dynamic p = new ExpandoObject();
p.TAG = TAG; p.TRIP_ID_LIST = string.Join(",", TRIP_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TAGS_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Tags o = new Tags();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Trip = new Trip();
o.My_Trip.TRIP_ID = GV<Int32>(X["T_TRIP_TRIP_ID"]);o.My_Trip.TITLE = GV<String>(X["T_TRIP_TITLE"]);o.My_Trip.SUB_TITLE = GV<String>(X["T_TRIP_SUB_TITLE"]);o.My_Trip.DETAILS = GV<String>(X["T_TRIP_DETAILS"]);o.My_Trip.CITY = GV<String>(X["T_TRIP_CITY"]);o.My_Trip.PRICE = GV<String>(X["T_TRIP_PRICE"]);o.My_Trip.DISCOUNT_PRICE = GV<String>(X["T_TRIP_DISCOUNT_PRICE"]);o.My_Trip.VIDEO_URL = GV<String>(X["T_TRIP_VIDEO_URL"]);o.My_Trip.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(X["T_TRIP_IS_AVAILABLE_OR_COMING_SOON"]);o.My_Trip.OFFER_HIGHLIGHT_TEXT = GV<String>(X["T_TRIP_OFFER_HIGHLIGHT_TEXT"]);o.My_Trip.ENTRY_USER_ID = GV<Int64>(X["T_TRIP_ENTRY_USER_ID"]);o.My_Trip.ENTRY_DATE = GV<String>(X["T_TRIP_ENTRY_DATE"]);o.My_Trip.OWNER_ID = GV<Int32>(X["T_TRIP_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public void Delete_Address ( long? ADDRESS_ID)
{
var p = new { ADDRESS_ID = ADDRESS_ID };
ExecuteDelete("UPG_DELETE_ADDRESS", p);
}
public void Delete_Contact ( Int32? CONTACT_ID)
{
var p = new { CONTACT_ID = CONTACT_ID };
ExecuteDelete("UPG_DELETE_CONTACT", p);
}
public void Delete_Features ( Int32? FEATURES_ID)
{
var p = new { FEATURES_ID = FEATURES_ID };
ExecuteDelete("UPG_DELETE_FEATURES", p);
}
public void Delete_Includes ( Int32? INCLUDES_ID)
{
var p = new { INCLUDES_ID = INCLUDES_ID };
ExecuteDelete("UPG_DELETE_INCLUDES", p);
}
public void Delete_Loc_l1 ( long? LOC_L1_ID)
{
var p = new { LOC_L1_ID = LOC_L1_ID };
ExecuteDelete("UPG_DELETE_LOC_L1", p);
}
public void Delete_Loc_l2 ( long? LOC_L2_ID)
{
var p = new { LOC_L2_ID = LOC_L2_ID };
ExecuteDelete("UPG_DELETE_LOC_L2", p);
}
public void Delete_Loc_l3 ( long? LOC_L3_ID)
{
var p = new { LOC_L3_ID = LOC_L3_ID };
ExecuteDelete("UPG_DELETE_LOC_L3", p);
}
public void Delete_Loc_l4 ( long? LOC_L4_ID)
{
var p = new { LOC_L4_ID = LOC_L4_ID };
ExecuteDelete("UPG_DELETE_LOC_L4", p);
}
public void Delete_Owner ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_OWNER", p);
}
public void Delete_Person ( long? PERSON_ID)
{
var p = new { PERSON_ID = PERSON_ID };
ExecuteDelete("UPG_DELETE_PERSON", p);
}
public void Delete_Reservation_query ( long? RESERVATION_QUERY_ID)
{
var p = new { RESERVATION_QUERY_ID = RESERVATION_QUERY_ID };
ExecuteDelete("UPG_DELETE_RESERVATION_QUERY", p);
}
public void Delete_Review ( Int32? REVIEW_ID)
{
var p = new { REVIEW_ID = REVIEW_ID };
ExecuteDelete("UPG_DELETE_REVIEW", p);
}
public void Delete_Social_media_links ( Int32? SOCIAL_MEDIA_LINKS_ID)
{
var p = new { SOCIAL_MEDIA_LINKS_ID = SOCIAL_MEDIA_LINKS_ID };
ExecuteDelete("UPG_DELETE_SOCIAL_MEDIA_LINKS", p);
}
public void Delete_Staff ( Int32? STAFF_ID)
{
var p = new { STAFF_ID = STAFF_ID };
ExecuteDelete("UPG_DELETE_STAFF", p);
}
public void Delete_Tags ( long? TAGS_ID)
{
var p = new { TAGS_ID = TAGS_ID };
ExecuteDelete("UPG_DELETE_TAGS", p);
}
public void Delete_Trip ( Int32? TRIP_ID)
{
var p = new { TRIP_ID = TRIP_ID };
ExecuteDelete("UPG_DELETE_TRIP", p);
}
public void Delete_User ( long? USER_ID)
{
var p = new { USER_ID = USER_ID };
ExecuteDelete("UPG_DELETE_USER", p);
}
public void Delete_Address_By_PERSON_ID ( long? PERSON_ID)
{
var p = new { PERSON_ID = PERSON_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_PERSON_ID", p);
}
public void Delete_Address_By_LOC_L1_ID ( long? LOC_L1_ID)
{
var p = new { LOC_L1_ID = LOC_L1_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_LOC_L1_ID", p);
}
public void Delete_Address_By_LOC_L2_ID ( long? LOC_L2_ID)
{
var p = new { LOC_L2_ID = LOC_L2_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_LOC_L2_ID", p);
}
public void Delete_Address_By_LOC_L3_ID ( long? LOC_L3_ID)
{
var p = new { LOC_L3_ID = LOC_L3_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_LOC_L3_ID", p);
}
public void Delete_Address_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_OWNER_ID", p);
}
public void Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE ( long? PERSON_ID, string ADDRESS_TYPE_CODE)
{
var p = new { PERSON_ID = PERSON_ID,ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_PERSON_ID_ADDRESS_TYPE_CODE", p);
}
public void Delete_Address_By_LOC_L4_ID ( long? LOC_L4_ID)
{
var p = new { LOC_L4_ID = LOC_L4_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_LOC_L4_ID", p);
}
public void Delete_Contact_By_PERSON_ID ( long? PERSON_ID)
{
var p = new { PERSON_ID = PERSON_ID };
ExecuteDelete("UPG_DELETE_CONTACT_BY_PERSON_ID", p);
}
public void Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT)
{
var p = new { PERSON_ID = PERSON_ID,CONTACT_TYPE_CODE = CONTACT_TYPE_CODE,CONTACT = CONTACT };
ExecuteDelete("UPG_DELETE_CONTACT_BY_PERSON_ID_CONTACT_TYPE_CODE_CONTACT", p);
}
public void Delete_Contact_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_CONTACT_BY_OWNER_ID", p);
}
public void Delete_Features_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_FEATURES_BY_OWNER_ID", p);
}
public void Delete_Features_By_TRIP_ID ( Int32? TRIP_ID)
{
var p = new { TRIP_ID = TRIP_ID };
ExecuteDelete("UPG_DELETE_FEATURES_BY_TRIP_ID", p);
}
public void Delete_Includes_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_INCLUDES_BY_OWNER_ID", p);
}
public void Delete_Includes_By_TRIP_ID ( Int32? TRIP_ID)
{
var p = new { TRIP_ID = TRIP_ID };
ExecuteDelete("UPG_DELETE_INCLUDES_BY_TRIP_ID", p);
}
public void Delete_Loc_l1_By_CODE ( string CODE)
{
var p = new { CODE = CODE };
ExecuteDelete("UPG_DELETE_LOC_L1_BY_CODE", p);
}
public void Delete_Loc_l1_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_LOC_L1_BY_OWNER_ID", p);
}
public void Delete_Loc_l2_By_LOC_L1_ID_CODE ( long? LOC_L1_ID, string CODE)
{
var p = new { LOC_L1_ID = LOC_L1_ID,CODE = CODE };
ExecuteDelete("UPG_DELETE_LOC_L2_BY_LOC_L1_ID_CODE", p);
}
public void Delete_Loc_l2_By_LOC_L1_ID ( long? LOC_L1_ID)
{
var p = new { LOC_L1_ID = LOC_L1_ID };
ExecuteDelete("UPG_DELETE_LOC_L2_BY_LOC_L1_ID", p);
}
public void Delete_Loc_l2_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_LOC_L2_BY_OWNER_ID", p);
}
public void Delete_Loc_l3_By_LOC_L2_ID_CODE ( long? LOC_L2_ID, string CODE)
{
var p = new { LOC_L2_ID = LOC_L2_ID,CODE = CODE };
ExecuteDelete("UPG_DELETE_LOC_L3_BY_LOC_L2_ID_CODE", p);
}
public void Delete_Loc_l3_By_LOC_L2_ID ( long? LOC_L2_ID)
{
var p = new { LOC_L2_ID = LOC_L2_ID };
ExecuteDelete("UPG_DELETE_LOC_L3_BY_LOC_L2_ID", p);
}
public void Delete_Loc_l3_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_LOC_L3_BY_OWNER_ID", p);
}
public void Delete_Loc_l4_By_LOC_L3_ID_CODE ( long? LOC_L3_ID, string CODE)
{
var p = new { LOC_L3_ID = LOC_L3_ID,CODE = CODE };
ExecuteDelete("UPG_DELETE_LOC_L4_BY_LOC_L3_ID_CODE", p);
}
public void Delete_Loc_l4_By_LOC_L3_ID ( long? LOC_L3_ID)
{
var p = new { LOC_L3_ID = LOC_L3_ID };
ExecuteDelete("UPG_DELETE_LOC_L4_BY_LOC_L3_ID", p);
}
public void Delete_Loc_l4_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_LOC_L4_BY_OWNER_ID", p);
}
public void Delete_Person_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_PERSON_BY_OWNER_ID", p);
}
public void Delete_Reservation_query_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_RESERVATION_QUERY_BY_OWNER_ID", p);
}
public void Delete_Review_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_REVIEW_BY_OWNER_ID", p);
}
public void Delete_Social_media_links_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_SOCIAL_MEDIA_LINKS_BY_OWNER_ID", p);
}
public void Delete_Staff_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_STAFF_BY_OWNER_ID", p);
}
public void Delete_Tags_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_TAGS_BY_OWNER_ID", p);
}
public void Delete_Tags_By_TRIP_ID ( Int32? TRIP_ID)
{
var p = new { TRIP_ID = TRIP_ID };
ExecuteDelete("UPG_DELETE_TAGS_BY_TRIP_ID", p);
}
public void Delete_Trip_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_TRIP_BY_OWNER_ID", p);
}
public void Delete_User_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_USER_BY_OWNER_ID", p);
}
public void Delete_User_By_USERNAME ( string USERNAME)
{
var p = new { USERNAME = USERNAME };
ExecuteDelete("UPG_DELETE_USER_BY_USERNAME", p);
}
public long? Edit_Address ( long? ADDRESS_ID, long? PERSON_ID, string ADDRESS_TYPE_CODE, long? LOC_L1_ID, long? LOC_L2_ID, long? LOC_L3_ID, long? LOC_L4_ID, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID)
{
Address oAddress = new Address();
oAddress.ADDRESS_ID = ADDRESS_ID;oAddress.PERSON_ID = PERSON_ID;oAddress.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE;oAddress.LOC_L1_ID = LOC_L1_ID;oAddress.LOC_L2_ID = LOC_L2_ID;oAddress.LOC_L3_ID = LOC_L3_ID;oAddress.LOC_L4_ID = LOC_L4_ID;oAddress.STREET = STREET;oAddress.BUILDING = BUILDING;oAddress.FLOOR = FLOOR;oAddress.POBOX = POBOX;oAddress.VALID_DATE_START = VALID_DATE_START;oAddress.VALID_DATE_END = VALID_DATE_END;oAddress.NOTES = NOTES;oAddress.ENTRY_DATE = ENTRY_DATE;oAddress.ENTRY_USER_ID = ENTRY_USER_ID;oAddress.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_ADDRESS", oAddress, "ADDRESS_ID");
return oAddress.ADDRESS_ID;
}
public Int32? Edit_Contact ( Int32? CONTACT_ID, long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Contact oContact = new Contact();
oContact.CONTACT_ID = CONTACT_ID;oContact.PERSON_ID = PERSON_ID;oContact.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE;oContact.CONTACT = CONTACT;oContact.DESCRIPTION = DESCRIPTION;oContact.ENTRY_USER_ID = ENTRY_USER_ID;oContact.ENTRY_DATE = ENTRY_DATE;oContact.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_CONTACT", oContact, "CONTACT_ID");
return oContact.CONTACT_ID;
}
public Int32? Edit_Features ( Int32? FEATURES_ID, Int32? TRIP_ID, string TITLE, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Features oFeatures = new Features();
oFeatures.FEATURES_ID = FEATURES_ID;oFeatures.TRIP_ID = TRIP_ID;oFeatures.TITLE = TITLE;oFeatures.DESCRIPTION = DESCRIPTION;oFeatures.ENTRY_USER_ID = ENTRY_USER_ID;oFeatures.ENTRY_DATE = ENTRY_DATE;oFeatures.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_FEATURES", oFeatures, "FEATURES_ID");
return oFeatures.FEATURES_ID;
}
public Int32? Edit_Includes ( Int32? INCLUDES_ID, Int32? TRIP_ID, string TITLE, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Includes oIncludes = new Includes();
oIncludes.INCLUDES_ID = INCLUDES_ID;oIncludes.TRIP_ID = TRIP_ID;oIncludes.TITLE = TITLE;oIncludes.DESCRIPTION = DESCRIPTION;oIncludes.ENTRY_USER_ID = ENTRY_USER_ID;oIncludes.ENTRY_DATE = ENTRY_DATE;oIncludes.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_INCLUDES", oIncludes, "INCLUDES_ID");
return oIncludes.INCLUDES_ID;
}
public long? Edit_Loc_l1 ( long? LOC_L1_ID, string CODE, string DESCRIPTION, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID)
{
Loc_l1 oLoc_l1 = new Loc_l1();
oLoc_l1.LOC_L1_ID = LOC_L1_ID;oLoc_l1.CODE = CODE;oLoc_l1.DESCRIPTION = DESCRIPTION;oLoc_l1.NOTES = NOTES;oLoc_l1.ENTRY_DATE = ENTRY_DATE;oLoc_l1.ENTRY_USER_ID = ENTRY_USER_ID;oLoc_l1.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_LOC_L1", oLoc_l1, "LOC_L1_ID");
return oLoc_l1.LOC_L1_ID;
}
public long? Edit_Loc_l2 ( long? LOC_L2_ID, string CODE, string DESCRIPTION, long? LOC_L1_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID)
{
Loc_l2 oLoc_l2 = new Loc_l2();
oLoc_l2.LOC_L2_ID = LOC_L2_ID;oLoc_l2.CODE = CODE;oLoc_l2.DESCRIPTION = DESCRIPTION;oLoc_l2.LOC_L1_ID = LOC_L1_ID;oLoc_l2.NOTES = NOTES;oLoc_l2.ENTRY_DATE = ENTRY_DATE;oLoc_l2.ENTRY_USER_ID = ENTRY_USER_ID;oLoc_l2.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_LOC_L2", oLoc_l2, "LOC_L2_ID");
return oLoc_l2.LOC_L2_ID;
}
public long? Edit_Loc_l3 ( long? LOC_L3_ID, string CODE, string DESCRIPTION, long? LOC_L2_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID)
{
Loc_l3 oLoc_l3 = new Loc_l3();
oLoc_l3.LOC_L3_ID = LOC_L3_ID;oLoc_l3.CODE = CODE;oLoc_l3.DESCRIPTION = DESCRIPTION;oLoc_l3.LOC_L2_ID = LOC_L2_ID;oLoc_l3.NOTES = NOTES;oLoc_l3.ENTRY_DATE = ENTRY_DATE;oLoc_l3.ENTRY_USER_ID = ENTRY_USER_ID;oLoc_l3.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_LOC_L3", oLoc_l3, "LOC_L3_ID");
return oLoc_l3.LOC_L3_ID;
}
public long? Edit_Loc_l4 ( long? LOC_L4_ID, string CODE, string DESCRIPTION, long? LOC_L3_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID)
{
Loc_l4 oLoc_l4 = new Loc_l4();
oLoc_l4.LOC_L4_ID = LOC_L4_ID;oLoc_l4.CODE = CODE;oLoc_l4.DESCRIPTION = DESCRIPTION;oLoc_l4.LOC_L3_ID = LOC_L3_ID;oLoc_l4.NOTES = NOTES;oLoc_l4.ENTRY_DATE = ENTRY_DATE;oLoc_l4.ENTRY_USER_ID = ENTRY_USER_ID;oLoc_l4.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_LOC_L4", oLoc_l4, "LOC_L4_ID");
return oLoc_l4.LOC_L4_ID;
}
public Int32? Edit_Owner ( Int32? OWNER_ID, string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, string ENTRY_DATE)
{
Owner oOwner = new Owner();
oOwner.OWNER_ID = OWNER_ID;oOwner.CODE = CODE;oOwner.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE;oOwner.DESCRIPTION = DESCRIPTION;oOwner.ENTRY_DATE = ENTRY_DATE;
ExecuteEdit("UPG_EDIT_OWNER", oOwner, "OWNER_ID");
return oOwner.OWNER_ID;
}
public long? Edit_Person ( long? PERSON_ID, string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, bool? IS_BLOCKED, string DESCRIPTION, Int32? OWNER_ID, long? ENTRY_USER_ID, string ENTRY_DATE)
{
Person oPerson = new Person();
oPerson.PERSON_ID = PERSON_ID;oPerson.FIRST_NAME = FIRST_NAME;oPerson.LAST_NAME = LAST_NAME;oPerson.FATHER_NAME = FATHER_NAME;oPerson.MOTHER_NAME = MOTHER_NAME;oPerson.TITLE_CODE = TITLE_CODE;oPerson.GENDER_CODE = GENDER_CODE;oPerson.RELIGION_CODE = RELIGION_CODE;oPerson.BIRTH_DATE = BIRTH_DATE;oPerson.IS_BLOCKED = IS_BLOCKED;oPerson.DESCRIPTION = DESCRIPTION;oPerson.OWNER_ID = OWNER_ID;oPerson.ENTRY_USER_ID = ENTRY_USER_ID;oPerson.ENTRY_DATE = ENTRY_DATE;
ExecuteEdit("UPG_EDIT_PERSON", oPerson, "PERSON_ID");
return oPerson.PERSON_ID;
}
public long? Edit_Reservation_query ( long? RESERVATION_QUERY_ID, Int32? NB_OF_ADULTS, Int32? NB_OF_CHILDREN, string PICK_UP_ADDRESS, string TRIP_DATE, string QUERY_DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Reservation_query oReservation_query = new Reservation_query();
oReservation_query.RESERVATION_QUERY_ID = RESERVATION_QUERY_ID;oReservation_query.NB_OF_ADULTS = NB_OF_ADULTS;oReservation_query.NB_OF_CHILDREN = NB_OF_CHILDREN;oReservation_query.PICK_UP_ADDRESS = PICK_UP_ADDRESS;oReservation_query.TRIP_DATE = TRIP_DATE;oReservation_query.QUERY_DESCRIPTION = QUERY_DESCRIPTION;oReservation_query.ENTRY_USER_ID = ENTRY_USER_ID;oReservation_query.ENTRY_DATE = ENTRY_DATE;oReservation_query.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_RESERVATION_QUERY", oReservation_query, "RESERVATION_QUERY_ID");
return oReservation_query.RESERVATION_QUERY_ID;
}
public Int32? Edit_Review ( Int32? REVIEW_ID, string TITLE, string REVIEW_TEXT, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Review oReview = new Review();
oReview.REVIEW_ID = REVIEW_ID;oReview.TITLE = TITLE;oReview.REVIEW_TEXT = REVIEW_TEXT;oReview.ENTRY_USER_ID = ENTRY_USER_ID;oReview.ENTRY_DATE = ENTRY_DATE;oReview.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_REVIEW", oReview, "REVIEW_ID");
return oReview.REVIEW_ID;
}
public Int32? Edit_Social_media_links ( Int32? SOCIAL_MEDIA_LINKS_ID, string TITLE, string URL, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Social_media_links oSocial_media_links = new Social_media_links();
oSocial_media_links.SOCIAL_MEDIA_LINKS_ID = SOCIAL_MEDIA_LINKS_ID;oSocial_media_links.TITLE = TITLE;oSocial_media_links.URL = URL;oSocial_media_links.ENTRY_USER_ID = ENTRY_USER_ID;oSocial_media_links.ENTRY_DATE = ENTRY_DATE;oSocial_media_links.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_SOCIAL_MEDIA_LINKS", oSocial_media_links, "SOCIAL_MEDIA_LINKS_ID");
return oSocial_media_links.SOCIAL_MEDIA_LINKS_ID;
}
public Int32? Edit_Staff ( Int32? STAFF_ID, string TITLE, string DESCRIPTION, string EMAIL, string PHONE, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Staff oStaff = new Staff();
oStaff.STAFF_ID = STAFF_ID;oStaff.TITLE = TITLE;oStaff.DESCRIPTION = DESCRIPTION;oStaff.EMAIL = EMAIL;oStaff.PHONE = PHONE;oStaff.ENTRY_USER_ID = ENTRY_USER_ID;oStaff.ENTRY_DATE = ENTRY_DATE;oStaff.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_STAFF", oStaff, "STAFF_ID");
return oStaff.STAFF_ID;
}
public long? Edit_Tags ( long? TAGS_ID, Int32? TRIP_ID, string TAG, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Tags oTags = new Tags();
oTags.TAGS_ID = TAGS_ID;oTags.TRIP_ID = TRIP_ID;oTags.TAG = TAG;oTags.ENTRY_USER_ID = ENTRY_USER_ID;oTags.ENTRY_DATE = ENTRY_DATE;oTags.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_TAGS", oTags, "TAGS_ID");
return oTags.TAGS_ID;
}
public Int32? Edit_Trip ( Int32? TRIP_ID, string TITLE, string SUB_TITLE, string DETAILS, string CITY, string PRICE, string DISCOUNT_PRICE, string VIDEO_URL, bool? IS_AVAILABLE_OR_COMING_SOON, string OFFER_HIGHLIGHT_TEXT, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Trip oTrip = new Trip();
oTrip.TRIP_ID = TRIP_ID;oTrip.TITLE = TITLE;oTrip.SUB_TITLE = SUB_TITLE;oTrip.DETAILS = DETAILS;oTrip.CITY = CITY;oTrip.PRICE = PRICE;oTrip.DISCOUNT_PRICE = DISCOUNT_PRICE;oTrip.VIDEO_URL = VIDEO_URL;oTrip.IS_AVAILABLE_OR_COMING_SOON = IS_AVAILABLE_OR_COMING_SOON;oTrip.OFFER_HIGHLIGHT_TEXT = OFFER_HIGHLIGHT_TEXT;oTrip.ENTRY_USER_ID = ENTRY_USER_ID;oTrip.ENTRY_DATE = ENTRY_DATE;oTrip.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_TRIP", oTrip, "TRIP_ID");
return oTrip.TRIP_ID;
}
public long? Edit_User ( long? USER_ID, Int32? OWNER_ID, string USERNAME, string PASSWORD, string USER_TYPE_CODE, bool? IS_ACTIVE, string ENTRY_DATE)
{
User oUser = new User();
oUser.USER_ID = USER_ID;oUser.OWNER_ID = OWNER_ID;oUser.USERNAME = USERNAME;oUser.PASSWORD = PASSWORD;oUser.USER_TYPE_CODE = USER_TYPE_CODE;oUser.IS_ACTIVE = IS_ACTIVE;oUser.ENTRY_DATE = ENTRY_DATE;
ExecuteEdit("UPG_EDIT_USER", oUser, "USER_ID");
return oUser.USER_ID;
}
public List<dynamic> GET_DISTINCT_SETUP_TBL ( Int32? OWNER_ID)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_DISTINCT_SETUP_TBL", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.TBL_NAME = GV<String>(X["TBL_NAME"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> GET_NEXT_VALUE ( string STARTER_CODE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.STARTER_CODE = STARTER_CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_NEXT_VALUE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LAST_VALUE = GV<Int64>(X["LAST_VALUE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> GET_TBL_SETUP ()
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_TBL_SETUP", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_ADDRESS ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_ADDRESS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ADDRESS_ID = GV<Int64>(X["ADDRESS_ID"]);o.PERSON_ID = GV<Int64>(X["PERSON_ID"]);o.ADDRESS_TYPE_CODE = GV<String>(X["ADDRESS_TYPE_CODE"]);o.LOC_L1_ID = GV<Int64>(X["LOC_L1_ID"]);o.LOC_L2_ID = GV<Int64>(X["LOC_L2_ID"]);o.LOC_L3_ID = GV<Int64>(X["LOC_L3_ID"]);o.LOC_L4_ID = GV<Int64>(X["LOC_L4_ID"]);o.STREET = GV<String>(X["STREET"]);o.BUILDING = GV<String>(X["BUILDING"]);o.FLOOR = GV<String>(X["FLOOR"]);o.POBOX = GV<String>(X["POBOX"]);o.VALID_DATE_START = GV<String>(X["VALID_DATE_START"]);o.VALID_DATE_END = GV<String>(X["VALID_DATE_END"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_CONTACT ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_CONTACT", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.CONTACT_ID = GV<Int32>(X["CONTACT_ID"]);o.PERSON_ID = GV<Int64>(X["PERSON_ID"]);o.CONTACT_TYPE_CODE = GV<String>(X["CONTACT_TYPE_CODE"]);o.CONTACT = GV<String>(X["CONTACT"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_FEATURES ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_FEATURES", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.FEATURES_ID = GV<Int32>(X["FEATURES_ID"]);o.TRIP_ID = GV<Int32>(X["TRIP_ID"]);o.TITLE = GV<String>(X["TITLE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_INCLUDES ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_INCLUDES", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.INCLUDES_ID = GV<Int32>(X["INCLUDES_ID"]);o.TRIP_ID = GV<Int32>(X["TRIP_ID"]);o.TITLE = GV<String>(X["TITLE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_LOC_L1 ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_LOC_L1", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LOC_L1_ID = GV<Int64>(X["LOC_L1_ID"]);o.CODE = GV<String>(X["CODE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_LOC_L2 ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_LOC_L2", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LOC_L2_ID = GV<Int64>(X["LOC_L2_ID"]);o.CODE = GV<String>(X["CODE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.LOC_L1_ID = GV<Int64>(X["LOC_L1_ID"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_LOC_L3 ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_LOC_L3", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LOC_L3_ID = GV<Int64>(X["LOC_L3_ID"]);o.CODE = GV<String>(X["CODE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.LOC_L2_ID = GV<Int64>(X["LOC_L2_ID"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_LOC_L4 ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_LOC_L4", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LOC_L4_ID = GV<Int64>(X["LOC_L4_ID"]);o.CODE = GV<String>(X["CODE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.LOC_L3_ID = GV<Int64>(X["LOC_L3_ID"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_OWNER ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_OWNER", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.CODE = GV<String>(X["CODE"]);o.MAINTENANCE_DUE_DATE = GV<String>(X["MAINTENANCE_DUE_DATE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_PERSON ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_PERSON", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.PERSON_ID = GV<Int64>(X["PERSON_ID"]);o.FIRST_NAME = GV<String>(X["FIRST_NAME"]);o.LAST_NAME = GV<String>(X["LAST_NAME"]);o.FATHER_NAME = GV<String>(X["FATHER_NAME"]);o.MOTHER_NAME = GV<String>(X["MOTHER_NAME"]);o.TITLE_CODE = GV<String>(X["TITLE_CODE"]);o.GENDER_CODE = GV<String>(X["GENDER_CODE"]);o.RELIGION_CODE = GV<String>(X["RELIGION_CODE"]);o.BIRTH_DATE = GV<String>(X["BIRTH_DATE"]);o.IS_BLOCKED = GV<Boolean>(X["IS_BLOCKED"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_RESERVATION_QUERY ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_RESERVATION_QUERY", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.RESERVATION_QUERY_ID = GV<Int64>(X["RESERVATION_QUERY_ID"]);o.NB_OF_ADULTS = GV<Int32>(X["NB_OF_ADULTS"]);o.NB_OF_CHILDREN = GV<Int32>(X["NB_OF_CHILDREN"]);o.PICK_UP_ADDRESS = GV<String>(X["PICK_UP_ADDRESS"]);o.TRIP_DATE = GV<String>(X["TRIP_DATE"]);o.QUERY_DESCRIPTION = GV<String>(X["QUERY_DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_REVIEW ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_REVIEW", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.REVIEW_ID = GV<Int32>(X["REVIEW_ID"]);o.TITLE = GV<String>(X["TITLE"]);o.REVIEW_TEXT = GV<String>(X["REVIEW_TEXT"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_SOCIAL_MEDIA_LINKS ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_SOCIAL_MEDIA_LINKS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.SOCIAL_MEDIA_LINKS_ID = GV<Int32>(X["SOCIAL_MEDIA_LINKS_ID"]);o.TITLE = GV<String>(X["TITLE"]);o.URL = GV<String>(X["URL"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_STAFF ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_STAFF", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.STAFF_ID = GV<Int32>(X["STAFF_ID"]);o.TITLE = GV<String>(X["TITLE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.EMAIL = GV<String>(X["EMAIL"]);o.PHONE = GV<String>(X["PHONE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_TAGS ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_TAGS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.TAGS_ID = GV<Int64>(X["TAGS_ID"]);o.TRIP_ID = GV<Int32>(X["TRIP_ID"]);o.TAG = GV<String>(X["TAG"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_TRIP ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_TRIP", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.TRIP_ID = GV<Int32>(X["TRIP_ID"]);o.TITLE = GV<String>(X["TITLE"]);o.SUB_TITLE = GV<String>(X["SUB_TITLE"]);o.DETAILS = GV<String>(X["DETAILS"]);o.CITY = GV<String>(X["CITY"]);o.PRICE = GV<String>(X["PRICE"]);o.DISCOUNT_PRICE = GV<String>(X["DISCOUNT_PRICE"]);o.VIDEO_URL = GV<String>(X["VIDEO_URL"]);o.IS_AVAILABLE_OR_COMING_SOON = GV<Boolean>(X["IS_AVAILABLE_OR_COMING_SOON"]);o.OFFER_HIGHLIGHT_TEXT = GV<String>(X["OFFER_HIGHLIGHT_TEXT"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_USER ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_USER", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.USER_ID = GV<Int64>(X["USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.USER_TYPE_CODE = GV<String>(X["USER_TYPE_CODE"]);o.IS_ACTIVE = GV<Boolean>(X["IS_ACTIVE"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_CHECK_USER_EXISTENCE ( Int32? OWNER_ID, string USERNAME,ref  bool? EXISTS)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.USERNAME = USERNAME; p.EXISTS = EXISTS;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_CHECK_USER_EXISTENCE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
EXISTS = p.EXISTS;
return oList;
}
public List<dynamic> UP_EDIT_SETUP ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME, bool? ISSYSTEM, bool? ISDELETEABLE, bool? ISUPDATEABLE, bool? ISVISIBLE, bool? ISDELETED, Int32? DISPLAY_ORDER, string CODE_VALUE_EN, string CODE_VALUE_FR, string CODE_VALUE_AR, string ENTRY_DATE, long? ENTRY_USER_ID, string NOTES)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.CODE_NAME = CODE_NAME; p.ISSYSTEM = ISSYSTEM; p.ISDELETEABLE = ISDELETEABLE; p.ISUPDATEABLE = ISUPDATEABLE; p.ISVISIBLE = ISVISIBLE; p.ISDELETED = ISDELETED; p.DISPLAY_ORDER = DISPLAY_ORDER; p.CODE_VALUE_EN = CODE_VALUE_EN; p.CODE_VALUE_FR = CODE_VALUE_FR; p.CODE_VALUE_AR = CODE_VALUE_AR; p.ENTRY_DATE = ENTRY_DATE; p.ENTRY_USER_ID = ENTRY_USER_ID; p.NOTES = NOTES;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EDIT_SETUP", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_EXTRACT_ROUTINE_PARAMETERS ( string ROUTINE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.ROUTINE_NAME = ROUTINE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EXTRACT_ROUTINE_PARAMETERS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ROUTINE_NAME = GV<String>(X["ROUTINE_NAME"]);o.PARAM_NAME = GV<String>(X["PARAM_NAME"]);o.PARAM_TYPE = GV<String>(X["PARAM_TYPE"]);o.IS_OUTPUT = GV<Boolean>(X["IS_OUTPUT"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_EXTRACT_ROUTINE_RESULT_SCHEMA ( string ROUTINE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.ROUTINE_NAME = ROUTINE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EXTRACT_ROUTINE_RESULT_SCHEMA", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ROUTINE_NAME = GV<String>(X["ROUTINE_NAME"]);o.COLUMN_NAME = GV<String>(X["COLUMN_NAME"]);o.COLUMN_TYPE = GV<String>(X["COLUMN_TYPE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GENERATE_INSERT_STATEMENTS ( string @tableName)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.@tableName = @tableName;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GENERATE_INSERT_STATEMENTS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_NEXT_VALUE ( string STARTER_CODE,ref  long? VALUE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.STARTER_CODE = STARTER_CODE; p.VALUE = VALUE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_NEXT_VALUE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
VALUE = p.VALUE;
return oList;
}
public List<dynamic> UP_GET_SETUP_ENTRIES ( Int32? OWNER_ID, string TBL_NAME, bool? ISDELETED, bool? ISVISIBLE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.ISDELETED = ISDELETED; p.ISVISIBLE = ISVISIBLE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_SETUP_ENTRIES", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_SETUP_ENTRY ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.CODE_NAME = CODE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_SETUP_ENTRY", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_USER_BY_CREDENTIALS ( Int32? OWNER_ID, string USERNAME, string PASSWORD)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.USERNAME = USERNAME; p.PASSWORD = PASSWORD;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_USER_BY_CREDENTIALS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.USER_ID = GV<Int64>(X["USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
}
}
