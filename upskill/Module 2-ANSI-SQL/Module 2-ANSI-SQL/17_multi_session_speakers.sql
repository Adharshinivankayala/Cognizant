-- Exercise 17: Multi-Session Speakers
-- Identify speakers who are handling more than one session across all events.

SELECT
    speaker_name,
    COUNT(*) AS session_count
FROM Sessions
GROUP BY speaker_name
HAVING COUNT(*) > 1;
