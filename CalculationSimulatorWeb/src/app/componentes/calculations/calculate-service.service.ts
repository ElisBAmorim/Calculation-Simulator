import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { request } from './request';
import { response } from './response';

@Injectable({
  providedIn: 'root'
})
export class CalculateServiceService {

  private readonly API = 'https://localhost:8080/v1/Calculate/CDB'
  constructor(private http: HttpClient) { }


  postCdb(request: request): Observable<response> {
    return this.http.post<response>(this.API, request);
  }

}
