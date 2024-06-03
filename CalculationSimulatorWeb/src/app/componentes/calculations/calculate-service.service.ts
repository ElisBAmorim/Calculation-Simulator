import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { request } from './request';
import { response } from './response';
import { TagContentType } from '@angular/compiler';

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

  //post2() {
  //  var settings = {
  //    "url": "https://localhost:8080/v1/Calculate/CDB",
  //    "method": "POST",
  //    "timeout": 0,
  //    "headers": {
  //      "Content-Type": "application/json"
  //    },
  //    "data": JSON.stringify({
  //      "applicationValue": 1000,
  //      "numberOfMonths": 6
  //    }),
  //  };

  //  $.ajax(settings).done(function (response: any) {
  //    console.log(response);
  //  });
  //}

  postXhr(request: request) {
    var data = JSON.stringify({
      "applicationValue": request.applicationValue,
      "numberOfMonths": request.numberOfMonths
    });

    var xhr = new XMLHttpRequest();
    xhr.withCredentials = true;

    xhr.addEventListener("readystatechange", function () {
      if (this.readyState === 4) {
        console.log(this.responseText);
        if (this.responseText != null) {
          console.log(this.responseText);
        }
      }
    });

    xhr.open("POST", "v1/calculate/cdb");
    xhr.setRequestHeader("Content-Type", "application/json");

    xhr.send(data);
   
  }
}
