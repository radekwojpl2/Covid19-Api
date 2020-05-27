import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { CountriesAggregated } from '../interfaces/countries-aggregated';

@Injectable({
  providedIn: 'root'
})
export class Covid19Service {

  constructor(
    private httpClient: HttpClient
  ) { }

  public GetAllAggregatedCountries(): Observable<CountriesAggregated[]>{
    
    return this.httpClient.get<CountriesAggregated[]>('https://localhost:5001/CsvController/GetAllDataFromCountriesAggregated')
    

  }

}
