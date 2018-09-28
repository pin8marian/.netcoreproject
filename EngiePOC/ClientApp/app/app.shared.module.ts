import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { ModalModule } from 'ngx-bootstrap/modal';

import { SearchDataService } from './services/search-items.service';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { ContractareComponent } from './components/contractare/contractare.component';
import { ServiciiComponent } from './components/servicii/servicii.component';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        HomeComponent,
        ContractareComponent,
        ServiciiComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'contractare', component: ContractareComponent },
            { path: 'servicii', component: ServiciiComponent },
            { path: '**', redirectTo: 'home' }
        ]),
        ModalModule.forRoot()
    ],
    providers: [
        SearchDataService
    ]
})
export class AppModuleShared {
}
