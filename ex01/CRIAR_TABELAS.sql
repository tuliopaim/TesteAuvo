CREATE TABLE TbUser(
	user_id int primary key identity,
	user_name varchar(45),
	user_cargo varchar(45),
	user_login varchar(45),
	user_senha varchar(45)
)

CREATE TABLE tbTarefa(
	task_id int primary key identity,
	task_user_para int foreign key references TbUser(user_id),
	task_date date,
	task_latitude decimal,
	task_longitude decimal,
	tbTarefacol varchar(45)
)

CREATE TABLE tbReagendamento(
	reag_id int primary key identity,
	reag_id_task int foreign key references tbTarefa(task_id),
	reag_date date
)


INSERT INTO TbUser 
VALUES
('Candidato 1', 'dev', 'candidato1', 'senhasecreta'),
('Candidato 2', 'dev', 'candidato2', 'senhasecret@'),
('Candidato 3', 'dev', 'candidato3', 'senhasecr3ta'),
('Candidato 4', 'dev', 'candidato4', 'senhas3creta'),
('Avaliador 1', 'Avaliador', 'avaliador1', 'senhasecreta'),
('Avaliador 2', 'Avaliador', 'avaliador2', 'senhasecreta')

INSERT INTO tbTarefa
VALUES
(1, '2020-07-24', 1, 2, 'Realizar teste'),
(2, '2020-07-31', 3, 4, 'Realizar teste'),
(3, '2020-08-07', 5, 6, 'Realizar teste'),
(4, '2020-07-24', 7, 8, 'Realizar teste'),
(5, '2020-07-24', 9, 10, 'Corrigir teste'),
(5, '2020-07-31', 11, 12, 'Corrigir teste'),
(6, '2020-08-07', 13, 14, 'Corrigir teste'),
(6, '2020-07-24', 15, 16, 'Corrigir teste'),
(6, '2020-08-07', 13, 14, 'Corrigir teste'),
(5, '2020-08-10', 15, 16, 'Definir candidato ideal'),
(5, '2020-08-10', 15, 16, 'Definir candidato ideal'),
(6, '2020-08-10', 15, 16, 'Definir candidato ideal')

INSERT INTO tbReagendamento
VALUES
(2, '2020-08-07'),
(6, '2020-08-07')