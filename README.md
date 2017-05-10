# SwissTransport.NET
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT) [![NuGet](https://img.shields.io/nuget/v/SwissTransport.NET.svg)](https://www.nuget.org/packages/SwissTransport.NET)

SwissTransport.NET offers a .NET Standard library for the [Swiss public transport API](https://transport.opendata.ch)

## Installation

To install SwissTransport.NET, run the following command in the [Package Manager Console](https://docs.microsoft.com/en-us/nuget/tools/package-manager-console):

![](nuget.png)

## Usage

To interact with SwissTransport.NET you first need to create a instance of SwissTransportClient using the following code
```
using SwissTransport;

SwissTransportClient swissTransport = new SwissTransportClient();
```

### Locations

Returns the matching locations for the given parameters

```
public async Task<List<Location>> GetLocations(string locationName)
```

### Stationboard

Returns the next connections leaving from a specific location

```
public async Task<Stationboard> GetStationBoard(string stationName,
                                                string stationId = null,
                                                List<Transportation> transportations = null,
                                                DateTime? dateTime = null,
                                                int? limit = null,
                                                StationboardType? type = null)
```
