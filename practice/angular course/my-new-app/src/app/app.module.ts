import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { CustomersComponent } from './customers/customers.component';
import { CustomersListComponent } from './customers/customers-list/customers-list.component';

@NgModule({
  declarations: [
    AppComponent,
    CustomersComponent,
    CustomersListComponent,
    
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
  