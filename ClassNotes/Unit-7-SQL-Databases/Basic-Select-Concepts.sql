--------------------------------------------------------------------------------------------------------
-- Basic SELECT Lecture Code
--------------------------------------------------------------------------------------------------------
-- -- indicates a comment - anything following on the line is ignored
--
-- SQL SELECT statement - retrieve values from the database (Read)
--
-- A SELECT statement is often referred to as a query
--
-- Basic syntax: (the order in which these is important/required)
--
--      SELECT   - columns to include in the result (seperate multiple column reqeusts with commas)
--      FROM     - table containing rows used in the query 
--      WHERE    - rows to include in the result - WHERE predicates are similar to Java predicate (a predicate is conditions)
--      ORDER BY - sequence of rows in the result
--                 without an ORDER BY the sequence of the rows in the result is not predictable
--                 if the sequence of teh rows in teh result matter - code an ORDER BY
--
-- WHERE predicates:
--
--        =  <>  !=  >  >=  <  <= -- not equal can be specified two ways:  <>   !=
--        IN(list-of-values)      -- alterative to a series of = OR
--        NOT IN(list-of-values)  -- alterative to a series of != AND
--        BETWEEN value AND value
--        IS NULL          -- special predicate for checking to see if column is null 
--        IS NOT NULL      -- special predicate for checking to see if column is not null 
--        LIKE    (use wildcards: % means 0 to any number of any characters
--                                _ means exactly any one character
--                'word%'  - starts with test
--                '%word'  - ends with test
--                '%word%' - contains test
--
--        ILIKE   (case insensivtive LIKE - Postgres extension)
--
-- predicates may be combined using AND and OR
--
-- use parentheses to make your multi-predicate condition clear

-- The DISTINCT clause on a SELECT removes duplicate values from the result
-- based on the all columns that follow
--
-- The DISTINCT ON(columns/expression) clause on a SELECT removes duplicate values from the result
-- based on the all columns/expression inside the parentheses that follow (Postgres extension)

--  
------------------------------------------------------------------------------------------------------
select * from gambler					-- get all columns from the gambler table
;
select birth_date, gambler_name			-- get me these columbs
	from gambler						-- from this table
;
select birth_date, gambler_name			-- get me these columbs
	from gambler						-- from this table with rows
	where gambler_name = 'S.Q. Elle'	-- which rows you want in the result
;
select birth_date, gambler_name			-- get me these columbs
	from gambler						-- from this table with rows
	where gambler_name like '%X%'
;
select birth_date, gambler_name			-- get me these columbs
	from gambler						-- from this table with rows
	where birth_date between '01/01/1970' and '12/31/1979' -- rows where gambler was born in the 70s
;
select birth_date, gambler_name, DATEDIFF(CURRENT_DATE, birth_date, 1)	-- get me these columbs
	from gambler											-- from this table with rows