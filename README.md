# Pastelaria

# Para rodar o projeto, você deve criar um banco de dados local chamado Pastelaria, Depois rodar o seguinte script nele:

CREATE TABLE dbo.tarefaStatus ( 
	id                   int      NOT NULL,
	descricao            varchar(45)      NOT NULL,
	CONSTRAINT pk_tarefaStatus PRIMARY KEY  ( id ) 
 );
GO

CREATE TABLE dbo.tipoUsuario ( 
	id                   int      NOT NULL,
	descricao            varchar(45)      NOT NULL,
	CONSTRAINT pk_tipo_usuario PRIMARY KEY  ( id ) 
 );
GO

CREATE TABLE dbo.usuario ( 
	id                   int    IDENTITY  NOT NULL,
	idTipoUsuario        int      NOT NULL,
	nome                 varchar(45)      NOT NULL,
	email                varchar(100)      NOT NULL,
	[senha ]             varchar(30)      NOT NULL,
	dataExpiracaoSenha   datetime      NOT NULL,
	idUsuarioCadastro    int      NOT NULL,
	CONSTRAINT pk_usuario PRIMARY KEY  ( id ) 
 );
GO

CREATE TABLE dbo.tarefa ( 
	id                   int    IDENTITY  NOT NULL,
	idTarefaStatus       int      NOT NULL,
	descricao            varchar(2000)      NOT NULL,
	dataCriacao          datetime      NOT NULL,
	dataConclusao        datetime      NULL,
	idUsuarioCadastro    int      NOT NULL,
	CONSTRAINT pk_tarefa PRIMARY KEY  ( id ) 
 );
GO

CREATE TABLE dbo.usuarioTarefa ( 
	id					 int    IDENTITY  NOT NULL,
	idUsuario            int      NOT NULL,
	idTarefa             int      NOT NULL,
	CONSTRAINT pk_usuarioTarefa PRIMARY KEY  ( id ) 
 );
GO

CREATE TABLE dbo.comentario ( 
	id                   int    IDENTITY  NOT NULL,
	idMae                int      NULL,
	idTarefa             int      NOT NULL,
	descricao            varchar(200)      NOT NULL,
	dataCadastro         datetime      NOT NULL,
	idUsuarioCadastro    int      NOT NULL,
	CONSTRAINT pk_comentario PRIMARY KEY  ( id ) 
 );
GO

ALTER TABLE dbo.comentario ADD CONSTRAINT fk_comentario_tarefa FOREIGN KEY ( idTarefa ) REFERENCES dbo.tarefa( id );
GO

ALTER TABLE dbo.comentario ADD CONSTRAINT fk_comentario_comentario FOREIGN KEY ( idMae ) REFERENCES dbo.comentario( id );
GO

ALTER TABLE dbo.tarefa ADD CONSTRAINT fk_tarefa_tarefastatus FOREIGN KEY ( idTarefaStatus ) REFERENCES dbo.tarefaStatus( id );
GO

ALTER TABLE dbo.usuario ADD CONSTRAINT fk_usuario_tipo_usuario FOREIGN KEY ( idTipoUsuario ) REFERENCES dbo.tipoUsuario( id );
GO

ALTER TABLE dbo.usuarioTarefa ADD CONSTRAINT fk_usuariotarefa_usuariotarefa FOREIGN KEY ( idUsuario ) REFERENCES dbo.usuario( id );
GO

ALTER TABLE dbo.usuarioTarefa ADD CONSTRAINT fk_usuariotarefa_tarefa FOREIGN KEY ( idTarefa ) REFERENCES dbo.tarefa( id );
GO

# Depois você deve rodar o seguinte script nesse banco de dados:

INSERT INTO tipoUsuario (id, descricao) VALUES (1, 'Gerente');
INSERT INTO tipoUsuario (id, descricao) VALUES (2, 'Funcionário');

INSERT INTO usuario (idTipoUsuario, nome, email, senha, dataExpiracaoSenha, idUsuarioCadastro) VALUES
(1, 'Lima', 'waldsonh@gmail.com', 'limasmn', '2032-02-21T18:10:00', 1);

INSERT INTO usuario (idTipoUsuario, nome, email, senha, dataExpiracaoSenha, idUsuarioCadastro) VALUES
(2, 'Ane', 'ane@gmail.com', 'anesmn', '2032-02-21T18:10:00', 1),
(2, 'Felipe', 'felipe@gmail.com', 'felipesmn', '2032-02-21T18:10:00', 1),
(2, 'Matheus', 'matheus@gmail.com', 'matheussmn', '2032-02-21T18:10:00', 1),
(2, 'Caio', 'caio@gmail.com', 'caiosmn', '2032-02-21T18:10:00', 1),
(2, 'Joao', 'joao@gmail.com', 'joaosmn', '2032-02-21T18:10:00', 1),
(2, 'Emersson', 'emersson@gmail.com', 'emerssonsmn', '2032-02-21T18:10:00', 1),
(2, 'Arthur', 'arthur@gmail.com', 'arthursmn', '2032-02-21T18:10:00', 1);

# após isso, você deve modificar a string de conexão localizada no appSettings.json para abrir o seu banco de dados local.

# depois, abra o terminal e digite "cd Pastelaria.Web", em seguida digite "dotnet watch run" e pronto

# a tela de usuário está mostrando a lista de usuários mas não está cadastrando, o controller de cadastrar usuario está errado.