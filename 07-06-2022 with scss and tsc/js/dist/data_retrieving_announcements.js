"use strict";
const newAnnounce = document.querySelector('li.announcement .alertul');
fetch('../js/dist/announcements.json')
    .then(response => response.json())
    .then(data => {
    for (let i of data) {
        const announceLiEl = document.createElement('li');
        announceLiEl.classList.add('alertli');
        const pa = document.createElement('span');
        pa.classList.add('pa');
        pa.innerHTML = 'PA: ';
        const paInner = document.createElement('span');
        paInner.innerHTML = i.pa;
        pa.appendChild(paInner);
        announceLiEl.appendChild(pa);
        const read = document.createElement('span');
        read.classList.add('read');
        const readimg = document.createElement('img');
        readimg.setAttribute('src', "../quantumScreenAssets/images/unread.png");
        read.appendChild(readimg);
        announceLiEl.appendChild(read);
        newAnnounce.appendChild(announceLiEl);
    }
});
