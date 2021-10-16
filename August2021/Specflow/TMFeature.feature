Feature: TMFeature
	 As a turnup portal admin 
	 I would like to create ,edit,delete time and material record
	 so that i can manage employees time and material sucessfully 

	 @tmtest @regression
Scenario: Create time and material record with vaild details
	Given I logged into turnup portal sucessfully
	And I nagivate to time and material pagwe
	When I create time and material record
	Then The record should be created sucessfully


 @tmtest @regression
Scenario Outline: Edit time and material record with vaild details
	Given I logged into turnup portal sucessfully
	And I nagivate to time and material pagwe
	When I update <Decrption> existed time and material record
	Then The record should be update sucessfully
	Examples: 
	| Decrption |
	| apple     |
	| mat       |
	| set       |




 @tmtest @regression
Scenario Outline: delete time and material record with vaild details
	Given I logged into turnup portal sucessfully
	And I nagivate to time and material pagwe
	When I delete time and material record
	Then The record should be delete sucessfully