import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { request } from '../Interface/request';
import { response } from '../Interface/response';

@Injectable({
  providedIn: 'root'
})
export class CalculateServiceService {

  private readonly API = 'v1/calculate/cdb'
  constructor(private http: HttpClient) { }


  postCdb(request: request): Observable<response> {
    alert("Service -> value: " + request.applicationValue + " mes: " + request.numberOfMonths);
    return this.http.post<response>(this.API, request);
  }

  post(request: request): Observable<response>{  

    const raw = JSON.stringify({
      "applicationValue": request.applicationValue,
      "numberOfMonths": request.numberOfMonths
    });

    const resp = this.http.post<response>(this.API, raw, { headers: { "Content-Type": "application/json" }, responseType: "json" });
    
    return resp;  
  }
    
}
