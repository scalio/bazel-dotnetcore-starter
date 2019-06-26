
# C# rules
load("@bazel_tools//tools/build_defs/repo:git.bzl", "git_repository")
git_repository(
    name = "io_bazel_rules_dotnet",
    remote = "https://github.com/bazelbuild/rules_dotnet",
    tag = "0.0.3",
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
