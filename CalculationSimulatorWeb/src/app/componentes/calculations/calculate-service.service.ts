import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CalculateServiceService {

  private readonly API = 'https://localhost:8080/v1/Calculate/CDB'
  constructor(private http: HttpClient) { }
}

 
  //constructor(private http: HttpClient) { }

  //postCdb(request: request): Observable<request> {
  //  return this.http.post<request>(this.API, request);
  //}

