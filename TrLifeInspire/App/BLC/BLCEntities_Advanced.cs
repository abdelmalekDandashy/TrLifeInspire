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
#region Reservation_query
public partial class Reservation_query
{
#region Advanced Properties
#endregion
}
#endregion
#region Loc_l3
public partial class Loc_l3
{
#region Advanced Properties
public Loc_l2 My_Loc_l2 {get;set;}
#endregion
}
#endregion
#region Review
public partial class Review
{
#region Advanced Properties
#endregion
}
#endregion
#region Trip
public partial class Trip
{
#region Advanced Properties
#endregion
}
#endregion
#region Loc_l4
public partial class Loc_l4
{
#region Advanced Properties
public Loc_l3 My_Loc_l3 {get;set;}
#endregion
}
#endregion
#region Address
public partial class Address
{
#region Advanced Properties
public Person My_Person {get;set;}
public Loc_l1 My_Loc_l1 {get;set;}
public Loc_l2 My_Loc_l2 {get;set;}
public Loc_l3 My_Loc_l3 {get;set;}
public Loc_l4 My_Loc_l4 {get;set;}
#endregion
}
#endregion
#region Owner
public partial class Owner
{
#region Advanced Properties
#endregion
}
#endregion
#region Features
public partial class Features
{
#region Advanced Properties
public Trip My_Trip {get;set;}
#endregion
}
#endregion
#region User
public partial class User
{
#region Advanced Properties
#endregion
}
#endregion
#region Includes
public partial class Includes
{
#region Advanced Properties
public Trip My_Trip {get;set;}
#endregion
}
#endregion
#region Staff
public partial class Staff
{
#region Advanced Properties
#endregion
}
#endregion
#region Person
public partial class Person
{
#region Advanced Properties
#endregion
}
#endregion
#region Tags
public partial class Tags
{
#region Advanced Properties
public Trip My_Trip {get;set;}
#endregion
}
#endregion
#region Social_media_links
public partial class Social_media_links
{
#region Advanced Properties
#endregion
}
#endregion
#region Contact
public partial class Contact
{
#region Advanced Properties
public Person My_Person {get;set;}
#endregion
}
#endregion
#region Uploaded_file
public partial class Uploaded_file
{
#region Advanced Properties
#endregion
}
#endregion
#region Loc_l1
public partial class Loc_l1
{
#region Advanced Properties
#endregion
}
#endregion
#region Loc_l2
public partial class Loc_l2
{
#region Advanced Properties
public Loc_l1 My_Loc_l1 {get;set;}
#endregion
}
#endregion
}
