-- Exercise 18: Resource Availability Check
-- List all events that do not have any resources uploaded.

SELECT e.event_id, e.title
FROM Events e
LEFT JOIN Resources res ON e.event_id = res.event_id
WHERE res.resource_id IS NULL;
