-- Display all the films and their language
SELECT film.title, language.name
FROM film
INNER JOIN language ON film.language_id = language.language_id

-- Display all the films and in English

SELECT film.title, film.language_id, language.name
FROM film
LEFT JOIN language ON film.language_id = language.language_id

-- Display all the films with their category

SELECT film.title, category.name
FROM film
LEFT JOIN film_category ON film.film_id = film_category.film_id
LEFT JOIN category ON film_category.category_id = category.category_id


-- Display all the films with a category of Horror

SELECT film.title, category.name
FROM film
LEFT JOIN film_category ON film.film_id = film_category.film_id
LEFT JOIN category ON film_category.category_id = category.category_id
WHERE category.name = 'Horror'

-- Display all the films with a category of Horror and title that begins with the letter F


-- Who acted in what together?

-- How many times have two actors appeared together?

SELECT COUNT(*) AS num_films, a1.actor_id, a2.actor_id, a1.last_name, a2.last_name
FROM film f
INNER JOIN film_actor fa1 on f.film_id = fa1.film_id
INNER JOIN film_actor fa2 ON f.film_id = fa2.film_id AND fa1.actor_id <> fa2.actor_id
INNER JOIN actor a1 ON a1.actor_id = fa1.actor_id
INNER JOIN actor a2 ON a2.actor_id = fa2.actor_id
GROUP BY a1.actor_id, a2.actor_id, a1.last_name, a2.last_name
ORDER BY num_films DESC
-- What movies did the two most often acted together actors appear in together?


SELECT top 1 COUNT(*) AS num_films, a1.actor_id AS 'actor 1 Id', a2.actor_id AS 'actor 2 Id', a1.last_name, a2.last_name
FROM film f
INNER JOIN film_actor fa1 on f.film_id = fa1.film_id
INNER JOIN film_actor fa2 ON f.film_id = fa2.film_id AND fa1.actor_id <> fa2.actor_id
INNER JOIN actor a1 ON a1.actor_id = fa1.actor_id
INNER JOIN actor a2 ON a2.actor_id = fa2.actor_id
GROUP BY a1.actor_id, a2.actor_id, a1.last_name, a2.last_name
ORDER BY num_films DESC

WITH actor1Movies AS(
SELECT film_actor.film_id
FROM actor
JOIN film_actor ON actor.actor_id = film_actor.actor_id
WHERE film_actor.actor_id = 60
)
SELECT film_actor.film_id
FROM actor
JOIN film_actor ON actor.actor_id = film_actor.actor_id
JOIN actor1Movies ON actor1Movies.film_id = film_actor.film_id
JOIN FILM on film.FILM_ID = FILM.FILM_ID
WHERE film_actor.actor_id = 27