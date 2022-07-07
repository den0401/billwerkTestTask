Feature: GlobalSQA

Scenario: Number of countries in the dropdown
	Given the GlobalSQA page is opened
	When I click the select country dropdown
	Then the dropdown list contains '249' countries