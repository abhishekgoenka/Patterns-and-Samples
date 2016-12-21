var gulp = require('gulp');
var webserver = require('gulp-webserver');

gulp.task('helloworld', function() {
  gulp.src('.')
    .pipe(webserver({
      host: "127.0.0.1",
      livereload: true,
      directoryListing: false,
      open: true,
      fallback: "helloworld/index.html"
    }));
});

gulp.task('duffdevice', function() {
  gulp.src('.')
    .pipe(webserver({
      host: "127.0.0.1",
      livereload: true,
      directoryListing: false,
      open: true,
      fallback: "DuffDeviceAlgorithm/index.html"
    }));
});


// The default task (called when you run `gulp` from cli) 
//gulp.task('default',['webserver']);