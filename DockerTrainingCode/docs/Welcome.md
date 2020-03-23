# Docker for dummies
Welcome to Docker for Dummies. This tutorial will help you understand what containers are, and how it fits in your development environment. 

_If you find any issues in this tutorial, feel free to create an issue or a PR containing a fix._

![Hello image](.media/hello.png)

[[_TOC_]]

## What is Docker?
Chances are you've at least heard of Docker: a helpful tool for packing, shipping and running applications within 'containers'. Docker enables you to separate your applications from your infrastructure so you can deliver software quickly. Let's discover the core terminology before we start.

### Containers
Containers and VM's are similar in their goals: to isolate an application and its dependencies into a self-contained unit that can run *anywhere*. Containers and virtual machines have similar resource isolation and allocation benefits, but function differently because containers virtualize the operating system instead of hardware. Containers are more portable and efficient.

![.media/container-vm.png](.media/container-vm.png)

The idea of containers is that you run every application inside its own container. Want SQL Server? Start up a sql container. Custom application? Package it up into an 'image' and run it as a container.

### Images
> The image is the recipe, the container is the cake.

An image is the template (application plus required binaries and libraries) needed to build a running Docker container. For example, a SQL server image contains the files and executable needed to get a SQL server up and running. It's only when actually running an instance of this image (a container) that it will execute. 

Once an image is created, it is immutable. Changes done to an image result in a new image.

That concludes the basic terminology. 

## Command-line?!
In this tutorial we will use the command-line in combination with an editor (Visual Studio, Visual Studio Code, or Notepad++ for that matter). The reason for this is to more easily understand the fundamentals of Docker. After this tutorial, you can safely use Visual Studio tooling, with the added benefit you'll have a better understanding of which files it creates, and the reason it has to create them.

## Course Outline

- Part 1: [Containerizing a console application](/1.-Containerizing-a-console-app)
- Part 2: [Optimizing our container](/2.-Optimizing-our-container)
- Part 3: [Deploying our container in Azure](/3.-Deploying-our-container-in-Azure)
- Part 4: [Looking into Visual Studio tooling](/4.-Looking-into-Visual-Studio-tooling)
- Part 5: [Moving our container to other environments](/5.-Moving-our-container-to-other-environments)

Before we start, you'll have to [setting up your machine](/Setting-up-your-machine).
