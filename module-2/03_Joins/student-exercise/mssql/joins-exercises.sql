-- The following queries utilize the "dvdstore" database.

-- 1. All of the films that Nick Stallone has appeared in
-- (30 rows)

SELECT title
FROM film
JOIN film_actor ON film.film_id = film_actor.actor_id
JOIN actor ON film_actor.actor_id = actor.actor_id  
WHERE first_name = 'Nick' AND last_name = 'Stallone';

-- 2. All of the films that Rita Reynolds has appeared in
-- (20 rows)

SELECT title
FROM film
JOIN film_actor ON film.film_id = film_actor.actor_id
JOIN actor ON film_actor.actor_id = actor.actor_id  
WHERE first_name = 'Rita' AND last_name = 'Reynolds';

-- 3. All of the films that Judy Dean or River Dean have appeared in
-- (46 rows)

SELECT title
FROM film
JOIN film_actor ON film.film_id = film_actor.actor_id
JOIN actor ON film_actor.actor_id = actor.actor_id  
WHERE last_name = 'Dean';

-- 4. All of the the ‘Documentary’ films
-- (68 rows)

SELECT film.title AS Title, category.name AS Category
FROM film 
INNER JOIN film_category ON film.film_id = film_category.film_id
INNER JOIN category ON category.category_id = film_category.category_id
WHERE category.name = 'Documentary'
ORDER BY film.title

-- 5. All of the ‘Comedy’ films
-- (58 rows)

SELECT film.title AS Title, category.name AS Category
FROM film 
INNER JOIN film_category ON film.film_id = film_category.film_id
INNER JOIN category ON category.category_id = film_category.category_id
WHERE category.name = 'Comedy'
ORDER BY film.title

-- 6. All of the ‘Children’ films that are rated ‘G’
-- (10 rows)

SELECT film.title
FROM film 
INNER JOIN film_category ON film.film_id = film_category.film_id
INNER JOIN category ON category.category_id = film_category.category_id
WHERE category.name = 'Children' AND film.rating = 'G';

-- 7. All of the ‘Family’ films that are rated ‘G’ and are less than 2 hours in length
-- (3 rows)

SELECT film.title
FROM film 
INNER JOIN film_category ON film.film_id = film_category.film_id
INNER JOIN category ON category.category_id = film_category.category_id
WHERE category.name = 'Family' AND film.rating = 'G' AND film.length <= 120;

-- 8. All of the films featuring actor Matthew Leigh that are rated ‘G’
-- (9 rows)

SELECT title
FROM film
JOIN film_actor ON film.film_id = film_actor.film_id --HAD FILM HERE UHM THINKING EMOJI
JOIN actor ON film_actor.actor_id = actor.actor_id  
WHERE first_name = 'Matthew' AND last_name = 'Leigh' AND rating = 'G';

-- 9. All of the ‘Sci-Fi’ films released in 2006
-- (61 rows)

SELECT film.title
FROM film 
INNER JOIN film_category ON film.film_id = film_category.film_id
INNER JOIN category ON category.category_id = film_category.category_id
WHERE category.name = 'Sci-Fi' AND film.release_year = '2006';

-- 10. All of the ‘Action’ films starring Nick Stallone
-- (2 rows)

SELECT film.title
FROM film 
INNER JOIN film_category ON film.film_id = film_category.film_id
INNER JOIN category ON category.category_id = film_category.category_id
JOIN film_actor ON film.film_id = film_actor.film_id --HAD FILM HERE UHM THINKING EMOJI
JOIN actor ON film_actor.actor_id = actor.actor_id  
WHERE category.name = 'Action' AND first_name = 'Nick' AND last_name = 'Stallone';

-- 11. The address of all stores, including street address, city, district, and country
-- (2 rows)

SELECT address.address ,city.city, address.district, country.country
FROM store
INNER JOIN address ON store.store_id = address.address_id
INNER JOIN city ON address.address_id = city.city_id
INNER JOIN country ON city.city_id = country.country_id

-- 12. A list of all stores by ID, the store’s street address, and the name of the store’s manager
-- (2 rows)

SELECT address.address ,city.city, address.district, country.country
FROM store
INNER JOIN address ON store.store_id = address.address_id
INNER JOIN city ON address.address_id = city.city_id
INNER JOIN country ON city.city_id = country.country_id


-- 13. The first and last name of the top ten customers ranked by number of rentals 
-- (#1 should be “ELEANOR HUNT” with 46 rentals, #10 should have 39 rentals)

SELECT TOP 10 COUNT(*) AS number_of_rental, customer.first_name, customer.last_name
FROM customer
INNER JOIN rental ON customer.customer_id = rental.customer_id
GROUP BY customer.first_name , customer.last_name
ORDER BY number_of_rental DESC;

-- 14. The first and last name of the top ten customers ranked by dollars spent 
-- (#1 should be “KARL SEAL” with 221.55 spent, #10 should be “ANA BRADLEY” with 174.66 spent)

SELECT TOP 10 SUM(payment.amount) AS dollars_spent, customer.first_name, customer.last_name
FROM customer
INNER JOIN payment ON payment.customer_id = customer.customer_id
GROUP BY customer.first_name, customer.last_name
ORDER BY dollars_spent DESC

-- 15. The store ID, street address, total number of rentals, total amount of sales (i.e. payments), and average sale of each store.
-- (NOTE: Keep in mind that an employee may work at multiple stores.)
-- (Store 1 has 7928 total rentals and Store 2 has 8121 total rentals)

SELECT store.store_id, address.address, COUNT(rental.rental_id) AS 'total number of rentals' , SUM(payment.amount) AS 'total amount of sales' , AVG(payment.amount) AS 'average sale'
FROM store

JOIN address ON store.store_id = address.address_id
JOIN inventory ON store.store_id = inventory.store_id
JOIN rental ON rental.inventory_id = inventory.inventory_id
JOIN payment ON rental.rental_id = payment.rental_id

GROUP BY store.store_id, address.address


-- 16. The top ten film titles by number of rentals
-- (#1 should be “BUCKET BROTHERHOOD” with 34 rentals and #10 should have 31 rentals)

SELECT TOP 10 film.title, COUNT(rental.rental_id) AS num_of_rentals
FROM film 
JOIN inventory On film.film_id = inventory.film_id
JOIN rental ON inventory.inventory_id = rental.inventory_id
GROUP BY film.title
ORDER BY num_of_rentals DESC;

-- 17. The top five film categories by number of rentals 
-- (#1 should be “Sports” with 1179 rentals and #5 should be “Family” with 1096 rentals)

SELECT TOP 5 category.name, COUNT(rental.rental_id) AS num_of_rentals
FROM category 

JOIN film_category On category.category_id = film_category.category_id
JOIN film On film.film_id = film_category.film_id
JOIN inventory On film.film_id = inventory.film_id
JOIN rental ON inventory.inventory_id = rental.inventory_id

GROUP BY category.name
ORDER BY num_of_rentals DESC;

-- 18. The top five Action film titles by number of rentals 
-- (#1 should have 30 rentals and #5 should have 28 rentals)

SELECT TOP 5 film.title, COUNT(rental.rental_id) AS num_of_rentals
FROM category 
JOIN film_category On category.category_id = film_category.category_id
JOIN film On film.film_id = film_category.film_id
JOIN inventory On film.film_id = inventory.film_id
JOIN rental ON inventory.inventory_id = rental.inventory_id

WHERE category.name ='Action'
GROUP BY film.title
ORDER BY num_of_rentals DESC;

-- 19. The top 10 actors ranked by number of rentals of films starring that actor 
-- (#1 should be “GINA DEGENERES” with 753 rentals and #10 should be “SEAN GUINESS” with 599 rentals)

SELECT TOP 10(actor.first_name + ' ' + actor.last_name) AS 'actor name' , COUNT(rental.rental_id) AS num_of_rentals
FROM actor 

JOIN film_actor On actor.actor_id = film_actor.actor_id
JOIN film On film_actor.film_id = film.film_id
JOIN inventory On film.film_id = inventory.film_id
JOIN rental ON inventory.inventory_id = rental.inventory_id

GROUP BY  actor.first_name, actor.last_name, actor.actor_id --WHY ACTOR.ACTOR_ID
ORDER BY num_of_rentals DESC;

-- 20. The top 5 “Comedy” actors ranked by number of rentals of films in the “Comedy” category starring that actor 
-- (#1 should have 87 rentals and #5 should have 72 rentals)

SELECT TOP 5 (actor.first_name + ' ' + actor.last_name) AS 'actor name' , COUNT(rental.rental_id) AS num_of_rentals
FROM actor 

JOIN film_actor On actor.actor_id = film_actor.actor_id
JOIN film On film_actor.film_id = film.film_id
JOIN film_category On film.film_id = film_category.film_id
JOIN category On film_category.category_id = category.category_id
JOIN inventory On film.film_id = inventory.film_id
JOIN rental ON inventory.inventory_id = rental.inventory_id

WHERE category.name ='Comedy'
GROUP BY  actor.actor_id, actor.first_name, actor.last_name --WHY ACTOR.ACTOR_ID
ORDER BY num_of_rentals DESC;
