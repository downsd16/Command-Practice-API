<a name="readme-top"></a>

<br />
<div align="center">
  <h1 align="center">Command Practice Leaderboard API</h1>

  <p align="center">
    A simple Azure Function for reading and writing command practice leaderboard statistics using the cache-aside pattern.
    <br />
    <br />
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li><a href="#about-the-project">About The Project</a></li>
    <li><a href="#getting-started">Getting Started</a></li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#improvements">Improvements</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->

## About The Project

![project diagram](<GITHUB ASSET HREF>?raw=true)

This API uses Azure Cache for Redis, CosmosDB NoSQL, and the <a href="https://www.nuget.org/packages/Microsoft.Azure.Cosmos">.NET Azure CosmosDB package</a> to store a leaderboard for a gamified CLI learning tool. The cache-aside pattern is used for scalability and throughput improvements. The REST API is called to either read data or add/update data in the database. 

Features:
- Redis Cache for scalability/performance
- High scores stored in redis sorted set
- CosmosDB NoSQL for point of origin storage
- <a href="https://learn.microsoft.com/en-us/azure/architecture/patterns/cache-aside">Cache-Aside</a> pattern implementation
- CI/CD with GitHub Actions (default yaml included)

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started

This is an example of how you may give instructions on setting up your project locally.
To get a local copy up and running follow these simple example steps.


### Installation

1. Clone the repo
   ```sh
   git clone https://github.com/downsd16/hire-downs-api.git
   ```
3. Install Packages
   ```sh
   cd <PATH_TO_PROJECT_ROOT_DIR>
   dotnet add package
   ```
4. Deploy resources from ARM template
5. Configure Keyvault secrets/table id's

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- USAGE EXAMPLES -->
## Usage

Configure the desired level of Function call (Anon, Function, Private) and call from resource according to the chosen level.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- IMPROVEMENTS -->
## Improvements

Some improvements I would make to the API

- Caching for faster response time
- Content upload front end (i.e. Sanity.io)
- Scale in/out rules using App Insights Metrics
    - Currently uses consumption for cost savings
- Move project images to blob CDN
    - Project images are served from frontend storage

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

- [LinkedIn](https://www.linkedin.com/in/devindowns5/)
- [Personal Website](https://hire-downs.dev)
- [Project Link](https://github.com/downsd16/hire-downs.dev)

<p align="right">(<a href="#readme-top">back to top</a>)</p>
