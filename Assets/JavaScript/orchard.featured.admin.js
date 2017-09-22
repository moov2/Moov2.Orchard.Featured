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