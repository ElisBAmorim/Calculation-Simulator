import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { request } from './request';
import { response } from './response';

@Injectable({
  providedIn: 'root'
})
export class CalculateServiceService {

  private readonly API = 'http://localhost:8080/v1/Calculate/CDB'
  constructor(private http: HttpClient) { }


  postCdb(request: request): Observable<response> {
    alert("Service -> value: " + request.applicationValue + " mes: " + request.numberOfMonths);
    return this.http.post<response>(this.API, request);
  }

  post(request: request): Observable<any>{
    const myHeaders = new Headers();
    myHeaders.append("Content-Type", "application/json");

    const raw = JSON.stringify({
      "applicationValue": request.applicationValue,
      "numberOfMonths": request.numberOfMonths
    });

    //const requestOptions = {
    //  method: "POST",
    //  headers: myHeaders,
    //  body: raw,
    //  redirect: "follow"
    //};
    alert("Service -> valueRaw: " + raw);
    const resp = this.http.post<response>(this.API, raw, { responseType: "json"});
    return resp;
    //fetch("https://localhost:8080/v1/Calculate/CDB", requestOptions)
    //  .then((response) => response.text())
    //  .then((result) => console.log(result))
    //  .catch((error) => console.error(error));
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
