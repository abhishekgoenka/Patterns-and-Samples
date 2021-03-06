## Synopsis
This repository contains industry recommended examples and code snippet of various languages like JavaScript, C#, etc

## Before you begin
Download all the packages using following commands before you start
>npm update

>bower update

Analyzing source with JSHint and JSCS
>gulp vet

Analyzing source with JSHint and JSCS (shows verbose output)
>gulp vet --verbose

## HelloWorld
This is the test project to try examples. Use following command to browse
>gulp helloworld

## Duff Device Algorithm
This project demo's [Duff's Device Algorithm](https://en.wikipedia.org/wiki/Duff's_device) performance. Don’t use this kind of optimization [unless you really need it!](https://en.wikipedia.org/wiki/Program_optimization#When_to_optimize). 

The gain in performance in some browsers is so small (and some cases even null) that I don’t think it worth using the bitwise operations and division since it makes the code less readable than using Math.floor (that uses Math.floor and simple division) is way more readable and have similar performance

Make sure you confirm that the Duff’s device really improves the performance, even the benchmark demonstrating huge performance gains from normal loops in some cases the performance can be worse, specially since modern JavaScript engines does many optimizations automatically and this kind of technique can potentially “cancel” some of them.

>gulp duffdevice

## Gulp Sample Code
The project is a simple one-page HTML website. However, by setting this code up together, it helps to demonstrate various gulp tasks. [Go inside the project for more details.](https://github.com/abhishekgoenka/Patterns-and-Samples/tree/master/GulpSampleCode)

## .NET Design Patterns
This project contains sample code for commonly used .NET design patterns. Kindly send a pull request if you like to add any specific pattern which you want to include in the project.  [Go inside the project for more details.](https://github.com/abhishekgoenka/Patterns-and-Samples/tree/master/DotNetDesignPatterns) 

## License
MIT license
