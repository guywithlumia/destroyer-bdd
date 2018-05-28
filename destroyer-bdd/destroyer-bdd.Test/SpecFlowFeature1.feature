Feature: SpecFlowFeature1

Scenario Outline: Add new file
	Given I have my destroyer
	When I add new file path <filePath>
	Then File count is 1
		Examples: 
		| filePath |
		| "d:\test1.txt"|
		| "d:\test2.txt"|

Scenario Outline: File not exists
	Given I have my destroyer
	When I add new file path <filePath>
	Then File count is 0
		Examples: 
		| filePath |
		| "d:\test3.txt"|

