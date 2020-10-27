-- INSERT

-- 1. Add Klingon as a spoken language in the USA
-- 2. Add Klingon as a spoken language in Great Britain


-- UPDATE

-- 1. Update the capital of the USA to Houston
-- 2. Update the capital of the USA to Washington DC and the head of state

-- DELETE

-- 1. Delete English as a spoken language in the USA

DELETE 
SELECT *
FROM countrylanguage
WHERE countrycode ='USA'

SELECT *
FROM country

-- 2. Delete all occurrences of the Klingon language 


-- REFERENTIAL INTEGRITY

-- 1. Try just adding Elvish to the country language table.

-- 2. Try inserting English as a spoken language in the country ZZZ. What happens?
INSERT INTO countrylanguage(countrycode, language,isofficial, percentage)
VALUES ('ZZZ', 'English',0,.5)
-- 3. Try deleting the country USA. What happens?
DELETE
FROM country
WHERE code ='USA'

-- CONSTRAINTS

-- 1. Try inserting English as a spoken language in the USA

-- 2. Try again. What happens?

-- 3. Let's relocate the USA to the continent - 'Outer Space'


-- How to view all of the constraints

SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
SELECT * FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE
SELECT * FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS


-- TRANSACTIONS

-- 1. Try deleting all of the rows from the country language table and roll it back.

-- 2. Try updating all of the cities to be in the USA and roll it back
BEGIN TRANSACTION

SELECT COUNT(*) FROM city WHERE countrycode ='USA'

UPDATE INTO country
SELECT COUNT(*) FROM city WHERE countrycode ='USA'





-- 3. Demonstrate two different SQL connections trying to access the same table where one happens to be inside of a transaction but hasn't committed yet.