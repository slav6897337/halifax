| Package | NuGet |
|-|-|
| Halifax.Api &nbsp;&nbsp;&nbsp; | [![NuGet](https://img.shields.io/nuget/v/Halifax.Api.svg)](https://www.nuget.org/packages/Halifax.Api/)  |
| Halifax.Core &nbsp;&nbsp;&nbsp; | [![NuGet](https://img.shields.io/nuget/v/Halifax.Core.svg)](https://www.nuget.org/packages/Halifax.Core/) |
| Halifax.Models &nbsp;&nbsp;&nbsp; | [![NuGet](https://img.shields.io/nuget/v/Halifax.Models.svg)](https://www.nuget.org/packages/Halifax.Models/) | 

# Halifax Service Foundation
Simplistic libraries for complex projects. Halifax libraries are designed to speed up API service development process by encapsulating common functionality required for all microservices, allowing developers to focus on the business logic instead of copy-pasting the boilerplate code from project to project. The libraries are focussed on the following aspects of any application:
- ✅ Exception handling
- ✅ API models
- ✅ Swagger
- ✅ JWT Auth
- ✅ Logging
- ✅ CORS

# Installation
Install the API library using [nuget package](https://www.nuget.org/packages/Halifax.Api) with Package Manager Console:

```
Install-Package Halifax.Api
```

Or using .NET CLI:

```
dotnet add package Halifax.Api
```

# Getting Started

Please refer to the [Peggy's Cove](https://github.com/andrei-m-code/halifax/blob/main/PeggysCove.Api/Startup.cs) example API project Startup.cs file for more details but basically all you need is to have this in your startup class:

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHalifax();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHalifax();
        }
    }

This enables routing with controllers and exception handling.

# Models

It's very beneficial if all API responses follow the same format. In order to achieve it there is a model called `ApiResponse`. It's designed to return response data, empty data or error information in the same consistent format. Here are the main use cases:

    // Return API response with your model
    return ApiResponse.With(model);
    
    // Return empty API response
    return ApiResponse.Empty;

When API response is used for all APIs in the project the response will always be of a format:

    {
        data: {...} // your model
        success: true/false,
        error: { // null if successful
            type: "ArgumentNullException",
            message: "Email is required",
            trace: "(126) ArgumentNullException was thrown ... (typical exception stack trace)"
        }
    }

# MIT License

Copyright (c) 2020 Andrei M

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

