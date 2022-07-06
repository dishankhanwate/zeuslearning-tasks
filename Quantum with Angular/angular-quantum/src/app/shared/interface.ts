export interface IAlert {
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

// "name": "License for Introduction to Algebra has been assigned to your school",
//         "unread":true,
//         "course":"",
//         "class":"",
//         "date": {"day":15,"month":"Sep","year":2018},
//         "time": {"hour":7,"minute":21,"pm":true}

let a = {"day":15,"month":"Sep","year":2018};

console.log(a)