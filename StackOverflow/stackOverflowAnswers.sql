create database StackOverflow;

use StackOverflow;

create table questions(
id int not null auto_increment,
username varchar(50),
title varchar(50),
detail varchar(255),
posted datetime,
category varchar(50),
tags varchar(50),
status int,
primary key (id)
);

create table answers(
id int not null auto_increment,
username varchar(50),
detail varchar(255),
questionId int,
posted datetime,
upvotes int,
primary key (id),
foreign key (questionId) references questions (id)
);


INSERT INTO `stackoverflow`.`questions` (`username`, `title`, `detail`, `posted`, `category`, `tags`, `status`)
 VALUES ('ngusain', 'IIS', 'What is IIS', curdate(), '.NET', '.NET,ASP.NET', '1');
INSERT INTO `stackoverflow`.`questions` (`username`, `title`, `detail`, `posted`, `category`, `tags`, `status`) 
VALUES ('ngusain', 'GIT', 'How to checkin using git bash', curdate(), 'GIT', 'source control, git', '1');

insert into answers (id, username, detail, questionId, posted, upvotes)
Values (1, 'Sirisha', 'IIS is used to host ASP.NET web applications and static websites', 1, curdate(), 1);
insert into answers (id, username, detail, questionId, posted, upvotes)
Values (2, 'Manit', 'Use Commond Line to Push to GitHub', 2, curdate(), 1);
insert into answers (id, username, detail, questionId, posted, upvotes)
Values (3, 'Laksh', 'The git push commond is used to upload local repository content to a remote repository', 2, curdate(), 1);

select * from answers;

select * from questions;




