using System;
using System.Collections.Generic;
namespace DALC
{
#region Entities
public partial class Reservation_query
{
public long? RESERVATION_QUERY_ID {get;set;}
public Int32? NB_OF_ADULTS {get;set;}
public Int32? NB_OF_CHILDREN {get;set;}
public string PICK_UP_ADDRESS {get;set;}
public string TRIP_DATE {get;set;}
public string QUERY_DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Loc_l3
{
public long? LOC_L3_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? LOC_L2_ID {get;set;}
public string NOTES {get;set;}
public string ENTRY_DATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
public Loc_l2 My_Loc_l2 {get;set;}
}
public partial class Review
{
public Int32? REVIEW_ID {get;set;}
public string TITLE {get;set;}
public string REVIEW_TEXT {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Trip
{
public Int32? TRIP_ID {get;set;}
public string TITLE {get;set;}
public string SUB_TITLE {get;set;}
public string DETAILS {get;set;}
public string CITY {get;set;}
public string PRICE {get;set;}
public string DISCOUNT_PRICE {get;set;}
public string VIDEO_URL {get;set;}
public bool? IS_AVAILABLE_OR_COMING_SOON {get;set;}
public string OFFER_HIGHLIGHT_TEXT {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Loc_l4
{
public long? LOC_L4_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? LOC_L3_ID {get;set;}
public string NOTES {get;set;}
public string ENTRY_DATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
public Loc_l3 My_Loc_l3 {get;set;}
}
public partial class Address
{
public long? ADDRESS_ID {get;set;}
public long? PERSON_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public long? LOC_L1_ID {get;set;}
public long? LOC_L2_ID {get;set;}
public long? LOC_L3_ID {get;set;}
public long? LOC_L4_ID {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public string NOTES {get;set;}
public string ENTRY_DATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
public Person My_Person {get;set;}
public Loc_l1 My_Loc_l1 {get;set;}
public Loc_l2 My_Loc_l2 {get;set;}
public Loc_l3 My_Loc_l3 {get;set;}
public Loc_l4 My_Loc_l4 {get;set;}
}
public partial class Owner
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public string ENTRY_DATE {get;set;}
}
public partial class Features
{
public Int32? FEATURES_ID {get;set;}
public Int32? TRIP_ID {get;set;}
public string TITLE {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Trip My_Trip {get;set;}
}
public partial class User
{
public long? USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string USER_TYPE_CODE {get;set;}
public bool? IS_ACTIVE {get;set;}
public string ENTRY_DATE {get;set;}
}
public partial class Includes
{
public Int32? INCLUDES_ID {get;set;}
public Int32? TRIP_ID {get;set;}
public string TITLE {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Trip My_Trip {get;set;}
}
public partial class Staff
{
public Int32? STAFF_ID {get;set;}
public string TITLE {get;set;}
public string DESCRIPTION {get;set;}
public string EMAIL {get;set;}
public string PHONE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Person
{
public long? PERSON_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string FATHER_NAME {get;set;}
public string MOTHER_NAME {get;set;}
public string TITLE_CODE {get;set;}
public string GENDER_CODE {get;set;}
public string RELIGION_CODE {get;set;}
public string BIRTH_DATE {get;set;}
public bool? IS_BLOCKED {get;set;}
public string DESCRIPTION {get;set;}
public Int32? OWNER_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
}
public partial class Tags
{
public long? TAGS_ID {get;set;}
public Int32? TRIP_ID {get;set;}
public string TAG {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Trip My_Trip {get;set;}
}
public partial class Social_media_links
{
public Int32? SOCIAL_MEDIA_LINKS_ID {get;set;}
public string TITLE {get;set;}
public string URL {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Contact
{
public Int32? CONTACT_ID {get;set;}
public long? PERSON_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Person My_Person {get;set;}
}
public partial class Uploaded_file
{
public long? UPLOADED_FILE_ID {get;set;}
public string REL_ENTITY {get;set;}
public long? REL_KEY {get;set;}
public string REL_FIELD {get;set;}
public Int32? SIZE {get;set;}
public string EXTENSION {get;set;}
public string STAMP {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Loc_l1
{
public long? LOC_L1_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string NOTES {get;set;}
public string ENTRY_DATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Loc_l2
{
public long? LOC_L2_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? LOC_L1_ID {get;set;}
public string NOTES {get;set;}
public string ENTRY_DATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
public Loc_l1 My_Loc_l1 {get;set;}
}
#endregion 
public partial interface IDALC
{
Reservation_query Get_Reservation_query_By_RESERVATION_QUERY_ID ( long? RESERVATION_QUERY_ID);
Loc_l3 Get_Loc_l3_By_LOC_L3_ID ( long? LOC_L3_ID);
Review Get_Review_By_REVIEW_ID ( Int32? REVIEW_ID);
Trip Get_Trip_By_TRIP_ID ( Int32? TRIP_ID);
Loc_l4 Get_Loc_l4_By_LOC_L4_ID ( long? LOC_L4_ID);
Address Get_Address_By_ADDRESS_ID ( long? ADDRESS_ID);
Owner Get_Owner_By_OWNER_ID ( Int32? OWNER_ID);
Features Get_Features_By_FEATURES_ID ( Int32? FEATURES_ID);
User Get_User_By_USER_ID ( long? USER_ID);
Includes Get_Includes_By_INCLUDES_ID ( Int32? INCLUDES_ID);
Staff Get_Staff_By_STAFF_ID ( Int32? STAFF_ID);
Person Get_Person_By_PERSON_ID ( long? PERSON_ID);
Tags Get_Tags_By_TAGS_ID ( long? TAGS_ID);
Social_media_links Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID ( Int32? SOCIAL_MEDIA_LINKS_ID);
Contact Get_Contact_By_CONTACT_ID ( Int32? CONTACT_ID);
Uploaded_file Get_Uploaded_file_By_UPLOADED_FILE_ID ( long? UPLOADED_FILE_ID);
Loc_l1 Get_Loc_l1_By_LOC_L1_ID ( long? LOC_L1_ID);
Loc_l2 Get_Loc_l2_By_LOC_L2_ID ( long? LOC_L2_ID);
Reservation_query Get_Reservation_query_By_RESERVATION_QUERY_ID_Adv ( long? RESERVATION_QUERY_ID);
Loc_l3 Get_Loc_l3_By_LOC_L3_ID_Adv ( long? LOC_L3_ID);
Review Get_Review_By_REVIEW_ID_Adv ( Int32? REVIEW_ID);
Trip Get_Trip_By_TRIP_ID_Adv ( Int32? TRIP_ID);
Loc_l4 Get_Loc_l4_By_LOC_L4_ID_Adv ( long? LOC_L4_ID);
Address Get_Address_By_ADDRESS_ID_Adv ( long? ADDRESS_ID);
Features Get_Features_By_FEATURES_ID_Adv ( Int32? FEATURES_ID);
User Get_User_By_USER_ID_Adv ( long? USER_ID);
Includes Get_Includes_By_INCLUDES_ID_Adv ( Int32? INCLUDES_ID);
Staff Get_Staff_By_STAFF_ID_Adv ( Int32? STAFF_ID);
Person Get_Person_By_PERSON_ID_Adv ( long? PERSON_ID);
Tags Get_Tags_By_TAGS_ID_Adv ( long? TAGS_ID);
Social_media_links Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID_Adv ( Int32? SOCIAL_MEDIA_LINKS_ID);
Contact Get_Contact_By_CONTACT_ID_Adv ( Int32? CONTACT_ID);
Loc_l1 Get_Loc_l1_By_LOC_L1_ID_Adv ( long? LOC_L1_ID);
Loc_l2 Get_Loc_l2_By_LOC_L2_ID_Adv ( long? LOC_L2_ID);
List<Reservation_query> Get_Reservation_query_By_RESERVATION_QUERY_ID_List ( List<long?> RESERVATION_QUERY_ID_LIST);
List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST);
List<Review> Get_Review_By_REVIEW_ID_List ( List<Int32?> REVIEW_ID_LIST);
List<Trip> Get_Trip_By_TRIP_ID_List ( List<Int32?> TRIP_ID_LIST);
List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List ( List<long?> LOC_L4_ID_LIST);
List<Address> Get_Address_By_ADDRESS_ID_List ( List<long?> ADDRESS_ID_LIST);
List<Owner> Get_Owner_By_OWNER_ID_List ( List<Int32?> OWNER_ID_LIST);
List<Features> Get_Features_By_FEATURES_ID_List ( List<Int32?> FEATURES_ID_LIST);
List<User> Get_User_By_USER_ID_List ( List<long?> USER_ID_LIST);
List<Includes> Get_Includes_By_INCLUDES_ID_List ( List<Int32?> INCLUDES_ID_LIST);
List<Staff> Get_Staff_By_STAFF_ID_List ( List<Int32?> STAFF_ID_LIST);
List<Person> Get_Person_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST);
List<Tags> Get_Tags_By_TAGS_ID_List ( List<long?> TAGS_ID_LIST);
List<Social_media_links> Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID_List ( List<Int32?> SOCIAL_MEDIA_LINKS_ID_LIST);
List<Contact> Get_Contact_By_CONTACT_ID_List ( List<Int32?> CONTACT_ID_LIST);
List<Uploaded_file> Get_Uploaded_file_By_UPLOADED_FILE_ID_List ( List<long?> UPLOADED_FILE_ID_LIST);
List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST);
List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST);
List<Reservation_query> Get_Reservation_query_By_RESERVATION_QUERY_ID_List_Adv ( List<long?> RESERVATION_QUERY_ID_LIST);
List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST);
List<Review> Get_Review_By_REVIEW_ID_List_Adv ( List<Int32?> REVIEW_ID_LIST);
List<Trip> Get_Trip_By_TRIP_ID_List_Adv ( List<Int32?> TRIP_ID_LIST);
List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List_Adv ( List<long?> LOC_L4_ID_LIST);
List<Address> Get_Address_By_ADDRESS_ID_List_Adv ( List<long?> ADDRESS_ID_LIST);
List<Features> Get_Features_By_FEATURES_ID_List_Adv ( List<Int32?> FEATURES_ID_LIST);
List<User> Get_User_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST);
List<Includes> Get_Includes_By_INCLUDES_ID_List_Adv ( List<Int32?> INCLUDES_ID_LIST);
List<Staff> Get_Staff_By_STAFF_ID_List_Adv ( List<Int32?> STAFF_ID_LIST);
List<Person> Get_Person_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST);
List<Tags> Get_Tags_By_TAGS_ID_List_Adv ( List<long?> TAGS_ID_LIST);
List<Social_media_links> Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID_List_Adv ( List<Int32?> SOCIAL_MEDIA_LINKS_ID_LIST);
List<Contact> Get_Contact_By_CONTACT_ID_List_Adv ( List<Int32?> CONTACT_ID_LIST);
List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST);
List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST);
List<Reservation_query> Get_Reservation_query_By_OWNER_ID ( Int32? OWNER_ID);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE ( long? LOC_L2_ID, string CODE);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID ( long? LOC_L2_ID);
List<Loc_l3> Get_Loc_l3_By_OWNER_ID ( Int32? OWNER_ID);
List<Review> Get_Review_By_OWNER_ID ( Int32? OWNER_ID);
List<Trip> Get_Trip_By_OWNER_ID ( Int32? OWNER_ID);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE ( long? LOC_L3_ID, string CODE);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID ( long? LOC_L3_ID);
List<Loc_l4> Get_Loc_l4_By_OWNER_ID ( Int32? OWNER_ID);
List<Address> Get_Address_By_PERSON_ID ( long? PERSON_ID);
List<Address> Get_Address_By_LOC_L1_ID ( long? LOC_L1_ID);
List<Address> Get_Address_By_LOC_L2_ID ( long? LOC_L2_ID);
List<Address> Get_Address_By_LOC_L3_ID ( long? LOC_L3_ID);
List<Address> Get_Address_By_OWNER_ID ( Int32? OWNER_ID);
List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE ( long? PERSON_ID, string ADDRESS_TYPE_CODE);
List<Address> Get_Address_By_LOC_L4_ID ( long? LOC_L4_ID);
List<Features> Get_Features_By_OWNER_ID ( Int32? OWNER_ID);
List<Features> Get_Features_By_TRIP_ID ( Int32? TRIP_ID);
List<User> Get_User_By_OWNER_ID ( Int32? OWNER_ID);
List<User> Get_User_By_USERNAME ( string USERNAME);
List<Includes> Get_Includes_By_OWNER_ID ( Int32? OWNER_ID);
List<Includes> Get_Includes_By_TRIP_ID ( Int32? TRIP_ID);
List<Staff> Get_Staff_By_OWNER_ID ( Int32? OWNER_ID);
List<Person> Get_Person_By_OWNER_ID ( Int32? OWNER_ID);
List<Tags> Get_Tags_By_OWNER_ID ( Int32? OWNER_ID);
List<Tags> Get_Tags_By_TRIP_ID ( Int32? TRIP_ID);
List<Social_media_links> Get_Social_media_links_By_OWNER_ID ( Int32? OWNER_ID);
List<Contact> Get_Contact_By_PERSON_ID ( long? PERSON_ID);
List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT);
List<Contact> Get_Contact_By_OWNER_ID ( Int32? OWNER_ID);
List<Uploaded_file> Get_Uploaded_file_By_OWNER_ID ( Int32? OWNER_ID);
List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY ( string REL_ENTITY);
List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY_REL_KEY ( string REL_ENTITY, long? REL_KEY);
List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD ( string REL_ENTITY, long? REL_KEY, string REL_FIELD);
List<Loc_l1> Get_Loc_l1_By_CODE ( string CODE);
List<Loc_l1> Get_Loc_l1_By_OWNER_ID ( Int32? OWNER_ID);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE ( long? LOC_L1_ID, string CODE);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID ( long? LOC_L1_ID);
List<Loc_l2> Get_Loc_l2_By_OWNER_ID ( Int32? OWNER_ID);
List<Reservation_query> Get_Reservation_query_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE_Adv ( long? LOC_L2_ID, string CODE);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_Adv ( long? LOC_L2_ID);
List<Loc_l3> Get_Loc_l3_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Review> Get_Review_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Trip> Get_Trip_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE_Adv ( long? LOC_L3_ID, string CODE);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_Adv ( long? LOC_L3_ID);
List<Loc_l4> Get_Loc_l4_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Address> Get_Address_By_PERSON_ID_Adv ( long? PERSON_ID);
List<Address> Get_Address_By_LOC_L1_ID_Adv ( long? LOC_L1_ID);
List<Address> Get_Address_By_LOC_L2_ID_Adv ( long? LOC_L2_ID);
List<Address> Get_Address_By_LOC_L3_ID_Adv ( long? LOC_L3_ID);
List<Address> Get_Address_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv ( long? PERSON_ID, string ADDRESS_TYPE_CODE);
List<Address> Get_Address_By_LOC_L4_ID_Adv ( long? LOC_L4_ID);
List<Features> Get_Features_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Features> Get_Features_By_TRIP_ID_Adv ( Int32? TRIP_ID);
List<User> Get_User_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<User> Get_User_By_USERNAME_Adv ( string USERNAME);
List<Includes> Get_Includes_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Includes> Get_Includes_By_TRIP_ID_Adv ( Int32? TRIP_ID);
List<Staff> Get_Staff_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Person> Get_Person_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Tags> Get_Tags_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Tags> Get_Tags_By_TRIP_ID_Adv ( Int32? TRIP_ID);
List<Social_media_links> Get_Social_media_links_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Contact> Get_Contact_By_PERSON_ID_Adv ( long? PERSON_ID);
List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT);
List<Contact> Get_Contact_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Loc_l1> Get_Loc_l1_By_CODE_Adv ( string CODE);
List<Loc_l1> Get_Loc_l1_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE_Adv ( long? LOC_L1_ID, string CODE);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_Adv ( long? LOC_L1_ID);
List<Loc_l2> Get_Loc_l2_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST);
List<Address> Get_Address_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST);
List<Address> Get_Address_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST);
List<Address> Get_Address_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST);
List<Address> Get_Address_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST);
List<Address> Get_Address_By_LOC_L4_ID_List ( List<long?> LOC_L4_ID_LIST);
List<Features> Get_Features_By_TRIP_ID_List ( List<Int32?> TRIP_ID_LIST);
List<Includes> Get_Includes_By_TRIP_ID_List ( List<Int32?> TRIP_ID_LIST);
List<Tags> Get_Tags_By_TRIP_ID_List ( List<Int32?> TRIP_ID_LIST);
List<Contact> Get_Contact_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST);
List<Address> Get_Address_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST);
List<Address> Get_Address_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST);
List<Address> Get_Address_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST);
List<Address> Get_Address_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST);
List<Address> Get_Address_By_LOC_L4_ID_List_Adv ( List<long?> LOC_L4_ID_LIST);
List<Features> Get_Features_By_TRIP_ID_List_Adv ( List<Int32?> TRIP_ID_LIST);
List<Includes> Get_Includes_By_TRIP_ID_List_Adv ( List<Int32?> TRIP_ID_LIST);
List<Tags> Get_Tags_By_TRIP_ID_List_Adv ( List<Int32?> TRIP_ID_LIST);
List<Contact> Get_Contact_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST);
List<Reservation_query> Get_Reservation_query_By_Criteria ( string PICK_UP_ADDRESS, string TRIP_DATE, string QUERY_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Reservation_query> Get_Reservation_query_By_Where ( string PICK_UP_ADDRESS, string TRIP_DATE, string QUERY_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Review> Get_Review_By_Criteria ( string TITLE, string REVIEW_TEXT, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Review> Get_Review_By_Where ( string TITLE, string REVIEW_TEXT, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Trip> Get_Trip_By_Criteria ( string TITLE, string SUB_TITLE, string DETAILS, string CITY, string PRICE, string DISCOUNT_PRICE, string VIDEO_URL, string OFFER_HIGHLIGHT_TEXT, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Trip> Get_Trip_By_Where ( string TITLE, string SUB_TITLE, string DETAILS, string CITY, string PRICE, string DISCOUNT_PRICE, string VIDEO_URL, string OFFER_HIGHLIGHT_TEXT, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Criteria_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Where_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Features> Get_Features_By_Criteria ( string TITLE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Features> Get_Features_By_Where ( string TITLE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Criteria ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Where ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Includes> Get_Includes_By_Criteria ( string TITLE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Includes> Get_Includes_By_Where ( string TITLE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Criteria ( string TITLE, string DESCRIPTION, string EMAIL, string PHONE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Where ( string TITLE, string DESCRIPTION, string EMAIL, string PHONE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Criteria ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Where ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Criteria_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Where_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Tags> Get_Tags_By_Criteria ( string TAG, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Tags> Get_Tags_By_Where ( string TAG, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Social_media_links> Get_Social_media_links_By_Criteria ( string TITLE, string URL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Social_media_links> Get_Social_media_links_By_Where ( string TITLE, string URL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Criteria ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Where ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Uploaded_file> Get_Uploaded_file_By_Criteria ( string REL_ENTITY, string REL_FIELD, string EXTENSION, string STAMP, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Uploaded_file> Get_Uploaded_file_By_Where ( string REL_ENTITY, string REL_FIELD, string EXTENSION, string STAMP, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l1> Get_Loc_l1_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l1> Get_Loc_l1_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Reservation_query> Get_Reservation_query_By_Criteria_Adv ( string PICK_UP_ADDRESS, string TRIP_DATE, string QUERY_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Reservation_query> Get_Reservation_query_By_Where_Adv ( string PICK_UP_ADDRESS, string TRIP_DATE, string QUERY_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Review> Get_Review_By_Criteria_Adv ( string TITLE, string REVIEW_TEXT, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Review> Get_Review_By_Where_Adv ( string TITLE, string REVIEW_TEXT, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Trip> Get_Trip_By_Criteria_Adv ( string TITLE, string SUB_TITLE, string DETAILS, string CITY, string PRICE, string DISCOUNT_PRICE, string VIDEO_URL, string OFFER_HIGHLIGHT_TEXT, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Trip> Get_Trip_By_Where_Adv ( string TITLE, string SUB_TITLE, string DETAILS, string CITY, string PRICE, string DISCOUNT_PRICE, string VIDEO_URL, string OFFER_HIGHLIGHT_TEXT, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Features> Get_Features_By_Criteria_Adv ( string TITLE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Features> Get_Features_By_Where_Adv ( string TITLE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Criteria_Adv ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Where_Adv ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Includes> Get_Includes_By_Criteria_Adv ( string TITLE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Includes> Get_Includes_By_Where_Adv ( string TITLE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Criteria_Adv ( string TITLE, string DESCRIPTION, string EMAIL, string PHONE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Where_Adv ( string TITLE, string DESCRIPTION, string EMAIL, string PHONE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Criteria_Adv ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Where_Adv ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Criteria_Adv_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Where_Adv_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Tags> Get_Tags_By_Criteria_Adv ( string TAG, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Tags> Get_Tags_By_Where_Adv ( string TAG, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Social_media_links> Get_Social_media_links_By_Criteria_Adv ( string TITLE, string URL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Social_media_links> Get_Social_media_links_By_Where_Adv ( string TITLE, string URL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Criteria_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Where_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l1> Get_Loc_l1_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l1> Get_Loc_l1_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_InList ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_InList ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_InList_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_InList_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Features> Get_Features_By_Criteria_InList ( string TITLE, string DESCRIPTION, List<Int32?> TRIP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Features> Get_Features_By_Where_InList ( string TITLE, string DESCRIPTION, List<Int32?> TRIP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Includes> Get_Includes_By_Criteria_InList ( string TITLE, string DESCRIPTION, List<Int32?> TRIP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Includes> Get_Includes_By_Where_InList ( string TITLE, string DESCRIPTION, List<Int32?> TRIP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Tags> Get_Tags_By_Criteria_InList ( string TAG, List<Int32?> TRIP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Tags> Get_Tags_By_Where_InList ( string TAG, List<Int32?> TRIP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Criteria_InList ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Where_InList ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_InList_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_InList_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_InList_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_InList_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Features> Get_Features_By_Criteria_InList_Adv ( string TITLE, string DESCRIPTION, List<Int32?> TRIP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Features> Get_Features_By_Where_InList_Adv ( string TITLE, string DESCRIPTION, List<Int32?> TRIP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Includes> Get_Includes_By_Criteria_InList_Adv ( string TITLE, string DESCRIPTION, List<Int32?> TRIP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Includes> Get_Includes_By_Where_InList_Adv ( string TITLE, string DESCRIPTION, List<Int32?> TRIP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Tags> Get_Tags_By_Criteria_InList_Adv ( string TAG, List<Int32?> TRIP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Tags> Get_Tags_By_Where_InList_Adv ( string TAG, List<Int32?> TRIP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Criteria_InList_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Where_InList_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
void Delete_Reservation_query ( long? RESERVATION_QUERY_ID);
void Delete_Loc_l3 ( long? LOC_L3_ID);
void Delete_Review ( Int32? REVIEW_ID);
void Delete_Trip ( Int32? TRIP_ID);
void Delete_Loc_l4 ( long? LOC_L4_ID);
void Delete_Address ( long? ADDRESS_ID);
void Delete_Owner ( Int32? OWNER_ID);
void Delete_Features ( Int32? FEATURES_ID);
void Delete_User ( long? USER_ID);
void Delete_Includes ( Int32? INCLUDES_ID);
void Delete_Staff ( Int32? STAFF_ID);
void Delete_Person ( long? PERSON_ID);
void Delete_Tags ( long? TAGS_ID);
void Delete_Social_media_links ( Int32? SOCIAL_MEDIA_LINKS_ID);
void Delete_Contact ( Int32? CONTACT_ID);
void Delete_Uploaded_file ( long? UPLOADED_FILE_ID);
void Delete_Loc_l1 ( long? LOC_L1_ID);
void Delete_Loc_l2 ( long? LOC_L2_ID);
void Delete_Reservation_query_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Loc_l3_By_LOC_L2_ID_CODE ( long? LOC_L2_ID, string CODE);
void Delete_Loc_l3_By_LOC_L2_ID ( long? LOC_L2_ID);
void Delete_Loc_l3_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Review_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Trip_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Loc_l4_By_LOC_L3_ID_CODE ( long? LOC_L3_ID, string CODE);
void Delete_Loc_l4_By_LOC_L3_ID ( long? LOC_L3_ID);
void Delete_Loc_l4_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Address_By_PERSON_ID ( long? PERSON_ID);
void Delete_Address_By_LOC_L1_ID ( long? LOC_L1_ID);
void Delete_Address_By_LOC_L2_ID ( long? LOC_L2_ID);
void Delete_Address_By_LOC_L3_ID ( long? LOC_L3_ID);
void Delete_Address_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE ( long? PERSON_ID, string ADDRESS_TYPE_CODE);
void Delete_Address_By_LOC_L4_ID ( long? LOC_L4_ID);
void Delete_Features_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Features_By_TRIP_ID ( Int32? TRIP_ID);
void Delete_User_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_User_By_USERNAME ( string USERNAME);
void Delete_Includes_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Includes_By_TRIP_ID ( Int32? TRIP_ID);
void Delete_Staff_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Person_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Tags_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Tags_By_TRIP_ID ( Int32? TRIP_ID);
void Delete_Social_media_links_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Contact_By_PERSON_ID ( long? PERSON_ID);
void Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT);
void Delete_Contact_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Uploaded_file_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Uploaded_file_By_REL_ENTITY ( string REL_ENTITY);
void Delete_Uploaded_file_By_REL_ENTITY_REL_KEY ( string REL_ENTITY, long? REL_KEY);
void Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD ( string REL_ENTITY, long? REL_KEY, string REL_FIELD);
void Delete_Loc_l1_By_CODE ( string CODE);
void Delete_Loc_l1_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Loc_l2_By_LOC_L1_ID_CODE ( long? LOC_L1_ID, string CODE);
void Delete_Loc_l2_By_LOC_L1_ID ( long? LOC_L1_ID);
void Delete_Loc_l2_By_OWNER_ID ( Int32? OWNER_ID);
long? Edit_Reservation_query ( long? RESERVATION_QUERY_ID, Int32? NB_OF_ADULTS, Int32? NB_OF_CHILDREN, string PICK_UP_ADDRESS, string TRIP_DATE, string QUERY_DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
long? Edit_Loc_l3 ( long? LOC_L3_ID, string CODE, string DESCRIPTION, long? LOC_L2_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID);
Int32? Edit_Review ( Int32? REVIEW_ID, string TITLE, string REVIEW_TEXT, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Trip ( Int32? TRIP_ID, string TITLE, string SUB_TITLE, string DETAILS, string CITY, string PRICE, string DISCOUNT_PRICE, string VIDEO_URL, bool? IS_AVAILABLE_OR_COMING_SOON, string OFFER_HIGHLIGHT_TEXT, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
long? Edit_Loc_l4 ( long? LOC_L4_ID, string CODE, string DESCRIPTION, long? LOC_L3_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID);
long? Edit_Address ( long? ADDRESS_ID, long? PERSON_ID, string ADDRESS_TYPE_CODE, long? LOC_L1_ID, long? LOC_L2_ID, long? LOC_L3_ID, long? LOC_L4_ID, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID);
Int32? Edit_Owner ( Int32? OWNER_ID, string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, string ENTRY_DATE);
Int32? Edit_Features ( Int32? FEATURES_ID, Int32? TRIP_ID, string TITLE, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
long? Edit_User ( long? USER_ID, Int32? OWNER_ID, string USERNAME, string PASSWORD, string USER_TYPE_CODE, bool? IS_ACTIVE, string ENTRY_DATE);
Int32? Edit_Includes ( Int32? INCLUDES_ID, Int32? TRIP_ID, string TITLE, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Staff ( Int32? STAFF_ID, string TITLE, string DESCRIPTION, string EMAIL, string PHONE, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
long? Edit_Person ( long? PERSON_ID, string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, bool? IS_BLOCKED, string DESCRIPTION, Int32? OWNER_ID, long? ENTRY_USER_ID, string ENTRY_DATE);
long? Edit_Tags ( long? TAGS_ID, Int32? TRIP_ID, string TAG, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Social_media_links ( Int32? SOCIAL_MEDIA_LINKS_ID, string TITLE, string URL, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Contact ( Int32? CONTACT_ID, long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
long? Edit_Uploaded_file ( long? UPLOADED_FILE_ID, string REL_ENTITY, long? REL_KEY, string REL_FIELD, Int32? SIZE, string EXTENSION, string STAMP, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
long? Edit_Loc_l1 ( long? LOC_L1_ID, string CODE, string DESCRIPTION, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID);
long? Edit_Loc_l2 ( long? LOC_L2_ID, string CODE, string DESCRIPTION, long? LOC_L1_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID);
List<dynamic> GET_DISTINCT_SETUP_TBL ( Int32? OWNER_ID);
List<dynamic> GET_NEXT_VALUE ( string STARTER_CODE);
List<dynamic> GET_TBL_SETUP ();
List<dynamic> UP_BULK_UPSERT_ADDRESS ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_CONTACT ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_FEATURES ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_INCLUDES ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_LOC_L1 ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_LOC_L2 ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_LOC_L3 ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_LOC_L4 ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_OWNER ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_PERSON ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_RESERVATION_QUERY ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_REVIEW ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_SOCIAL_MEDIA_LINKS ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_STAFF ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_TAGS ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_TRIP ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_UPLOADED_FILE ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_USER ( string JSON_CONTENT);
List<dynamic> UP_CHECK_USER_EXISTENCE ( Int32? OWNER_ID, string USERNAME,ref  bool? EXISTS);
List<dynamic> UP_EDIT_SETUP ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME, bool? ISSYSTEM, bool? ISDELETEABLE, bool? ISUPDATEABLE, bool? ISVISIBLE, bool? ISDELETED, Int32? DISPLAY_ORDER, string CODE_VALUE_EN, string CODE_VALUE_FR, string CODE_VALUE_AR, string ENTRY_DATE, long? ENTRY_USER_ID, string NOTES);
List<dynamic> UP_EXTRACT_ROUTINE_PARAMETERS ( string ROUTINE_NAME);
List<dynamic> UP_EXTRACT_ROUTINE_RESULT_SCHEMA ( string ROUTINE_NAME);
List<dynamic> UP_GENERATE_INSERT_STATEMENTS ( string @tableName);
List<dynamic> UP_GET_NEXT_VALUE ( string STARTER_CODE,ref  long? VALUE);
List<dynamic> UP_GET_SETUP_ENTRIES ( Int32? OWNER_ID, string TBL_NAME, bool? ISDELETED, bool? ISVISIBLE);
List<dynamic> UP_GET_SETUP_ENTRY ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME);
List<dynamic> UP_GET_USER_BY_CREDENTIALS ( Int32? OWNER_ID, string USERNAME, string PASSWORD);
}
}
