load("@io_bazel_rules_dotnet//dotnet:defs.bzl", "fsharp_binary")

fsharp_binary(
  name = "numberwang.exe",
  srcs = [
    "Program.fs",
  ],
  deps = [
    "@core_sdk_stdlib//:libraryset",
    "@fsharp.core//:lib",

    # Work-around...
    # "@fparsec//:lib",
    "@FParsec//:FParsec.dll",
    "@FParsec//:FParsecCS.dll",

  ],
)
