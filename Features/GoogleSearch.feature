Feature: Google Search

  Scenario: Search for Facebook
    Given I have opened the browser
    When I navigate to Google and search for "Facebook"
    Then the search results should include "Facebook.com"
