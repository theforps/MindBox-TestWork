SELECT 
    Products.ProductName, 
    ProductCategories.CategoryName
FROM 
    Products
LEFT JOIN 
    ProductCategoryMapping ON Products.ProductID = ProductCategoryMapping.ProductID
LEFT JOIN 
    ProductCategories ON ProductCategoryMapping.CategoryID = ProductCategories.CategoryID;

