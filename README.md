# Bazel Dotnet-Core Starter
Bazel build for C# starter project

# Issues

Check out solutions for possible Windows issues here:

https://github.com/scalio/bazel-dotnetcore-starter/wiki

# Build and run dotnet core console app

`bazel run //App:bin`

# Build docker image for dotnet core console app

## Build image

`bazel run //App:docker`

## Publish image

`bazel run --define push_tag=${IMAGE_TAG} --define push_repository=${REPOSITORY} //App:push_container`

# Build asp net core app

`bazel build //AspNetCore:dll`

# Build docker image for asp net core app

## Build image

`bazel run //AspNetCore:docker`

## Publish image

`bazel run --define push_tag=${IMAGE_TAG} --define push_repository=${REPOSITORY} //AspNetCore:push_container`

## Credits

Created by [@baio](https://github.com/baio/), [@siberex](https://github.com/siberex/) @ [Scalio](https://scal.io/)


## About us
<p align="center">
    <br/>
    <a href="https://scal.io/">
        <img src="https://raw.githubusercontent.com/scalio/bazel-status/master/assets/scalio-logo.svg?sanitize=true" />
    </a>
    <br/>
</p>
