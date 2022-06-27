// function myFunction() {
//     var x = document.getElementById("myTopnav");
//     if (x.className === "container") {
//       x.className += " responsive";
//     } else {
//       x.className = "container";
//     }
// }
const gridding = document.querySelector('.gridding')

fetch('../js/data.json')
    .then(response => response.json())
    .then(data => {
        for (i of data) {
            const bigrectangles = document.createElement('div');
            bigrectangles.classList.add('bigrectangle');

            const rectangles = document.createElement('div');
            rectangles.classList.add('rectangles');
            bigrectangles.appendChild(rectangles);

            const imgspan = document.createElement('span');
            imgspan.classList.add('imgspan');
            rectangles.appendChild(imgspan);

            const courseimg = document.createElement('img');
            courseimg.classList.add('courseimg');
            courseimg.setAttribute('src', i.img);
            imgspan.appendChild(courseimg);

            const rightcontent = document.createElement('div');
            rightcontent.classList.add('rightcontent');
            rectangles.appendChild(rightcontent);

            const namestar = document.createElement('div');
            namestar.classList.add('namestar');
            rightcontent.appendChild(namestar);

            const coursename = document.createElement('span');
            coursename.classList.add('coursename');
            coursename.innerHTML=i.topic;
            namestar.appendChild(coursename);

            const star = document.createElement('img');
            star.classList.add('star');
            star.setAttribute('src', "../quantumScreenAssets/icons/favourite.svg");
            namestar.appendChild(star);

            const br = document.createElement('br');
            namestar.appendChild(br);

            const subject = document.createElement('div');
            subject.classList.add('subject');
            rightcontent.appendChild(subject);

            const subjectspan = document.createElement('span');
            subjectspan.innerHTML=i.subject;
            subject.appendChild(subjectspan);

            const subjectbarspan = document.createElement('span');
            subjectbarspan.innerHTML='|';
            subject.appendChild(subjectbarspan);

            const subjectgradespan = document.createElement('span');
            subjectgradespan.innerHTML=`Grade ${i.grade}`;
            subject.appendChild(subjectgradespan);

            const subjectaddspan = document.createElement('span');
            subjectaddspan.innerHTML=`${i.gradeExtra}`;
            subject.appendChild(subjectaddspan);

            const info = document.createElement('div');
            info.classList.add('info');
            rightcontent.appendChild(info);

            if ((i.units!=null) && (i.lessons!=null) && (i.topics!=null)) {

                const content = document.createElement('div');
                content.classList.add('content');
                info.appendChild(content);

                const contentspan1 = document.createElement('span');
                contentspan1.innerHTML=i.units+'&nbsp;';
                content.appendChild(contentspan1);

                const contentspan2 = document.createElement('span');
                contentspan2.innerHTML='Units&nbsp;&nbsp;';
                content.appendChild(contentspan2);

                const contentspan3 = document.createElement('span');
                contentspan3.innerHTML=i.lessons+'&nbsp;';
                content.appendChild(contentspan3);

                const contentspan4 = document.createElement('span');
                contentspan4.innerHTML='Lessons&nbsp;&nbsp;&nbsp;';
                content.appendChild(contentspan4);

                const contentspan5 = document.createElement('span');
                contentspan5.innerHTML=i.topics+'&nbsp;';
                content.appendChild(contentspan5);

                const contentspan6 = document.createElement('span');
                contentspan6.innerHTML='Topics';
                content.appendChild(contentspan6);

            };

            const option = document.createElement("option");
            option.text = i.teacher;
            option.value = i.teacher;
            if (i.teacher==='No Classes') {
                option.setAttribute('disabled','');
                option.setAttribute('selected','');
            }
            const select = document.createElement("select");
            select.setAttribute('name', "");
            select.setAttribute('id', "");
            select.classList.add('select')
            select.appendChild(option);
            info.appendChild(select);

            if ((i.students!= null) || (i.duration!= null)) {
                const validity = document.createElement('div');
                validity.classList.add('validity');
                info.appendChild(validity);

                if ((i.students!= null)) {

                    const validityspan = document.createElement('span');
                    validityspan.innerHTML=i.students+' Students';
                    validity.appendChild(validityspan);
    
                }
    
                if ((i.students!= null) && (i.duration!= null)) {
    
                    const validitybarspan = document.createElement('span');
                    validitybarspan.innerHTML='|';
                    validity.appendChild(validitybarspan);
    
                }
    
                if ((i.duration!=null)) {
    
                    const validitydate = document.createElement('span');
                    validitydate.innerHTML=`${i.duration}`;
                    validity.appendChild(validitydate);
    
                }
            }

            const bottombar = document.createElement('div');
            bottombar.classList.add('bottombar');
            bigrectangles.appendChild(bottombar);

            const bottomimg1 = document.createElement('img');
            bottomimg1.setAttribute('src', "../quantumScreenAssets/icons/preview.svg" );
            bottombar.appendChild(bottomimg1);

            const bottomimg2 = document.createElement('img');
            bottomimg2.setAttribute('src', "../quantumScreenAssets/icons/manage course.svg");
            bottombar.appendChild(bottomimg2);

            const bottomimg3 = document.createElement('img');
            bottomimg3.setAttribute('src',"../quantumScreenAssets/icons/grade submissions.svg" );
            bottombar.appendChild(bottomimg3);

            const bottomimg4 = document.createElement('img');
            bottomimg4.setAttribute('src', "../quantumScreenAssets/icons/reports.svg");
            bottombar.appendChild(bottomimg4);

            

            // const teacher = document.createElement('option');
            // // teacher.setAttribute('value',i.teacher)
            // teacher.innerHTML= i.teacher
            // select.appendChild(select);

            gridding.appendChild(bigrectangles);
        }
    })
