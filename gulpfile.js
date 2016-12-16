var gulp = require('gulp');
var webserver = require('gulp-webserver');

gulp.task('helloworld', function() {
  gulp.src('.')
    .pipe(webserver({
      livereload: true,
      directoryListing: false,
      open: true,
      fallback: "helloworld/index.html"
    }));
});


// The default task (called when you run `gulp` from cli) 
//gulp.task('default',['webserver']);