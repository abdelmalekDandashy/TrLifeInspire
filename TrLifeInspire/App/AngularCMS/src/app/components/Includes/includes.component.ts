import { Component, OnInit, OnDestroy } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { Subscription } from 'rxjs/Subscription';
import { Location } from '@angular/common';
import { MatDialog } from '@angular/material';
import {
    Proxy,
    Includes,
    Params_Get_Includes_By_Where,
    Params_Delete_Includes,
    Params_Delete_Uploaded_file,
    Trip,
    Params_Get_Trip_By_OWNER_ID,

} from '../../core/services/proxy.service';
import { DeleteConfirmationComponent } from '../delete-confirmation/delete-confirmation.component';
import { CommonService } from '../../core/services/common.service';
import { FileHolder } from 'angular2-image-upload';
@Component({
    selector: 'app-includes',
    templateUrl: './includes.component.html',
    styleUrls: ['./includes.component.css']
})
export class IncludesComponent implements OnInit, OnDestroy {
    Get_Includes_By_Where_Subscription = new Subscription();
    searchModel: Params_Get_Includes_By_Where = new Params_Get_Includes_By_Where();
    data: Includes[] = [];

    TripList: Trip[];
    _params_Get_Trip_By_OWNER_ID = new Params_Get_Trip_By_OWNER_ID();
    Get_Trip_By_OWNER_ID_Subscription = new Subscription();



    constructor(private proxy: Proxy, private CmSvc: CommonService, private dialog: MatDialog, private location: Location) { }

    ngOnInit(): void {
        this.searchModel.START_ROW = 0;

        this._params_Get_Trip_By_OWNER_ID.OWNER_ID = 1;
        this.Get_Trip_By_OWNER_ID_Subscription = this.proxy.Get_Trip_By_OWNER_ID(this._params_Get_Trip_By_OWNER_ID).subscribe(result => this.TripList = result);


        this.fetchData();
    }
    ngOnDestroy(): void {
        this.Get_Includes_By_Where_Subscription.unsubscribe();
        this.Get_Trip_By_OWNER_ID_Subscription.unsubscribe();

    }
    ClearAndFetch() {
        this.data = [];
        this.searchModel.START_ROW = 0;
        this.fetchData();
    }
    fetchData() {
        this.searchModel.END_ROW = this.searchModel.START_ROW + 10;
        this.Get_Includes_By_Where_Subscription = this.proxy.Get_Includes_By_Where(this.searchModel).subscribe(result => {
            if (result.My_Result != null) {
                result.My_Result.forEach((element: any) => {
                    element.MyURL = this.CmSvc.APIUrl + '/Upload_Image?REL_ENTITY=[TBL_INCLUDES]&REL_FIELD=INCLUDES_IMAGE&REL_KEY=' + element.INCLUDES_ID;
                    if (element.My_Uploaded_files != null) {
                        element.MyUploadedImages = [];
                        element.My_Uploaded_files.forEach(x => {
                            x.url = x.My_URL;
                            element.MyUploadedImages.push(x.My_URL);
                        });
                    }
                    this.data.push(element);
                });
            }
        });
    }
    AddEntry() {
        if (this.data !== undefined) {
            if (this.data.filter(e => e.INCLUDES_ID === -1).length > 0) {
                return;
            }
        }
        const record = new Includes();
        record.INCLUDES_ID = -1;
        this.data.unshift(record);
    }
    Edit(current) {
        this.proxy.Edit_Includes(current).subscribe((result) => {
            if (result != null) {
                this.CmSvc.ShowMessage('Done');
                if (current.INCLUDES_ID === -1) {
                    this.data.splice(this.data.indexOf(current), 1);
                    const newEntry: any = result;
                    newEntry.MyUploadedImages = [];
                    newEntry.MyURL = this.CmSvc.APIUrl + '/Upload_Image?REL_ENTITY=[TBL_INCLUDES]&REL_FIELD=INCLUDES_IMAGE&REL_KEY=' + newEntry.INCLUDES_ID;
                    this.data.unshift(newEntry);
                }
            }
        });
    }
    Delete(entry) {
        const dialogRef = this.dialog.open(DeleteConfirmationComponent);
        dialogRef.afterClosed().subscribe(response => {
            if (response) {
                const _params_Delete_Includes = new Params_Delete_Includes();
                _params_Delete_Includes.INCLUDES_ID = entry.INCLUDES_ID;
                this.proxy.Delete_Includes(_params_Delete_Includes).subscribe(data => {
                    if (data === '') {
                        this.data.splice(this.data.indexOf(entry), 1);
                    }
                });
            }
        });
    }
    onScroll() {
        this.searchModel.START_ROW = this.searchModel.START_ROW + 10;
        this.fetchData();
    }

    imageFinishedUploading(file: FileHolder) {
        const body = file.serverResponse['_body'];
        const data = JSON.parse(body);
        const filename = data;
        file.src = this.CmSvc.APIUrl.replace('api/Data/', 'Files/Uploaded/') + '' + filename;
    }

    onRemoved(file: FileHolder) {
        const str_filname = file.src.substr(file.src.lastIndexOf('/') + 1);
        const UPLOADED_FILE_ID = str_filname.split('.')[0];

        const p: Params_Delete_Uploaded_file = new Params_Delete_Uploaded_file();
        p.UPLOADED_FILE_ID = +UPLOADED_FILE_ID;
        this.proxy.Delete_Uploaded_file(p).subscribe(() => {
            this.CmSvc.ShowMessage('Deleted Successfully', 2000);
        });
    }

    onUploadStateChanged(state: boolean) { }
    goBack() {
        this.location.back();
    }
}
