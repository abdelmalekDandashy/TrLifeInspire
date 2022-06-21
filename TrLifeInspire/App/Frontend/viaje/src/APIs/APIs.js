import { Proxy } from "./fetch";
import * as P from "./fetch";

let myProxy = new Proxy();
export async function Edit_Table(data, methodName) {
  // //console.log(JSON.stringify({ data, methodName }));
  let result = await myProxy.Edit_Table(data, methodName);
  if (!result.ExceptionMsg) {
    //alert(JSON.stringify(result))
    return result;
    //  return {Product : result.My_Result }
  } else {
    //console.log(JSON.stringify(result));
    return result;
  }
}
export async function Delete_Table(data, methodName) {
  //console.log(JSON.stringify(methodName));
  let result = await myProxy.Delete_Table(data, methodName);
  if (!result.ExceptionMsg) {
    //alert(JSON.stringify(result))
    return result;
    //  return {Product : result.My_Result }
  } else {
    //console.log(JSON.stringify(result));
    return result;
  }
}
export async function Get_Table(data, methodName) {
  //console.log(JSON.stringify({ data, methodName }));
  try {
    let result = await myProxy.Get_Table(data, methodName);
    // //console.log(result)
    return result;
  } catch (e) {
    alert(e);
  }
}
