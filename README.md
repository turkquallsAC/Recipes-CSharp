# _Recipes_
Unit testing with C# and xUnit

# Add Recipe

```Gherkin
Feature: Add Recipe
    As a baker
    I want to be able to add recipes
    So that I can delight my guests with new creations

    Scenario: Add Recipe
        When I add a recipe
        Then I see the recipe in my list of recipes
```

# Get Recipes

```Gherkin
Feature: Get Recipes
    As a baker
    I want to be able to view my recipes
    So that I can pick the perfect ones for today's specials

    Scenario: Get All Recipes
        Given I have added recipes
        When I get all recipes
        Then I see all recipes available

    Scenario: Get Recipes By Ingredient
        Given I have added recipes
        When I get recipes with the ingredient 'Cinnamon'
        Then I see all recipes that use 'Cinnamon'
```

# Update Recipe

```Gherkin
Feature: Update Recipe
    As a baker
    I want to be able to update my recipes
    So that I can continue improving my recipes based on feedback

    Scenario: Update Recipe Ingredient
        Given I have an existing recipe
        When I update an ingredient's measurement to '1/2 Cups'
        Then I see the ingredient's measurement is '1/2 Cups'
    
    Scenario: Update Recipe Name
        Given I have an existing recipe
        When I update its name to be 'Boss Blueberry Muffin'
        Then I see the recipe's name is now 'Boss Blueberry Muffin'

    Scenario: Remove Ingredient from Recipe
        Given I have an existing recipe
        When I remove an ingredient from the recipe
        Then I the ingredient is not longer in the recipe

    Scenario: Add Ingredient to Recipe
        Given I have an existing recipe
        When I add the ingredient 'Brown Sugar' '1 cup'
        Then I see the recipe requires '1 cup' 'Brown Sugar'
```

# Delete Recipe

```Gherkin
Feature: Delete Recipe
    As a baker
    I want to be able to remove bad recipes
    So that I don't continue making bad food

    Scenario: Delete Recipe
        Given I have an existing recipe
        When I delete the recipe
        Then the recipe does not exist
```

## Recipe Data

Recipe data has the following attributes

```
Recipe
    Name: Name of the recipe
    Ingredients: List of ingredients

Ingredient
    Name: Name of the ingredient
    Amount: Measurement of the amount of the ingredient to use.
```