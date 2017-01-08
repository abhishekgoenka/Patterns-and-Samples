//As you create or expand your gulpfile, you may reach a point where you would
//prefer to separate your confguration into an additional file
module.exports = function() {
    'use strict';
    var config = {
        css: 'css/*.css',
        js: 'js/*.js'
    }
    return config;
};