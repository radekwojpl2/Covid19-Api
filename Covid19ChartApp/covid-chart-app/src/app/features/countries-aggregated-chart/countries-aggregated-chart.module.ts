import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CountriesAggregatedChartComponent } from './countries-aggregated-chart.component';
import { ChartsModule } from 'ng2-charts';


import {MatSelectModule} from '@angular/material/select'; 


@NgModule({
  declarations: [CountriesAggregatedChartComponent],
  imports: [
    CommonModule,
    ChartsModule,
    MatSelectModule
  ],
  exports: [
    CountriesAggregatedChartComponent
  ]
})
export class CountriesAggregatedChartModule { }
