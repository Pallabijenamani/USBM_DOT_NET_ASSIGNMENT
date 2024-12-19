CREATE OR ALTER PROCEDURE SaveBooksInfo
(
    @Title NVARCHAR(100),
    @Author NVARCHAR(100),
    @Genre NVARCHAR(100),
    @PublishedYear BIGINT
)
AS
BEGIN
    -- Insert the provided data into the Book table
    INSERT INTO Book(Title, Author, Genre, PublishedYear)
    VALUES (@Title, @Author, @Genre, @PublishedYear);
END;

-- Create the Book table if it does not exist (only run this once)
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Book')
BEGIN
    CREATE TABLE Book
    (
        BookID INT IDENTITY(1,1) PRIMARY KEY,
        Title NVARCHAR(100),
        Author NVARCHAR(100),
        Genre NVARCHAR(100),
        PublishedYear BIGINT
    );
END;

-- Sample procedure calls
EXEC SaveBooksInfo @Title = 'The Great Gatsby', @Author = 'F. Scott Fitzgerald', @Genre = 'Fiction', @PublishedYear = 1925;
EXEC SaveBooksInfo @Title = 'To Kill a Mockingbird', @Author = 'Harper Lee', @Genre = 'Fiction', @PublishedYear = 1960;
EXEC SaveBooksInfo @Title = '1984', @Author = 'George Orwell', @Genre = 'Dystopian', @PublishedYear = 1949;
EXEC SaveBooksInfo @Title = 'Moby Dick ', @Author = 'Herman Melville', @Genre = 'Adventure', @PublishedYear = 1851;
EXEC SaveBooksInfo @Title = 'War and Peace ', @Author = 'Leo Tolstoy ', @Genre = 'Historical', @PublishedYear = 1869;



select * from LibraryManagementSystem.dbo.Book;
select * from Book;


drop table Book;
