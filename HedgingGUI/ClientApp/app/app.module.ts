import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { AdminComponent } from './admin/admin.component';
import { HomeComponent } from './home/home.component';

import { MaterialModule } from './material.module';
import { AdminService } from 'ClientApp/core/services/api.client.generated';
import { HttpClientModule } from '@angular/common/http';
import { UsersComponent } from './admin/users/users.component';

@NgModule({
  declarations: [
      AppComponent,
      AdminComponent,
      HomeComponent,
      UsersComponent
  ],
  imports: [
      BrowserModule,
      BrowserAnimationsModule,
      HttpClientModule,
      MaterialModule,
      RouterModule.forRoot([
        { path: '', component: HomeComponent, pathMatch: 'full' },
        { path: 'home', component: HomeComponent },
        { path: 'admin', component: AdminComponent}
      ])
  ],
  providers: [AdminService],
  bootstrap: [AppComponent]
})
export class AppModule { }
