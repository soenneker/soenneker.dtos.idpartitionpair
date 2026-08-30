[![](https://img.shields.io/nuget/v/Soenneker.Dtos.IdPartitionPair.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Dtos.IdPartitionPair/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.idpartitionpair/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.idpartitionpair/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Dtos.IdPartitionPair.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Dtos.IdPartitionPair/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.idpartitionpair/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.idpartitionpair/actions/workflows/codeql.yml)

# Soenneker.Dtos.IdPartitionPair

A two-field DTO for addressing a record in a partitioned data store. Both fields are required, and the JSON shape is identical with `System.Text.Json` and Newtonsoft.Json.

## Install

```bash
dotnet add package Soenneker.Dtos.IdPartitionPair
```

## Usage

```csharp
using Soenneker.Dtos.IdPartitionPair;

var address = new IdPartitionPair
{
    Id = "order-1042",
    PartitionKey = "customer-87"
};
```

It serializes as:

```json
{
  "id": "order-1042",
  "partitionKey": "customer-87"
}
```

The type does not impose a partition-key convention or validate that the pair exists. Pass the exact values expected by the backing store.
