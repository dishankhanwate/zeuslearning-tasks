
const lidown = document.querySelectorAll('.lidown')
const uldown = document.querySelector('ul.down') as HTMLUListElement
const hamburger = document.querySelector('.hamburger') as HTMLSpanElement


lidown.forEach(n => n.addEventListener('click', () => {
    lidown.forEach(a => {
        if (a !== n){
            a.classList.remove('active')
        }
    })
    n.classList.toggle('active')
}))

hamburger.addEventListener('click', () => {
    uldown.classList.toggle('active')
})


// for alert button 

const alertlist = document.querySelector('.alert') as HTMLUListElement;
const alertLogo = document.querySelector('.alerts') as HTMLSpanElement;

alertLogo.addEventListener('click', () => {
    alertlist.classList.toggle('active')
})

// for read unread of alert notifications

const alertli = document.querySelectorAll('.alertli')
const readspan = document.querySelectorAll('span.read')

for (let i:number=0; i < readspan.length; i++) {
    readspan[i].addEventListener('click', () => {
        alertli[i].classList.toggle('active')
    })
}


// for announcements button

const announcementlist = document.querySelector('.announcement') as HTMLUListElement;
const announcementLogo = document.querySelector('.announcements') as HTMLSpanElement;

announcementLogo.addEventListener('click', () => {
    announcementlist.classList.toggle('active')
})