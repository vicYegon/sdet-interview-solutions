SELECT
    COUNT(*) AS total_tasks,
    SUM(CASE WHEN task_completed = 1 THEN 1 ELSE 0 END) AS completed_tasks,
    task_assignee,
    COUNT(*) AS tasks_assigned

FROM
    tasks

GROUP BY
    task_assignee;

/*
1. Will prepare a test data and use it to create test cases
2. Execute the query to ensure that all test data is included in the db
3 perform assertions to validate the results based on the test data


*/

/* the above query is essential for a database to automate when tryign to 
- get the total number of tasks in the db
- get the total number of task completed in the db
- get the total number of of tasks assigned for each specific user
 this test will help in future querying without repeating yourself to write the same query over and over
 */ 