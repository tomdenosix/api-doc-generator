[![.NET CI](https://github.com/tomdenosix/api-doc-generator/actions/workflows/CI.yml/badge.svg)](https://github.com/tomdenosix/api-doc-generator/actions/workflows/CI.yml)
[![CodeQL](https://github.com/tomdenosix/api-doc-generator/actions/workflows/github-code-scanning/codeql/badge.svg)](https://github.com/tomdenosix/api-doc-generator/actions/workflows/github-code-scanning/codeql)  
# API Doc Generator

API Doc Generator is a .NET 10 library that converts OpenAPI.NET specifications 
into a single, comprehensive HTML documentation file. This tool is designed to 
help developers and teams quickly generate readable and shareable API 
documentation from their OpenAPI (Swagger) definitions.

## Features
- Converts OpenAPI.NET documents to a single HTML file
- Easy integration into .NET 10 projects
- Produces clean, user-friendly API documentation

## Usage
1. Add the library to your .NET 10 project.
2. Use the provided API to load your OpenAPI.NET document.
3. Generate an HTML file with a single method call.

## Example
```csharp
// Example usage (details to be filled in as implementation progresses)
var html = ApiDocGenerator.GenerateHtml(openApiDocument);
File.WriteAllText("api-docs.html", html);
```

## License
[MIT](LICENSE)
