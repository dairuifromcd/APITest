# Introduction 
This project tests the Festivals API output

# Requirement
Visual Studio 2019
.NET Core 3.1

# Verifications
1. API response status code
2. API response content is not empty or null
3. API response content matches the Json Schema at Schemas/FestivalSchema.json, which mandanes all properties to be required and disallows additional properties
4. Festivals array is not null
5. Festivals count is larger than 0 and equal or samller than MAX (optional)
6. Festival names don't duplicate (optional)
7. Festival name is not empty or null
8. Festival bands is not null
9. Festival bands count is larger than 0 and equal or samller than MAX (optional)
10. Festival band names don't duplicate (optional)
11. Band name is not empty or null
12. Band RecordLabel is not empty or null

# Findings
Three issues found with API response below:

1. missing required property

a. Festival Twisted Tour, band Squint-281 does not have recordLabel property
b. Last Festival object does not have name property

2. invalid property value

a. For festival LOL-palooza, band Winter Primates' recordLabel property value = ""

[
  {
    "name": "LOL-palooza",
    "bands": [
      {
        "name": "Winter Primates",
        "recordLabel": ""
      },
      {
        "name": "Frank Jupiter",
        "recordLabel": "Pacific Records"
      },
      {
        "name": "Jill Black",
        "recordLabel": "Fourth Woman Records"
      },
      {
        "name": "Werewolf Weekday",
        "recordLabel": "XS Recordings"
      }
    ]
  },
  {
    "name": "Small Night In",
    "bands": [
      {
        "name": "Squint-281",
        "recordLabel": "Outerscope"
      },
      {
        "name": "The Black Dashes",
        "recordLabel": "Fourth Woman Records"
      },
      {
        "name": "Green Mild Cold Capsicum",
        "recordLabel": "Marner Sis. Recording"
      },
      {
        "name": "Yanke East",
        "recordLabel": "MEDIOCRE Music"
      },
      {
        "name": "Wild Antelope",
        "recordLabel": "Marner Sis. Recording"
      }
    ]
  },
  {
    "name": "Trainerella",
    "bands": [
      {
        "name": "Wild Antelope",
        "recordLabel": "Still Bottom Records"
      },
      {
        "name": "Manish Ditch",
        "recordLabel": "ACR"
      },
      {
        "name": "Adrian Venti",
        "recordLabel": "Monocracy Records"
      },
      {
        "name": "YOUKRANE",
        "recordLabel": "Anti Records"
      }
    ]
  },
  {
    "name": "Twisted Tour",
    "bands": [
      {
        "name": "Auditones",
        "recordLabel": "Marner Sis. Recording"
      },
      {
        "name": "Squint-281"
      },
      {
        "name": "Summon",
        "recordLabel": "Outerscope"
      }
    ]
  },
  {
    "bands": [
      {
        "name": "Propeller",
        "recordLabel": "Pacific Records"
      },
      {
        "name": "Critter Girls",
        "recordLabel": "ACR"
      }
    ]
  }
]