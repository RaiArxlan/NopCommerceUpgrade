-- Information: This script is used to query data to verify different things
-- Date: 2018-07-10
-- Plateform: SQL Server
-- CMS: NopCommerce

-- Test connection and DB details

SELECT @@VERSION AS 'SQL Server Version';
SELECT DB_NAME() AS 'Database Name';
SELECT SERVERPROPERTY('MachineName') AS 'Server Name';
SELECT GETDATE() AS 'Current Date and Time';


-- Query to get all tables
SELECT * FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE'
ORDER BY TABLE_NAME
--AND TABLE_NAME LIKE '%plug%'