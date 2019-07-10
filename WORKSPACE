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


# Download the rules_docker repository
http_archive(
    name = "io_bazel_rules_docker",
    sha256 = "87fc6a2b128147a0a3039a2fd0b53cc1f2ed5adb8716f50756544a572999ae9a",
    strip_prefix = "rules_docker-0.8.1",
    urls = ["https://github.com/bazelbuild/rules_docker/archive/v0.8.1.tar.gz"],
)

load(
    "@io_bazel_rules_docker//repositories:repositories.bzl",
    container_repositories = "repositories",
)

container_repositories()

load(
    "@io_bazel_rules_docker//container:container.bzl",
    "container_pull"
)

container_pull(
  name = "dotnet",
  registry = "mcr.microsoft.com",
  repository = "dotnet/core/runtime",
  # 'tag' is also supported, but digest is encouraged for reproducibility.
  tag = "2.2",
)
