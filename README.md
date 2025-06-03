# Melissa Cloud API NuGet Package

## Overview

The Melissa Cloud API NuGet Package provides a unified and streamlined way to access all Melissa Cloud APIs within a single, easy-to-use package. This allows developers to seamlessly integrate and access Melissa's powerful cloud-based services directly from their own development environment. 

For more details about how to use the Melissa Cloud API NuGet Package, please visit the [Melissa Docs](https://docs.melissa.com/cloud-api/cloud-api/cloud-api-packages-installation-guide.html)

For more details about Melissa Cloud APIs, please click [here](https://docs.melissa.com/cloud-api/cloud-api/cloud-api-index.html).

## Features

- **Comprehensive API Coverage:** Access all Melissa Cloud APIs through a unified interface
- **Ease of Integration:** Simplifies the process of integrating Melissa's Cloud APIs into your applications
- **Consistent Interface:** Offers a standardized way to interact with different Melissa Cloud APIs

## Available APIs
- Business Coder
- Global Address Verification
- Global Email
- Global Express Entry
- Global IP
- Global Name
- Global Phone
- People Business Search
- Personator Consumer
- Personator Identity
- Personator Search
- Property
- Reverse GeoCoder
- SmartMover
- SSN Name Match
- Street Route

## Tested Environment
- Windows 10 64-bit

# Getting Started

These instructions will get you a copy of the package integrated into your development environment.

### Licensing

All Melissa cloud services require a license to use. This license is an encrypted series of letters, numbers, and symbols. This license can also either be a Credit license or a Subscription license. Both ways use the same service, so you do not need to change your code to move from one model to another.

To learn more about how to set up a license key with Melissa, please click [here](https://docs.melissa.com/cloud-api/cloud-api/licensing.html).

### Installation

**To integrate the package source code with another Visual Studio project, proceed with the following instructions:**

1. Navigate to the project directory where you would like to add the package
2. Clone the package using the command:

```
git clone https://github.com/MelissaData/MelissaCloudAPI-Nuget
```

3. Open your **Visual Studio** project
4. Right-click the project solution and go to *Add* → *Existing Project*
5. Add **MelissaCloudAPINuGet.csproj**
6. Right-click the project in the solution explorer and go to *Add* → *Project Reference*
7. Add **MelissaCloudAPINuGet**

### Import in C#
After installing, add the following statement to import the namespace at the top of your C# file:

```
using MelissaData.CloudAPI;
```

## Contact Us
For free technical support, please call us at 800-MELISSA ext. 4 (800-635-4772 ext. 4) or email us at Tech@Melissa.com.
