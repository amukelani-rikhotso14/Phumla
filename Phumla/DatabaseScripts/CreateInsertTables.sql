CREATE TABLE [dbo].[Rooms] (
    [RoomId] INT IDENTITY(1,1) PRIMARY KEY,
    [HotelName] NVARCHAR(100) NOT NULL,
    [RoomNumber] NVARCHAR(10) NOT NULL,
    [RoomType] NVARCHAR(50) NOT NULL,
    [MaxAdults] INT NOT NULL,
    [MaxChildren] INT NOT NULL,
    [RatePerNight] DECIMAL(10,2) NOT NULL,
    [IsAvailable] BIT NOT NULL
);

INSERT INTO [dbo].[Rooms] (HotelName, RoomNumber, RoomType, MaxAdults, MaxChildren, RatePerNight, IsAvailable) VALUES 
('Cape Town', '101', 'Standard', 2, 1, 550.00, 1),
('Cape Town', '102', 'Standard', 2, 1, 550.00, 1),
('Cape Town', '103', 'Standard', 2, 1, 550.00, 1),
('Cape Town', '104', 'Standard', 2, 1, 550.00, 1),
('Cape Town', '105', 'Standard', 2, 1, 550.00, 1),
('Johannesburg', '201', 'Standard', 2, 1, 550.00, 1),
('Durban', '301', 'Standard', 2, 1, 550.00, 0),
('Port Elizabeth', '401', 'Standard', 2, 1, 550.00, 1);


CREATE TABLE [dbo].[Bookings] (
    [BookingId] INT IDENTITY(1,1) PRIMARY KEY,
    [GuestId] INT NOT NULL,
    [RoomId] INT NOT NULL,
    [HotelName] NVARCHAR(100) NOT NULL,
    [ArrivalDate] DATE NOT NULL,
    [DepartureDate] DATE NOT NULL,
    [Status] NVARCHAR(20) NOT NULL,
    FOREIGN KEY ([GuestId]) REFERENCES [dbo].[Guests]([GuestId]),
    FOREIGN KEY ([RoomId]) REFERENCES [dbo].[Rooms]([RoomId])
);

-- John Smith has a booking on 25th December as required
INSERT INTO [dbo].[Bookings] (GuestId, RoomId, HotelName, ArrivalDate, DepartureDate, Status) VALUES 
(1, 1, 'Cape Town', '2024-12-25', '2024-12-26', 'Confirmed'),
(3, 2, 'Cape Town', '2024-12-15', '2024-12-18', 'Confirmed'),
(4, 3, 'Cape Town', '2024-12-20', '2024-12-22', 'Pending'),
(6, 4, 'Cape Town', '2024-12-24', '2024-12-25', 'Confirmed');
-- Note: Nkosinathi Mthembu (GuestId 2) has no bookings as required

CREATE TABLE [dbo].[Payments] (
    [PaymentId] INT IDENTITY(1,1) PRIMARY KEY,
    [BookingId] INT NOT NULL,
    [Amount] DECIMAL(10,2) NOT NULL,
    [PaymentDate] DATETIME NOT NULL,
    [Method] NVARCHAR(20) NOT NULL,
    [Reference] NVARCHAR(50) NULL,
    FOREIGN KEY ([BookingId]) REFERENCES [dbo].[Bookings]([BookingId])
);

INSERT INTO [dbo].[Payments] (BookingId, Amount, PaymentDate, Method, Reference) VALUES 
(1, 199.00, '2024-12-10 14:30:00', 'Credit Card', 'PK-20241201-0001'),
(2, 450.00, '2024-12-12 09:00:00', 'Cash', NULL),
(3, 330.00, '2024-12-13 16:45:00', 'Credit Card', 'PK-20241201-0002');

CREATE TABLE [dbo].[OccupancyReports] (
    [ReportId] INT IDENTITY(1,1) PRIMARY KEY,
    [HotelName] NVARCHAR(100) NOT NULL,
    [ReportDate] DATE NOT NULL,
    [RoomsAvailable] INT NOT NULL,
    [RoomsOccupied] INT NOT NULL,
    [OccupancyPercentage] INT NOT NULL,
    [Revenue] INT NOT NULL
);

INSERT INTO [dbo].[OccupancyReports] (HotelName, ReportDate, RoomsAvailable, RoomsOccupied, OccupancyPercentage, Revenue) VALUES 
('Cape Town', '2024-12-24', 3, 2, 40, 2200),
('Cape Town', '2024-12-25', 0, 5, 100, 4975),
('Cape Town', '2024-12-26', 1, 4, 80, 3980),
('Cape Town', '2024-12-27', 4, 1, 20, 995);

CREATE TABLE [dbo].[Users] (
    [UserId] INT IDENTITY(1,1) PRIMARY KEY,
    [Username] NVARCHAR(50) NOT NULL UNIQUE,
    [Password] NVARCHAR(100) NOT NULL,
    [Role] NVARCHAR(20) NOT NULL
);

INSERT INTO [dbo].[Users] (Username, Password, Role) VALUES 
('receptionist', 'password123', 'Receptionist'),
('admin', 'adminpass', 'Admin'),
('manager', 'managerpass', 'Manager');

CREATE TABLE [dbo].[Guests] (
    [GuestId] INT IDENTITY(1,1) PRIMARY KEY,
    [Title] NVARCHAR(10) NOT NULL,
    [FirstName] NVARCHAR(50) NOT NULL,
    [LastName] NVARCHAR(50) NOT NULL,
    [Phone] NVARCHAR(20) NOT NULL,
    [Email] NVARCHAR(100) NULL,
    [IdNumber] NVARCHAR(30) NULL,
    [Address] NVARCHAR(200) NULL,
    [LoyaltyCard] NVARCHAR(30) NULL
);

INSERT INTO [dbo].[Guests] (Title, FirstName, LastName, Phone, Email, IdNumber, Address, LoyaltyCard) VALUES 
('Mr', 'John', 'Smith', '0211234567', 'john.smith@email.com', '8001015009087', '7 Main Rd, Rondebosch, 7700', 'PK001234'),
('Mr', 'Nkosinathi', 'Mthembu', '0317654321', 'nkosinathi@email.com', '8505123456789', '14 Lungelo Drive, Mtimkhulu, Durban, 4001', NULL),
('Mr', 'John', 'Doe', '0111234567', 'john.doe@email.com', '8001015009088', '123 Main Street, Johannesburg, 2000', 'PK001235'),
('Ms', 'Sarah', 'Johnson', '0219876543', 'sarah.johnson@email.com', '8505123456790', '25 Oak Avenue, Johannesburg', NULL),
('Dr', 'Michael', 'Brown', '0314567890', 'm.brown@email.com', '7712084567891', '42 Beach Road, Cape Town', 'PK005679'),
('Mrs', 'Alice', 'Davis', '0112345678', 'alice.davis@email.com', '9001015009088', '12 Rose Street, Pretoria', NULL),
('Mr', 'David', 'Wilson', '0218765432', 'david.wilson@email.com', '9205123456790', '34 Palm Avenue, Cape Town', 'PK009877'),
('Ms', 'Lisa', 'Taylor', '0316677889', 'lisa.taylor@email.com', '8803034567891', '67 Kloof Road, Cape Town', NULL),
('Mr', 'James', 'Anderson', '0114455667', 'james.anderson@email.com', '8904045678901', '89 Church Street, Pretoria', 'PK011223'),
('Mrs', 'Mary', 'Thomas', '0213344556', 'mary.thomas@email.com', '9105056789012', '56 Long Street, Cape Town', NULL);