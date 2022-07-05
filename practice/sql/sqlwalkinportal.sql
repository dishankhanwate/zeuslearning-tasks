show databases;
use walkinportal;

show tables;

select * from job_roles;


insert into job_roles(title,job_details)
values ('Instructional Designer' ,
'{"Gross Compensation Package":"Rs. 5,00,000 lpa",
"Role Description :":"- Generate highly interactive and innovative instructional strategies for e-learning solutions - Develop course structure and learning specifications addressing the requirements of the target audience - Construct appropriate testing strategies to ensure learners\' understanding and performance - Address usability issues - Keep abreast of new trends in e-learning - Ensure that the instructional strategies are as per global standards - Prepare instructional design checklists and guidelines - Check for quality assurance",
"Requirements :":"- Experience in creating instructional plans and course maps. - Experience in the use of media like graphics, illustrations, photographs, audio, video, animations, and simulations in instruction - Awareness of different instructional design models and familiarity with instructional and learning theories - Awareness of latest trends in e-learning and instructional design - Strong client consulting/interfacing skills. - Ability to guide clients to focus on specific objectives and teaching points - Strong meeting facilitation, presentation and interpersonal skills - A thorough understanding of the web as an instructional medium - Post graduate degree in Education, Instructional Design, Mass Communication or Journalism"}');

insert into job_roles(title,job_details)
values ('Software Engineer' ,
'{"Gross Compensation Package":"Rs. 5,00,000 lpa",
"Role Description :":"- Generate highly interactive and innovative instructional strategies for e-learning solutions - Develop course structure and learning specifications addressing the requirements of the target audience - Construct appropriate testing strategies to ensure learners\' understanding and performance - Address usability issues - Keep abreast of new trends in e-learning - Ensure that the instructional strategies are as per global standards - Prepare instructional design checklists and guidelines - Check for quality assurance",
"Requirements :":"- Experience in creating instructional plans and course maps. - Experience in the use of media like graphics, illustrations, photographs, audio, video, animations, and simulations in instruction - Awareness of different instructional design models and familiarity with instructional and learning theories - Awareness of latest trends in e-learning and instructional design - Strong client consulting/interfacing skills. - Ability to guide clients to focus on specific objectives and teaching points - Strong meeting facilitation, presentation and interpersonal skills - A thorough understanding of the web as an instructional medium - Post graduate degree in Education, Instructional Design, Mass Communication or Journalism"}'),
('Software Quality Engineer' ,
'{"Gross Compensation Package":"Rs. 5,00,000 lpa",
"Role Description :":"- Generate highly interactive and innovative instructional strategies for e-learning solutions - Develop course structure and learning specifications addressing the requirements of the target audience - Construct appropriate testing strategies to ensure learners\' understanding and performance - Address usability issues - Keep abreast of new trends in e-learning - Ensure that the instructional strategies are as per global standards - Prepare instructional design checklists and guidelines - Check for quality assurance",
"Requirements :":"- Experience in creating instructional plans and course maps. - Experience in the use of media like graphics, illustrations, photographs, audio, video, animations, and simulations in instruction - Awareness of different instructional design models and familiarity with instructional and learning theories - Awareness of latest trends in e-learning and instructional design - Strong client consulting/interfacing skills. - Ability to guide clients to focus on specific objectives and teaching points - Strong meeting facilitation, presentation and interpersonal skills - A thorough understanding of the web as an instructional medium - Post graduate degree in Education, Instructional Design, Mass Communication or Journalism"}');

select * from walk_ins;


insert into walk_ins(title,from_date,to_date, location, expiry_date, internship_detail)
values ('Walk in for Design Job Role', '2021-10-08','2021-11-08','Mumbai','2021-05-08','');

insert into walk_ins(title,from_date,to_date, location, expiry_date, internship_detail)
values ('Walk In for Multiple Job Roles', '2021-10-03','2021-11-04','Mumbai','2021-10-08','Internship Opportunity for MCA Students'),
('Walk In for Design and Development Job Role', '2021-10-10','2021-11-11','Mumbai','2021-10-08','');

insert into post_application_guidelines(fields)
values('{"Date & Time of Walk-In":"",
"Venue of Walk-In":"Zeus Systems Pvt. Ltd. 1402, 14th Floor, Tower B, Peninsula Business Park. Ganpatrao Kadam Marg Lower Parel (W) Mumbai - 400 013 Phone: +91-22-66600000",
"THINGS TO REMEMBER":"- Please report 30 MINUTES prior to your reporting time. - Download your Hall Ticket from below and carry it with you during your Walk-In."}');

select * from post_application_guidelines;

select * from pre_requisites;

insert into pre_requisites(fields,walk_ins_id)
values('{"General Instructions":"- We have a two–year indemnity for permanent candidates. We will provide training to the selected candidates. - Candidates who have appeared for any test held by Zeus Learning in the past 12 months will not be allowed to appear for this recruitment test.",
"Instructions for the Exam":"- Candidates are requested to log in half an hour prior to the exam start time as they would need to capture their image using a web camera. By taking this test, you are permitting the examination system to capture your video for invigilation purposes. - Candidates would not be able to appear for the exam if the web camera attached to their system is not functional. - The web camera of your system must be enabled and must remain switched on throughout the examination. In the event of non-receipt of a webcam, your examination will be considered null and void. - Candidate’s audio and video will be recorded during the examination and will also be monitored by a live proctor. The proctor may terminate your exam in case he/she observes any malpractice during the exam. - Candidates are advised to use their own Laptop/PC with a stable internet connection (min 1 Mbps) during the exam. - Candidates cannot use an iOS system/device for this exam.",
"Minimum System Requirements":"- Personal Laptop or Desktop computer in working condition with good quality camera (you can use Windows 7 and above). - The latest version of Google Chrome Browser only. - Please note that Internet speed should be minimum 1 Mbps. - Do not use a MacBook or iPad for the proctored exam.",
"Process":"- Every round is an elimination round. Candidates need to clear all rounds to get selected. Round I : 4th August, 2018 Aptitude Test : 25 Questions Round II (Interview) : 4th August, 2018."}',
(select id from walk_ins where title='Walk in for Design Job Role'));

insert into pre_requisites(fields,walk_ins_id)
values('{"General Instructions":"- We have a two–year indemnity for permanent candidates. We will provide training to the selected candidates. - Candidates who have appeared for any test held by Zeus Learning in the past 12 months will not be allowed to appear for this recruitment test.",
"Instructions for the Exam":"- Candidates are requested to log in half an hour prior to the exam start time as they would need to capture their image using a web camera. By taking this test, you are permitting the examination system to capture your video for invigilation purposes. - Candidates would not be able to appear for the exam if the web camera attached to their system is not functional. - The web camera of your system must be enabled and must remain switched on throughout the examination. In the event of non-receipt of a webcam, your examination will be considered null and void. - Candidate’s audio and video will be recorded during the examination and will also be monitored by a live proctor. The proctor may terminate your exam in case he/she observes any malpractice during the exam. - Candidates are advised to use their own Laptop/PC with a stable internet connection (min 1 Mbps) during the exam. - Candidates cannot use an iOS system/device for this exam.",
"Minimum System Requirements":"- Personal Laptop or Desktop computer in working condition with good quality camera (you can use Windows 7 and above). - The latest version of Google Chrome Browser only. - Please note that Internet speed should be minimum 1 Mbps. - Do not use a MacBook or iPad for the proctored exam.",
"Process":"- Every round is an elimination round. Candidates need to clear all rounds to get selected. Round I : 4th August, 2018 Aptitude Test : 25 Questions Round II (Interview) : 4th August, 2018."}',
(select id from walk_ins where title='Walk In for Design and Development Job Role')),
('{"General Instructions":"- We have a two–year indemnity for permanent candidates. We will provide training to the selected candidates. - Candidates who have appeared for any test held by Zeus Learning in the past 12 months will not be allowed to appear for this recruitment test.",
"Instructions for the Exam":"- Candidates are requested to log in half an hour prior to the exam start time as they would need to capture their image using a web camera. By taking this test, you are permitting the examination system to capture your video for invigilation purposes. - Candidates would not be able to appear for the exam if the web camera attached to their system is not functional. - The web camera of your system must be enabled and must remain switched on throughout the examination. In the event of non-receipt of a webcam, your examination will be considered null and void. - Candidate’s audio and video will be recorded during the examination and will also be monitored by a live proctor. The proctor may terminate your exam in case he/she observes any malpractice during the exam. - Candidates are advised to use their own Laptop/PC with a stable internet connection (min 1 Mbps) during the exam. - Candidates cannot use an iOS system/device for this exam.",
"Minimum System Requirements":"- Personal Laptop or Desktop computer in working condition with good quality camera (you can use Windows 7 and above). - The latest version of Google Chrome Browser only. - Please note that Internet speed should be minimum 1 Mbps. - Do not use a MacBook or iPad for the proctored exam.",
"Process":"- Every round is an elimination round. Candidates need to clear all rounds to get selected. Round I : 4th August, 2018 Aptitude Test : 25 Questions Round II (Interview) : 4th August, 2018."}',
(select id from walk_ins where title='Walk In for Multiple Job Roles'));

select * from time_slots;

insert into time_slots(from_time,to_time)
values
('09:00:00','11:00:00'),
('13:00:00','15:00:00'),
('11:00:00','13:00:00'),
('15:00:00','17:00:00');


insert into walk_ins_has_job_roles(walk_ins_id,job_roles_id)
values
(1,1),
(2,1),
(2,2),
(2,3),
(3,1),
(3,2);
-- ((select id from walk_ins where title='Walk in for Design Job Role'),
-- (select id from job_roles where title='Instructional Designer')),
-- ((select id from walk_ins where title='Walk In for Design and Development Job Role')
-- ,(select id from job_roles where title in ('Instructional Designer', 'Software Engineer'))),
-- ((select id from walk_ins where title='Walk In for Multiple Job Roles'),
-- (select id from job_roles where title in ('Instructional Designer', 'Software Engineer')));

select * from walk_ins_has_job_roles;
select * from walk_ins_has_time_slots;

ALTER TABLE walk_in_applications
modify time_slots time not null;

insert into walk_ins_has_time_slots(walk_ins_id,time_slots_id)
values
(1,1),
(1,2),
(2,2),
(2,3),
(3,3),
(3,4);

select * from job_roles;
select * from post_application_guidelines;
select * from pre_requisites;
select * from time_slots;
select * from user;
select * from walk_in_applications;
select * from walk_in_applications_has_job_roles;
select * from walk_ins;
select * from walk_ins_has_job_roles;
select * from walk_ins_has_time_slots;

-- page-1: all walkins
select wi.title, jr.title, wi.from_date, wi.to_date, wi.location, wi.expiry_date, wi.internship_detail from walk_ins as wi
join walk_ins_has_job_roles as wj on wi.id = wj.walk_ins_id
join job_roles as jr on wj.job_roles_id= jr.id;


-- page-2: particular walkin 
select wi.title, wi.from_date, wi.to_date, wi.location, wi.expiry_date, wi.internship_detail,
pr.fields, ts.from_time, ts.to_time, jr.title, jr.job_details
from walk_ins as wi 
join walk_ins_has_job_roles as wj on wi.id = wj.walk_ins_id
join job_roles as jr on wj.job_roles_id= jr.id
join pre_requisites as pr on wi.id=pr.walk_ins_id
join walk_ins_has_time_slots as wt on wi.id = wt.walk_ins_id
join time_slots as ts on ts.id= wt.time_slots_id
where wi.title='Walk In for Multiple Job Roles';


