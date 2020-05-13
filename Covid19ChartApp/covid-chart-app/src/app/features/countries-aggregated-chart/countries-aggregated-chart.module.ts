import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CountriesAggregatedChartComponent } from './countries-aggregated-chart.component';
import { ChartsModule } from 'ng2-charts';


@NgModule({
  declarations: [CountriesAggregatedChartComponent],
  imports: [
    CommonModule,
    ChartsModule
  ],
  exports: [
    CountriesAggregatedChartComponent
  ]
})
export class CountriesAggregatedChartModule { }
