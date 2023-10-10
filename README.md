# MobileMoneyConsumerToBusiness

MobileMoneyConsumerToBusiness is a web api and microservices solution.

## Technologies

Asp.net core 7.0 LTS project created using CQRS , DDD and MediatR ,rabbitMq as the broker 
and Sql server for the database *

Others:

- ASP.NET Core
- MediatR
- Mapster
- Fluent Validation
- Serilog
- RabbitMq
- MassTransit
- Sql server
- Minimal API

## Requirements

- https://www.microsoft.com/net/download/windows#/current the latest .NET Core 0.x SDK

### Running in Visual Studio

- Set Startup projects:
  - Web.API

## EF Core & Data Access

- The solution uses these `DbContexts`:

  - `ApplicationDbContext`
  
### Database providers:

- SqlServer


## How to configure API & Swagger

- For development is running on url - `http://localhost:40767` and swagger UI is available on url - `https://localhost:7184/swagger`
- For swagger UI is configured an API


## RabbitMq service

- To set up rabbitMq via:

### RabbitMQ


"RabbitMqQueueSettings": {
        "HostName": "",
        "VirtualHost": "",
        "UserName": "",
        "Port": "",
        "Password": ""
    }


### Solution structure:

- Core.Api:

  - `Web.API` - project that contains the web api

  ###Project folder structure
  - 'Domain': Core.Domain
  - contain entities, entity configurations, enums, exceptions,DbContext and Dependency injection setup
  
   - 'Application': Application
   - contains service definition and implementation,DTOs,Exceptions and  Dependency injection setup

    - 'Infrastructure': Infrastructure
    -contains the EventBus and repository  implementation 
