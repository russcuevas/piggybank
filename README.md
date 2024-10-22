DATABASE TEST

CREATE DATABASE "piggybank";

USE "piggybank";

CREATE TABLE users (
    id INT PRIMARY KEY IDENTITY(1,1),
    student_id INT NOT NULL,
    password NVARCHAR(255) NOT NULL
);

CREATE TABLE transactions (
    transaction_id INT PRIMARY KEY IDENTITY(1,1),
    student_id INT NOT NULL,
    transaction_date DATE NOT NULL,
    transaction_time TIME NOT NULL,
    amount DECIMAL(10, 2) NOT NULL
);

SELECT * FROM users;
SELECT * FROM transactions;
DELETE FROM users;
DELETE FROM transactions;

SELECT 
    t.transaction_id,
    t.transaction_date,
    t.transaction_time,
    t.amount,
    u.student_id
FROM 
    transactions t
LEFT JOIN 
    users u ON t.student_id = u.student_id;
