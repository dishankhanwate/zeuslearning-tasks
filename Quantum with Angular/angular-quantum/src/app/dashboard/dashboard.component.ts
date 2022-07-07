import { Component, OnInit } from '@angular/core';
import { DashboardService } from '../core/dashboard.service';
import { IDashboard } from '../shared/interface';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {

  dashboards: IDashboard[]=[];

  constructor(private dashboardService: DashboardService) { }

  ngOnInit(): void {
    this.getDashboards()
  }

  getDashboards(): void {
    this.dashboardService.getDashboards()
      .subscribe(dashboards => this.dashboards = dashboards);
  }
}
