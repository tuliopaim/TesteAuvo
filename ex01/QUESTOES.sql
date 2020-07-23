USE AvaliacaoAuvo

--Faça uma consulta SQL que retorne o número de tarefas de um determinado período,
--agrupado pelos usuários.

SELECT Usuario.user_id, Usuario.user_name, COUNT(1) as numero_de_tarefas
FROM tbTarefa AS Tarefa
INNER JOIN tbUser AS Usuario
	ON Tarefa.task_user_para = Usuario.user_id
WHERE Tarefa.task_date BETWEEN '2020-07-20' AND '2020-08-01'
GROUP BY Usuario.user_id, Usuario.user_name

--Faça uma consulta Sql que retorne todos os reagendamentos de uma tarefa ordenado pelo código do usuário.

SELECT Usuario.user_id, Usuario.user_login, Reagendamento.*
FROM tbReagendamento AS Reagendamento
INNER JOIN tbTarefa AS Tarefa
	ON Reagendamento.reag_id_task = Tarefa.task_id
INNER JOIN tbUser AS Usuario
	ON Tarefa.task_user_para = Usuario.user_id
--WHERE Tarefa.task_id = 2
ORDER BY Usuario.user_id

--Faça uma consulta Sql que retorne todos os usuários que possuem mais de cinquenta tarefas.

SELECT Usuario.user_id
FROM tbTarefa AS Tarefa
INNER JOIN tbUser AS Usuario
	ON Tarefa.task_user_para = Usuario.user_id
GROUP BY Usuario.user_id
HAVING COUNT(1) > 50

--Faça uma Sql que retorno todas as tarefas duplicadas.

SELECT	 task_user_para
		,task_latitude	
		,task_longitude	
		,tbTarefacol
FROM tbTarefa
GROUP BY  task_user_para
		 ,task_latitude	
		 ,task_longitude	
		 ,tbTarefacol		
HAVING COUNT(1) > 1