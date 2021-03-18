# bazel-fparsec

Using traditional .NET tooling:

```bash
dotnet run -- numberwang
```

Using Bazel:

```bash
bazel run //:numberwang.exe -- numberwang
```

Refresh Nuget dependencies:

```bash
bazel run @io_bazel_rules_dotnet//tools/nuget2bazel:nuget2bazel.exe -- sync -p $PWD
```

Inspecting the FParsec package:

```bash
$ wget https://www.nuget.org/api/v2/package/FParsec/1.1.1 -O fparsec.zip

$ unzip fparsec.zip -d fparsec

$ tree ./fparsec
./fparsec
├── [Content_Types].xml
├── FParsec.nuspec
├── lib
│   ├── net45
│   │   ├── FParsecCS.dll
│   │   ├── FParsecCS.pdb
│   │   ├── FParsecCS.xml
│   │   ├── FParsec.dll
│   │   ├── FParsec.pdb
│   │   └── FParsec.xml
│   └── netstandard2.0
│       ├── FParsecCS.dll
│       ├── FParsecCS.pdb
│       ├── FParsecCS.xml
│       ├── FParsec.dll
│       ├── FParsec.pdb
│       └── FParsec.xml
├── package
│   └── services
│       └── metadata
│           └── core-properties
│               └── 476d896566b94649b5814b9912b805bc.psmdcp
└── _rels
```
