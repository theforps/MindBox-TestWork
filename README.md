# Library and queries

## ShapeLibrary
A C# library for delivery to external customers that can calculate the area of a circle by radius and a triangle on three sides. 

Contains:
* Unit tests
* Ease of adding other shapes
* Calculating the area of a shape without knowing the type of shape in compile-time
* Checking whether the triangle is rectangular

## Queries
There are products and categories in the MS SQL Server database. There can be many categories corresponding to one product, and there can be many products in one category. 

Contains: 
* SQL query to select all pairs "Product Name – Category Name". If the product has no categories, then its name should still be displayed
* Request to create tables
* Request to fill in tables
