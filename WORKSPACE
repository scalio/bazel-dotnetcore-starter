workspace(
    # How this workspace would be referenced with absolute labels from another workspace
    name = "bazel_dotnetcore_starter",
)

load("@bazel_tools//tools/build_defs/repo:http.bzl", "http_archive")

# C# rules
http_archive(
    name = "io_bazel_rules_dotnet",
    sha256 = "3ba440608bedc4527239584c3958b5b6507839e2e617a6e0d0e974e300826f26",
    strip_prefix = "rules_dotnet-0.0.3",
    urls = ["https://github.com/bazelbuild/rules_dotnet/archive/0.0.3.tar.gz"],
)

# C# toolchain setup
load(
    "@io_bazel_rules_dotnet//dotnet:defs.bzl", 
    "core_register_sdk", 
    "net_register_sdk",
    #"mono_register_sdk",
    "dotnet_register_toolchains",
    "dotnet_repositories",
    #"nuget_package",
)

dotnet_register_toolchains()
dotnet_repositories()

# .NET Core:
core_register_sdk("v2.1.502", name = "core_sdk")
# .NET Framework:
net_register_sdk("net471", name = "net_sdk")
# Mono:
# mono_register_sdk()
