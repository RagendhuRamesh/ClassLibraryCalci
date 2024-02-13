Feature: Calculator1
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProjectCalculator/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Mul two numbers
	Given the first number is 10
	And the second number is 20
	When the two numbers are Multi
	Then the result should be 200

Scenario: sub two numbers
	Given the first number is 10
	And the second number is 20
	When the two numbers are sub
	Then the result should be 10

Scenario: div two numbers
	Given the first number is 10
	And the second number is 5
	When the two numbers are div
	Then the result should be 2