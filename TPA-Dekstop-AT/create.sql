

CREATE TABLE Employee
(
	EmployeeId INT Identity  PRIMARY KEY,
	EmployeeName VARCHAR(50) NOT NULL,
	EmployeeAddress VARCHAR(50) NOT NULL,
	EmployeeGender CHAR(6) NOT NULL,
	EmployeeSalary INT NOT NULL,
	EmployeePosition VARCHAR(30) NOT NULL,
	EmployeePassword VARCHAR(15) NOT NULL,
	EmployeeStatus VARCHAR(15) NOT NULL
)

CREATE TABLE Ticket
(
	TicketID INT IDENTITY PRIMARY KEY,
	TicketType VARCHAR(10) NOT NULL,
	TicketPrice INT NOT NULL,
	TicketDate DATE DEFAULT GETDATE()
)

CREATE TABLE Room
(
	RoomID INT IDENTITY PRIMARY KEY,
	RoomType VARCHAR(10) NOT NULL,
	RoomPrice INT NOT NULL,
    RoomCapacity INT NOT NULL,
    RoomCondition VARCHAR(10) NOT NULL,
    RoomStatus VARCHAR (10) NOT NULL
)

CREATE TABLE Customer
(
    CustomerID INT IDENTITY PRIMARY KEY,
    CustomerName VARCHAR (30) NOT NULL,
    CustomerIdentificationNumber VARCHAR(20) NOT NULL,
    CustomerIdentificationType VARCHAR(10) NOT NULL,
    CustomerDOB Date DEFAULT GETDATE(),
    CustomerNationality VARCHAR(20) NOT NULL,
    CustomerPhone VARCHAR(20) NOT NULL,
    CustomerGender CHAR(6) NOT NULL
)

CREATE TABLE [Table]
(
    TableID INT IDENTITY PRIMARY KEY,
    TableCapacity INT NOT NULL,
    TableStatus VARCHAR(10) NOT NULL
)

CREATE TABLE OrderHeader
(
    OrderID INT IDENTITY PRIMARY KEY,
    OrderType VARCHAR(10) NOT NULL,
    TableID INT FOREIGN KEY REFERENCES [Table](TableID) ON UPDATE CASCADE ON DELETE CASCADE,
    PeopleCount INT NOT NULL,
    OrderStatus VARCHAR(20) NOT NULL
)

CREATE TABLE Menu 
(
    MenuID INT IDENTITY PRIMARY KEY,
    MenuName VARCHAR(30) NOT NULL,
    MenuPrice INT NOT NULL,
    MenuDescription VARCHAR(30) NOT NULL,
    MenuStock INT NOT NULL
)

CREATE TABLE OrderDetail
(
    OrderID INT FOREIGN KEY REFERENCES ORDERHeader(OrderID) ON UPDATE CASCADE ON DELETE CASCADE,
    MenuID INT FOREIGN  KEY REFERENCES Menu(MenuID) ON UPDATE CASCADE On DELETE CASCADE,
    Quantity INT NOT NULL,
	PRIMARY KEY(OrderID,MenuID)
)

CREATE TABLE Ride
(
    ActivityID INT IDENTITY PRIMARY KEY,
    ActivityType VARCHAR (10) DEFAULT 'Ride',
    ActivityName VARCHAR(30) NOT NULL,
    ActivityDuration INT NOT NULL,
    ActivityDescription VARCHAR(30) NOT NULL,
    Status VARCHAR(10) NOT NULL,
    MinHeight INT NOT NULL,
    MinAge INT NOT NULL,
    Restriction VARCHAR(50) NOT NULL
)

CREATE TABLE Parade
(
    ActivityID INT IDENTITY PRIMARY KEY,
    ActivityType VARCHAR (10) DEFAULT 'Parade',
    ActivityName VARCHAR(30) NOT NULL,
    ActivityDuration INT NOT NULL,
    ActivityDescription VARCHAR(30) NOT NULL,
    Status VARCHAR(10) NOT NULL,
    PeopleCount INT NOT NULL
)

CREATE TABLE Ingredient
(
    IngredientID INT IDENTITY PRIMARY KEY,
    IngredientName VARCHAR(50) NOT NULL,
    IngredientStock INT NOT NULL
)



CREATE TABLE WorkPerformance
(
    WorkPerformanceID INT IDENTITY PRIMARY KEY,
    EmployeeID INT FOREIGN KEY REFERENCES Employee(EmployeeID) ON UPDATE CASCADE ON DELETE CASCADE,
    PerformanceScore INT NOT NULL,
    Details VARCHAR(50) NOT NULL
)

CREATE TABLE Advertisement
(
    AdvertisementID INT IDENTITY PRIMARY KEY,
    AdvertisementName VARCHAR(50) NOT NULL,
    AdvertisementDescription VARCHAR(50) NOT NULL
) 

CREATE TABLE MaintenanceSchedule
(
    ScheduleID INT IDENTITY PRIMARY KEY,
    ScheduleType VARCHAR(20) NOT NULL,
    ScheduleDate DATE NOT NULL,
    Status VARCHAR(10) NOT NULL,
    Details VARCHAR(30) NOT NULL,
    ActivityID INT FOREIGN KEY REFERENCES Ride(ActivityID) ON UPDATE CASCADE ON DELETE CASCADE

)

CREATE TABLE HouseKeepingSchedule
(
    ScheduleID INT IDENTITY PRIMARY KEY,
    ScheduleType VARCHAR(20) NOT NULL,
    ScheduleDate DATE NOT NULL,
    Status VARCHAR(10) NOT NULL,
    Details VARCHAR(30) NOT NULL,
    RoomID INT FOREIGN KEY REFERENCES Room(RoomID) ON UPDATE CASCADE ON DELETE CASCADE
)

CREATE TABLE PurchaseRequest
(
    RequestID INT IDENTITY PRIMARY KEY,
    [From] VARCHAR(20) NOT NULL,
    [To] VARCHAR(20) NOT NULL,
    Status VARCHAR(10) NOT NULL,
    Message VARCHAR(50) NOT NULL,
    Details VARCHAR(50) NOT NULL
)

CREATE TABLE LeaveRequest
(
    RequestID INT IDENTITY PRIMARY KEY,
    [From] VARCHAR(20) NOT NULL,
    [To] VARCHAR(20) NOT NULL,
    Status VARCHAR(10) NOT NULL,
    Message VARCHAR(50) NOT NULL,
    StartDate DATE NOT NULL,
    EndDate DATE NOT NULL
)

CREATE TABLE EmployeeDischargeRequest
(
    RequestID INT IDENTITY PRIMARY KEY,
    [From] VARCHAR(20) NOT NULL,
    [To] VARCHAR(20) NOT NULL,
    Status VARCHAR(10) NOT NULL,
    Message VARCHAR(50) NOT NULL,
    Evidence VARCHAR(50) NOT NULL
)

CREATE TABLE FundRequest
(
    RequestID INT IDENTITY PRIMARY KEY,
    [From] VARCHAR(20) NOT NULL,
    [To] VARCHAR(20) NOT NULL,
    Status VARCHAR(10) NOT NULL,
    Message VARCHAR(50) NOT NULL,
    Amount INT NOT NULL
)

CREATE TABLE ConstructionRequest
(
    RequestID INT IDENTITY PRIMARY KEY,
    [From] VARCHAR(20) NOT NULL,
    [To] VARCHAR(20) NOT NULL,
    Status VARCHAR(10) NOT NULL,
    Message VARCHAR(50) NOT NULL,
    Details VARCHAR(50) NOT NULL
)

CREATE TABLE AttractionRequest
(
    RequestID INT IDENTITY PRIMARY KEY,
    [From] VARCHAR(20) NOT NULL,
    [To] VARCHAR(20) NOT NULL,
    Status VARCHAR(10) NOT NULL,
    Message VARCHAR(50) NOT NULL,
    PlanDetails VARCHAR(50) NOT NULL
)



