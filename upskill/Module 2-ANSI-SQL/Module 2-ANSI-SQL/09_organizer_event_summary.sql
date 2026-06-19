-- Exercise 9: Organizer Event Summary
-- For each event organizer, show the number of events created and
-- their current status (upcoming, completed, cancelled).

SELECT
    o.user_id AS organizer_id,
    o.full_name AS organizer_name,
    e.status,
    COUNT(*) AS event_count
FROM Events e
JOIN Users o ON e.organizer_id = o.user_id
GROUP BY o.user_id, o.full_name, e.status
ORDER BY o.user_id, e.status;
