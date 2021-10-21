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
