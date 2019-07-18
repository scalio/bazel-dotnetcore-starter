# bazel-dotnetcore-starter
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

# Build asp dotnet core app

`bazel build //AspNetCore:dll`

# Build docker image for asp dotnet core console app

## Build image

`bazel run //AspNetCore:docker`

## Publish image

`bazel run --define push_tag=${IMAGE_TAG} --define push_repository=${REPOSITORY} //AspNetCore:push_container`

## Credits

Created by [@baio](https://github.com/baio/), [@siberex](https://github.com/siberex/) @ [Scalio](https://scal.io/)

<!-- markdownlint-disable -->
<p align="center">
    <br/>
    <br/>
    <br/>
    <a href="https://scal.io/">
        <img src="readme-assets/scalio.png"/>
    </a>
</p>
<!-- markdownlint-restore -->

