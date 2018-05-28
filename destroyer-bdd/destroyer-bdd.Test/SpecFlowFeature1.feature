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

Scenario Outline: Destroy File
Given I have my destroyer
When I add new file path <filePath>
And I delete new file
Then File <filePath> non exists
		Examples: 
		| filePath |
		| "d:\test1.txt"|

Scenario Outline: Destroy Files
Given I have my destroyer
When I add new file path <filePath1>
And I add new file path <filePath2>
And I delete new files
Then File <filePath1> non exists
And File <filePath2> non exists
		Examples: 
		| filePath1 | filePath2 |
		| "d:\test4.txt"| "d:\test5.txt"|