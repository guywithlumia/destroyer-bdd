Feature: SpecFlowFeature1

Scenario: Add new file
	Given I have my destroyer
	When I add new file path "path"
	Then File count is 1
