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

This API uses a Redis Cache sorted set to store a leaderboard for a Command Practice gamified learning tool. The cache-aside pattern is used for scalability and throughput improvements.

Features:
<ul>
  <li>Use Redis Cache for scalability/performance</li>
  <li>CosmosDB NoSQL for point of origin storage</li>
  <li><a href="https://learn.microsoft.com/en-us/azure/architecture/patterns/cache-aside">Cache-Aside</a> pattern implementation</li>
  <li>CI/CD with GitHub Actions (default yaml included)</li>
</ul>

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
Best used with a single table utilizing partition keys for logical and throughput performance.

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

Devin Downs - downsd16@gmail.com

Project Link: [https://github.com/downsd16/hire-downs-api](https://github.com/downsd16/hire-downs-api)

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- MARKDOWN LINKS & IMAGES -->

[contributors-shield]: https://img.shields.io/github/contributors/downsd16/hire-downs-api.svg?style=for-the-badge
[contributors-url]: https://github.com/downsd16/hire-downs-api/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/downsd16/hire-downs-api.svg?style=for-the-badge
[forks-url]: https://github.com/downsd16/hire-downs-api/network/members
[license-shield]: https://img.shields.io/github/license/downsd16/hire-downs-api.svg?style=for-the-badge
[license-url]: https://github.com/downsd16/hire-downs-api/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/linkedin_username
