import { Component, OnInit } from '@angular/core';
import { Covid19Service } from 'src/app/core/services/covid-19.service';

@Component({
  selector: 'app-countries-aggregated-chart',
  templateUrl: './countries-aggregated-chart.component.html',
  styleUrls: ['./countries-aggregated-chart.component.css']
})
export class CountriesAggregatedChartComponent implements OnInit {
  constructor(private covidService: Covid19Service) {}

  allData: {
    confirmed: number;
    country: string;
    date: Date;
    deaths: number;
    recovered: number;
  }[];

  public barChartOptions = {
    scaleShowVerticalLines: false,
    responsive: true
  };
  public barChartLabels = Array.from(Array(120).keys());
  public barChartType = 'line';
  public barChartLegend = true;

  public barChartData = [
    { data: [123, 200], label: 'asd' },
    { data: [123, 300], label: 'asd' }
  ];

  ngOnInit(): void {
    this.covidService.GetAllAggregatedCountries().subscribe((data: any) => {
      this.allData = data;
      console.log(this.allData);
      console.log(
        this.allData.filter(x => x.country == 'Poland').map(x => x.recovered)
      );
    });

    setTimeout(() => {
      this.barChartData = [
        {
          data: 
            [].concat.apply(
              [],
              this.allData.filter(x => x.country == 'Poland').map(x => x.deaths)
            )
          ,
          label: 'Poland Deaths'
        },
        {
          data: [].concat.apply(
            [],
            this.allData
              .filter(x => x.country == 'Poland')
              .map(x => x.recovered)
          ),
          label: 'Poland recoverd'
        }
      ];

      console.log('deaths');
      
      console.log(
        [].concat.apply(
          [],
          this.allData.filter(x => x.country == 'Poland').map(x => x.deaths)
        )
      );
    }, 2000);
  }
}
