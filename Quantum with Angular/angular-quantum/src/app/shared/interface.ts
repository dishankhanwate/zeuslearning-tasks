export interface IAlert {
    id:number;
    name: string;
    unread: boolean;
    course: string;
    class: string;
    date: {
        day: number;
        month: string;
        year: number;
    };
    time: {
        hour: number;
        minute: number;
        pm: boolean;
    }
}

export interface IAnnouncement {
    id:number;
    pa:string;
    name: string;
    unread:boolean;
    course: string;
    class:string;
    files:number;
    date: {
        day: number;
        month: string;
        year: number;
    };
    time: {
        hour: number;
        minute: number;
        pm: boolean;
    }
}

export interface IDashboard {
    id:number;
    image:string;
    name:string;
    subject:string;
    grade:number;
    gradeExtra:number;
    units?:number;
    lessons?:number;
    topics?:number;
    classes: string[];
    students?: number;
    dateFrom?: {
        day: number;
        month: string;
        year: number;
    };
    dateTo?: {
        day: number;
        month: string;
        year: number;
    };
}