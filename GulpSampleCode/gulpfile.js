// Load Node Modules/Plugins
var gulp = require('gulp');
var concat = require('gulp-concat');
var uglify = require('gulp-uglify');
var myth = require('gulp-myth');
var uglify = require('gulp-uglify');
var jshint = require('gulp-jshint');
var imagemin = require('gulp-imagemin');
//var clean = require('gulp-clean');

// delete dist folder
// todo : not working
//gulp.task('clean', function() {
//    clean('dist');
//});
// Process Styles
gulp.task('styles', function() {
    return gulp.src('css/*.css')
        .pipe(concat('all.css'))
        .pipe(myth())
        .pipe(gulp.dest('dist/'));
});

// Process Scripts
gulp.task('scripts', function() {
    return gulp.src('js/*.js')
        .pipe(jshint())
        .pipe(jshint.reporter('default'))
        .pipe(concat('all.js'))
        .pipe(uglify())
        .pipe(gulp.dest('dist/'));
});

// Process Images
gulp.task('images', function() {
    return gulp.src('img/*')
        .pipe(imagemin())
        .pipe(gulp.dest('dist/img'));
});

// Build
gulp.task('build', ['styles', 'scripts', 'images']);

// Watch Files For Changes
gulp.task('watch', function() {
    gulp.watch(['css/*.css', 'js/*.js', 'img/*.'], ['build']);
});

// Default Task
gulp.task('default', ['styles', 'scripts', 'images', 'watch']);