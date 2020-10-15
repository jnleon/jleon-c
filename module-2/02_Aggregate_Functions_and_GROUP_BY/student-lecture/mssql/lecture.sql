-- ORDERING RESULTS

-- Populations of all countries in descending order
SELECT name, population	
FROM country
ORDER BY population DESC, name DESC;
--Names of countries and continents in ascending order
SELECT name, continent
FROM country
ORDER BY name, continent ASC ;

-- LIMITING RESULTS
-- The name and average life expectancy of the countries with the 10 highest life expectancies.

SELECT AVG(lifeexpectancy)
FROM country;

-- CONCATENATING OUTPUTS
SELECT SUM(population)
FROM city
WHERE district = 'Ohio';


-- The name & state of all cities in California, Oregon, or Washington.
-- "city, state", sorted by state then city



-- AGGREGATE FUNCTIONS
-- Average Life Expectancy in the World

-- Total population in Ohio

-- The surface area of the smallest country in the world

SELECT MIN(surfacearea)AS 'Smallest Surface Area'
FROM country;



-- The 10 largest countries in the world
SELECT TOP 10 name, surfacearea
FROM country
ORDER BY surfacearea DESC;

-- The number of countries who declared independence in 1991
SELECT name, indepyear
FROM country
WHERE indepyear =1991
ORDER BY name;

SELECT COUNT (*) AS '# of countries who indep. 1991' FROM country   WHERE indepyear=1991 ;

-- GROUP BY
-- Count the number of countries where each language is spoken, ordered from most countries to least
SELECT language, COUNT(countrycode) AS 'country count'
FROM countrylanguage
GROUP BY language
ORDER BY 'country count' DESC;


-- Average life expectancy of each continent ordered from highest to lowest

SELECT continent, AVG(lifeexpectancy) AS 'Average Life Expectancy', COUNT (*) as num_countries
FROM country
GROUP BY continent
ORDER BY 'Average Life Expectancy' DESC;

-- Exclude Antarctica from consideration for average life expectancy

SELECT continent, AVG(lifeexpectancy) AS 'Average_Life', COUNT (*) as num_countries
FROM country
WHERE lifeexpectancy IS NOT NULL
--WHERE continent <> 'Antarctica'
GROUP BY continent
ORDER BY 'Average_Life' DESC;



-- Sum of the population of cities in each state in the USA ordered by state name
SELECT district, SUM(population) As 'Population Cities'
FROM city
WHERE countrycode ='USA'
GROUP BY district
ORDER BY 'Population Cities' DESC;


-- The average population of cities in each state in the USA ordered by state name




-- SUBQUERIES
-- Find the names of cities under a given government leader





-- Find the names of cities whose country they belong to has not declared independence yet

-- Additional samples
-- You may alias column and table names to be more descriptive

-- Alias can also be used to create shorthand references, such as "c" for city and "co" for country.

-- Ordering allows columns to be displayed in ascending order, or descending order (Look at Arlington)

-- While you can use TOP to limit the number of results returned by a query,
-- in SQL Server it is recommended to use OFFSET and FETCH if you want to get
-- "pages" of results. For instance, to get the first 10 rows in the city table
-- ordered by the name, you could use the following query.
-- (Skip 0 rows, and return only the first 10 rows from the sorted result set.)

-- Most database platforms provide string functions that can be useful for working with string data. In addition to string functions, string concatenation is also usually supported, which allows us to build complete sentences if necessary.

-- Aggregate functions provide the ability to COUNT, SUM, and AVG, as well as determine MIN and MAX. Only returns a single row of value(s) unless used with GROUP BY.
-- Counts the number of rows in the city table

-- Also counts the number of rows in the city table

-- Gets the SUM of the population field in the city table, as well as
-- the AVG population, and a COUNT of the total number of rows.

SELECT SUM(population)AS 'Sum Of Population', AVG(population)AS 'Avarage Population', COUNT(population)AS 'Total Number Of Rows'
FROM city;




-- Gets the MIN population and the MAX population from the city table.

-- Using a GROUP BY with aggregate functions allows us to summarize information for a specific column. For instance, we are able to determine the MIN and MAX population for each countrycode in the city table.
