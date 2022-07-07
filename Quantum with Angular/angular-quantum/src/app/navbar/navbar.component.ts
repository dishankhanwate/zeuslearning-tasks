import { Component, OnInit } from '@angular/core';
import {AlertService} from '../core/alert.service';
import {AnnouncementService} from '../core/announcement.service';
import { IAlert, IAnnouncement } from '../shared/interface';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent implements OnInit {

  alerts: IAlert[]=[];
  announcements: IAnnouncement[]=[];

  isActiveAlert=false;
  isActiveAnnouncement=false;
  isActiveHam=false;
  isActiveDashboard=false;
  isActiveContent=false;
  isActiveUsers=false;
  isActiveReports=false;
  isActiveAdmin=false;

  changeActiveAlert(){
    this.isActiveAlert= !this.isActiveAlert;

    if (this.isActiveAlert){
      this.isActiveAnnouncement=false;
      this.isActiveHam=false;
    }
  }

  changeActiveAnnouncement(){
    this.isActiveAnnouncement= !this.isActiveAnnouncement;
    if (this.isActiveAnnouncement) {
      this.isActiveAlert=false;
      this.isActiveHam=false
    }
  }

  changeActiveHam(){
    this.isActiveHam= !this.isActiveHam;
    if (this.isActiveHam) {
      this.isActiveAlert=false;
      this.isActiveAnnouncement=false
    }
  }

  changeActiveDashboard(){
    this.isActiveDashboard= !this.isActiveDashboard;
    if (this.isActiveDashboard){
      this.isActiveContent=false;
      this.isActiveUsers=false;
      this.isActiveReports=false;
      this.isActiveAdmin=false;
    }
  }

  changeActiveContent(){
    this.isActiveContent= !this.isActiveContent;
    if (this.isActiveContent){
      this.isActiveDashboard=false;
      this.isActiveUsers=false;
      this.isActiveReports=false;
      this.isActiveAdmin=false;
    }
  }

  changeActiveUsers(){
    this.isActiveUsers= !this.isActiveUsers;
    if (this.isActiveUsers){
      this.isActiveContent=false;
      this.isActiveDashboard=false;
      this.isActiveReports=false;
      this.isActiveAdmin=false;
    }
  }

  changeActiveReports(){
    this.isActiveReports= !this.isActiveReports;
    if (this.isActiveReports){
      this.isActiveContent=false;
      this.isActiveUsers=false;
      this.isActiveDashboard=false;
      this.isActiveAdmin=false;
    }
  }

  changeActiveAdmin(){
    this.isActiveAdmin= !this.isActiveAdmin;
    if (this.isActiveAdmin){
      this.isActiveContent=false;
      this.isActiveUsers=false;
      this.isActiveReports=false;
      this.isActiveDashboard=false;
    }
  }



  constructor(private alertService: AlertService,
    private announcementService: AnnouncementService) { }

  ngOnInit(): void {
    this.getAlerts();
    this.getAnnouncements()
  }

  getAlerts(): void {
    this.alertService.getAlerts()
    .subscribe(alerts => this.alerts = alerts);
  }

  getAnnouncements(): void {
    this.announcementService.getAnnouncements()
    .subscribe(announcements => this.announcements = announcements);
  }

  changeActiveRead(alert:IAlert) {
    alert.unread=!alert.unread;
  }

  changeAnnouncementRead(announcement:IAnnouncement) {
    announcement.unread=!announcement.unread;
  }
}
