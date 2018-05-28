Feature: SpecFlowFeature1

Scenario Outline: Add new file
	Given I have my destroyer
	When I add new file path <filePath>
	Then File count is 1
		Examples: 
		| filePath |
		| "f:\test1.txt"|
		| "f:\test2.txt"|