Feature: Seller_Profile_Feature

As a 'Trade Your Skills(TYS)' portal Seller
I would like to add my Profile Details
So that I can view my Profile Details

Background: I log into the portal as a seller
	Given I have logged into Trade Your Skill portal successfully using email "wbugan@aol.com" and password "Intport"

Scenario Outline: Set a Seller's Profile Description with valid data
	When Seller navigates to the Description
	And Seller enters a new Description '<NewDesc>'
	Then The Seller's Profile Description was entered as '<NewDesc>'

Examples: 
| NewDesc                                                                                            |
| This is my description. I am very, very interested in seeing my description wrap into the 2nd line |

Scenario Outline: Set a Seller's Profile Description with invalid data
	When Seller navigates to the Description
	And Seller enters a new Description '<NewDesc>'
	Then The Seller's Profile Description ''<NewDesc>'' is invalid

Examples: 
| NewDesc |
|         |

Scenario Outline: Set a Seller's Profile Language with valid data
	When Seller navigates to Language
	And Seller enters Language '<Language>' and Level '<Level>'
	Then The Seller's Profile Language and Level were entered as '<Language>' and '<Level>'

Examples: 
| Language | Level            |
| Korean   | Native/Bilingual |
| Spanish  | Basic            |

Scenario Outline: Set a Seller's Profile Language with invalid data
	When Seller navigates to Language
	And Seller enters Language '<Language>' and Level '<Level>'
	Then The Seller's Profile Language and Level of '<Language>' and '<Level>' are invalid

Examples: 
| Language | Level            |
|          | Native/Bilingual |


Scenario Outline: Set a Seller's Profile Skill with valid data
	When Seller navigates to Skill
	And Seller enters Skill '<Skill>' and Level '<SkillLevel>'
	Then The Seller's Profile Language and Level were entered as '<Skill>' and '<SkillLevel>'

Examples: 
| Skill         | SkillLevel   |
| Leadership    | Expert       |
| Awareness     | Beginner     |
| Acute hearing | Intermediate |

Scenario Outline: Set a Seller's Profile Skill with invalid data
	When Seller navigates to Skill
	And Seller enters Skill '<Skill>' and Level '<SkillLevel>'
	Then The Seller's Profile Language and Level of '<Skill>' and '<SkillLevel>' are invalid

Examples: 
| Skill | SkillLevel |
|       | Expert     |

Scenario Outline: Set a Seller's Profile Education with valid data
	When Seller navigates to Education
	And Seller enters Education '<Country>' '<University>' '<Title>' '<Degree>' and '<YearOfGrad>'
	Then The Seller's Profile Education was entered as '<Country>' '<University>' '<Title>' '<Degree>' and '<YearOfGrad>'

Examples: 
| Country  | University                          | Title | Degree    | YearOfGrad |
| Zimbabwe | University of Zimbabwe SouthEastern | B.Sc  | Education | 1990       |

Scenario Outline: Set a Seller's Profile Education with invalid data
	When Seller navigates to Education
	And Seller enters Education '<Country>' '<University>' '<Title>' '<Degree>' and '<YearOfGrad>'
	Then The Seller's Profile Education of '<Country>' '<University>' '<Title>' '<Degree>' and '<YearOfGrad>' is invalid

Examples: 
| Country | University | Title | Degree | YearOfGrad |
|         |            |       |        |            |

Scenario Outline: Set a Seller's Profile Certification with valid data
	When Seller navigates to Certifications
	And Seller enters Certificate '<Certificate>' '<From>' and '<YearOfCert>'
	Then The Seller's Profile Certificate(s) was(were) entered as '<Certificate>' '<From>' and '<YearOfCert>'

Examples: 
| Certificate                | From                              | YearOfCert |
| Advanced Awareness of Self | Botswana Society of the very Calm | 2020       |

Scenario Outline: Set a Seller's Profile Certification with invalid data
	When Seller navigates to Certifications
	And Seller enters Certificate '<Certificate>' '<From>' and '<YearOfCert>'
	Then The Seller's Profile Certificate of '<Certificate>' '<From>' and '<YearOfCert>' is invalid

Examples: 
| Certificate | From | YearOfCert |
|             |      |            |

Scenario Outline: Set a Seller's Profile Availability with valid data
	When Seller navigates to Availability
	And Seller enters Availability of '<Availability>'
	Then The Seller's Profile Availability was entered as '<Availability>'

Examples: 
| Availability |
| Part Time    |


Scenario Outline: Set a Seller's Profile Hours with valid data
	When Seller navigates to Hours
	And Seller enters Hours of '<Hours>'
	Then The Seller's Profile Hours were entered as '<Hours>'

Examples: 
| Hours                    |
| More than 30hours a week |

Scenario Outline: Set a Seller's Profile Earnings Target with valid data
	When Seller navigates to Earnings Target
	And Seller enters Earnings Target '<EarningsTarget>'
	Then The Seller's Profile Hours were entered as '<EarningsTarget>'

Examples: 
| EarningsTarget            |
| More than $1000 per month |

#Scenario Outline: Search for existing Seller by User Name
#	When Any user searches for existing Seller by User Name '<UserName>'
#	Then The Seller '<UserName>' is found
#	And All of the Seller's Profile Details are displayed correctly on the Profile page
#
#Examples: 
#| UserName | NewDesc                                                                                            | Language | Level            | Skill      | SkillLevel | Country  | University                          | Title | Degree    | YearOfGrad | Certificate                | From                              | YearOfCert | Availability | Hours                    | EarningsTarget            |
#| Wesley B | This is my description. I am very, very interested in seeing my description wrap into the 2nd line | Korean   | Native/Bilingual | Leadership | Expert     | Zimbabwe | University of Zimbabwe SouthEastern | B.Sc  | Education | 1990       | Advanced Awareness of Self | Botswana Society of the very Calm | 2020       | Part Time    | More than 30hours a week | More than $1000 per month |
