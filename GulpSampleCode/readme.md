## Synopsis
The project is a simple one-page HTML website. However, by setting this code up together, it helps to demonstrate various gulp tasks. The project is developed in open source text editor - [Brackets](http://brackets.io/)

You are more than welcome to add in any additional code that you would like, but for the sake of simplicity and clarity, the code examples in this project designed specifically to demonstrate the work this tasks will do to our code.

## Downloading and installing node.js
As you know node.js and npm are the engines that work behind the scenes that allow us to operate gulp and keep track of any plugins we decide to use. For Mac and Windows, the installation is quite simple. All you need to do is navigate over to [http://nodejs.org](http://nodejs.org) and click on the big green INSTALL button. Once the installer has finished downloading, run the application and it will install both node.js and npm.

## Before you begin
Download all the packages using following commands before you start
>npm update

>bower update

Build source
>gulp build

Build and Run. Server will be listening at port 8080. Browse _http://localhost:8080_ to view the changes
>gulp

Following gulp plugins are used
* gulp-concat : Concatenates files
* gulp-uglify : Minify files with UglifyJS.
* gulp-myth : Myth - Postprocessor that polyfills CSS
* gulp-jshint : JSHint plugin for gulp
* gulp-imagemin : Minify PNG, JPEG, GIF and SVG images
* gulp-plumber : Gulp-plumber was created as a stop-gap to give us more control over handling errors in our tasks.
* gulp-sourcemaps : will allow us to view the unbuilt versions of our code in the browser so that we can properly debug it.

## License
MIT license
