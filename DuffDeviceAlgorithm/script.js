// self-executing anonymous function
(function () {
    console.log('self-executing anonymous function');
    registerEvents();

    //register events
    function registerEvents() {
        $('#btnExecuteLoop').click(btnExecuteLoopClick);
    }

    function btnExecuteLoopClick() {
        var iterationcount = parseInt($('#iterationcount').val());
        if (isNaN(iterationcount)) {
            console.warn($('#iterationcount').val() + ' value is not a number');
        }
        else {
            console.log('No of iterations ' + iterationcount);
            var TIMER_NAME_DUFF_DEVICE = 'Duff\'s Device Algorithm';
            var TIMER_NAME_WHILE_LOOP = 'While loop';

            //Duff's Device Algorithm performance
            console.time(TIMER_NAME_DUFF_DEVICE);
            duffsDevice(iterationcount);
            console.timeEnd(TIMER_NAME_DUFF_DEVICE);

            //While loop performance
            console.time(TIMER_NAME_WHILE_LOOP);
            iterateUsingForLoop(iterationcount);
            console.timeEnd(TIMER_NAME_WHILE_LOOP);
        }
    }

    /**
     * 1. Original JS Implementation by Jeff Greenberg 2/2001 - http://home.earthlink.net/~kendrasg/info/js_opt/
     */
    function duffsDevice(iterations) {
        var testVal = 0,
            n = iterations % 8;

        if (n > 0) {
            do {
                testVal++;
            }
            while (--n);  // n must be greater than 0 here
        }

        //Approach #1 : Math.floor(items.length / 8);
        //n = Math.floor(iterations / 8);

        //Approach #2 : multiplication is faster than division in some cases and `XOR 0` removes decimal digits
        /* jshint -W016 */
        n = (iterations * 0.125) ^ 0; 

        if (n > 0) {  // if iterations < 8 an infinite loop, added for safety in second printing
            do {
                testVal++;
                testVal++;
                testVal++;
                testVal++;
                testVal++;
                testVal++;
                testVal++;
                testVal++;
            }
            while (--n);  // n must be greater than 0 here also
        }
    }

    function iterateUsingForLoop(iterations) {
        var testVal = 0;
        do {
            testVal++;
        }
        while (--iterations);  // n must be greater than 0 here
    }



})();