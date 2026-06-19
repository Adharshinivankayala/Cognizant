-- Exercise 12: Event with Maximum Sessions
-- List the event(s) with the highest number of sessions.

SELECT
    e.event_id,
    e.title,
    s.session_count
FROM (
    SELECT event_id, COUNT(*) AS session_count
    FROM Sessions
    GROUP BY event_id
) s
JOIN Events e ON e.event_id = s.event_id
WHERE s.session_count = (
    SELECT MAX(cnt)
    FROM (SELECT COUNT(*) AS cnt FROM Sessions GROUP BY event_id) t
);
