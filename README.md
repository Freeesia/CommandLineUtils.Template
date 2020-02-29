# CommandLineUtils.Template
[![Publish](https://github.com/Freeesia/CommandLineUtils.Template/workflows/Publish/badge.svg?branch=master)](https://github.com/Freeesia/CommandLineUtils.Template/actions?query=workflow%3APublish)
[![NuGet version](https://badge.fury.io/nu/StudioFreesia.CommandLineUtils.Template.svg)](https://badge.fury.io/nu/StudioFreesia.CommandLineUtils.Template)

Template to use when creating an console app using [McMaster.Extensions.CommandLineUtils](https://github.com/natemcmaster/CommandLineUtils).

## Getting Started

### Installation

```bash
dotnet new -i StudioFreesia.CommandLineUtils.Template
```

### Creation from template

```bash
dotnet new cmd-utils -n <ProjectName>
```

## Example

### Only root command

1. Delete `Command.cs` and `[Subcommand(typeof(Command))]` in `Program.cs:6`.
2. Coding in `Program.OnExecute()`.

### SubCommand

1. Delete `Program.OnExecute()`.
2. Rename `Command.cs` and class name to command name.
3. Coding in `<RenamedName>.OnExecute()`.