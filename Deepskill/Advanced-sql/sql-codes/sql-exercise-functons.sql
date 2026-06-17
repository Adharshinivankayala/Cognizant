CREATE TABLE Employees (
    EmployeeID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10,2),
    JoinDate DATE
);
DELIMITER $$
#Insert Employee Stored Procedure
CREATE PROCEDURE sp_InsertEmployee(
    IN p_FirstName VARCHAR(50),
    IN p_LastName VARCHAR(50),
    IN p_DepartmentID INT,
    IN p_Salary DECIMAL(10,2),
    IN p_JoinDate DATE
)
BEGIN
    INSERT INTO Employees
    (
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    )
    VALUES
    (
        p_FirstName,
        p_LastName,
        p_DepartmentID,
        p_Salary,
        p_JoinDate
    );
END $$

DELIMITER ;
#Execute Insert Procedure
CALL sp_InsertEmployee(
    'Bhargav',
    'CH',
    1,
    50000,
    '2026-06-15'
);

DELIMITER $$
#Retrieve Employee By Department
CREATE PROCEDURE sp_GetEmployeesByDepartment(
    IN p_DepartmentID INT
)
BEGIN
    SELECT *
    FROM Employees
    WHERE DepartmentID = p_DepartmentID;
END $$

DELIMITER ;
#Execute Retrieval Procedure
CALL sp_GetEmployeesByDepartment(1);
#Verify Data
SELECT * FROM Employees;

DELIMITER $$

DELIMITER $$
#exrecise-07-return data from scalar function
CREATE FUNCTION fn_GetSalary(
    p_EmployeeID INT
)
RETURNS DECIMAL(10,2)
DETERMINISTIC
BEGIN
    DECLARE empSalary DECIMAL(10,2);

    SELECT Salary
    INTO empSalary
    FROM Employees
    WHERE EmployeeID = p_EmployeeID;

    RETURN empSalary;
END $$

DELIMITER ;

SELECT fn_GetSalary(1) AS Salary;