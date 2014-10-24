Feature: Basket
	In order to know what I will be paying
	As a consumer
	I want to know the cost of my basket

Scenario: Empty basket
	Given I have an empty basket
	When I request my basket
	Then the basket price should be 0