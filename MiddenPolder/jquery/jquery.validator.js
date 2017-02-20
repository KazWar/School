// Simple no-frills form validator.
//
// Author:
//         Tomasz Waraksa, Dublin, 2014
// License:
//         (c) MIT
//
// Specify the following options:
//      container:          selector pointing to the container where fields to validate are present
//      validClass:         CSS class to apply to the inputs when value is OK
//      invalidClass:       CSS class to apply to the inputs when value is not OK
//
function Validator(options) {

    validator = {
        // Options
        options: options,

        // Validation rules
        rules: [],


        // Creates field validation rules input fields within the specified container
        apply: function (container) {
            validator.rules = [];

            // find all inputs tagged with data-validate attribute
            var inputs = $('input[data-validate]', $(container));
            inputs.each(function (index, element) {
                var input = $(element);
                // store validation rule for the input
                var rule = {
                    input: input,
                    message: input.attr('data-validate-message'),       // custom message to display, when value is invalid
                    required: input.is('[data-validate-required]'),     // field is required
                    maxlength: input.attr('data-validate-maxlength'),   // maximal allowed length of the value
                    datatype: input.attr('data-validate-type'),         // value must be of specified type, now only number is supported
                    minvalue: input.attr('data-validate-min'),          // minimal allowed value (applies only when data type set to number)
                    maxvalue: input.attr('data-validate-max'),          // maximal allowed value (applies only when data type set to number)
                    allowed: input.attr('data-validate-allowed'),       // allowed value or values (comma-separated)
                    regex: input.attr('data-validate-regex'),           // regular expression to match
                    uppercase: input.is('[data-validate-uppercase]'),   // converts the input to uppercase
                    lowercase: input.is('[data-validate-lowercase]'),   // converts the input to lowercase
                    isValid: true,
                };
                // if input has associated error message, find the placeholder for displaying it
                if (rule.message) {
                    rule.messageContainer = $("*[data-validate-message-for='" + input.attr('id') + "']", $(container));
                }
                validator.rules.push(rule);
                // trigger the rule when user leaves the input,
                // to immediately check whether the input was valid.
                input.blur(function () {
                    validator.checkRule(rule);
                });
            });
        },


        // Executes all validation rules, returns true if all are OK.
        // Marks the associated inputs as invalid if rule checks failed.
        validate: function () {
            // check all rules
            var isValid = true;
            for (var i = 0; i < validator.rules.length; i++) {
                // get rule, assume it's OK, get field value
                var rule = validator.rules[i];
                if (!validator.checkRule(rule))
                    isValid = false;
            }

            return isValid;
        },


        // Executes the specified validation rule, returns its result,
        // Marks the associated inputs as invalid if rule check failed
        checkRule: function (rule) {
            rule.isValid = true;
            var value = rule.input.val().trim();

            // lower/uppercase?
            if (rule.lowercase) {
                value = value.toLowerCase();
                rule.input.val(value);
            }
            if (rule.uppercase) {
                value = value.toUpperCase();
                rule.input.val(value);
            }

            // field required?
            if (rule.required) {
                rule.isValid = value != '';
            }

            // field length is OK?
            if (rule.maxlength) {
                rule.isValid = value.length <= parseInt(rule.maxlength);
            }

            // data type specified?
            if (rule.isValid && rule.datatype) {
                if (rule.datatype == 'number') {
                    rule.isValid = !isNaN(value);
                    if (rule.isValid) {
                        // range is OK?
                        if (rule.minvalue) {
                            rule.isValid = parseFloat(value) >= parseFloat(rule.minvalue);
                        }
                        if (rule.isValid && rule.maxvalue) {
                            rule.isValid = parseFloat(value) <= parseFloat(rule.maxvalue);
                        }
                    }
                }
            }

            // allowed values specified?
            if (rule.isValid && rule.allowed) {
                // check if input is equal to one of the allowed values
                var allowedValues = rule.allowed.split(',');
                rule.isValid = false;
                for (var k = 0; k < allowedValues.length; k++)
                    if (value == allowedValues[k]) {
                        rule.isValid = true;
                        break;
                    }
            }

            // regular expression specified?
            if (rule.isValid && rule.regex) {
                var re = RegExp(rule.regex);
                rule.isValid = re.test(value);
            }

            // mark the control as valid/invalid
            if (rule.isValid)
                validator.markAsValid(rule);
            else
                validator.markAsInvalid(rule);

            return rule.isValid;
        },


        // Marks the specified element as valid
        markAsValid: function (rule) {
            if (validator.options.validClass)
                rule.input.addClass(validator.options.validClass);
            if (validator.options.invalidClass)
                rule.input.removeClass(validator.options.invalidClass);
            // hide error message 
            if (rule.message) {
                if (rule.messageContainer.length > 0)
                    rule.messageContainer.html('');
                else
                    rule.input.attr('title', '');
            }
        },

        // Displays the error message associated with the input
        markAsInvalid: function (rule) {
            if (validator.options.validClass)
                rule.input.removeClass(validator.options.validClass);
            if (validator.options.invalidClass)
                rule.input.addClass(validator.options.invalidClass);
            // display error message if specified
            if (rule.message) {
                if (rule.messageContainer.length > 0)
                    rule.messageContainer.html(rule.message);
                else
                    rule.input.attr('title', rule.message);
            }
        },


    };

    // If container specified in options, immediately apply the validator to it.
    if (validator.options.container)
        validator.apply(validator.options.container);

    return validator;
}
