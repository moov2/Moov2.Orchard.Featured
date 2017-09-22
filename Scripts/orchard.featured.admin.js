/*
** NOTE: This file is generated by Gulp and should not be edited directly!
** Any changes made directly to this file will be overwritten next time its asset group is processed by Gulp.
*/

(function () {
    var $enabledCheckbox = $('.js-featured-enable-field input[type=checkbox]'),
        $weightField = $('.js-featured-weight-field');

    /**
     * Updates the visibility of the weight field.
     */
    var updateWeightVisibility = function () {
        if ($enabledCheckbox.is(':checked')) {
            $weightField.css('display', 'block');
            return;
        }

        $weightField.css('display', 'none');
    };

    updateWeightVisibility();
    $enabledCheckbox.on('change', updateWeightVisibility);
})();
//# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIm9yY2hhcmQuZmVhdHVyZWQuYWRtaW4uanMiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBLEFBTEE7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0EiLCJmaWxlIjoib3JjaGFyZC5mZWF0dXJlZC5hZG1pbi5qcyIsInNvdXJjZXNDb250ZW50IjpbIihmdW5jdGlvbiAoKSB7XHJcbiAgICB2YXIgJGVuYWJsZWRDaGVja2JveCA9ICQoJy5qcy1mZWF0dXJlZC1lbmFibGUtZmllbGQgaW5wdXRbdHlwZT1jaGVja2JveF0nKSxcclxuICAgICAgICAkd2VpZ2h0RmllbGQgPSAkKCcuanMtZmVhdHVyZWQtd2VpZ2h0LWZpZWxkJyk7XHJcblxyXG4gICAgLyoqXHJcbiAgICAgKiBVcGRhdGVzIHRoZSB2aXNpYmlsaXR5IG9mIHRoZSB3ZWlnaHQgZmllbGQuXHJcbiAgICAgKi9cclxuICAgIHZhciB1cGRhdGVXZWlnaHRWaXNpYmlsaXR5ID0gZnVuY3Rpb24gKCkge1xyXG4gICAgICAgIGlmICgkZW5hYmxlZENoZWNrYm94LmlzKCc6Y2hlY2tlZCcpKSB7XHJcbiAgICAgICAgICAgICR3ZWlnaHRGaWVsZC5jc3MoJ2Rpc3BsYXknLCAnYmxvY2snKTtcclxuICAgICAgICAgICAgcmV0dXJuO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgJHdlaWdodEZpZWxkLmNzcygnZGlzcGxheScsICdub25lJyk7XHJcbiAgICB9O1xyXG5cclxuICAgIHVwZGF0ZVdlaWdodFZpc2liaWxpdHkoKTtcclxuICAgICRlbmFibGVkQ2hlY2tib3gub24oJ2NoYW5nZScsIHVwZGF0ZVdlaWdodFZpc2liaWxpdHkpO1xyXG59KSgpOyJdLCJzb3VyY2VSb290IjoiL3NvdXJjZS8ifQ==