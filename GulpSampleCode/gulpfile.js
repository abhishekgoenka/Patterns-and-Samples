// Load Node Modules/Plugins
var gulp = require('gulp');
var concat = require('gulp-concat');
var uglify = require('gulp-uglify');
var myth = require('gulp-myth');
var jshint = require('gulp-jshint');
var imagemin = require('gulp-imagemin');
var connect = require('connect');
var serve = require('serve-static');
var browsersync = require('browser-sync');
var plumber = require('gulp-plumber');
var beeper = require('beeper');
var del = require('del');
var config = require('./gulp.config')();
var runSequence = require('run-sequence');
var sourcemaps = require('gulp-sourcemaps')

// delete dist folder
gulp.task('build-clean', function(cb) {
    return del('dist', cb);
});
// Process Styles
gulp.task('build-styles', function() {
    return gulp.src(config.css)
        .pipe(plumber({
            errorHandler: onError
        }))
        .pipe(concat('all.css'))
        .pipe(myth())
        .pipe(gulp.dest('dist/'));
});

// Process Scripts
gulp.task('build-scripts', function() {
    return gulp.src(config.js)
        .pipe(plumber({
            errorHandler: onError
        }))
        .pipe(sourcemaps.init())
        .pipe(jshint())
        .pipe(jshint.reporter('default'))
        .pipe(concat('all.js'))
        .pipe(uglify())
        .pipe(sourcemaps.write())
        .pipe(gulp.dest('dist/'));
});

// Process Images
gulp.task('build-images', function() {
    return gulp.src('img/*')
        .pipe(imagemin())
        .pipe(gulp.dest('dist/img'));
});

// full Build
gulp.task('build', function(callback) {
    return runSequence('build-clean', ['build-scripts', 'build-styles', 'build-images'], callback);
});

// Watch Files For Changes
gulp.task('watch', function() {
    gulp.watch(['css/*.css', 'js/*.js', 'img/*.'], ['build']);
});

// spin a web server
gulp.task('server', function() {
    return connect().use(serve(__dirname))
        .listen(8080)
        .on('listening', function() {
            console.log('Server Running: View at http://localhost:8080');
        });
});

// browsersync : BrowserSync will additionally sync up every action that
//               is performed on your pages across any device on your local network.
gulp.task('browsersync', function(cb) {
    return browsersync({
        server: {
            baseDir: './'
        }
    }, cb);
});

// Default Task
//  By default, Gulp tasks run parallelly. We need a way to run them sequentially. 
//  There is no easy way to do so using plugin. This is fixed in V4.0 
//  This is intended to be a temporary solution until the release of gulp 4.0 which has support for defining task dependencies in series or in parallel.
gulp.task('default', function(callback) {
    return runSequence('build', ['watch', 'server', ], callback);
});

// Error Helper
function onError(err) {
    beeper();
    console.log(err);
}