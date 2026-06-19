-- Exercise 24: Average Session Duration per Event
-- Compute the average duration (in minutes) of sessions in each event.

SELECT
    event_id,
    ROUND(AVG(TIMESTAMPDIFF(MINUTE, start_time, end_time)), 2) AS avg_duration_minutes
FROM Sessions
GROUP BY event_id;
