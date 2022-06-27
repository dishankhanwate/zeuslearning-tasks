"use strict";
const lidown = document.querySelectorAll('.lidown');
const uldown = document.querySelector('ul.down');
const hamburger = document.querySelector('.hamburger');
lidown.forEach(n => n.addEventListener('click', () => {
    lidown.forEach(a => {
        if (a !== n) {
            a.classList.remove('active');
        }
    });
    n.classList.toggle('active');
}));
hamburger.addEventListener('click', () => {
    uldown.classList.toggle('active');
});
const alertlist = document.querySelector('.alert');
const alertLogo = document.querySelector('.alerts');
alertLogo.addEventListener('click', () => {
    alertlist.classList.toggle('active');
});
const alertli = document.querySelectorAll('.alertli');
const readspan = document.querySelectorAll('span.read');
for (let i = 0; i < readspan.length; i++) {
    readspan[i].addEventListener('click', () => {
        alertli[i].classList.toggle('active');
    });
}
const announcementlist = document.querySelector('.announcement');
const announcementLogo = document.querySelector('.announcements');
announcementLogo.addEventListener('click', () => {
    announcementlist.classList.toggle('active');
});
