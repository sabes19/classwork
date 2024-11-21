-- Practice Basic SQL
--
-- List all entries in the casino table
select * from casino -- select * - get all columns in the order they are defined

-- Show the location and name each casino
select location, casino_name	-- get these columns IN THIS ORDER
	from casino					-- from this database


-- List all Vegas casinos
select casino_name, location
	from casino
	where location = 'Las Vegas'

-- List all casinos whose size is more than 30000
select casino_name, size
	from casino
	where size > 30000

-- Show the size of Vegas casinos if we double the size
select casino_name, size
	--	, size						-- comment out the , size line to remove from querry
		, size * 2 as 'Double Size' -- Coulmns to include the result
	from casino
	where location = 'Las Vegas'

-- List of gamblers with oldest first (earilest birthday)
select * from gambler

select gambler_name, birth_date
	from gambler
order by birth_date

-- if the order of rows in the result matter, - code order by to sort them
-- ASC	-- ascending (low to high) -- defualt order
-- DESC	-- descending order
	