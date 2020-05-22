import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { log, debug } from 'util';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent implements OnInit  {
  ngOnInit(): void {
    debugger;
    this.GetToken();
    }
  public forecasts: WeatherForecast[];

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    http.get<WeatherForecast[]>(baseUrl + 'api/SampleData/WeatherForecasts').subscribe(result => {
      this.forecasts = result;
    }, error => console.error(error));

    
    

  }

  GetToken() {
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Access-Control-Allow-Origin': '*',
        'Access-Control-Allow-Methods': 'GET,HEAD,OPTIONS,POST,PUT',
      })
    };
    const body = `grant_type=authorization_code&client_id=039bb643-891d-4abd-846d-a38c2e89adad&redirect_uri=https://test-scgdistpurchasing.nexterdigitals-dev.com/login&code=5zD0G9GbxEm2B9LRWX-_mA.fVlbsXz41wieGH39YWrB-NIDTcY.mbOVy93sAGq8cnJI4pjFjxlIJqrCt3d9Ee-jA5uKgP9mg1gzKqoU3adxxdm7V5f97g5AiAdVbOw2I7xizJuL0bZkYFDCexJbUsIbqWsTsZlOeVp_BEDYmhUR_KmtIQBh5OZeMiaA5hNn5ZOm_98LAtyRKNoOoccO6pJ8wb2TDjtYM-xGmZ0JIKynlwPqh4CT4rYLcC3AX5QkPKYm9Wc-7zpDq5Rh8ZBaG3Hv0NK-g2XEvI2OKGVY0MnI3tJeVQKdEpHySq8KL5DF3wLNwNvVXt2YaJS02V3T7WJx4agWpiFrb85UazoDcISHVYOfP68RJHfTGst4FgD15pucSYkWtA`;

    return this.http.post<any>('https://accessdev.scg.co.th/adfs/oauth2/token', body, httpOptions).subscribe(result => {
      console.log(result) 

    }, error => console.error(error));
  }

}

interface WeatherForecast {
  dateFormatted: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
