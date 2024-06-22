-- Used to retrieve the passwordHash for the Log In process.
SELECT PwdHash FROM Users WHERE UserName = @username; 

-- Store a user data at the sign up form.
INSERT INTO Users (Email, UserName, PwdHash) VALUES (@Email, @Username, @PwdHash);