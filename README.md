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
+ Rename a category, requires a valid category name
+ Delete a category, if not related to any todos
+ Create a new tag, requires a valid tag name
+ Rename a tag, requires a valid tag name
+ Delete a tag, if not related to any todos
+ Create a todo, requires a valid description and an optional due date, which can be in the past
+ Update a todo's description, if todo is not complete, requires a valid description
+ Update a todo's due date, if todo is not complete, due date is optional and can be in the past
+ Toggle todo complete/not complete
+ Delete todo
+ Add tags to a todo
+ Remove tags from a todo
+ Add categories to a todo
+ Remove categories from a todo
+ See all todos sorted by due date descending, not including completed todos
+ See all completed todos sorted by due date descending
+ Filter todos by categories
+ Filter todos by tags
### Improvement opportunities
TBD
