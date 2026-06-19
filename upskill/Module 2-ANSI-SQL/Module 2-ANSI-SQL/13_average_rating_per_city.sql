-- Exercise 13: Average Rating per City
-- Calculate the average feedback rating of events conducted in each city.

SELECT
    e.city,
    ROUND(AVG(f.rating), 2) AS avg_rating
FROM Events e
JOIN Feedback f ON e.event_id = f.event_id
GROUP BY e.city
ORDER BY avg_rating DESC;
