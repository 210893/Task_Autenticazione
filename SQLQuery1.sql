CREATE TABLE Amministratore(
    amministratoreID INT PRIMARY KEY IDENTITY(1,1),
    codice VARCHAR(36) DEFAULT NEWID() NOT NULL,
    username VARCHAR(250) NOT NULL,
    pass VARCHAR(250) NOT NULL,
    email VARCHAR(250) NOT NULL UNIQUE
)

CREATE TABLE Utente(
    utenteID INT PRIMARY KEY IDENTITY(1,1),
    codice VARCHAR(36) DEFAULT NEWID() NOT NULL,
    username VARCHAR(250) NOT NULL,
    pass VARCHAR(250) NOT NULL,
    email VARCHAR(250) NOT NULL UNIQUE
)

INSERT INTO Amministratore (username, pass, email)
VALUES 
    ('admin1', 'password123', 'admin1@example.com'),
    ('admin2', 'password456', 'admin2@example.com'),
    ('admin3', 'password789', 'admin3@example.com'),
    ('admin4', 'passwordABC', 'admin4@example.com'),
    ('admin5', 'passwordXYZ', 'admin5@example.com');

	INSERT INTO Utente (username, pass, email)
VALUES 
    ('user1', 'userpass123', 'user1@example.com'),
    ('user2', 'userpass456', 'user2@example.com'),
    ('user3', 'userpass789', 'user3@example.com'),
    ('user4', 'userpassABC', 'user4@example.com'),
    ('user5', 'userpassXYZ', 'user5@example.com');

	SELECT * FROM Amministratore, Utente