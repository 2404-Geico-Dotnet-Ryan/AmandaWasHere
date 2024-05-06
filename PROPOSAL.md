------------- Proposal -------------

Idea: BakeShop, where you can order bakery goods and search for recipes

Users: Owner, Customer

As an Owner:
- can log in
- able to mark items not available (ingredient and search what recipes that impacts to 
then mark as not available)
- add/edit/delete recipes

As a customer:
- login
- order bake items
- search for recipes


------------- Planning How To -------------

Login: creation? then store, then accesses - happy path for now, use FileIO;

marking not available: List of ingredients? That each recipe will reference to allow recipe 
updates based on availability of ingredients. PRimary key - ingredients

add/edit/delete: list/collection

order bake items: do while loop for asking if they want to add more items, bool

search recipes: ? not sure yet, probably similar to login, have fileIO where recipes are stored?

----------- Created files ----------
 - Recipes by Ingredients xl (values true/false) - where if an ingredient is not available, it will check this table for which recipes are impacted and then update the "store front" shopping aspect of buying baked good;

