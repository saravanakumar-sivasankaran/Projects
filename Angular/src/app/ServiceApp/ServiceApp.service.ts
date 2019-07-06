import { Injectable } from '@angular/core';
import { ServiceApp } from './ServiceApp';
import { Http, Response, RequestOptions, Headers } from '@angular/http';
import { Observable } from 'rxjs/Rx';
import 'rxjs/rx';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';

@Injectable()
export class AppService {
    private serviceApp: ServiceApp[] = [
        {
            ID: 1,
            Name: 'Saravanakumar S',
            InvokeFrom: 'WebAPI',
            CreatedDate: '11/10/2017'
        },
        {
            ID: 2,
            Name: 'Vidhubala',
            InvokeFrom: 'AWSApi',
            CreatedDate: '12/11/2017'
        }
    ];


    constructor(private _http: Http) {

    }

    getService(): Observable<ServiceApp[]> {
        return this.getServiceDetails().map(response => response)
            .catch((error: any) => Observable.throw(error.json().error || 'Server error'));
    }

    getServiceDetails(): Observable<any> {
        return Observable.of(this.serviceApp);
    }
}
