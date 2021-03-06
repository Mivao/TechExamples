# TechExamples
Each folder contains a project that is an example implementation of a piece of technology related to .Net.

Categories listed below with links to documentation where possible, as well as other helpful resources.

## Application Performance Management (APM)
- [New Relic](https://docs.newrelic.com/) 
- [Jaeger, open source, end-to-end distributed tracing](https://www.jaegertracing.io/)
   - [Jaeger Intro](https://www.youtube.com/watch?v=UNqilb9_zwY) 
- [OpenTelemetry, log, metric, and trace exporter](https://opentelemetry.io/docs/) ([.NET client](https://github.com/open-telemetry/opentelemetry-dotnet))

## Operations
- [Serilog, simple .NET logging with fully-structured events](https://serilog.net/)
   - [Serilog Tutorial - Covers the Basics](https://www.youtube.com/watch?v=_iryZxv8Rxw) 
- [NLog](https://nlog-project.org/) (Used in older projects)

## Database
- SQL Server
- [Availability Groups (HA, High Availability)](https://docs.microsoft.com/en-us/sql/database-engine/availability-groups/windows/always-on-availability-groups-sql-server?view=sql-server-ver15)
   - [Overview of "Always On" features in SQL Server](https://youtu.be/HuXVpNTbknM) 
- [SQL Agent Jobs](https://docs.microsoft.com/en-us/sql/ssms/agent/sql-server-agent?view=sql-server-ver15)

## Dependency Injection (DI) and Inversion of Control (IoC)
- [Autofac, DI and IoC container](https://autofac.org/)
   - [Available scopes](https://autofaccn.readthedocs.io/en/latest/lifetime/instance-scope.html)   
- [.NET Built-in DI](https://docs.microsoft.com/en-us/dotnet/core/extensions/dependency-injection)
- DI/IoC Theory and Design Patterns 
   - [Good primer video on DI in .NET](https://www.youtube.com/watch?v=0x2KW-dJDQU&ab_channel=JetBrainsTV)

## Authentication
- OAuth2.0 Flows, Grant Types, etc.
  - [Good LinkedIn course on OAuth2.0](https://www.linkedin.com/learning/web-security-oauth-and-openid-connect-2)
  - [Really Clear Explanation of Exactly What OAuth/OIDC Are](https://youtu.be/996OiexHze0)
  - [OAuth playground](http://oauth.com/playground/)
- [Identity Server](https://identityserver4.readthedocs.io/en/latest/)
   - [Intro to setting up identity server](https://youtu.be/HJQ2-sJURvA)
   - [Connecting a database](https://youtu.be/Sw1rScI20xM)
- JOT Tokens
- JWS Signing

## Cryptography
- Symmetric/Asymmetric Cryptography
   - [A Brief Explainer](https://www.youtube.com/watch?v=AQDCe585Lnc)
   - [More detail on RSA Encryption](https://www.comparitech.com/blog/information-security/rsa-encryption/) (A bit of Maths involved)
- PGP Encryption & Signing
   - [A Library for PGP in C#](https://github.com/mattosaurus/PgpCore) 

## Other
- [Dapper - a simple object mapper for .NET](https://github.com/DapperLib/Dapper)
- [Polly - a .NET resilience and transient-fault-handling library](https://github.com/App-vNext/Polly)
   - [A Video Tutorial on Polly](https://www.youtube.com/watch?v=yXzn6HxTufM&list=PLUOequmGnXxM1L_nj63YIWB8B5wdNk6dA&index=1) 
   - [Video about circuit breakers](https://youtu.be/JljTcjt798c)
   - [How Netflix uses circuit breakers](https://netflixtechblog.com/making-the-netflix-api-more-resilient-a8ec62159c2d) (more interesting if you do some research into redis and cacheing)
- [Newtonsoft - JSON parsing, serialization, and deserialization](https://www.newtonsoft.com/json)
- [Redis - a key-value datastructure used for cacheing](https://redis.io/)
   - [.NET docs on distributed cacheing](https://docs.microsoft.com/en-us/aspnet/core/performance/caching/distributed?view=aspnetcore-5.0)
   - [Setting up basic interactions with Redis](https://youtu.be/jwek4w6als4)
   - [Custom middleware/attributes to cache responses](https://youtu.be/KboCpJGa9ag)
   - [HTTP cacheing headers](https://docs.microsoft.com/en-us/aspnet/core/performance/caching/response?view=aspnetcore-5.0)
   - Unclear how to effectively use this with non-static data (like all of ours has been so far), would need to remove/invalidate the caches when data is modified.
   - [Interesting write up on cacheing considerations](https://lobster1234.github.io/2017/07/05/caching-gotchas-and-lessons-learned/)
- [Solace Event Broker](https://docs.solace.com/Solace-PubSub-Platform.htm)
