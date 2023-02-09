Feature: SellerProfileFeature

As a 'Trade Your Skills(TYS)' portal Seller
I would like to add my Profile Details
So that I can view my Profile Details

Background: I sign into the portal as a seller
	Given I have signed into Trade Your Skill portal successfully using email "wbugan@aol.com" and password "Intport"

Scenario Outline: Set a Seller's Profile Description with valid data
	When Seller navigates to the Description
	And Seller enters a new Description '<NewDesc>'
	Then The Sellers Profile Description was entered as "<NewDesc>"

Examples: 
| NewDesc                                                                                                                                                    |
| This is my description. I am very, very interested in seeing my description wrap into the next line which is going to require many, many, many more words. |

@ignore
Scenario Outline: Set a Seller's Profile Description with invalid - blank - data
	When Seller navigates to the Description
	And Seller enters a new Description '<NewDesc>'
	Then The Sellers Profile Description '<NewDesc>' is invalid

Examples: 
| NewDesc |
|         |

@ignore
Scenario Outline: Set a Seller's Profile Description with invalid - too much - data
	When Seller navigates to the Description
	And Seller enters a new Description '<NewDesc>'
	Then The Sellers Profile Description '<NewDesc>' is invalid

Examples: 
| NewDesc                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| This data is being used to exceed the number of characters allowed in the Description textbox on the Profile page of the Trade Your Skills website. It may take several more words and characters to reach the limit, but I am certain that I can reach it even if I have to write silly words until my fingers hurt. The previous sentence ended with 310 characters so it will not be long before I reach the 600-character limit. Will the textbox count the spaces as characters or will it not count the spaces in the total character count? The count was 430 and 531, respectively without and with the space character at the end of the previous sentence. |

Scenario Outline: Set a Seller's Profile Language with valid data
	When Seller navigates to Language
	And Seller enters Language '<Language>' and Level '<Level>'
	Then The Sellers Profile Language and Level were entered as '<Language>' and '<Level>'

Examples: 
| Language | Level            |
| Korean   | Native/Bilingual |
| Spanish  | Basic            |

@ignore
Scenario Outline: Set a Seller's Profile Language with invalid - blank - data
	When Seller navigates to Language
	And Seller enters invalid Language '<Language>' and Level '<Level>'
	Then The Sellers Profile Language and Level of '<Language>' and '<Level>' are invalid

Examples: 
| Language | Level            |
|          |                  |
|          | Native/Bilingual |
| Korean   |                  |

@ignore
Scenario Outline: Set a Seller's Profile Language with invalid - duplicate - data
	When Seller navigates to Language
	And Seller enters invalid Language '<Language>' and Level '<Level>'
	Then The Sellers Profile Language and Level of '<Language>' and '<Level>' are invalid

Examples: 
| Language | Level            |
| Korean   | Native/Bilingual |
| Korean   | Native/Bilingual |

@ignore
Scenario Outline: Set a Seller's Profile Skill with valid data
	When Seller navigates to Skill
	And Seller enters Skill '<Skill>' and Skill Level '<SkillLevel>'
	Then The Sellers Profile Skill and Skill Level were entered as '<Skill>' and '<SkillLevel>'

Examples: 
| Skill         | SkillLevel   |
| Leadership    | Expert       |
| leadership    | Expert       |
| Acute hearing | Intermediate |

@ignore
Scenario Outline: Set a Seller's Profile Skill with invalid - blank - data
	When Seller navigates to Skill
	And Seller enters invalid Skill '<Skill>' and Level '<SkillLevel>'
	Then The Sellers Profile Skill and Skill Level of '<Skill>' and '<SkillLevel>' are invalid

Examples: 
| Skill  | SkillLevel |
|        |            |
|        | Expert     |
| Verbal |            |

@ignore
Scenario Outline: Set a Seller's Profile Skill with invalid - duplicate - data
	When Seller navigates to Skill
	And Seller enters invalid Skill '<Skill>' and Level '<SkillLevel>'
	Then The Sellers Profile Skill and Skill Level of '<Skill>' and '<SkillLevel>' are invalid

Examples: 
| Skill     | SkillLevel |
| Listening | Expert     |
| Listening | Expert     |

Scenario Outline: Set a Seller's Profile Education with valid data
	When Seller navigates to Education
	And Seller enters Education '<Country>' '<University>' '<Title>' '<Degree>' and '<YearOfGrad>'
	Then The Sellers Profile Education was entered as '<Country>' '<University>' '<Title>' '<Degree>' and '<YearOfGrad>'

Examples: 
| Country  | University                          | Title | Degree    | YearOfGrad |
| Zimbabwe | University of Zimbabwe SouthEastern | B.Sc  | Education | 1994       |

@ignore
Scenario Outline: Set a Seller's Profile Education with invalid - blank - data
	When Seller navigates to Education
	And Seller enters invalid Education '<Country>' '<University>' '<Title>' '<Degree>' and '<YearOfGrad>'
	Then The Sellers Profile Education of '<Country>' '<University>' '<Title>' '<Degree>' and '<YearOfGrad>' is invalid

Examples: 
| Country | University | Title | Degree | YearOfGrad |
|         |            |       |        |            |

@ignore
Scenario Outline: Set a Seller's Profile Certification with valid data
	When Seller navigates to Certifications
	And Seller enters Certificate '<Certificate>' '<From>' and '<YearOfCert>'
	Then The Sellers Profile Certificate(s) was(were) entered as '<Certificate>' '<From>' and '<YearOfCert>'

Examples: 
| Certificate                | From                              | YearOfCert |
| Advanced Awareness of Self | Botswana Society of the very Calm | 2020       |

@ignore
Scenario Outline: Set a Seller's Profile Certification with invalid - blank - data
	When Seller navigates to Certifications
	And Seller enters invalid Certificate '<Certificate>' '<From>' and '<YearOfCert>'
	Then The Sellers Profile Certificate of '<Certificate>' '<From>' and '<YearOfCert>' is invalid

Examples: 
| Certificate | From | YearOfCert |
|             |      |            |

@ignore
Scenario Outline: Set a Seller's Profile Availability with valid data
	When Seller navigates to Availability
	And Seller enters Availability of '<Availability>'
	Then The Sellers Profile Availability was entered as '<Availability>'

Examples: 
| Availability |
| Part Time    |


@ignore
Scenario Outline: Set a Seller's Profile Hours with valid data
	When Seller navigates to Hours
	And Seller enters Hours of '<Hours>'
	Then The Sellers Profile Hours were entered as '<Hours>'

Examples: 
| Hours                    |
| More than 30hours a week |

@ignore
Scenario Outline: Set a Seller's Profile Earnings Target with valid data
	When Seller navigates to Earnings Target
	And Seller enters Earnings Target '<EarningsTarget>'
	Then The Sellers Profile Earnings Target was entered as '<EarningsTarget>'

Examples: 
| EarningsTarget            |
| More than $1000 per month |

#Scenario Outline: Search for existing Seller by User Name
#	When Any user searches for existing Seller by User Name '<UserName>'
#	Then The Seller '<UserName>' is found
#	And All of the Seller\'s Profile Details are displayed correctly on the Profile page
#
#Examples: 
#| UserName | NewDesc                                                                                             | Language | Level            | Skill      | SkillLevel | Country  | University                          | Title | Degree    | YearOfGrad | Certificate                | From                              | YearOfCert | Availability | Hours                    | EarningsTarget            |
#| Wesley B | This is my description. I am very, very interested in seeing my description wrap into the next line | Korean   | Native/Bilingual | Leadership | Expert     | Zimbabwe | University of Zimbabwe SouthEastern | B.Sc  | Education | 1990       | Advanced Awareness of Self | Botswana Society of the very Calm | 2020       | Part Time    | More than 30hours a week | More than $1000 per month |

@ignore
Scenario Outline: Simulate 5,000 sellers trying to add their profile Languages at the same time
	When Five thousand sellers navigate to their Profile Language page
	And Sellers enter <Language> and <Level>
	Then Trade Your Skills portal stops responding

Examples: 
| Language | Level  |
| Kareokee | Fluent |