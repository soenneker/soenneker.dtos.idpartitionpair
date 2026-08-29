[![](https://img.shields.io/nuget/v/Soenneker.Dtos.IdPartitionPair.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Dtos.IdPartitionPair/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.idpartitionpair/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.idpartitionpair/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Dtos.IdPartitionPair.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Dtos.IdPartitionPair/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.idpartitionpair/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.idpartitionpair/actions/workflows/codeql.yml)

# Soenneker.Dtos.IdPartitionPair

Identifies a partitioned record by its resource identifier and partition key.

## Install

```bash
dotnet add package Soenneker.Dtos.IdPartitionPair
```

## What you get

- `IdPartitionPair` — Identifies a partitioned record by its resource identifier and partition key.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `IdPartitionPair.Id` | Stable identifier of the record within its partition. | Stable identifier of the record within its partition. |
| `IdPartitionPair.PartitionKey` | Partition key used to locate and route the record in the backing data store. | Partition key used to locate and route the record in the backing data store. |
