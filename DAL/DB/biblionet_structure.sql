  
create database if not exists biblionet character set utf8 collate utf8_unicode_ci;
use biblionet;

grant all privileges on biblionet.* to 'biblionet_user'@'localhost' identified by 'secret';

drop table if exists emprunt;
drop table if exists livre;
drop table if exists utilisateur;

create table utilisateur (
    util_id integer not null primary key auto_increment,
    util_nom varchar(100) not null,
    util_prenom varchar(100) not null
);

create table livre (
    livre_id integer not null primary key auto_increment,
    livre_isbn varchar(14) not null,
    livre_titre varchar(150) not null,
    livre_auteur varchar(150) not null
);

create table emprunt (
  empr_id integer not null primary key auto_increment,
  empr_date date not null,
  empr_rendu boolean not null,
  util_id integer not null,
  livre_id integer not null,
  foreign key (livre_id) references livre(livre_id),
  foreign key (util_id) references utilisateur(util_id)
);
