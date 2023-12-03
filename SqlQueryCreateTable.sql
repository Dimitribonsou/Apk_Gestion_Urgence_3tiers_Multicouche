CREATE TABLE Personnel(
id_perso int primary key,nom varchar(100),prenom varchar(50),mdp varchar(200),tel varchar(20),
service varchar(50),role int default 0,email varchar(50),quartier varchar(50)
);
CREATE TABLE Service(
id_serv int primary key,nom varchar(50),filiere varchar(50),description text,id_perso int ,foreign key(id_perso) REFERENCES Personnel(id_perso));
CREATE TABLE Probleme
(
id_pb int primary key ,libelle varchar(50),description text,id_serv int ,id_perso int,foreign key(id_serv) REFERENCES Service(id_serv),foreign key (id_perso) REFERENCES Personnel(id_perso)
);
CREATE TABLE Information
(
  id_info int primary key,libelle varchar(50),message text,date_envoie datetime,date_expiration datetime,id_serv int,foreign key (id_serv) REFERENCES Service(id_serv)
);
CREATE TABLE Programme
(
 id_prog int primary key,titre varchar(50),date_debut datetime,date_fin datetime,description text,id_serv int ,foreign key(id_serv) REFERENCES Service(id_serv)
);
