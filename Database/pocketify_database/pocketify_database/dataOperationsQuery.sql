-- Used to retrieve the passwordHash for the Log In process.
SELECT PwdHash FROM Users WHERE UserName = @username; 

-- Store a user data at the sign up form.
INSERT INTO Users (Email, UserName, PwdHash) VALUES (@Email, @Username, @PwdHash);

-- Get the user Details
SELECT UserName, Email FROM Users WHERE UID = @uid;

-- Update User Details
UPDATE Users SET UserName = @Username, Email = @Email WHERE UID = @uid;

insert into Categories (UID, CategoryName, CategoryBudget) Values (@UserId, @CatName, @CatBudget);

select * from Categories;
