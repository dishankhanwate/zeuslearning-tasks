import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Observable,of } from 'rxjs';
import { map, catchError, tap } from 'rxjs/operators';
import { IDashboard } from '../shared/interface'

@Injectable({
  providedIn: 'root'
})
export class DashboardService {

  baseUrl: string = 'assets/'
  
  constructor(private http: HttpClient) { }
  
  getDashboards() : Observable<IDashboard[]> {
    return this.http.get<IDashboard[]>(this.baseUrl + 'dashboardData.json')
      .pipe(
        catchError(this.handleError<IDashboard[]>('getDashboards'))
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

