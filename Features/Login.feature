@LoginTest
Feature: SauceDemo Login

  Scenario: Successful login with valid credentials
    Given I navigate to the login page
    When I login with username "standard_user" and password "secret_sauce"
    Then I should be redirected to the inventory page

  Scenario: Add Sauce Labs Backpack to the cart
    Given I navigate to the login page
    When I login with username "standard_user" and password "secret_sauce"
    And I add the product "Sauce Labs Backpack" to the cart
    Then the product "Sauce Labs Backpack" should be visible in the cart