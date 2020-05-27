import { Component, OnInit } from '@angular/core';
import { Covid19Service } from 'src/app/core/services/covid-19.service';
import { CountriesAggregated } from 'src/app/core/interfaces/countries-aggregated';
import { Label } from 'ng2-charts';

@Component({
  selector: 'app-countries-aggregated-chart',
  templateUrl: './countries-aggregated-chart.component.html',
  styleUrls: ['./countries-aggregated-chart.component.css']
})
export class CountriesAggregatedChartComponent implements OnInit {
  constructor(private covidService: Covid19Service) {}

  allData: CountriesAggregated[];

  countryList: string[];

  total: number;
  deaths: number;
  recovered: number;

  public barChartOptions = {
    scaleShowVerticalLines: false,
    responsive: true
  };
  public barChartLabels: Label[] = ['adasd', 'dasd', 'asdad'];
  public barChartType = 'line';
  public barChartLegend = true;

  public barChartData = [
    { data: [], label: 'Poland Deaths' },
    { data: [], label: 'Poland recoverd' },
    { data: [], label: 'Poland confirmed' }
  ];

  countryHasChanged($event) {
    this.covidService.GetAllAggregatedCountries().subscribe((data: any) => {
      this.allData = data;

      this.total = this.allData
        .filter(x => x.country == $event)
        .map(x => x.confirmed)
        .slice(-1)[0];

      this.deaths = this.allData
        .filter(x => x.country == $event)
        .map(x => x.deaths)
        .slice(-1)[0];

      this.recovered = this.allData
        .filter(x => x.country == $event)
        .map(x => x.recovered)
        .slice(-1)[0];

      this.barChartLabels = this.allData
        .filter(x => x.country == $event)
        .map(x => x.date.slice(0, 10)) as Label[];

      this.barChartData = [
        {
          data: [].concat.apply(
            [],
            this.allData
              .filter(x => x.country == $event)
              .map(x => x.deaths)
              .map((value, index, elements: number[]) => {
                if (index != 0) {
                  return (value = elements[index] - elements[index - 1]);
                }
              })
          ),
          label: `${$event} Deaths`
        },
        {
          data: [].concat.apply(
            [],
            this.allData
              .filter(x => x.country == $event)
              .map(x => x.recovered)
              .map((value, index, elements: number[]) => {
                if (index != 0) {
                  return (value = elements[index] - elements[index - 1]);
                }
              })
          ),
          label: `${$event} recoverd`
        },
        {
          data: [].concat.apply(
            [],
            this.allData
              .filter(x => x.country == $event)
              .map(x => x.confirmed)
              .map((value, index, elements: number[]) => {
                if (index != 0) {
                  return (value = elements[index] - elements[index - 1]);
                }
              })
          ),
          label: `${$event} confirmed`
        }
      ];
    });
  }

  ngOnInit(): void {
    this.covidService.GetAllAggregatedCountries().subscribe((data: any) => {
      this.allData = data;

      this.countryList = this.allData.map(x => x.country).filter((v, i, a) => a.indexOf(v) === i);

      this.total = this.allData
        .filter(x => x.country == 'Poland')
        .map(x => x.confirmed)
        .slice(-1)[0];

      this.deaths = this.allData
        .filter(x => x.country == 'Poland')
        .map(x => x.deaths)
        .slice(-1)[0];

      this.recovered = this.allData
        .filter(x => x.country == 'Poland')
        .map(x => x.recovered)
        .slice(-1)[0];

      this.barChartLabels = this.allData
        .filter(x => x.country == 'Poland')
        .map(x => x.date.slice(0, 10)) as Label[];

      this.barChartData = [
        {
          data: [].concat.apply(
            [],
            this.allData
              .filter(x => x.country == 'Poland')
              .map(x => x.deaths)
              .map((value, index, elements: number[]) => {
                if (index != 0) {
                  return (value = elements[index] - elements[index - 1]);
                }
              })
          ),
          label: 'Poland Deaths'
        },
        {
          data: [].concat.apply(
            [],
            this.allData
              .filter(x => x.country == 'Poland')
              .map(x => x.recovered)
              .map((value, index, elements: number[]) => {
                if (index != 0) {
                  return (value = elements[index] - elements[index - 1]);
                }
              })
          ),
          label: 'Poland recoverd'
        },
        {
          data: [].concat.apply(
            [],
            this.allData
              .filter(x => x.country == 'Poland')
              .map(x => x.confirmed)
              .map((value, index, elements: number[]) => {
                if (index != 0) {
                  return (value = elements[index] - elements[index - 1]);
                }
              })
          ),
          label: 'Poland confirmed'
        }
      ];
    });
  }
}
