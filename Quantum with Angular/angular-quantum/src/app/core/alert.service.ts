import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Observable,of } from 'rxjs';
import { map, catchError, tap } from 'rxjs/operators';
import { IAlert } from '../shared/interface'

@Injectable({
  providedIn: 'root'
})
export class AlertService {

  baseUrl: string = 'assets/'
  
  constructor(private http: HttpClient) { }


  getAlerts() : Observable<IAlert[]> {
    return this.http.get<IAlert[]>(this.baseUrl + 'alert.json')
      .pipe(
        catchError(this.handleError<IAlert[]>('getAlerts'))
      );
  }


  private handleError<T>(operation = 'operation', result?: T) {
      return (error: any): Observable<T> => {

        // TODO: send the error to remote logging infrastructure
        console.error(error); // log to console instead

        // Let the app keep running by returning an empty result.
        return of(result as T);
      };
  }
}
