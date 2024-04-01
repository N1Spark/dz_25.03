------AVG CALORIES

CREATE PROCEDURE FindAVGCal
AS
BEGIN
    DECLARE @AverageCalories FLOAT;
    
    SELECT @AverageCalories = AVG(Calories) FROM Products;
    
    SELECT TOP 1 *
    FROM Products
    ORDER BY ABS(Calories - @AverageCalories) ASC;
END;


-----------Search by Color Parametr

CREATE PROCEDURE FindByColor
    @Color NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM Products
    WHERE Color = @Color;
END;



-----------Min Calories All

CREATE PROCEDURE FindMinCal
    @minCalories INT
AS
BEGIN
    SELECT *
    FROM Products
    WHERE Calories < @minCalories;
END;



-----------Max Calories All

CREATE PROCEDURE FindMaxCal
    @maxCalories INT
AS
BEGIN
    SELECT *
    FROM Products
    WHERE Calories > @maxCalories;
END;



-----------Min and Max Calories All

CREATE PROCEDURE FindMinMaxCal
    @minCalories INT,
    @maxCalories INT
AS
BEGIN
    SELECT *
    FROM Products
    WHERE Calories >= @minCalories AND Calories <= @maxCalories;
END;



-------------Red and Yellow Color

CREATE PROCEDURE FindYelowRed
AS
BEGIN
    SELECT *
    FROM Products
    WHERE Color IN ('Yellow', 'Red');
END;


----------Add Product

CREATE PROCEDURE InsertProduct
    @Name NVARCHAR(100),
    @Type NVARCHAR(100),
    @Color NVARCHAR(50),
    @Calories INT
AS
BEGIN
    INSERT INTO Products (Name, Type, Color, Calories)
    VALUES (@Name, @Type, @Color, @Calories);
END;


----------Delete Product
CREATE PROCEDURE DeleteProduct
    @Name NVARCHAR(100),
    @Type NVARCHAR(100),
    @Color NVARCHAR(50),
    @Calories INT
AS
BEGIN
    DELETE FROM Products
    WHERE Name = @Name
        AND Type = @Type
        AND Color = @Color
        AND Calories = @Calories;
END;