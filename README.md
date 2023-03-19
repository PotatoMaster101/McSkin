# McSkin
[![License: MIT](https://img.shields.io/badge/License-MIT-brightgreen.svg)](https://github.com/PotatoMaster101/McSkin/blob/main/LICENSE)
[![.NET](https://github.com/PotatoMaster101/McSkin/actions/workflows/dotnet.yml/badge.svg)](https://github.com/PotatoMaster101/McSkin/actions/workflows/dotnet.yml)
[![Nuget](https://img.shields.io/nuget/v/McSkin)](https://www.nuget.org/packages/McSkin)

Small library for playing with Minecraft skins.

## Building
Build with [`dotnet`](https://dotnet.microsoft.com/):
```
$ dotnet build -c Release
```

## Testing
Run all unit tests with [`dotnet`](https://dotnet.microsoft.com/):
```
$ dotnet test -c Release
```

## Usage
```cs
// retrieve a player skin
using var skin = await SkinGrabber.FromUsername("PotatoMaster101");

// retrieve a section on the skin
var section = SkinSectionCollection.Get(SkinSectionId.Head);
using var head = skin.GetSection(section);

// copy a section to another skin
using var skin2 = await SkinGrabber.FromUsername("MHF_Pig");
skin.CopySectionTo(section, skin2);

// save a skin
await skin2.Save("output.png");
```
