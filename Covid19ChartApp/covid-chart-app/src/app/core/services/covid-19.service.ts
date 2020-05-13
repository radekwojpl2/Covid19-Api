import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class Covid19Service {

  constructor(
    private httpClient: HttpClient
  ) { }

  public GetAllAggregatedCountries(): Observable<any>{
    
    return this.httpClient.get('https://localhost:5001/CsvController/GetAllDataFromCountriesAggregated')
    

  }

}
