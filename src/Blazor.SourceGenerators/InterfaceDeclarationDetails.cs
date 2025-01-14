﻿// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace Blazor.SourceGenerators;

record class InterfaceDeclarationDetails(
    GeneratorOptions Options,
    InterfaceDeclarationSyntax InterfaceDeclaration,
    AttributeSyntax InteropAttribute);
