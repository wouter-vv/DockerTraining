[[_TOC_]]

## Prerequisites
There are no specific skills needed for this tutorial beyond a basic comfort with Visual Studio, Visual Studio Code and/or the command-line.

While the course uses .NET Core 3.1, prior experience with it is not required but will certainly be helpful.

## Setting up your computer
Getting all the tooling setup on your computer can be a daunting task, but getting Docker up and running has become very easy.

The *getting started* guide on Docker has detailed instructions for setting up Docker on [Windows](https://docs.docker.com/docker-for-windows/install/).

Once you are done installing Docker, test your Docker installation by running the following command in cmd/powershell/bash:
```
$ docker run hello-world
Unable to find image 'hello-world:latest' locally
latest: Pulling from library/hello-world
03f4658f8b78: Pull complete
a3ed95caeb02: Pull complete
Digest: sha256:8be990ef2aeb16dbcb9271ddfe2610fa6658d13f6dfb8bc72074cc1ca36966a7
Status: Downloaded newer image for hello-world:latest

Hello from Docker.
This message shows that your installation appears to be working correctly.
...
```

## Getting the labs

All our guidance and labs are available on [Azure DevOps](https://dev.azure.com/codit/Codit%20Integration%20Factory/_git/DockerForDummies).

You can pull them to your local computer as following:
```shell
git clone https://codit@dev.azure.com/codit/Codit%20Integration%20Factory/_git/DockerForDummies
```

Is the guidance or lab not clear? Feel free to open a pull request with your proposal.

# Next Steps
For the next step in the training, head over to [1. Containerizing a console application](/1.-Containerizing-a-console-app)
