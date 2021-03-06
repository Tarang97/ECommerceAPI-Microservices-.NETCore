# ECommerceAPI with Microservices and ASP.NET Core 3.1

The purpose of this project is to develop an e-Commerce RESTful API service App. by leveraging the Microservices architecture with C# and ASP.NET Core. The several services based on the e-commerce website are created such as Products, Orders, Customers, Search in an isolated solution with the independent In-Memory Database to access the data using HttpClient from Search service solution. The Unit Testing is in practice to follow Test-Driven Development pattern to define and confirm software's behavior.

After building in development environment, the build and release pipeline is configured in Azure DevOps to perform CI/CD to deliver software at a faster pace with lower risk by automating the tests and delivering it in multiple stages.

Furthermore, the Docker Support is used by configuring and debugging the docker compose and publishing it to the container registry. So, that later when we provision the Azure Service Fabric, we can use docker compose script to pull the images in the Agent Node and orchestrate our Microservices application from there and verify its response.
