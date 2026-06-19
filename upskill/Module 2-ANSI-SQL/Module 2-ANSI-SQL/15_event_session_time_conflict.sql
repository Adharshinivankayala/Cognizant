-- Exercise 15: Event Session Time Conflict
-- Identify overlapping sessions within the same event (i.e., session start
-- and end times that conflict).

SELECT
    a.event_id,
    a.session_id AS session_1_id,
    a.title AS session_1_title,
    b.session_id AS session_2_id,
    b.title AS session_2_title
FROM Sessions a
JOIN Sessions b
    ON a.event_id = b.event_id
    AND a.session_id < b.session_id
WHERE a.start_time < b.end_time
  AND b.start_time < a.end_time;
