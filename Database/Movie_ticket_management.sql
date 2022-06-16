USE [Movie_ticket_management];

CREATE TABLE [Role](
	code VARCHAR(10) NOT NULL UNIQUE, 
	name VARCHAR(20),
	description VARCHAR(MAX),
	
	PRIMARY KEY(code),
	CONSTRAINT RightRoleCode CHECK 
		  (code = 'ADMIN' OR 
		  code = 'MANAGER' OR 
		  code = 'USER')
)

GO

CREATE TABLE [User](
	username VARCHAR(20) NOT NULL UNIQUE, 
	password VARCHAR(20) NOT NULL,
	fullname VARCHAR(100),
	address VARCHAR(MAX), 
	phone VARCHAR(10),
	birthday DATE, 
	email VARCHAR(20),
	balance FLOAT,

	role_code VARCHAR(10),

	-- PRIMARY KEY(username), 
	FOREIGN KEY (role_code) REFERENCES [Role](code)
)

GO 

ALTER TABLE [User]
ADD CONSTRAINT PK_User PRIMARY KEY (username);

GO

CREATE TABLE [Room] (
	roomid INT NOT NULL IDENTITY(1,1), 
	name VARCHAR(10), 
	num_of_seats INT,

	PRIMARY KEY(roomid)
)

GO

CREATE TABLE Seat (
	seatid INT NOT NULL IDENTITY(1,1), 
	code VARCHAR(10), 
	kind VARCHAR(10), 
	status BIT, 
	room_id INT,

	PRIMARY KEY(seatid),
	FOREIGN KEY(room_id) REFERENCES [Room](roomid), 
	CHECK (kind = 'VIP' OR kind = 'COMMON')
)

GO

CREATE TABLE Movie (
	movieid INT NOT NULL IDENTITY(1,1), 
	name VARCHAR(MAX), 
	rating INT, 
	genre VARCHAR(20), 
	short_description VARCHAR(MAX), 
	duration INT, 
	trailer VARCHAR(MAX),
	thumbnail VARCHAR(MAX),

	PRIMARY KEY (movieid)
)

GO

CREATE TABLE [Schedule] (
	scheduleid INT NOT NULL IDENTITY(1,1), 
	start_time DATETIME, 
	end_time DATETIME, 

	movie_id INT, 
	room_id INT,

	PRIMARY KEY(scheduleid), 
	FOREIGN KEY (movie_id) REFERENCES [Movie](movieid), 
	FOREIGN KEY (room_id) REFERENCES [Room](roomid),
	CHECK (start_time < end_time)
)

GO

CREATE TABLE [Statistics] (
	statisticsid INT NOT NULL IDENTITY(1,1), 
	revenue FLOAT, 
	sum_of_ticket INT, 
	[date] DATETIME,

	PRIMARY KEY (statisticsid)
)

GO

CREATE TABLE Ticket (
	ticketid INT NOT NULL IDENTITY(1,1), 
	price FLOAT, 
	booking_date DATETIME,

	schedule_id INT, 
	username VARCHAR(20), 
	seat_id INT,
	statistics_id INT,

	PRIMARY KEY(ticketid),
	FOREIGN KEY (schedule_id) REFERENCES Schedule(scheduleid),
	FOREIGN KEY (username) REFERENCES [User](username),
	FOREIGN KEY (statistics_id) REFERENCES [Statistics](statisticsid),
	FOREIGN KEY (seat_id) REFERENCES [Seat](seatid)
)

GO

CREATE TABLE [Character] (
	characterid INT NOT NULL IDENTITY(1,1), 
	fullname VARCHAR(100), 
	birthday DATE, 
	height INT,

	PRIMARY KEY (characterid)
)

GO

CREATE TABLE Filming(
	movie_id INT NOT NULL, 
	character_id INT NOT NULL,

	FOREIGN KEY (movie_id) REFERENCES Movie(movieid),
	FOREIGN KEY (character_id) REFERENCES [Character](characterid)
)

GO 


/* ================== Auditing ================== */
/*===== Role =====*/
ALTER TABLE [Role]
ADD created_date DATETIME NULL,
	created_by VARCHAR(20) NULL, 
	modified_date DATETIME NULL,
	modified_by VARCHAR(20) NULL, 
	
	CONSTRAINT FK_Role_created_by FOREIGN KEY (created_by) REFERENCES [User](username), 
	CONSTRAINT FK_Role_modified_by FOREIGN KEY (modified_by) REFERENCES [User](username);

/* ============================================ Add Data ====================================== */
/*===================== Role =====================*/
INSERT INTO [Role]([code], [name], [description]) VALUES('ADMIN', 'Admin', 'This is Admin');
INSERT INTO [Role]([code], [name], [description]) VALUES('MANAGER', 'Manager', 'This is Manager');
INSERT INTO [Role]([code], [name], [description]) VALUES('USER', 'User', 'This is User');


/*===================== User =====================*/
INSERT INTO [User]([username], [password], [fullname], [address], [phone], [birthday], [email], [balance], [role_code])
VALUES ('admin', '123456', 'Admin', 'Quang Binh', '0123456789', '2020-04-15', 'abc@gmail.com', 1500000, 'ADMIN');

INSERT INTO [User]([username], [password], [fullname], [address], [phone], [birthday], [email], [balance], [role_code])
VALUES ('manager1', '123456', 'Manager 1', 'Quang Binh', '0123456789', '2020-04-15', 'abc@gmail.com', 1500000, 'MANAGER');
INSERT INTO [User]([username], [password], [fullname], [address], [phone], [birthday], [email], [balance], [role_code])
VALUES ('manager2', '123456', 'Manager 2', 'Quang Binh', '0123456789', '2020-04-15', 'abc@gmail.com', 1500000, 'MANAGER');
INSERT INTO [User]([username], [password], [fullname], [address], [phone], [birthday], [email], [balance], [role_code])
VALUES ('manager3', '123456', 'Manager 3', 'Quang Binh', '0123456789', '2020-04-15', 'abc@gmail.com', 1500000, 'MANAGER');

INSERT INTO [User]([username], [password], [fullname], [address], [phone], [birthday], [email], [balance], [role_code])
VALUES ('user1', '123456', 'User 1', 'Quang Binh', '0123456789', '2020-04-15', 'abc@gmail.com', 15000, 'USER');
INSERT INTO [User]([username], [password], [fullname], [address], [phone], [birthday], [email], [balance], [role_code])
VALUES ('user2', '123456', 'User 2', 'Quang Binh', '0123456789', '2020-04-15', 'abc@gmail.com', 1500000, 'USER');
INSERT INTO [User]([username], [password], [fullname], [address], [phone], [birthday], [email], [balance], [role_code])
VALUES ('user3', '123456', 'User 3', 'Quang Binh', '0123456789', '2020-04-15', 'abc@gmail.com', 1500000, 'USER');
INSERT INTO [User]([username], [password], [fullname], [address], [phone], [birthday], [email], [balance], [role_code])
VALUES ('user4', '123456', 'User 4', 'Quang Binh', '0123456789', '2020-04-15', 'abc@gmail.com', 1500000, 'USER');
INSERT INTO [User]([username], [password], [fullname], [address], [phone], [birthday], [email], [balance], [role_code])
VALUES ('user5', '123456', 'User 5', 'Quang Binh', '0123456789', '2020-04-15', 'abc@gmail.com', 1500000, 'USER');
INSERT INTO [User]([username], [password], [fullname], [address], [phone], [birthday], [email], [balance], [role_code])
VALUES ('user6', '123456', 'User 6', 'Quang Binh', '0123456789', '2020-04-15', 'abc@gmail.com', 1500000, 'USER');
INSERT INTO [User]([username], [password], [fullname], [address], [phone], [birthday], [email], [balance], [role_code])
VALUES ('user7', '123456', 'User 7', 'Quang Binh', '0123456789', '2020-04-15', 'abc@gmail.com', 1500000, 'USER');

/*===================== Character =====================*/
INSERT INTO [Character](fullname, birthday, height) 
VALUES('Character 1', '2020-04-15', 160);
INSERT INTO [Character](fullname, birthday, height) 
VALUES('Character 2', '2020-04-15', 160);
INSERT INTO [Character](fullname, birthday, height) 
VALUES('Character 3', '2020-04-15', 160);
INSERT INTO [Character](fullname, birthday, height) 
VALUES('Character 4', '2020-04-15', 160);
INSERT INTO [Character](fullname, birthday, height) 
VALUES('Character 5', '2020-04-15', 160);
INSERT INTO [Character](fullname, birthday, height) 
VALUES('Character 6', '2020-04-15', 160);


/*===================== Movie =====================*/
INSERT INTO [Movie] ([name], [rating], [genre], [short_description], [trailer], [thumbnail], [duration])
VALUES('Movie 1', 5, 'Hanh dong', 'Day la phim hanh dong', null, null, 90);
INSERT INTO [Movie] ([name], [rating], [genre], [short_description], [trailer], [thumbnail], [duration])
VALUES('Movie 2', 5, 'Tinh cam', 'Day la movie 2', null, null, 100);
INSERT INTO [Movie] ([name], [rating], [genre], [short_description], [trailer], [thumbnail], [duration])
VALUES('Movie 3', 5, 'Hai', 'Day la movie 3', null, null, 80);
INSERT INTO [Movie] ([name], [rating], [genre], [short_description], [trailer], [thumbnail], [duration])
VALUES('Movie 4', 5, 'Kinh di', 'Day la movie 4', null, null, 76);
INSERT INTO [Movie] ([name], [rating], [genre], [short_description], [trailer], [thumbnail], [duration])
VALUES('Movie 5', 5, 'Hanh dong', 'Day la movie 5', null, null, 90);
INSERT INTO [Movie] ([name], [rating], [genre], [short_description], [trailer], [thumbnail], [duration])
VALUES('Movie 6', 5, 'Tinh cam', 'Day la movie 6', null, null, 100);
INSERT INTO [Movie] ([name], [rating], [genre], [short_description], [trailer], [thumbnail], [duration])
VALUES('Movie 7', 5, 'Hai', 'Day la movie 7', null, null, 80);
INSERT INTO [Movie] ([name], [rating], [genre], [short_description], [trailer], [thumbnail], [duration])
VALUES('Movie 8', 5, 'Kinh di', 'Day la movie 8', null, null, 76);


/*===================== Filming =====================*/
INSERT INTO [Filming]([movie_id], [character_id]) 
VALUES(1, 6);
INSERT INTO [Filming]([movie_id], [character_id]) 
VALUES(2, 5);
INSERT INTO [Filming]([movie_id], [character_id]) 
VALUES(3, 4);
INSERT INTO [Filming]([movie_id], [character_id]) 
VALUES(4, 3);
INSERT INTO [Filming]([movie_id], [character_id]) 
VALUES(5, 2);
INSERT INTO [Filming]([movie_id], [character_id]) 
VALUES(6, 1);
INSERT INTO [Filming]([movie_id], [character_id]) 
VALUES(7, 2);
INSERT INTO [Filming]([movie_id], [character_id]) 
VALUES(8, 3);
INSERT INTO [Filming]([movie_id], [character_id]) 
VALUES(7, 4);
INSERT INTO [Filming]([movie_id], [character_id]) 
VALUES(6, 5);
INSERT INTO [Filming]([movie_id], [character_id]) 
VALUES(5, 6);


/*===================== Room =====================*/
INSERT INTO [Room]([name], [num_of_seats])
VALUES('Room 1', 10);
INSERT INTO [Room]([name], [num_of_seats])
VALUES('Room 2', 15);
INSERT INTO [Room]([name], [num_of_seats])
VALUES('Room 3', 15);
INSERT INTO [Room]([name], [num_of_seats])
VALUES('Room 4', 10);


/*===================== Seat =====================*/
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(101, 'VIP', 0, 1);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(102, 'VIP', 0, 1);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(103, 'VIP', 0, 1);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(104, 'VIP', 0, 1);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(105, 'VIP', 0, 1);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(106, 'COMMON', 0, 1);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(107, 'COMMON', 0, 1);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(108, 'COMMON', 0, 1);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(109, 'COMMON', 0, 1);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(1010, 'COMMON', 0, 1);

INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(201, 'VIP', 0, 2);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(202, 'VIP', 0, 2);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(203, 'VIP', 0, 2);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(204, 'VIP', 0, 2);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(205, 'VIP', 0, 2);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(206, 'COMMON', 0, 2);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(207, 'COMMON', 0, 2);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(208, 'COMMON', 0, 2);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(209, 'COMMON', 0, 2);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(2010, 'COMMON', 0, 2);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(2011, 'COMMON', 0, 2);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(2012, 'COMMON', 0, 2);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(2013, 'COMMON', 0, 2);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(2014, 'COMMON', 0, 2);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(2015, 'COMMON', 0, 2);

INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(301, 'VIP', 0, 3);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(302, 'VIP', 0, 3);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(303, 'VIP', 0, 3);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(304, 'COMMON', 0, 3);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(305, 'VIP', 0, 3);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(306, 'COMMON', 0, 3);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(307, 'COMMON', 0, 3);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(308, 'COMMON', 0, 3);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(309, 'COMMON', 0, 3);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(3010, 'COMMON', 0, 3);

INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(401, 'VIP', 0, 4);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(402, 'VIP', 0, 4);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(403, 'VIP', 0, 4);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(404, 'VIP', 0, 4);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(405, 'VIP', 0, 4);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(406, 'COMMON', 0, 4);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(407, 'COMMON', 0, 4);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(408, 'COMMON', 0, 4);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(409, 'COMMON', 0, 4);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(4010, 'COMMON', 0, 4);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(4011, 'COMMON', 0, 4);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(4012, 'COMMON', 0, 4);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(4013, 'COMMON', 0, 4);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(4014, 'COMMON', 0, 4);
INSERT INTO [Seat]([code], [kind], [status], [room_id])
VALUES(4015, 'COMMON', 0, 4);


/*===================== Schedule =====================*/
INSERT INTO [Schedule]([start_time], [end_time], [movie_id], [room_id])
VALUES ('2020-05-23 13:00:00', '2020-05-23 14:30:00', 1, 3);
INSERT INTO [Schedule]([start_time], [end_time], [movie_id], [room_id])
VALUES ('2020-05-23 14:00:00', '2020-05-23 15:30:00', 1, 2);
INSERT INTO [Schedule]([start_time], [end_time], [movie_id], [room_id])
VALUES ('2020-05-23 13:00:00', '2020-05-23 14:30:00', 1, 4);
INSERT INTO [Schedule]([start_time], [end_time], [movie_id], [room_id])
VALUES ('2020-05-23 21:00:00', '2020-05-23 22:30:00', 1, 1);

INSERT INTO [Schedule]([start_time], [end_time], [movie_id], [room_id])
VALUES ('2020-05-24 21:00:00', '2020-05-24 22:40:00', 2, 1);
INSERT INTO [Schedule]([start_time], [end_time], [movie_id], [room_id])
VALUES ('2020-05-24 19:00:00', '2020-05-24 20:40:00', 2, 2);
INSERT INTO [Schedule]([start_time], [end_time], [movie_id], [room_id])
VALUES ('2020-05-24 20:00:00', '2020-05-24 21:40:00', 2, 3);
INSERT INTO [Schedule]([start_time], [end_time], [movie_id], [room_id])
VALUES ('2020-05-24 21:00:00', '2020-05-24 22:40:00', 2, 4);

INSERT INTO [Schedule]([start_time], [end_time], [movie_id], [room_id])
VALUES ('2020-05-25 21:00:00', '2020-05-25 22:20:00', 3, 1);
INSERT INTO [Schedule]([start_time], [end_time], [movie_id], [room_id])
VALUES ('2020-05-25 14:00:00', '2020-05-25 15:20:00', 3, 2);
INSERT INTO [Schedule]([start_time], [end_time], [movie_id], [room_id])
VALUES ('2020-05-25 16:00:00', '2020-05-25 17:20:00', 3, 3);
INSERT INTO [Schedule]([start_time], [end_time], [movie_id], [room_id])
VALUES ('2020-05-25 22:00:00', '2020-05-25 23:20:00', 3, 4);

INSERT INTO [Schedule]([start_time], [end_time], [movie_id], [room_id])
VALUES ('2020-05-26 21:00:00', '2020-05-26 22:16:00', 4, 1);
INSERT INTO [Schedule]([start_time], [end_time], [movie_id], [room_id])
VALUES ('2020-05-26 22:00:00', '2020-05-26 23:16:00', 4, 2);
INSERT INTO [Schedule]([start_time], [end_time], [movie_id], [room_id])
VALUES ('2020-05-26 15:00:00', '2020-05-26 16:16:00', 4, 3);
INSERT INTO [Schedule]([start_time], [end_time], [movie_id], [room_id])
VALUES ('2020-05-26 20:00:00', '2020-05-26 21:16:00', 4, 4);


/*===================== Ticket =====================*/
INSERT INTO [Ticket]([price],[schedule_id],[username],[seat_id])
VALUES (85000, 5, 'user1', 1);
INSERT INTO [Ticket]([price],[schedule_id],[username],[seat_id])
VALUES (75000, 2, 'user2', 2);
INSERT INTO [Ticket]([price],[schedule_id],[username],[seat_id])
VALUES (65000, 1, 'user3', 3);
INSERT INTO [Ticket]([price],[schedule_id],[username],[seat_id])
VALUES (35000, 3, 'user4', 5);
INSERT INTO [Ticket]([price],[schedule_id],[username],[seat_id])
VALUES (85000, 5, 'user3', 6);
INSERT INTO [Ticket]([price],[schedule_id],[username],[seat_id])
VALUES (55000, 4, 'user2', 7);
INSERT INTO [Ticket]([price],[schedule_id],[username],[seat_id])
VALUES (65000, 5, 'user1', 8);
INSERT INTO [Ticket]([price],[schedule_id],[username],[seat_id])
VALUES (75000, 6, 'user2', 9);
INSERT INTO [Ticket]([price],[schedule_id],[username],[seat_id])
VALUES (85000, 1, 'user3', 10);

