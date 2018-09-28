import { Injectable, Inject } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class SearchDataService {

    constructor(private http: Http, @Inject('BASE_URL') private baseUrl: string) {

    }

    getItems(apiRoute: string) {
        return this.http.get(this.baseUrl + 'api/' + apiRoute)
            .map(res => res.json());
    }

    searchItems(searchParams: any, apiRoute: string) {
        return this.http.post(this.baseUrl + 'api/' + apiRoute + '/SearchData', searchParams)
            .map(res => res.json());
    }

    setToSign(engieObject: any, apiRoute: string) {
        return this.http.post(this.baseUrl + 'api/' + apiRoute + '/GetSignLink', engieObject)
            .map(res => res.json());
    }
}