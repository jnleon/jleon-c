USE assessment;
GO

-- Select all columns from users where the user's role is admin
select * from users where users.role='admin';
-- Select name and description from items that were created after Sept. 20, 2019 and the description isn't null
select name, description from items where items.created = '2019-09-20' AND description IS NOT NULL;
-- Select first_name and last_name from users and order by when they were created, latest first
select first_name, last_name from users ORDER BY created desc;
-- Select finished and a count all the items that are finished/not finished
select COUNT(*) AS 'items finished' from items where finished=0; 
select COUNT(*) AS 'items not finished' from items where finished=1;
-- Select a user's first_name and last_name and the item's name for every finished item
select u.first_name, u.last_name, name from items i
INNER JOIN users u ON i.id = u.id
WHERE i.finished =1;


