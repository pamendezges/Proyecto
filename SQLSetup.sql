IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'moviES')
  BEGIN
    CREATE DATABASE moviES

  END
go

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='users')
BEGIN
use MoviES
    CREATE TABLE users (
	id_Person INT IDENTITY (1, 1) PRIMARY KEY,
	name_user VARCHAR (255) NOT NULL,
	surname_user VARCHAR (255) NOT NULL,
	email_user VARCHAR (255) NOT NULL,
	username VARCHAR (255) NOT NULL
);
END

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='admins')
BEGIN
use MoviES
	CREATE TABLE admins (
	id_Person INT IDENTITY (1, 1) PRIMARY KEY,
	name_admin VARCHAR (255) NOT NULL,
	surname_admin VARCHAR (255) NOT NULL,
	email_admin VARCHAR (255) NOT NULL,
	adminname VARCHAR (255) NOT NULL
);
END

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='notThePasswords')
BEGIN
use MoviES
	CREATE TABLE notThePasswords (
	id_Password INT IDENTITY (1, 1) PRIMARY KEY,
	id_Person INT NOT NULL,
	not_the_Password VARCHAR (255) NOT NULL
);
END

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='bankDetails')
BEGIN
use MoviES
	CREATE TABLE bankDetails (
	id_Data INT IDENTITY (1, 1) PRIMARY KEY,
	id_Person INT NOT NULL,
	entity VARCHAR (255) NOT NULL,
	card_Number VARCHAR (255) NOT NULL,
	expiring_Date DATE NOT NULL
);
END


IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='films')
BEGIN
use MoviES
	CREATE TABLE films (
	id_Content INT IDENTITY (1, 1) PRIMARY KEY,
	title VARCHAR (255) NOT NULL,
	category VARCHAR (255) NOT NULL,
	director VARCHAR (255) NOT NULL,
	producer VARCHAR (255) NOT NULL,
	main_Actor VARCHAR (255) NOT NULL
);
END


IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='documentaries')
BEGIN
use MoviES
	CREATE TABLE documentaries (
	id_Content INT IDENTITY (1, 1) PRIMARY KEY,
	title VARCHAR (255) NOT NULL,
	category VARCHAR (255) NOT NULL,
	tv_Producer VARCHAR (255) NOT NULL,
	voiceover BIT NOT NULL
);
END



