import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpEvent} from '@angular/common/http';
import { Observable } from 'rxjs';
import {map} from 'rxjs/operators';
import { CommonService } from './common.service';
@Injectable()
export class Proxy {
APIBaseUrl = '';
url = '';
constructor(public api: HttpClient, private common: CommonService) {
this.APIBaseUrl = common.APIUrl; 
}
Get_Trip_By_OWNER_ID(i_Params_Get_Trip_By_OWNER_ID: Params_Get_Trip_By_OWNER_ID) : Observable<Trip[]> {
this.url = this.APIBaseUrl + '/Get_Trip_By_OWNER_ID?Ticket=' + this.common.ticket;
const headers = new HttpHeaders({ 'Content-Type': 'application/json','ticket': this.common.ticket });
const options = { headers: headers };
return this.api.post<Result_Get_Trip_By_OWNER_ID>(this.url, JSON.stringify(i_Params_Get_Trip_By_OWNER_ID), options)
.pipe(map(response => { this.common.Handle_Exception(response.ExceptionMsg); return response.My_Result;}));
}
Get_Trip_By_TRIP_ID(i_Params_Get_Trip_By_TRIP_ID: Params_Get_Trip_By_TRIP_ID) : Observable<Trip> {
this.url = this.APIBaseUrl + '/Get_Trip_By_TRIP_ID?Ticket=' + this.common.ticket;
const headers = new HttpHeaders({ 'Content-Type': 'application/json','ticket': this.common.ticket });
const options = { headers: headers };
return this.api.post<Result_Get_Trip_By_TRIP_ID>(this.url, JSON.stringify(i_Params_Get_Trip_By_TRIP_ID), options)
.pipe(map(response => { this.common.Handle_Exception(response.ExceptionMsg); return response.My_Result;}));
}
Get_Trip_By_Criteria(i_Params_Get_Trip_By_Criteria: Params_Get_Trip_By_Criteria) : Observable<Result_Get_Trip_By_Criteria> {
this.url = this.APIBaseUrl + '/Get_Trip_By_Criteria?Ticket=' + this.common.ticket;
const headers = new HttpHeaders({ 'Content-Type': 'application/json','ticket': this.common.ticket });
const options = { headers: headers };
return this.api.post<Result_Get_Trip_By_Criteria>(this.url, JSON.stringify(i_Params_Get_Trip_By_Criteria), options)
.pipe(map(response => { this.common.Handle_Exception(response.ExceptionMsg); return response;}));
}
Get_Trip_By_Where(i_Params_Get_Trip_By_Where: Params_Get_Trip_By_Where) : Observable<Result_Get_Trip_By_Where> {
this.url = this.APIBaseUrl + '/Get_Trip_By_Where?Ticket=' + this.common.ticket;
const headers = new HttpHeaders({ 'Content-Type': 'application/json','ticket': this.common.ticket });
const options = { headers: headers };
return this.api.post<Result_Get_Trip_By_Where>(this.url, JSON.stringify(i_Params_Get_Trip_By_Where), options)
.pipe(map(response => { this.common.Handle_Exception(response.ExceptionMsg); return response;}));
}
Edit_Trip(i_Trip: Trip) : Observable<Trip> {
this.url = this.APIBaseUrl + '/Edit_Trip?Ticket=' + this.common.ticket;
const headers = new HttpHeaders({ 'Content-Type': 'application/json','ticket': this.common.ticket });
const options = { headers: headers };
return this.api.post<Result_Edit_Trip>(this.url, JSON.stringify(i_Trip), options)
.pipe(map(response => { this.common.Handle_Exception(response.ExceptionMsg); return response.My_Trip;}));
}
Delete_Trip(i_Params_Delete_Trip: Params_Delete_Trip) : Observable<string> {
this.url = this.APIBaseUrl + '/Delete_Trip?Ticket=' + this.common.ticket;
const headers = new HttpHeaders({ 'Content-Type': 'application/json','ticket': this.common.ticket });
const options = { headers: headers };
return this.api.post<any>(this.url, JSON.stringify(i_Params_Delete_Trip), options)
.pipe(map(response => { this.common.Handle_Exception(response.ExceptionMsg);return response.ExceptionMsg;}));
}
Get_Features_By_Where(i_Params_Get_Features_By_Where: Params_Get_Features_By_Where) : Observable<Result_Get_Features_By_Where> {
this.url = this.APIBaseUrl + '/Get_Features_By_Where?Ticket=' + this.common.ticket;
const headers = new HttpHeaders({ 'Content-Type': 'application/json','ticket': this.common.ticket });
const options = { headers: headers };
return this.api.post<Result_Get_Features_By_Where>(this.url, JSON.stringify(i_Params_Get_Features_By_Where), options)
.pipe(map(response => { this.common.Handle_Exception(response.ExceptionMsg); return response;}));
}
Edit_Features(i_Features: Features) : Observable<Features> {
this.url = this.APIBaseUrl + '/Edit_Features?Ticket=' + this.common.ticket;
const headers = new HttpHeaders({ 'Content-Type': 'application/json','ticket': this.common.ticket });
const options = { headers: headers };
return this.api.post<Result_Edit_Features>(this.url, JSON.stringify(i_Features), options)
.pipe(map(response => { this.common.Handle_Exception(response.ExceptionMsg); return response.My_Features;}));
}
Delete_Features(i_Params_Delete_Features: Params_Delete_Features) : Observable<string> {
this.url = this.APIBaseUrl + '/Delete_Features?Ticket=' + this.common.ticket;
const headers = new HttpHeaders({ 'Content-Type': 'application/json','ticket': this.common.ticket });
const options = { headers: headers };
return this.api.post<any>(this.url, JSON.stringify(i_Params_Delete_Features), options)
.pipe(map(response => { this.common.Handle_Exception(response.ExceptionMsg);return response.ExceptionMsg;}));
}
Delete_Uploaded_file(i_Params_Delete_Uploaded_file: Params_Delete_Uploaded_file) : Observable<string> {
this.url = this.APIBaseUrl + '/Delete_Uploaded_file?Ticket=' + this.common.ticket;
const headers = new HttpHeaders({ 'Content-Type': 'application/json','ticket': this.common.ticket });
const options = { headers: headers };
return this.api.post<any>(this.url, JSON.stringify(i_Params_Delete_Uploaded_file), options)
.pipe(map(response => { this.common.Handle_Exception(response.ExceptionMsg);return response.ExceptionMsg;}));
}
Get_Includes_By_Where(i_Params_Get_Includes_By_Where: Params_Get_Includes_By_Where) : Observable<Result_Get_Includes_By_Where> {
this.url = this.APIBaseUrl + '/Get_Includes_By_Where?Ticket=' + this.common.ticket;
const headers = new HttpHeaders({ 'Content-Type': 'application/json','ticket': this.common.ticket });
const options = { headers: headers };
return this.api.post<Result_Get_Includes_By_Where>(this.url, JSON.stringify(i_Params_Get_Includes_By_Where), options)
.pipe(map(response => { this.common.Handle_Exception(response.ExceptionMsg); return response;}));
}
Edit_Includes(i_Includes: Includes) : Observable<Includes> {
this.url = this.APIBaseUrl + '/Edit_Includes?Ticket=' + this.common.ticket;
const headers = new HttpHeaders({ 'Content-Type': 'application/json','ticket': this.common.ticket });
const options = { headers: headers };
return this.api.post<Result_Edit_Includes>(this.url, JSON.stringify(i_Includes), options)
.pipe(map(response => { this.common.Handle_Exception(response.ExceptionMsg); return response.My_Includes;}));
}
Delete_Includes(i_Params_Delete_Includes: Params_Delete_Includes) : Observable<string> {
this.url = this.APIBaseUrl + '/Delete_Includes?Ticket=' + this.common.ticket;
const headers = new HttpHeaders({ 'Content-Type': 'application/json','ticket': this.common.ticket });
const options = { headers: headers };
return this.api.post<any>(this.url, JSON.stringify(i_Params_Delete_Includes), options)
.pipe(map(response => { this.common.Handle_Exception(response.ExceptionMsg);return response.ExceptionMsg;}));
}
Get_Social_media_links_By_Where(i_Params_Get_Social_media_links_By_Where: Params_Get_Social_media_links_By_Where) : Observable<Result_Get_Social_media_links_By_Where> {
this.url = this.APIBaseUrl + '/Get_Social_media_links_By_Where?Ticket=' + this.common.ticket;
const headers = new HttpHeaders({ 'Content-Type': 'application/json','ticket': this.common.ticket });
const options = { headers: headers };
return this.api.post<Result_Get_Social_media_links_By_Where>(this.url, JSON.stringify(i_Params_Get_Social_media_links_By_Where), options)
.pipe(map(response => { this.common.Handle_Exception(response.ExceptionMsg); return response;}));
}
Edit_Social_media_links(i_Social_media_links: Social_media_links) : Observable<Social_media_links> {
this.url = this.APIBaseUrl + '/Edit_Social_media_links?Ticket=' + this.common.ticket;
const headers = new HttpHeaders({ 'Content-Type': 'application/json','ticket': this.common.ticket });
const options = { headers: headers };
return this.api.post<Result_Edit_Social_media_links>(this.url, JSON.stringify(i_Social_media_links), options)
.pipe(map(response => { this.common.Handle_Exception(response.ExceptionMsg); return response.My_Social_media_links;}));
}
Delete_Social_media_links(i_Params_Delete_Social_media_links: Params_Delete_Social_media_links) : Observable<string> {
this.url = this.APIBaseUrl + '/Delete_Social_media_links?Ticket=' + this.common.ticket;
const headers = new HttpHeaders({ 'Content-Type': 'application/json','ticket': this.common.ticket });
const options = { headers: headers };
return this.api.post<any>(this.url, JSON.stringify(i_Params_Delete_Social_media_links), options)
.pipe(map(response => { this.common.Handle_Exception(response.ExceptionMsg);return response.ExceptionMsg;}));
}
Get_Staff_By_Where(i_Params_Get_Staff_By_Where: Params_Get_Staff_By_Where) : Observable<Result_Get_Staff_By_Where> {
this.url = this.APIBaseUrl + '/Get_Staff_By_Where?Ticket=' + this.common.ticket;
const headers = new HttpHeaders({ 'Content-Type': 'application/json','ticket': this.common.ticket });
const options = { headers: headers };
return this.api.post<Result_Get_Staff_By_Where>(this.url, JSON.stringify(i_Params_Get_Staff_By_Where), options)
.pipe(map(response => { this.common.Handle_Exception(response.ExceptionMsg); return response;}));
}
Edit_Staff(i_Staff: Staff) : Observable<Staff> {
this.url = this.APIBaseUrl + '/Edit_Staff?Ticket=' + this.common.ticket;
const headers = new HttpHeaders({ 'Content-Type': 'application/json','ticket': this.common.ticket });
const options = { headers: headers };
return this.api.post<Result_Edit_Staff>(this.url, JSON.stringify(i_Staff), options)
.pipe(map(response => { this.common.Handle_Exception(response.ExceptionMsg); return response.My_Staff;}));
}
Delete_Staff(i_Params_Delete_Staff: Params_Delete_Staff) : Observable<string> {
this.url = this.APIBaseUrl + '/Delete_Staff?Ticket=' + this.common.ticket;
const headers = new HttpHeaders({ 'Content-Type': 'application/json','ticket': this.common.ticket });
const options = { headers: headers };
return this.api.post<any>(this.url, JSON.stringify(i_Params_Delete_Staff), options)
.pipe(map(response => { this.common.Handle_Exception(response.ExceptionMsg);return response.ExceptionMsg;}));
}
Edit_Uploaded_file(i_Uploaded_file: Uploaded_file) : Observable<Uploaded_file> {
this.url = this.APIBaseUrl + '/Edit_Uploaded_file?Ticket=' + this.common.ticket;
const headers = new HttpHeaders({ 'Content-Type': 'application/json','ticket': this.common.ticket });
const options = { headers: headers };
return this.api.post<Result_Edit_Uploaded_file>(this.url, JSON.stringify(i_Uploaded_file), options)
.pipe(map(response => { this.common.Handle_Exception(response.ExceptionMsg); return response.My_Uploaded_file;}));
}
Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD: Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD) : Observable<string> {
this.url = this.APIBaseUrl + '/Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD?Ticket=' + this.common.ticket;
const headers = new HttpHeaders({ 'Content-Type': 'application/json','ticket': this.common.ticket });
const options = { headers: headers };
return this.api.post<any>(this.url, JSON.stringify(i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD), options)
.pipe(map(response => { this.common.Handle_Exception(response.ExceptionMsg);return response.ExceptionMsg;}));
}
}
export class Params_Get_Trip_By_OWNER_ID
{
OWNER_ID?: number;
}
export class Trip
{
TRIP_ID?: number;
TITLE: string;
SUB_TITLE: string;
DETAILS: string;
CITY: string;
PRICE: string;
DISCOUNT_PRICE: string;
VIDEO_URL: string;
IS_AVAILABLE_OR_COMING_SOON?: boolean;
OFFER_HIGHLIGHT_TEXT: string;
ENTRY_USER_ID?: number;
ENTRY_DATE: string;
OWNER_ID?: number;
My_Uploaded_files: Uploaded_file[];
}
export class Uploaded_file
{
UPLOADED_FILE_ID?: number;
REL_ENTITY: string;
REL_KEY?: number;
REL_FIELD: string;
SIZE?: number;
EXTENSION: string;
STAMP: string;
ENTRY_USER_ID?: number;
ENTRY_DATE: string;
OWNER_ID?: number;
My_URL: string;
}
export class Params_Get_Trip_By_TRIP_ID
{
TRIP_ID?: number;
}
export class Params_Get_Trip_By_Criteria
{
OWNER_ID?: number;
TITLE: string;
SUB_TITLE: string;
DETAILS: string;
CITY: string;
PRICE: string;
DISCOUNT_PRICE: string;
VIDEO_URL: string;
OFFER_HIGHLIGHT_TEXT: string;
START_ROW?: number;
END_ROW?: number;
TOTAL_COUNT?: number;
}
export class Params_Get_Trip_By_Where
{
OWNER_ID?: number;
TITLE: string;
SUB_TITLE: string;
DETAILS: string;
CITY: string;
PRICE: string;
DISCOUNT_PRICE: string;
VIDEO_URL: string;
OFFER_HIGHLIGHT_TEXT: string;
START_ROW?: number;
END_ROW?: number;
TOTAL_COUNT?: number;
}
export class Params_Delete_Trip
{
TRIP_ID?: number;
}
export class Params_Get_Features_By_Where
{
OWNER_ID?: number;
TITLE: string;
DESCRIPTION: string;
START_ROW?: number;
END_ROW?: number;
TOTAL_COUNT?: number;
}
export class Features
{
FEATURES_ID?: number;
TRIP_ID?: number;
TITLE: string;
DESCRIPTION: string;
ENTRY_USER_ID?: number;
ENTRY_DATE: string;
OWNER_ID?: number;
My_Trip: Trip;
}
export class Params_Delete_Features
{
FEATURES_ID?: number;
}
export class Params_Delete_Uploaded_file
{
UPLOADED_FILE_ID?: number;
}
export class Params_Get_Includes_By_Where
{
OWNER_ID?: number;
TITLE: string;
DESCRIPTION: string;
START_ROW?: number;
END_ROW?: number;
TOTAL_COUNT?: number;
}
export class Includes
{
INCLUDES_ID?: number;
TRIP_ID?: number;
TITLE: string;
DESCRIPTION: string;
ENTRY_USER_ID?: number;
ENTRY_DATE: string;
OWNER_ID?: number;
My_Trip: Trip;
}
export class Params_Delete_Includes
{
INCLUDES_ID?: number;
}
export class Params_Get_Social_media_links_By_Where
{
OWNER_ID?: number;
TITLE: string;
URL: string;
START_ROW?: number;
END_ROW?: number;
TOTAL_COUNT?: number;
}
export class Social_media_links
{
SOCIAL_MEDIA_LINKS_ID?: number;
TITLE: string;
URL: string;
ENTRY_USER_ID?: number;
ENTRY_DATE: string;
OWNER_ID?: number;
}
export class Params_Delete_Social_media_links
{
SOCIAL_MEDIA_LINKS_ID?: number;
}
export class Params_Get_Staff_By_Where
{
OWNER_ID?: number;
TITLE: string;
DESCRIPTION: string;
EMAIL: string;
PHONE: string;
START_ROW?: number;
END_ROW?: number;
TOTAL_COUNT?: number;
}
export class Staff
{
STAFF_ID?: number;
TITLE: string;
DESCRIPTION: string;
EMAIL: string;
PHONE: string;
ENTRY_USER_ID?: number;
ENTRY_DATE: string;
OWNER_ID?: number;
}
export class Params_Delete_Staff
{
STAFF_ID?: number;
}
export class Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD
{
REL_ENTITY: string;
REL_KEY?: number;
REL_FIELD: string;
}
export class Action_Result{
ExceptionMsg: string;
}
export class Result_Get_Trip_By_OWNER_ID extends Action_Result {
My_Result : Trip[];
My_Params_Get_Trip_By_OWNER_ID : Params_Get_Trip_By_OWNER_ID;
}
export class Result_Get_Trip_By_TRIP_ID extends Action_Result {
My_Result : Trip;
My_Params_Get_Trip_By_TRIP_ID : Params_Get_Trip_By_TRIP_ID;
}
export class Result_Get_Trip_By_Criteria extends Action_Result {
My_Result : Trip[];
My_Params_Get_Trip_By_Criteria : Params_Get_Trip_By_Criteria;
}
export class Result_Get_Trip_By_Where extends Action_Result {
My_Result : Trip[];
My_Params_Get_Trip_By_Where : Params_Get_Trip_By_Where;
}
export class Result_Edit_Trip extends Action_Result {
My_Trip : Trip;
}
export class Result_Delete_Trip extends Action_Result {
My_Params_Delete_Trip : Params_Delete_Trip;
}
export class Result_Get_Features_By_Where extends Action_Result {
My_Result : Features[];
My_Params_Get_Features_By_Where : Params_Get_Features_By_Where;
}
export class Result_Edit_Features extends Action_Result {
My_Features : Features;
}
export class Result_Delete_Features extends Action_Result {
My_Params_Delete_Features : Params_Delete_Features;
}
export class Result_Delete_Uploaded_file extends Action_Result {
My_Params_Delete_Uploaded_file : Params_Delete_Uploaded_file;
}
export class Result_Get_Includes_By_Where extends Action_Result {
My_Result : Includes[];
My_Params_Get_Includes_By_Where : Params_Get_Includes_By_Where;
}
export class Result_Edit_Includes extends Action_Result {
My_Includes : Includes;
}
export class Result_Delete_Includes extends Action_Result {
My_Params_Delete_Includes : Params_Delete_Includes;
}
export class Result_Get_Social_media_links_By_Where extends Action_Result {
My_Result : Social_media_links[];
My_Params_Get_Social_media_links_By_Where : Params_Get_Social_media_links_By_Where;
}
export class Result_Edit_Social_media_links extends Action_Result {
My_Social_media_links : Social_media_links;
}
export class Result_Delete_Social_media_links extends Action_Result {
My_Params_Delete_Social_media_links : Params_Delete_Social_media_links;
}
export class Result_Get_Staff_By_Where extends Action_Result {
My_Result : Staff[];
My_Params_Get_Staff_By_Where : Params_Get_Staff_By_Where;
}
export class Result_Edit_Staff extends Action_Result {
My_Staff : Staff;
}
export class Result_Delete_Staff extends Action_Result {
My_Params_Delete_Staff : Params_Delete_Staff;
}
export class Result_Edit_Uploaded_file extends Action_Result {
My_Uploaded_file : Uploaded_file;
}
export class Result_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD extends Action_Result {
My_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD : Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD;
}
