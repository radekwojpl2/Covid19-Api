import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { TopMenuModule } from './features/top-menu/top-menu.module';
import {HttpClientModule} from '@angular/common/http'
import { CountriesAggregatedChartModule } from './features/countries-aggregated-chart/countries-aggregated-chart.module';



@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    TopMenuModule,
    HttpClientModule,
    CountriesAggregatedChartModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
