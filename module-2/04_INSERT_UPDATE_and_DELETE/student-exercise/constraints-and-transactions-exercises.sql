-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.

INSERT INTO actor(first_name, last_name)
VALUES ('HAMPTON','AVENUE') ,( 'LISA', 'BYWAY')

-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.

INSERT INTO film(title,description,release_year, language_id, length)
VALUES ('EUCLIDEAN PI', 'The epic story of Euclid as a pizza delivery boy in ancient Greece', 2008, 1,198)

-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.

INSERT INTO film_actor(film_id, actor_id)
VALUES((SELECT film_id FROM film WHERE title ='EUCLIDEAN PI'), (SELECT actor_id FROM actor WHERE first_name= 'HAMPTON' AND last_name= 'AVENUE')),
	((SELECT film_id FROM film WHERE title ='EUCLIDEAN PI'), (SELECT actor_id FROM actor WHERE first_name= 'LISA' AND last_name= 'BYWAY'));

/*
EQUAL TO
VALUES((1001),(201)), ((1001),(202))
*/

-- 4. Add Mathmagical to the category table.
INSERT INTO category(name)
VALUES ('Mathmagical');

-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"

INSERT INTO film_category(film_id, category_id)
VALUES((SELECT film_id FROM film WHERE title ='RANDOM GO'),(SELECT category_id FROM category WHERE name= 'Mathmagical')),
	((SELECT film_id FROM film WHERE title ='EUCLIDEAN PI'), (SELECT category_id FROM category WHERE name= 'Mathmagical')),
	((SELECT film_id FROM film WHERE title ='EGG IGBY'), (SELECT category_id FROM category WHERE name= 'Mathmagical')),
	((SELECT film_id FROM film WHERE title ='KARATE MOON'), (SELECT category_id FROM category WHERE name= 'Mathmagical')),
	((SELECT film_id FROM film WHERE title ='YOUNG LANGUAGE'),(SELECT category_id FROM category WHERE name= 'Mathmagical'));

-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)

--Could've done like above to select the Mathmagical category, but already know its category_id so just used it like that:)

UPDATE film
SET rating ='G'
WHERE film_id IN (SELECT film_id FROM film_category WHERE category_id = 17)

-- 7. Add a copy of "Euclidean PI" to all the stores.

-- Since I created the movie and after testing I already know its film_id is 1001, and from yesterday 
--that there are 2 stores, I could Subquery to find out how many stores, but I used EUCLIDEAN PI's film_id to make it faster.

INSERT INTO inventory(film_id, store_id)
VALUES (1001, 1), (1001,2)

-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.
-- (Did it succeed? Why?)

-- <It didnt work, since there is a constraint to it, since its multireferenced the other keys would be loose, and it doesnt like it>

DELETE 
FROM film
WHERE title ='EUCLIDEAN PI'

-- 9. Delete Mathmagical from the category table.
-- (Did it succeed? Why?)

-- <It didnt work, since there is a constraint to it, since its multireferenced the other keys would be loose, and it doesnt like it
--in this example it occured in the film category, since its contained with category_id in the other table, with key>

DELETE 
FROM category
WHERE name = 'Mathmagical'

-- 10. Delete all links to Mathmagical in the film_category tale.
-- (Did it succeed? Why?)

-- <It got deleted, in this case in film_category ,the key for the category_id 
--  isnt being referenced in any other tables so it can be eliminated>

DELETE 
FROM film_category
WHERE category_id = 17

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".

DELETE 
FROM category
WHERE name = 'Mathmagical'

DELETE 
FROM film
WHERE title ='EUCLIDEAN PI'

-- (Did either deletes succeed? Why?)
-- < The category was succesfully deleted, but the film wasnt, because there is still a 
-- constraint within the actor keys in film_actor and the film_id(still being referenced.>

-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.

SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
SELECT * FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE
SELECT * FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS

/*
There was a constraint because the film actor is still tied to the movie with the actor_id and film_id
and is film_id to the inventory, and from inventory into the two stores were I added the movie to film_id(1001), store_id(1), (2).
*/
