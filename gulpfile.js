var gulp = require('gulp');
var args = require('yargs').argv;
var config = require('./gulp.config')();
var $ = require('gulp-load-plugins')({lazy: true});

gulp.task('helloworld', function() {
  gulp.src('.')
    .pipe($.webserver({
      host: '127.0.0.1',
      livereload: true,
      directoryListing: false,
      open: true,
      fallback: 'helloworld/index.html'
    }));
});

gulp.task('duffdevice', function() {
  gulp.src('.')
    .pipe($.webserver({
      host: '127.0.0.1',
      livereload: true,
      directoryListing: false,
      open: true,
      fallback: 'DuffDeviceAlgorithm/index.html'
    }));
});


/**
 * Analyze source code
 */
gulp.task('vet', function() {
  log('Analyzing source with JSHint and JSCS');
  return gulp
  .src(config.alljs)
  .pipe($.if(args.verbose, $.print()))
  .pipe($.jscs())
  .pipe($.jshint())
  .pipe($.jshint.reporter('jshint-stylish', {verbose: true}))
  .pipe($.jshint.reporter('fail'));
});


/**
 * Log a message or series of messages using chalk's blue color.
 * Can pass in a string, object or array.
 */
function log(msg) {
    if (typeof(msg) === 'object') {
        for (var item in msg) {
            if (msg.hasOwnProperty(item)) {
                $.util.log($.util.colors.blue(msg[item]));
            }
        }
    } else {
        $.util.log($.util.colors.blue(msg));
    }
}