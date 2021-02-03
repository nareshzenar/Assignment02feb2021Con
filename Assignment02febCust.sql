use WFA3DotNet

CREATE TABLE tblCustomer02feb (
		Cid int not null PRIMARY KEY identity(101,1),
		CName varchar(30),
		DOB Date,
		City varchar(20)
)

select * from tblCustomer02feb

INSERT into tblCustomer02feb VALUES ('John', '04-Apr-1949', 'Hyd')
INSERT into tblCustomer02feb VALUES ('Wick', '12-Dec-1967','Mum')
INSERT into tblCustomer02feb VALUES ('sams', '9-Sep-1940', 'Che')
INSERT into tblCustomer02feb VALUES ('Dean', '23-Nov-1965','New York City')
INSERT into tblCustomer02feb VALUES ('Avengers', '05-Nov-1962', 'Che')
INSERT into tblCustomer02feb VALUES ('AAAA', '29-Dec-1960','Mum')
INSERT into tblCustomer02feb VALUES ('BBBB', '05-Aug-1974','Hyd')
INSERT into tblCustomer02feb VALUES ('CCCC', '23-Nov-1955','Pune')
INSERT into tblCustomer02feb VALUES ('DDDD', '19-Mar-1966','Blr')
INSERT into tblCustomer02feb VALUES ('EEEE', '19-Mar-1963','Che')