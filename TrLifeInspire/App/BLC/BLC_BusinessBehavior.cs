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
#region Reset_Address_By_Loc_l1
public void Reset_Address_By_Loc_l1(Loc_l1 i_Loc_l1, List<Address> i_Address_List)
{
#region Declaration And Initialization Section.
Params_Delete_Address_By_LOC_L1_ID oParams_Delete_Address_By_LOC_L1_ID = new Params_Delete_Address_By_LOC_L1_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l1");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Address
//---------------------------------
oParams_Delete_Address_By_LOC_L1_ID.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Delete_Address_By_LOC_L1_ID(oParams_Delete_Address_By_LOC_L1_ID);
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l1_WithAddress(i_Loc_l1, i_Address_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l1");}
}
#endregion
#region Reset_Address_By_Loc_l1
public void Reset_Address_By_Loc_l1(Loc_l1 i_Loc_l1, List<Address> i_Address_List_To_Delete,List<Address> i_Address_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Address oParams_Delete_Address = new Params_Delete_Address();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l1");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Address_List_To_Delete != null)
{
foreach (var oRow in i_Address_List_To_Delete)
{
oParams_Delete_Address.ADDRESS_ID = oRow.ADDRESS_ID;
Delete_Address(oParams_Delete_Address);
}
}
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l1_WithAddress(i_Loc_l1, i_Address_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l1");}
}
#endregion
#region Edit_Loc_l1_With_Address(Loc_l1 i_Loc_l1,List<Address> i_AddressList)
public void Edit_Loc_l1_WithAddress(Loc_l1 i_Loc_l1,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1_WithAddress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l1(i_Loc_l1);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1_WithAddress");}
}
#endregion
#region Reset_Loc_l2_By_Loc_l1
public void Reset_Loc_l2_By_Loc_l1(Loc_l1 i_Loc_l1, List<Loc_l2> i_Loc_l2_List)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l2_By_LOC_L1_ID oParams_Delete_Loc_l2_By_LOC_L1_ID = new Params_Delete_Loc_l2_By_LOC_L1_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l2_By_Loc_l1");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Loc_l2
//---------------------------------
oParams_Delete_Loc_l2_By_LOC_L1_ID.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Delete_Loc_l2_By_LOC_L1_ID(oParams_Delete_Loc_l2_By_LOC_L1_ID);
//---------------------------------
// Edit Loc_l2
//---------------------------------
Edit_Loc_l1_WithLoc_l2(i_Loc_l1, i_Loc_l2_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l2_By_Loc_l1");}
}
#endregion
#region Reset_Loc_l2_By_Loc_l1
public void Reset_Loc_l2_By_Loc_l1(Loc_l1 i_Loc_l1, List<Loc_l2> i_Loc_l2_List_To_Delete,List<Loc_l2> i_Loc_l2_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l2 oParams_Delete_Loc_l2 = new Params_Delete_Loc_l2();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l2_By_Loc_l1");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Loc_l2_List_To_Delete != null)
{
foreach (var oRow in i_Loc_l2_List_To_Delete)
{
oParams_Delete_Loc_l2.LOC_L2_ID = oRow.LOC_L2_ID;
Delete_Loc_l2(oParams_Delete_Loc_l2);
}
}
//---------------------------------
// Edit Loc_l2
//---------------------------------
Edit_Loc_l1_WithLoc_l2(i_Loc_l1, i_Loc_l2_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l2_By_Loc_l1");}
}
#endregion
#region Edit_Loc_l1_With_Loc_l2(Loc_l1 i_Loc_l1,List<Loc_l2> i_Loc_l2List)
public void Edit_Loc_l1_WithLoc_l2(Loc_l1 i_Loc_l1,List<Loc_l2> i_List_Loc_l2)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1_WithLoc_l2");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l1(i_Loc_l1);
if (i_List_Loc_l2 != null)
{
foreach(Loc_l2 oLoc_l2 in i_List_Loc_l2)
{
oLoc_l2.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Edit_Loc_l2(oLoc_l2);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1_WithLoc_l2");}
}
#endregion
#region Edit_Loc_l1_WithRelatedData(Loc_l1 i_Loc_l1,List<Address> i_List_Address,List<Loc_l2> i_List_Loc_l2)
public void Edit_Loc_l1_WithRelatedData(Loc_l1 i_Loc_l1,List<Address> i_List_Address,List<Loc_l2> i_List_Loc_l2)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l1(i_Loc_l1);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Edit_Address(oAddress);
}
}
if (i_List_Loc_l2 != null)
{
foreach(Loc_l2 oLoc_l2 in i_List_Loc_l2)
{
oLoc_l2.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Edit_Loc_l2(oLoc_l2);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1_WithRelatedData");}
}
#endregion
#region Delete_Loc_l1_With_Children(Loc_l1 i_Loc_l1)
public void Delete_Loc_l1_With_Children(Loc_l1 i_Loc_l1)
{
 #region Declaration And Initialization Section.
Params_Delete_Loc_l1 oParams_Delete_Loc_l1 = new Params_Delete_Loc_l1();
Params_Delete_Address_By_LOC_L1_ID oParams_Delete_Address_By_LOC_L1_ID = new Params_Delete_Address_By_LOC_L1_ID();
Params_Delete_Loc_l2_By_LOC_L1_ID oParams_Delete_Loc_l2_By_LOC_L1_ID = new Params_Delete_Loc_l2_By_LOC_L1_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l1_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Address_By_LOC_L1_ID.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Delete_Address_By_LOC_L1_ID(oParams_Delete_Address_By_LOC_L1_ID);
oParams_Delete_Loc_l2_By_LOC_L1_ID.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Delete_Loc_l2_By_LOC_L1_ID(oParams_Delete_Loc_l2_By_LOC_L1_ID);
//-------------------------

//-------------------------
oParams_Delete_Loc_l1.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Delete_Loc_l1(oParams_Delete_Loc_l1);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l1_With_Children");}
}
#endregion
#region Reset_Address_By_Loc_l2
public void Reset_Address_By_Loc_l2(Loc_l2 i_Loc_l2, List<Address> i_Address_List)
{
#region Declaration And Initialization Section.
Params_Delete_Address_By_LOC_L2_ID oParams_Delete_Address_By_LOC_L2_ID = new Params_Delete_Address_By_LOC_L2_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l2");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Address
//---------------------------------
oParams_Delete_Address_By_LOC_L2_ID.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Delete_Address_By_LOC_L2_ID(oParams_Delete_Address_By_LOC_L2_ID);
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l2_WithAddress(i_Loc_l2, i_Address_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l2");}
}
#endregion
#region Reset_Address_By_Loc_l2
public void Reset_Address_By_Loc_l2(Loc_l2 i_Loc_l2, List<Address> i_Address_List_To_Delete,List<Address> i_Address_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Address oParams_Delete_Address = new Params_Delete_Address();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l2");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Address_List_To_Delete != null)
{
foreach (var oRow in i_Address_List_To_Delete)
{
oParams_Delete_Address.ADDRESS_ID = oRow.ADDRESS_ID;
Delete_Address(oParams_Delete_Address);
}
}
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l2_WithAddress(i_Loc_l2, i_Address_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l2");}
}
#endregion
#region Edit_Loc_l2_With_Address(Loc_l2 i_Loc_l2,List<Address> i_AddressList)
public void Edit_Loc_l2_WithAddress(Loc_l2 i_Loc_l2,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2_WithAddress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l2(i_Loc_l2);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2_WithAddress");}
}
#endregion
#region Reset_Loc_l3_By_Loc_l2
public void Reset_Loc_l3_By_Loc_l2(Loc_l2 i_Loc_l2, List<Loc_l3> i_Loc_l3_List)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l3_By_LOC_L2_ID oParams_Delete_Loc_l3_By_LOC_L2_ID = new Params_Delete_Loc_l3_By_LOC_L2_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l3_By_Loc_l2");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Loc_l3
//---------------------------------
oParams_Delete_Loc_l3_By_LOC_L2_ID.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Delete_Loc_l3_By_LOC_L2_ID(oParams_Delete_Loc_l3_By_LOC_L2_ID);
//---------------------------------
// Edit Loc_l3
//---------------------------------
Edit_Loc_l2_WithLoc_l3(i_Loc_l2, i_Loc_l3_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l3_By_Loc_l2");}
}
#endregion
#region Reset_Loc_l3_By_Loc_l2
public void Reset_Loc_l3_By_Loc_l2(Loc_l2 i_Loc_l2, List<Loc_l3> i_Loc_l3_List_To_Delete,List<Loc_l3> i_Loc_l3_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l3 oParams_Delete_Loc_l3 = new Params_Delete_Loc_l3();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l3_By_Loc_l2");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Loc_l3_List_To_Delete != null)
{
foreach (var oRow in i_Loc_l3_List_To_Delete)
{
oParams_Delete_Loc_l3.LOC_L3_ID = oRow.LOC_L3_ID;
Delete_Loc_l3(oParams_Delete_Loc_l3);
}
}
//---------------------------------
// Edit Loc_l3
//---------------------------------
Edit_Loc_l2_WithLoc_l3(i_Loc_l2, i_Loc_l3_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l3_By_Loc_l2");}
}
#endregion
#region Edit_Loc_l2_With_Loc_l3(Loc_l2 i_Loc_l2,List<Loc_l3> i_Loc_l3List)
public void Edit_Loc_l2_WithLoc_l3(Loc_l2 i_Loc_l2,List<Loc_l3> i_List_Loc_l3)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2_WithLoc_l3");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l2(i_Loc_l2);
if (i_List_Loc_l3 != null)
{
foreach(Loc_l3 oLoc_l3 in i_List_Loc_l3)
{
oLoc_l3.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Edit_Loc_l3(oLoc_l3);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2_WithLoc_l3");}
}
#endregion
#region Edit_Loc_l2_WithRelatedData(Loc_l2 i_Loc_l2,List<Address> i_List_Address,List<Loc_l3> i_List_Loc_l3)
public void Edit_Loc_l2_WithRelatedData(Loc_l2 i_Loc_l2,List<Address> i_List_Address,List<Loc_l3> i_List_Loc_l3)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l2(i_Loc_l2);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Edit_Address(oAddress);
}
}
if (i_List_Loc_l3 != null)
{
foreach(Loc_l3 oLoc_l3 in i_List_Loc_l3)
{
oLoc_l3.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Edit_Loc_l3(oLoc_l3);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2_WithRelatedData");}
}
#endregion
#region Delete_Loc_l2_With_Children(Loc_l2 i_Loc_l2)
public void Delete_Loc_l2_With_Children(Loc_l2 i_Loc_l2)
{
 #region Declaration And Initialization Section.
Params_Delete_Loc_l2 oParams_Delete_Loc_l2 = new Params_Delete_Loc_l2();
Params_Delete_Address_By_LOC_L2_ID oParams_Delete_Address_By_LOC_L2_ID = new Params_Delete_Address_By_LOC_L2_ID();
Params_Delete_Loc_l3_By_LOC_L2_ID oParams_Delete_Loc_l3_By_LOC_L2_ID = new Params_Delete_Loc_l3_By_LOC_L2_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l2_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Address_By_LOC_L2_ID.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Delete_Address_By_LOC_L2_ID(oParams_Delete_Address_By_LOC_L2_ID);
oParams_Delete_Loc_l3_By_LOC_L2_ID.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Delete_Loc_l3_By_LOC_L2_ID(oParams_Delete_Loc_l3_By_LOC_L2_ID);
//-------------------------

//-------------------------
oParams_Delete_Loc_l2.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Delete_Loc_l2(oParams_Delete_Loc_l2);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l2_With_Children");}
}
#endregion
#region Reset_Address_By_Loc_l3
public void Reset_Address_By_Loc_l3(Loc_l3 i_Loc_l3, List<Address> i_Address_List)
{
#region Declaration And Initialization Section.
Params_Delete_Address_By_LOC_L3_ID oParams_Delete_Address_By_LOC_L3_ID = new Params_Delete_Address_By_LOC_L3_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l3");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Address
//---------------------------------
oParams_Delete_Address_By_LOC_L3_ID.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Delete_Address_By_LOC_L3_ID(oParams_Delete_Address_By_LOC_L3_ID);
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l3_WithAddress(i_Loc_l3, i_Address_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l3");}
}
#endregion
#region Reset_Address_By_Loc_l3
public void Reset_Address_By_Loc_l3(Loc_l3 i_Loc_l3, List<Address> i_Address_List_To_Delete,List<Address> i_Address_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Address oParams_Delete_Address = new Params_Delete_Address();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l3");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Address_List_To_Delete != null)
{
foreach (var oRow in i_Address_List_To_Delete)
{
oParams_Delete_Address.ADDRESS_ID = oRow.ADDRESS_ID;
Delete_Address(oParams_Delete_Address);
}
}
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l3_WithAddress(i_Loc_l3, i_Address_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l3");}
}
#endregion
#region Edit_Loc_l3_With_Address(Loc_l3 i_Loc_l3,List<Address> i_AddressList)
public void Edit_Loc_l3_WithAddress(Loc_l3 i_Loc_l3,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3_WithAddress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l3(i_Loc_l3);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3_WithAddress");}
}
#endregion
#region Reset_Loc_l4_By_Loc_l3
public void Reset_Loc_l4_By_Loc_l3(Loc_l3 i_Loc_l3, List<Loc_l4> i_Loc_l4_List)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l4_By_LOC_L3_ID oParams_Delete_Loc_l4_By_LOC_L3_ID = new Params_Delete_Loc_l4_By_LOC_L3_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l4_By_Loc_l3");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Loc_l4
//---------------------------------
oParams_Delete_Loc_l4_By_LOC_L3_ID.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Delete_Loc_l4_By_LOC_L3_ID(oParams_Delete_Loc_l4_By_LOC_L3_ID);
//---------------------------------
// Edit Loc_l4
//---------------------------------
Edit_Loc_l3_WithLoc_l4(i_Loc_l3, i_Loc_l4_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l4_By_Loc_l3");}
}
#endregion
#region Reset_Loc_l4_By_Loc_l3
public void Reset_Loc_l4_By_Loc_l3(Loc_l3 i_Loc_l3, List<Loc_l4> i_Loc_l4_List_To_Delete,List<Loc_l4> i_Loc_l4_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l4 oParams_Delete_Loc_l4 = new Params_Delete_Loc_l4();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l4_By_Loc_l3");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Loc_l4_List_To_Delete != null)
{
foreach (var oRow in i_Loc_l4_List_To_Delete)
{
oParams_Delete_Loc_l4.LOC_L4_ID = oRow.LOC_L4_ID;
Delete_Loc_l4(oParams_Delete_Loc_l4);
}
}
//---------------------------------
// Edit Loc_l4
//---------------------------------
Edit_Loc_l3_WithLoc_l4(i_Loc_l3, i_Loc_l4_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l4_By_Loc_l3");}
}
#endregion
#region Edit_Loc_l3_With_Loc_l4(Loc_l3 i_Loc_l3,List<Loc_l4> i_Loc_l4List)
public void Edit_Loc_l3_WithLoc_l4(Loc_l3 i_Loc_l3,List<Loc_l4> i_List_Loc_l4)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3_WithLoc_l4");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l3(i_Loc_l3);
if (i_List_Loc_l4 != null)
{
foreach(Loc_l4 oLoc_l4 in i_List_Loc_l4)
{
oLoc_l4.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Edit_Loc_l4(oLoc_l4);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3_WithLoc_l4");}
}
#endregion
#region Edit_Loc_l3_WithRelatedData(Loc_l3 i_Loc_l3,List<Address> i_List_Address,List<Loc_l4> i_List_Loc_l4)
public void Edit_Loc_l3_WithRelatedData(Loc_l3 i_Loc_l3,List<Address> i_List_Address,List<Loc_l4> i_List_Loc_l4)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l3(i_Loc_l3);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Edit_Address(oAddress);
}
}
if (i_List_Loc_l4 != null)
{
foreach(Loc_l4 oLoc_l4 in i_List_Loc_l4)
{
oLoc_l4.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Edit_Loc_l4(oLoc_l4);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3_WithRelatedData");}
}
#endregion
#region Delete_Loc_l3_With_Children(Loc_l3 i_Loc_l3)
public void Delete_Loc_l3_With_Children(Loc_l3 i_Loc_l3)
{
 #region Declaration And Initialization Section.
Params_Delete_Loc_l3 oParams_Delete_Loc_l3 = new Params_Delete_Loc_l3();
Params_Delete_Address_By_LOC_L3_ID oParams_Delete_Address_By_LOC_L3_ID = new Params_Delete_Address_By_LOC_L3_ID();
Params_Delete_Loc_l4_By_LOC_L3_ID oParams_Delete_Loc_l4_By_LOC_L3_ID = new Params_Delete_Loc_l4_By_LOC_L3_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l3_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Address_By_LOC_L3_ID.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Delete_Address_By_LOC_L3_ID(oParams_Delete_Address_By_LOC_L3_ID);
oParams_Delete_Loc_l4_By_LOC_L3_ID.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Delete_Loc_l4_By_LOC_L3_ID(oParams_Delete_Loc_l4_By_LOC_L3_ID);
//-------------------------

//-------------------------
oParams_Delete_Loc_l3.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Delete_Loc_l3(oParams_Delete_Loc_l3);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l3_With_Children");}
}
#endregion
#region Reset_Address_By_Loc_l4
public void Reset_Address_By_Loc_l4(Loc_l4 i_Loc_l4, List<Address> i_Address_List)
{
#region Declaration And Initialization Section.
Params_Delete_Address_By_LOC_L4_ID oParams_Delete_Address_By_LOC_L4_ID = new Params_Delete_Address_By_LOC_L4_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l4");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Address
//---------------------------------
oParams_Delete_Address_By_LOC_L4_ID.LOC_L4_ID = i_Loc_l4.LOC_L4_ID;
Delete_Address_By_LOC_L4_ID(oParams_Delete_Address_By_LOC_L4_ID);
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l4_WithAddress(i_Loc_l4, i_Address_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l4");}
}
#endregion
#region Reset_Address_By_Loc_l4
public void Reset_Address_By_Loc_l4(Loc_l4 i_Loc_l4, List<Address> i_Address_List_To_Delete,List<Address> i_Address_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Address oParams_Delete_Address = new Params_Delete_Address();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l4");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Address_List_To_Delete != null)
{
foreach (var oRow in i_Address_List_To_Delete)
{
oParams_Delete_Address.ADDRESS_ID = oRow.ADDRESS_ID;
Delete_Address(oParams_Delete_Address);
}
}
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l4_WithAddress(i_Loc_l4, i_Address_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l4");}
}
#endregion
#region Edit_Loc_l4_With_Address(Loc_l4 i_Loc_l4,List<Address> i_AddressList)
public void Edit_Loc_l4_WithAddress(Loc_l4 i_Loc_l4,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l4_WithAddress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l4(i_Loc_l4);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L4_ID = i_Loc_l4.LOC_L4_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l4_WithAddress");}
}
#endregion
#region Edit_Loc_l4_WithRelatedData(Loc_l4 i_Loc_l4,List<Address> i_List_Address)
public void Edit_Loc_l4_WithRelatedData(Loc_l4 i_Loc_l4,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l4_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l4(i_Loc_l4);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L4_ID = i_Loc_l4.LOC_L4_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l4_WithRelatedData");}
}
#endregion
#region Delete_Loc_l4_With_Children(Loc_l4 i_Loc_l4)
public void Delete_Loc_l4_With_Children(Loc_l4 i_Loc_l4)
{
 #region Declaration And Initialization Section.
Params_Delete_Loc_l4 oParams_Delete_Loc_l4 = new Params_Delete_Loc_l4();
Params_Delete_Address_By_LOC_L4_ID oParams_Delete_Address_By_LOC_L4_ID = new Params_Delete_Address_By_LOC_L4_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l4_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Address_By_LOC_L4_ID.LOC_L4_ID = i_Loc_l4.LOC_L4_ID;
Delete_Address_By_LOC_L4_ID(oParams_Delete_Address_By_LOC_L4_ID);
//-------------------------

//-------------------------
oParams_Delete_Loc_l4.LOC_L4_ID = i_Loc_l4.LOC_L4_ID;
Delete_Loc_l4(oParams_Delete_Loc_l4);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l4_With_Children");}
}
#endregion
#region Reset_Address_By_Person
public void Reset_Address_By_Person(Person i_Person, List<Address> i_Address_List)
{
#region Declaration And Initialization Section.
Params_Delete_Address_By_PERSON_ID oParams_Delete_Address_By_PERSON_ID = new Params_Delete_Address_By_PERSON_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Person");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Address
//---------------------------------
oParams_Delete_Address_By_PERSON_ID.PERSON_ID = i_Person.PERSON_ID;
Delete_Address_By_PERSON_ID(oParams_Delete_Address_By_PERSON_ID);
//---------------------------------
// Edit Address
//---------------------------------
Edit_Person_WithAddress(i_Person, i_Address_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Person");}
}
#endregion
#region Reset_Address_By_Person
public void Reset_Address_By_Person(Person i_Person, List<Address> i_Address_List_To_Delete,List<Address> i_Address_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Address oParams_Delete_Address = new Params_Delete_Address();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Person");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Address_List_To_Delete != null)
{
foreach (var oRow in i_Address_List_To_Delete)
{
oParams_Delete_Address.ADDRESS_ID = oRow.ADDRESS_ID;
Delete_Address(oParams_Delete_Address);
}
}
//---------------------------------
// Edit Address
//---------------------------------
Edit_Person_WithAddress(i_Person, i_Address_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Person");}
}
#endregion
#region Edit_Person_With_Address(Person i_Person,List<Address> i_AddressList)
public void Edit_Person_WithAddress(Person i_Person,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person_WithAddress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Person(i_Person);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.PERSON_ID = i_Person.PERSON_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person_WithAddress");}
}
#endregion
#region Reset_Contact_By_Person
public void Reset_Contact_By_Person(Person i_Person, List<Contact> i_Contact_List)
{
#region Declaration And Initialization Section.
Params_Delete_Contact_By_PERSON_ID oParams_Delete_Contact_By_PERSON_ID = new Params_Delete_Contact_By_PERSON_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Contact_By_Person");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Contact
//---------------------------------
oParams_Delete_Contact_By_PERSON_ID.PERSON_ID = i_Person.PERSON_ID;
Delete_Contact_By_PERSON_ID(oParams_Delete_Contact_By_PERSON_ID);
//---------------------------------
// Edit Contact
//---------------------------------
Edit_Person_WithContact(i_Person, i_Contact_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Contact_By_Person");}
}
#endregion
#region Reset_Contact_By_Person
public void Reset_Contact_By_Person(Person i_Person, List<Contact> i_Contact_List_To_Delete,List<Contact> i_Contact_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Contact oParams_Delete_Contact = new Params_Delete_Contact();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Contact_By_Person");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Contact_List_To_Delete != null)
{
foreach (var oRow in i_Contact_List_To_Delete)
{
oParams_Delete_Contact.CONTACT_ID = oRow.CONTACT_ID;
Delete_Contact(oParams_Delete_Contact);
}
}
//---------------------------------
// Edit Contact
//---------------------------------
Edit_Person_WithContact(i_Person, i_Contact_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Contact_By_Person");}
}
#endregion
#region Edit_Person_With_Contact(Person i_Person,List<Contact> i_ContactList)
public void Edit_Person_WithContact(Person i_Person,List<Contact> i_List_Contact)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person_WithContact");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Person(i_Person);
if (i_List_Contact != null)
{
foreach(Contact oContact in i_List_Contact)
{
oContact.PERSON_ID = i_Person.PERSON_ID;
Edit_Contact(oContact);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person_WithContact");}
}
#endregion
#region Edit_Person_WithRelatedData(Person i_Person,List<Address> i_List_Address,List<Contact> i_List_Contact)
public void Edit_Person_WithRelatedData(Person i_Person,List<Address> i_List_Address,List<Contact> i_List_Contact)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Person(i_Person);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.PERSON_ID = i_Person.PERSON_ID;
Edit_Address(oAddress);
}
}
if (i_List_Contact != null)
{
foreach(Contact oContact in i_List_Contact)
{
oContact.PERSON_ID = i_Person.PERSON_ID;
Edit_Contact(oContact);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person_WithRelatedData");}
}
#endregion
#region Delete_Person_With_Children(Person i_Person)
public void Delete_Person_With_Children(Person i_Person)
{
 #region Declaration And Initialization Section.
Params_Delete_Person oParams_Delete_Person = new Params_Delete_Person();
Params_Delete_Address_By_PERSON_ID oParams_Delete_Address_By_PERSON_ID = new Params_Delete_Address_By_PERSON_ID();
Params_Delete_Contact_By_PERSON_ID oParams_Delete_Contact_By_PERSON_ID = new Params_Delete_Contact_By_PERSON_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Person_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Address_By_PERSON_ID.PERSON_ID = i_Person.PERSON_ID;
Delete_Address_By_PERSON_ID(oParams_Delete_Address_By_PERSON_ID);
oParams_Delete_Contact_By_PERSON_ID.PERSON_ID = i_Person.PERSON_ID;
Delete_Contact_By_PERSON_ID(oParams_Delete_Contact_By_PERSON_ID);
//-------------------------

//-------------------------
oParams_Delete_Person.PERSON_ID = i_Person.PERSON_ID;
Delete_Person(oParams_Delete_Person);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Person_With_Children");}
}
#endregion
}
}
