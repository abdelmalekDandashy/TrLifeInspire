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
#region Params_Get_Address_By_ADDRESS_ID
public partial class Params_Get_Address_By_ADDRESS_ID
{
#region Properties
public long? ADDRESS_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Contact_By_CONTACT_ID
public partial class Params_Get_Contact_By_CONTACT_ID
{
#region Properties
public Int32? CONTACT_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Features_By_FEATURES_ID
public partial class Params_Get_Features_By_FEATURES_ID
{
#region Properties
public Int32? FEATURES_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Includes_By_INCLUDES_ID
public partial class Params_Get_Includes_By_INCLUDES_ID
{
#region Properties
public Int32? INCLUDES_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Loc_l1_By_LOC_L1_ID
public partial class Params_Get_Loc_l1_By_LOC_L1_ID
{
#region Properties
public long? LOC_L1_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Loc_l2_By_LOC_L2_ID
public partial class Params_Get_Loc_l2_By_LOC_L2_ID
{
#region Properties
public long? LOC_L2_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Loc_l3_By_LOC_L3_ID
public partial class Params_Get_Loc_l3_By_LOC_L3_ID
{
#region Properties
public long? LOC_L3_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Loc_l4_By_LOC_L4_ID
public partial class Params_Get_Loc_l4_By_LOC_L4_ID
{
#region Properties
public long? LOC_L4_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Owner_By_OWNER_ID
public partial class Params_Get_Owner_By_OWNER_ID
{
#region Properties
public Int32? OWNER_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Person_By_PERSON_ID
public partial class Params_Get_Person_By_PERSON_ID
{
#region Properties
public long? PERSON_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Reservation_query_By_RESERVATION_QUERY_ID
public partial class Params_Get_Reservation_query_By_RESERVATION_QUERY_ID
{
#region Properties
public long? RESERVATION_QUERY_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Review_By_REVIEW_ID
public partial class Params_Get_Review_By_REVIEW_ID
{
#region Properties
public Int32? REVIEW_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID
public partial class Params_Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID
{
#region Properties
public Int32? SOCIAL_MEDIA_LINKS_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Staff_By_STAFF_ID
public partial class Params_Get_Staff_By_STAFF_ID
{
#region Properties
public Int32? STAFF_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Tags_By_TAGS_ID
public partial class Params_Get_Tags_By_TAGS_ID
{
#region Properties
public long? TAGS_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Trip_By_TRIP_ID
public partial class Params_Get_Trip_By_TRIP_ID
{
#region Properties
public Int32? TRIP_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Uploaded_file_By_UPLOADED_FILE_ID
public partial class Params_Get_Uploaded_file_By_UPLOADED_FILE_ID
{
#region Properties
public long? UPLOADED_FILE_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_User_By_USER_ID
public partial class Params_Get_User_By_USER_ID
{
#region Properties
public long? USER_ID {get;set;}

#endregion
}
#endregion
public partial class Params_Get_Address_By_ADDRESS_ID_List
{
public List<long?> ADDRESS_ID_LIST {get;set;}
}
public partial class Params_Get_Address_By_ADDRESS_ID_List_SP
{
public string ADDRESS_ID_LIST {get;set;}

}
public partial class Params_Get_Contact_By_CONTACT_ID_List
{
public List<Int32?> CONTACT_ID_LIST {get;set;}
}
public partial class Params_Get_Contact_By_CONTACT_ID_List_SP
{
public string CONTACT_ID_LIST {get;set;}

}
public partial class Params_Get_Features_By_FEATURES_ID_List
{
public List<Int32?> FEATURES_ID_LIST {get;set;}
}
public partial class Params_Get_Features_By_FEATURES_ID_List_SP
{
public string FEATURES_ID_LIST {get;set;}

}
public partial class Params_Get_Includes_By_INCLUDES_ID_List
{
public List<Int32?> INCLUDES_ID_LIST {get;set;}
}
public partial class Params_Get_Includes_By_INCLUDES_ID_List_SP
{
public string INCLUDES_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l1_By_LOC_L1_ID_List
{
public List<long?> LOC_L1_ID_LIST {get;set;}
}
public partial class Params_Get_Loc_l1_By_LOC_L1_ID_List_SP
{
public string LOC_L1_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l2_By_LOC_L2_ID_List
{
public List<long?> LOC_L2_ID_LIST {get;set;}
}
public partial class Params_Get_Loc_l2_By_LOC_L2_ID_List_SP
{
public string LOC_L2_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l3_By_LOC_L3_ID_List
{
public List<long?> LOC_L3_ID_LIST {get;set;}
}
public partial class Params_Get_Loc_l3_By_LOC_L3_ID_List_SP
{
public string LOC_L3_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l4_By_LOC_L4_ID_List
{
public List<long?> LOC_L4_ID_LIST {get;set;}
}
public partial class Params_Get_Loc_l4_By_LOC_L4_ID_List_SP
{
public string LOC_L4_ID_LIST {get;set;}

}
public partial class Params_Get_Owner_By_OWNER_ID_List
{
public List<Int32?> OWNER_ID_LIST {get;set;}
}
public partial class Params_Get_Owner_By_OWNER_ID_List_SP
{
public string OWNER_ID_LIST {get;set;}

}
public partial class Params_Get_Person_By_PERSON_ID_List
{
public List<long?> PERSON_ID_LIST {get;set;}
}
public partial class Params_Get_Person_By_PERSON_ID_List_SP
{
public string PERSON_ID_LIST {get;set;}

}
public partial class Params_Get_Reservation_query_By_RESERVATION_QUERY_ID_List
{
public List<long?> RESERVATION_QUERY_ID_LIST {get;set;}
}
public partial class Params_Get_Reservation_query_By_RESERVATION_QUERY_ID_List_SP
{
public string RESERVATION_QUERY_ID_LIST {get;set;}

}
public partial class Params_Get_Review_By_REVIEW_ID_List
{
public List<Int32?> REVIEW_ID_LIST {get;set;}
}
public partial class Params_Get_Review_By_REVIEW_ID_List_SP
{
public string REVIEW_ID_LIST {get;set;}

}
public partial class Params_Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID_List
{
public List<Int32?> SOCIAL_MEDIA_LINKS_ID_LIST {get;set;}
}
public partial class Params_Get_Social_media_links_By_SOCIAL_MEDIA_LINKS_ID_List_SP
{
public string SOCIAL_MEDIA_LINKS_ID_LIST {get;set;}

}
public partial class Params_Get_Staff_By_STAFF_ID_List
{
public List<Int32?> STAFF_ID_LIST {get;set;}
}
public partial class Params_Get_Staff_By_STAFF_ID_List_SP
{
public string STAFF_ID_LIST {get;set;}

}
public partial class Params_Get_Tags_By_TAGS_ID_List
{
public List<long?> TAGS_ID_LIST {get;set;}
}
public partial class Params_Get_Tags_By_TAGS_ID_List_SP
{
public string TAGS_ID_LIST {get;set;}

}
public partial class Params_Get_Trip_By_TRIP_ID_List
{
public List<Int32?> TRIP_ID_LIST {get;set;}
}
public partial class Params_Get_Trip_By_TRIP_ID_List_SP
{
public string TRIP_ID_LIST {get;set;}

}
public partial class Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List
{
public List<long?> UPLOADED_FILE_ID_LIST {get;set;}
}
public partial class Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List_SP
{
public string UPLOADED_FILE_ID_LIST {get;set;}

}
public partial class Params_Get_User_By_USER_ID_List
{
public List<long?> USER_ID_LIST {get;set;}
}
public partial class Params_Get_User_By_USER_ID_List_SP
{
public string USER_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_PERSON_ID
{
public long? PERSON_ID {get;set;}

}
public partial class Params_Get_Address_By_LOC_L1_ID
{
public long? LOC_L1_ID {get;set;}

}
public partial class Params_Get_Address_By_LOC_L2_ID
{
public long? LOC_L2_ID {get;set;}

}
public partial class Params_Get_Address_By_LOC_L3_ID
{
public long? LOC_L3_ID {get;set;}

}
public partial class Params_Get_Address_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE
{
public long? PERSON_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}

}
public partial class Params_Get_Address_By_LOC_L4_ID
{
public long? LOC_L4_ID {get;set;}

}
public partial class Params_Get_Contact_By_PERSON_ID
{
public long? PERSON_ID {get;set;}

}
public partial class Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT
{
public long? PERSON_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}

}
public partial class Params_Get_Contact_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Features_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Features_By_TRIP_ID
{
public Int32? TRIP_ID {get;set;}

}
public partial class Params_Get_Includes_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Includes_By_TRIP_ID
{
public Int32? TRIP_ID {get;set;}

}
public partial class Params_Get_Loc_l1_By_CODE
{
public string CODE {get;set;}

}
public partial class Params_Get_Loc_l1_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Loc_l2_By_LOC_L1_ID_CODE
{
public long? LOC_L1_ID {get;set;}
public string CODE {get;set;}

}
public partial class Params_Get_Loc_l2_By_LOC_L1_ID
{
public long? LOC_L1_ID {get;set;}

}
public partial class Params_Get_Loc_l2_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Loc_l3_By_LOC_L2_ID_CODE
{
public long? LOC_L2_ID {get;set;}
public string CODE {get;set;}

}
public partial class Params_Get_Loc_l3_By_LOC_L2_ID
{
public long? LOC_L2_ID {get;set;}

}
public partial class Params_Get_Loc_l3_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Loc_l4_By_LOC_L3_ID_CODE
{
public long? LOC_L3_ID {get;set;}
public string CODE {get;set;}

}
public partial class Params_Get_Loc_l4_By_LOC_L3_ID
{
public long? LOC_L3_ID {get;set;}

}
public partial class Params_Get_Loc_l4_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Person_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Reservation_query_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Review_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Social_media_links_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Staff_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Tags_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Tags_By_TRIP_ID
{
public Int32? TRIP_ID {get;set;}

}
public partial class Params_Get_Trip_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Uploaded_file_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Uploaded_file_By_REL_ENTITY
{
public string REL_ENTITY {get;set;}

}
public partial class Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY
{
public string REL_ENTITY {get;set;}
public long? REL_KEY {get;set;}

}
public partial class Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD
{
public string REL_ENTITY {get;set;}
public long? REL_KEY {get;set;}
public string REL_FIELD {get;set;}

}
public partial class Params_Get_User_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_User_By_USERNAME
{
public string USERNAME {get;set;}

}
public partial class Params_Get_Address_By_PERSON_ID_List
{
public List<long?> PERSON_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_LOC_L1_ID_List
{
public List<long?> LOC_L1_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_LOC_L2_ID_List
{
public List<long?> LOC_L2_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_LOC_L3_ID_List
{
public List<long?> LOC_L3_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_LOC_L4_ID_List
{
public List<long?> LOC_L4_ID_LIST {get;set;}

}
public partial class Params_Get_Contact_By_PERSON_ID_List
{
public List<long?> PERSON_ID_LIST {get;set;}

}
public partial class Params_Get_Features_By_TRIP_ID_List
{
public List<Int32?> TRIP_ID_LIST {get;set;}

}
public partial class Params_Get_Includes_By_TRIP_ID_List
{
public List<Int32?> TRIP_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l2_By_LOC_L1_ID_List
{
public List<long?> LOC_L1_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l3_By_LOC_L2_ID_List
{
public List<long?> LOC_L2_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l4_By_LOC_L3_ID_List
{
public List<long?> LOC_L3_ID_LIST {get;set;}

}
public partial class Params_Get_Tags_By_TRIP_ID_List
{
public List<Int32?> TRIP_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Features_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string TITLE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Features_By_Where
{

public Int32? OWNER_ID {get;set;}
public string TITLE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Includes_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string TITLE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Includes_By_Where
{

public Int32? OWNER_ID {get;set;}
public string TITLE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l1_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l1_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Person_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string FATHER_NAME {get;set;}
public string MOTHER_NAME {get;set;}
public string TITLE_CODE {get;set;}
public string GENDER_CODE {get;set;}
public string RELIGION_CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Person_By_Where
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string FATHER_NAME {get;set;}
public string MOTHER_NAME {get;set;}
public string TITLE_CODE {get;set;}
public string GENDER_CODE {get;set;}
public string RELIGION_CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Person_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string FATHER_NAME {get;set;}
public string MOTHER_NAME {get;set;}
public string TITLE_CODE {get;set;}
public string GENDER_CODE {get;set;}
public string RELIGION_CODE {get;set;}
public string BIRTH_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Person_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string FATHER_NAME {get;set;}
public string MOTHER_NAME {get;set;}
public string TITLE_CODE {get;set;}
public string GENDER_CODE {get;set;}
public string RELIGION_CODE {get;set;}
public string BIRTH_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Reservation_query_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string PICK_UP_ADDRESS {get;set;}
public string TRIP_DATE {get;set;}
public string QUERY_DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Reservation_query_By_Where
{

public Int32? OWNER_ID {get;set;}
public string PICK_UP_ADDRESS {get;set;}
public string TRIP_DATE {get;set;}
public string QUERY_DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Review_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string TITLE {get;set;}
public string REVIEW_TEXT {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Review_By_Where
{

public Int32? OWNER_ID {get;set;}
public string TITLE {get;set;}
public string REVIEW_TEXT {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Social_media_links_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string TITLE {get;set;}
public string URL {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Social_media_links_By_Where
{

public Int32? OWNER_ID {get;set;}
public string TITLE {get;set;}
public string URL {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Staff_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string TITLE {get;set;}
public string DESCRIPTION {get;set;}
public string EMAIL {get;set;}
public string PHONE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Staff_By_Where
{

public Int32? OWNER_ID {get;set;}
public string TITLE {get;set;}
public string DESCRIPTION {get;set;}
public string EMAIL {get;set;}
public string PHONE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Tags_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string TAG {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Tags_By_Where
{

public Int32? OWNER_ID {get;set;}
public string TAG {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Trip_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string TITLE {get;set;}
public string SUB_TITLE {get;set;}
public string DETAILS {get;set;}
public string CITY {get;set;}
public string PRICE {get;set;}
public string DISCOUNT_PRICE {get;set;}
public string VIDEO_URL {get;set;}
public string OFFER_HIGHLIGHT_TEXT {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Trip_By_Where
{

public Int32? OWNER_ID {get;set;}
public string TITLE {get;set;}
public string SUB_TITLE {get;set;}
public string DETAILS {get;set;}
public string CITY {get;set;}
public string PRICE {get;set;}
public string DISCOUNT_PRICE {get;set;}
public string VIDEO_URL {get;set;}
public string OFFER_HIGHLIGHT_TEXT {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Uploaded_file_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string REL_ENTITY {get;set;}
public string REL_FIELD {get;set;}
public string EXTENSION {get;set;}
public string STAMP {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Uploaded_file_By_Where
{

public Int32? OWNER_ID {get;set;}
public string REL_ENTITY {get;set;}
public string REL_FIELD {get;set;}
public string EXTENSION {get;set;}
public string STAMP {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string USER_TYPE_CODE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_By_Where
{

public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string USER_TYPE_CODE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public List<long?> LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string PERSON_ID_LIST {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public string LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public List<long?> LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string PERSON_ID_LIST {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public string LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Criteria_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public List<long?> LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Criteria_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public string PERSON_ID_LIST {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public string LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public List<long?> LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public string PERSON_ID_LIST {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public string LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public string PERSON_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public string PERSON_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Features_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string TITLE {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> TRIP_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Features_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string TITLE {get;set;}
public string DESCRIPTION {get;set;}
public string TRIP_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Features_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string TITLE {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> TRIP_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Features_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string TITLE {get;set;}
public string DESCRIPTION {get;set;}
public string TRIP_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Includes_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string TITLE {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> TRIP_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Includes_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string TITLE {get;set;}
public string DESCRIPTION {get;set;}
public string TRIP_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Includes_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string TITLE {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> TRIP_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Includes_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string TITLE {get;set;}
public string DESCRIPTION {get;set;}
public string TRIP_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Tags_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string TAG {get;set;}
public List<Int32?> TRIP_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Tags_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string TAG {get;set;}
public string TRIP_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Tags_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string TAG {get;set;}
public List<Int32?> TRIP_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Tags_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string TAG {get;set;}
public string TRIP_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
#region Params_Delete_Address
public partial class Params_Delete_Address
{
#region Properties
public long? ADDRESS_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Contact
public partial class Params_Delete_Contact
{
#region Properties
public Int32? CONTACT_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Features
public partial class Params_Delete_Features
{
#region Properties
public Int32? FEATURES_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Includes
public partial class Params_Delete_Includes
{
#region Properties
public Int32? INCLUDES_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Loc_l1
public partial class Params_Delete_Loc_l1
{
#region Properties
public long? LOC_L1_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Loc_l2
public partial class Params_Delete_Loc_l2
{
#region Properties
public long? LOC_L2_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Loc_l3
public partial class Params_Delete_Loc_l3
{
#region Properties
public long? LOC_L3_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Loc_l4
public partial class Params_Delete_Loc_l4
{
#region Properties
public long? LOC_L4_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Owner
public partial class Params_Delete_Owner
{
#region Properties
public Int32? OWNER_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Person
public partial class Params_Delete_Person
{
#region Properties
public long? PERSON_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Reservation_query
public partial class Params_Delete_Reservation_query
{
#region Properties
public long? RESERVATION_QUERY_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Review
public partial class Params_Delete_Review
{
#region Properties
public Int32? REVIEW_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Social_media_links
public partial class Params_Delete_Social_media_links
{
#region Properties
public Int32? SOCIAL_MEDIA_LINKS_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Staff
public partial class Params_Delete_Staff
{
#region Properties
public Int32? STAFF_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Tags
public partial class Params_Delete_Tags
{
#region Properties
public long? TAGS_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Trip
public partial class Params_Delete_Trip
{
#region Properties
public Int32? TRIP_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Uploaded_file
public partial class Params_Delete_Uploaded_file
{
#region Properties
public long? UPLOADED_FILE_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_User
public partial class Params_Delete_User
{
#region Properties
public long? USER_ID {get;set;}
#endregion
}
#endregion
public partial class Params_Delete_Address_By_PERSON_ID
{
public long? PERSON_ID {get;set;}
}
public partial class Params_Delete_Address_By_LOC_L1_ID
{
public long? LOC_L1_ID {get;set;}
}
public partial class Params_Delete_Address_By_LOC_L2_ID
{
public long? LOC_L2_ID {get;set;}
}
public partial class Params_Delete_Address_By_LOC_L3_ID
{
public long? LOC_L3_ID {get;set;}
}
public partial class Params_Delete_Address_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE
{
public long? PERSON_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
}
public partial class Params_Delete_Address_By_LOC_L4_ID
{
public long? LOC_L4_ID {get;set;}
}
public partial class Params_Delete_Contact_By_PERSON_ID
{
public long? PERSON_ID {get;set;}
}
public partial class Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT
{
public long? PERSON_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
}
public partial class Params_Delete_Contact_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Features_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Features_By_TRIP_ID
{
public Int32? TRIP_ID {get;set;}
}
public partial class Params_Delete_Includes_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Includes_By_TRIP_ID
{
public Int32? TRIP_ID {get;set;}
}
public partial class Params_Delete_Loc_l1_By_CODE
{
public string CODE {get;set;}
}
public partial class Params_Delete_Loc_l1_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Loc_l2_By_LOC_L1_ID_CODE
{
public long? LOC_L1_ID {get;set;}
public string CODE {get;set;}
}
public partial class Params_Delete_Loc_l2_By_LOC_L1_ID
{
public long? LOC_L1_ID {get;set;}
}
public partial class Params_Delete_Loc_l2_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Loc_l3_By_LOC_L2_ID_CODE
{
public long? LOC_L2_ID {get;set;}
public string CODE {get;set;}
}
public partial class Params_Delete_Loc_l3_By_LOC_L2_ID
{
public long? LOC_L2_ID {get;set;}
}
public partial class Params_Delete_Loc_l3_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Loc_l4_By_LOC_L3_ID_CODE
{
public long? LOC_L3_ID {get;set;}
public string CODE {get;set;}
}
public partial class Params_Delete_Loc_l4_By_LOC_L3_ID
{
public long? LOC_L3_ID {get;set;}
}
public partial class Params_Delete_Loc_l4_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Person_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Reservation_query_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Review_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Social_media_links_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Staff_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Tags_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Tags_By_TRIP_ID
{
public Int32? TRIP_ID {get;set;}
}
public partial class Params_Delete_Trip_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Uploaded_file_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Uploaded_file_By_REL_ENTITY
{
public string REL_ENTITY {get;set;}
}
public partial class Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY
{
public string REL_ENTITY {get;set;}
public long? REL_KEY {get;set;}
}
public partial class Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD
{
public string REL_ENTITY {get;set;}
public long? REL_KEY {get;set;}
public string REL_FIELD {get;set;}
}
public partial class Params_Delete_User_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_User_By_USERNAME
{
public string USERNAME {get;set;}
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
}
public partial class Owner
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public string ENTRY_DATE {get;set;}
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
public partial class Review
{
public Int32? REVIEW_ID {get;set;}
public string TITLE {get;set;}
public string REVIEW_TEXT {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
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
public partial class Tags
{
public long? TAGS_ID {get;set;}
public Int32? TRIP_ID {get;set;}
public string TAG {get;set;}
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
#region Params_Edit_Address_List
public partial class Params_Edit_Address_List
{
#region Properties
public List<Address> My_List_To_Edit { get; set; }
public List<Address> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Contact_List
public partial class Params_Edit_Contact_List
{
#region Properties
public List<Contact> My_List_To_Edit { get; set; }
public List<Contact> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Features_List
public partial class Params_Edit_Features_List
{
#region Properties
public List<Features> My_List_To_Edit { get; set; }
public List<Features> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Includes_List
public partial class Params_Edit_Includes_List
{
#region Properties
public List<Includes> My_List_To_Edit { get; set; }
public List<Includes> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Loc_l1_List
public partial class Params_Edit_Loc_l1_List
{
#region Properties
public List<Loc_l1> My_List_To_Edit { get; set; }
public List<Loc_l1> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Loc_l2_List
public partial class Params_Edit_Loc_l2_List
{
#region Properties
public List<Loc_l2> My_List_To_Edit { get; set; }
public List<Loc_l2> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Loc_l3_List
public partial class Params_Edit_Loc_l3_List
{
#region Properties
public List<Loc_l3> My_List_To_Edit { get; set; }
public List<Loc_l3> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Loc_l4_List
public partial class Params_Edit_Loc_l4_List
{
#region Properties
public List<Loc_l4> My_List_To_Edit { get; set; }
public List<Loc_l4> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Owner_List
public partial class Params_Edit_Owner_List
{
#region Properties
public List<Owner> My_List_To_Edit { get; set; }
public List<Owner> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Person_List
public partial class Params_Edit_Person_List
{
#region Properties
public List<Person> My_List_To_Edit { get; set; }
public List<Person> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Reservation_query_List
public partial class Params_Edit_Reservation_query_List
{
#region Properties
public List<Reservation_query> My_List_To_Edit { get; set; }
public List<Reservation_query> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Review_List
public partial class Params_Edit_Review_List
{
#region Properties
public List<Review> My_List_To_Edit { get; set; }
public List<Review> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Social_media_links_List
public partial class Params_Edit_Social_media_links_List
{
#region Properties
public List<Social_media_links> My_List_To_Edit { get; set; }
public List<Social_media_links> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Staff_List
public partial class Params_Edit_Staff_List
{
#region Properties
public List<Staff> My_List_To_Edit { get; set; }
public List<Staff> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Tags_List
public partial class Params_Edit_Tags_List
{
#region Properties
public List<Tags> My_List_To_Edit { get; set; }
public List<Tags> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Trip_List
public partial class Params_Edit_Trip_List
{
#region Properties
public List<Trip> My_List_To_Edit { get; set; }
public List<Trip> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Uploaded_file_List
public partial class Params_Edit_Uploaded_file_List
{
#region Properties
public List<Uploaded_file> My_List_To_Edit { get; set; }
public List<Uploaded_file> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_User_List
public partial class Params_Edit_User_List
{
#region Properties
public List<User> My_List_To_Edit { get; set; }
public List<User> My_List_To_Delete { get; set; }
#endregion
}
#endregion
}
