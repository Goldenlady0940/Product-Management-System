CREATE DATABASE CCONNECTION
USE CCONNECTION

CREATE TABLE PRODUCT
(
	ID INT,
	DAT DATETIME,
	INV_NUM INT,
	NAME VARCHAR(35),
	COUN INT,
	PRICE INT,
	AVAILABILITY VARCHAR(6),
	PLASTIC VARCHAR(6)
);
SELECT * FROM PRODUCT;
DROP TABLE PRODUCT;
INSERT INTO PRODUCT VALUES(1,'12-12-2000',2,'NAME',1,2.0,1,1);

CREATE TABLE PRODUC
(	ID INT,
	DAT DATETIME,
	INV_NUM INT,
	NAME VARCHAR(35),
	COUN INT,
	PRICE INT
);
SELECT * FROM PRODUC;
INSERT INTO PRODUC VALUES(1,'12-12-2000',2,'NAME',1,2);
DELETE FROM PRODUCT
