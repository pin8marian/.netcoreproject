import { SearchDataService } from './../../services/search-items.service';
import { Component, TemplateRef } from '@angular/core';
import { BsModalService } from 'ngx-bootstrap/modal';
import { BsModalRef } from 'ngx-bootstrap/modal/bs-modal-ref.service';

@Component({
    selector: 'servicii',
    templateUrl: './servicii.component.html'
})
export class ServiciiComponent {
    apiRoute: string = 'Read';

    loadLinks: boolean = true;
    items: any[] = [];
    searchParams: any = {
        cod_loc_consum: null,
        nr_inreg_dgsr: null,
        nume_client_final: null,
        telefon: null
    };
    modalRef: BsModalRef;
    config = {
        backdrop: true,
        ignoreBackdropClick: false
    };
    urlHref: string = "";
    appHref: string = "";

    constructor(private searchService: SearchDataService, private modalService: BsModalService) {
        this.searchService.getItems(this.apiRoute).subscribe(result => {
            this.items = result;
        }, error => console.error(error));
    }

    search() {
        this.items = [];
        this.searchService.searchItems(this.searchParams, this.apiRoute).subscribe(result => {
            this.items = result;
        }, error => console.error(error));
    };

    sendToSign(engieObject: any, template: TemplateRef<any>) {
        let isMobile = /Android/i.test(window.navigator.userAgent);
        this.modalRef = this.modalService.show(template, this.config);
        this.loadLinks = true;

        this.searchService.setToSign(engieObject, this.apiRoute).subscribe(result => {
            this.loadLinks = false;
            this.urlHref = result[0];
            this.appHref = result[1];
        }, error => console.error(error));
    }
}
