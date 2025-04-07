# Whitespace API C# Technical Test
## Overview
Your team is working on incrementally modernizing a .NET Web Forms application. One key challenge is creating a bridge between the legacy system and new microservices built with .NET Core.
Task
Create a small connector class that will:
- Accept data from a legacy Web Forms application using CustomerLegacyData as the payload
- Transform it to a modern format
- Make a **POST** API call to a RESTful endpoint - https://a323da25-bee8-4139-8b5f-096bea873fc2.mock.pstmn.io/customer/:id 
  with payload described in code
- Handle the response appropriately

## Requirements
- Transform data between received legacy data and modern API formats (handling null values appropriately)
- Implement error handling and logging
- Follow modern C# coding conventions
- Ensure the code is testable
- Consider performance implications

## Code Provided
- com.whitespacesws.interview.models - Library containing the required models for this exercise
- com.whitespacesws.interview.api - Empty Web API project.

## Discussion Points During Exercise
- How would you unit test this connector?
- How would you handle API throttling or failure scenarios?
- How would you monitor this component in production?
- How might this approach scale to hundreds of legacy data objects?

## Evaluation Criteria
- Clean code and SOLID principles
- Error handling approach
- Communication during problem solving
- Understanding of API concepts
- Consideration of legacy-to-modern transition challenges
