-- Used to retrieve the passwordHash for the Log In process.
SELECT PwdHash FROM Users WHERE UserName = @username; 