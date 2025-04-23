## TodoDomain
### Description
+ A single-context domain model with entities for a todo list application
+ A class library with related entity models and behaviors
### About
A single-context domain model with entities for a todo list application
### Built with
.NET 9, C# 13
### Features / rules
+ Create a new category, requires a valid category name
+ Create a new tag, requires a valid tag name
+ Create a todo, requires a valid description and an optional due date, which can be in the past
+ Rename a category, requires a valid category name
+ Rename a tag, requires a valid tag name
+ Update a todo's description, if todo is not complete, requires a valid description
+ Update a todo's due date, if todo is not complete, due date is optional and can be in the past
+ Toggle todo complete/not complete
+ Add categories to a todo
+ Remove categories from a todo
+ Add tags to a todo
+ Remove tags from a todo
+ Determine if a category can be deleted (e.g., does it have any todos?)
+ Determine if a tag can be deleted (e.g., does it have any todos?)
### Improvement opportunities
+ Implement a results type that can return success or failure, to replace the exceptions thrown by validation (which are not handled :( )
+ Review access modifiers and the public domain surface 
