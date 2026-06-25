# LogicBuilder.App.Spa.Forms.Parameters

[![CI](https://github.com/BpsLogicBuilder/LogicBuilder.App.Spa.Forms.Parameters/actions/workflows/ci.yml/badge.svg)](https://github.com/BpsLogicBuilder/LogicBuilder.App.Spa.Forms.Parameters/actions/workflows/ci.yml)
[![CodeQL](https://github.com/BpsLogicBuilder/LogicBuilder.App.Spa.Forms.Parameters/actions/workflows/github-code-scanning/codeql/badge.svg)](https://github.com/BpsLogicBuilder/LogicBuilder.App.Spa.Forms.Parameters/actions/workflows/github-code-scanning/codeql)
[![codecov](https://codecov.io/gh/BpsLogicBuilder/LogicBuilder.App.Spa.Forms.Parameters/graph/badge.svg?token=IQCZ1TKERD)](https://codecov.io/gh/BpsLogicBuilder/LogicBuilder.App.Spa.Forms.Parameters)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=BpsLogicBuilder_LogicBuilder.App.Spa.Forms.Parameters&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=BpsLogicBuilder_LogicBuilder.App.Spa.Forms.Parameters)

## Overview

**LogicBuilder.App.Spa.Forms.Parameters** is a .NET Standard 2.0 library that provides parameter classes serving as a contract between the Logic Builder application and the .NET applications it defines. This library enables declarative configuration of forms including their layout, controls, validation rules, and visibility logic.

## Purpose

The parameter classes in this library define the functionality of forms in applications built with Logic Builder. They allow form structure and behavior to be configured declaratively rather than programmatically, enabling the Logic Builder application to generate and manage complex forms with:

- **Layout Configuration**: Define form structure and organization
- **Control Definitions**: Specify which UI controls are utilized
- **Validation Rules**: Configure validation logic for form fields
- **Conditional Visibility**: Control when and how form elements are displayed

## Key Features

- ✅ Contract-based form configuration
- ✅ Declarative form definitions
- ✅ Built on top of `LogicBuilder.Forms.Parameters` (v2.1.1)
- ✅ .NET Standard 2.0 compatibility for broad platform support
- ✅ Strongly-typed parameter classes
- ✅ Support for Single Page Application (SPA) forms

## Use Case

This library is essential for applications using the Logic Builder framework, where forms need to be defined and configured externally from the Logic Builder application and consumed by the target .NET applications at runtime.

## Installation
- `dotnet add package LogicBuilder.App.Spa.Forms.Parameters`

Or via NuGet Package Manager:
- `Install-Package LogicBuilder.App.Spa.Forms.Parameters`

## Dependencies

- `LogicBuilder.Forms.Parameters` (>= 2.1.1)

## License

This project is licensed under the MIT License.

## Repository

- **GitHub**: [https://github.com/BpsLogicBuilder/LogicBuilder.App.Spa.Forms.Parameters](https://github.com/BpsLogicBuilder/LogicBuilder.App.Spa.Forms.Parameters)
- **Project Site**: [https://github.com/BpsLogicBuilder/LogicBuilder](https://github.com/BpsLogicBuilder/LogicBuilder)

## Copyright

Copyright © BPS 2026
