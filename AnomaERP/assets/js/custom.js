// Required: jquery, bootbox.js, bootstrap3-typeahead.js

function ErrorAlert(msg) {
    bootbox.alert({
        title: "<span class='text-danger'>Error</span>",
        message: msg,
        closeButton: true,
        buttons: {
            ok: {
                label: 'Close',
                className: 'btn-danger'
            }
        }
    });
}

function WarningAlert(msg) {
    bootbox.alert({
        title: "<span class='text-warning'>Warning</span>",
        message: msg,
        closeButton: true,
        buttons: {
            ok: {
                label: 'Close',
                className: 'btn-warning'
            }
        }
    });
}

function WarningAlertWithFocus(msg, id) {
    bootbox.alert({
        title: "<span class='text-warning'>Warning</span>",
        message: msg,
        closeButton: true,
        buttons: {
            ok: {
                label: 'Close',
                className: 'btn-warning'
            }
        },
        callback: function (result) {
            setTimeout(function () {
                $(id).focus();
                console.log(id);
            }, 10);
        }
    });
}

function InfoAlert(msg) {
    bootbox.alert({
        title: "<span class='text-primary'>Information</span>",
        message: msg,
        closeButton: true,
        buttons: {
            ok: {
                label: 'Close',
                className: 'btn-primary'
            }
        }
    });
}

function SuccessAlert(msg) {
    bootbox.alert({
        title: "<span class='text-success'>Success</span>",
        message: msg,
        closeButton: true,
        buttons: {
            ok: {
                label: 'Close',
                className: 'btn-success'
            }
        }
    });
}

function SuccessAlertReload(msg) {
    bootbox.alert({
        title: "<span class='text-success'>Success</span>",
        message: msg,
        closeButton: true,
        buttons: {
            ok: {
                label: 'Close',
                className: 'btn-success'
            }
        },
        callback: function () {
            window.location.reload(); // Auto Reload current page when close alert dialog
        }
    });
}

function ConfirmDialog(msg, callback) {
    bootbox.confirm({
        title: "Confirmation",
        message: msg,
        buttons: {
            cancel: {
                label: 'Cancel',
                className: 'btn-default'
            },
            confirm: {
                label: 'Confirm',
                className: 'btn-primary'
            }
        },
        callback: function (result) { callback(result); }
    });
}

function cToStr(param) {
    var result = "";
    if (!IsEmptyString(param)) {
        result = param.toString();
    }
    return result;
}

function IsEmptyString(param) {
    if (typeof (param) == "string") {
        param = param.toString().trim();
    }
    return (param === "" || param == null || param == undefined);
}

function IsEmptyObj(param) {
    return (param == null || param == undefined);
}

function RefreshAntiForgeryToken() {
    var dvToken = $("div[name=dvAntiForgeryToken]");
    if (dvToken.length) {
        $.get(dvToken.attr("token-url"), function (data) {
            dvToken.html(data);
        });
    }
}

function GetAntiForgeryToken(parentSelector) {
    var result = "";
    if (parentSelector != "" &&
        parentSelector != null &&
        parentSelector != undefined &&
        $(parentSelector).length) {
        result = $(parentSelector).find('input[name="__RequestVerificationToken"]').val();
    } else {
        result = $('input[name="__RequestVerificationToken"]').val();
    }
    return result;
}

function GetBooleanResult(param) {
    param = (
        (param != null && param != undefined) &&
        (param == true || param.toString().toLowerCase() === "true")
    );
    return param;
}

function GetActiveStatusContents(isActive) {
    isActive = (
        (isActive != null && isActive != undefined) &&
        (isActive == true || isActive.toString().toLowerCase() === "true")
    );
    var result = {};
    if (isActive) {
        result = {
            val: isActive,
            desc: "Active",
            css: "text-green",
            icon: ""
        };
    } else {
        result = {
            val: isActive,
            desc: "Inactive",
            css: "text-grey",
            icon: ""
        };
    }
    return result;
}

String.prototype.paddingLeft = function (paddingValue) {
    return String(paddingValue + this).slice(-paddingValue.length);
};

var InputAutocomplete = function () {
    // Remote result support: { Text: "", Value: "" }
    // Remote parameter: "q"

    var inputObj;
    var targetInputObj;
    var opts;
    var selected = null;
    var originalVal = null;
    var valueAttr = "selected-value";
    var textAttr = "selected-text";
    var initAutocomplete = function () {
        if (inputObj.length) {
            inputObj.attr(valueAttr, "");
            inputObj.typeahead({
                fitToElement: true,
                autoSelect: true,
                selectOnBlur: false,
                source: function (query, process) {
                    return $.getJSON(opts.remoteUrl, { q: query }, function (data) {
                        process(data)
                    })
                },
                displayText: function (item) {
                    return item.Text
                },
                afterSelect: function (item) {
                    this.$element[0].value = item.Text;
                    this.$element.attr(valueAttr, item.Value);
                    this.$element.attr(textAttr, item.Text);

                    setValueToTargetElement(item.Value);
                }
            }).on("blur", function (e) {
                var userText = cToStr($(this).val());
                var elementText = cToStr($(this).attr(textAttr));

                if (userText != elementText) {
                    $(this).val("");
                    $(this).attr(valueAttr, "");
                    $(this).attr(textAttr, "");

                    setValueToTargetElement("");
                }
            });
        }
    };

    var destroyAutocomplete = function () {
        if (inputObj.length) {
            inputObj.typeahead("destroy");
            inputObj.attr(valueAttr, null);
        }
    };

    var setValueToTargetElement = function (value) {
        if (targetInputObj.length) {
            targetInputObj.val(value);
        }
    };

    var getSelectedValue = function () {
        var result = "";
        if (inputObj.length) {
            result = inputObj.attr(valueAttr);
        }
        return result;
    }

    var getSelectedValue = function () {
        var result = "";
        if (inputObj.length) {
            result = inputObj.attr(valueAttr);
        }
        return result;
    }

    return {
        init: function (options) {
            opts = $.extend({
                remoteUrl: options.remoteUrl,
                inputSelector: options.inputSelector,
                targetInputSelector: options.targetInputSelector
            }, options);

            inputObj = $(opts.inputSelector);
            targetInputObj = $(opts.targetInputSelector);

            initAutocomplete();

            return InputAutocomplete;
        },
        destroy: function () {
            destroyAutocomplete();
        },
        getValue: function () {
            return getSelectedValue();
        }
    };
}();

$.PartialDialog = function (url, title, buttons) {
    var dialog;
    var smallSize = "small";
    var largeSize = "large";
    var progressElement = "<div class='text-center'><i class='fas fa-spinner fa-spin'></i></div>";

    var initDialog = function (size) {
        // Init modal Obj
        dialog = bootbox.dialog({
            size: size,
            title: title,
            message: progressElement,
            closeButton: true,
            buttons: buttons
        });

        // Append close dialog function
        dialog.close = function () {
            $(dialog).find("button.bootbox-close-button.close").click();
        }

        // Fixed bug Tabindex
        dialog.on('shown.bs.modal', function () {
            dialog.removeAttr("tabindex");
        });

        // Load & Render html
        loadPartialHtml();

        return dialog;
    }

    var loadPartialHtml = function () {
        var pageHtml = $('<div></div>').load(url);
        dialog.init(function () {
            setTimeout(function () {
                dialog.find('.bootbox-body').html(pageHtml);
            }, 500);
        });
    }

    var smallDialog = function () {
        return initDialog(smallSize);
    }
    var largeDialog = function () {
        return initDialog(largeSize);
    }

    return {
        small: smallDialog,
        large: largeDialog
    }
};

$.PostSecure = function (url, token, data, callback) {
    if (IsEmptyString(url)) {
        if (IsEmptyString(token))
            token = GetAntiForgeryToken();

        data["__RequestVerificationToken"] = token;
        $.post(url, data, function (res) {
            callback(res);
        });
    } else {
        console.log("Invalid request url.");
    }
};

$.fn.serializeObject = function () {
    var o = {};
    var a = this.serializeArray();
    $.each(a, function (i, element) {
        if (o[this.name] !== undefined) {
            if (!o[this.name].push) {
                o[this.name] = [o[this.name]];
            }
            o[this.name].push(this.value || '');
        } else {
            o[this.name] = this.value || '';
        }
    });

    $.each(this, function () {
        var type = $(this).attr("type");
        var isCheckbox = (type == "checkbox");
        var isRadio = (type == "radio");
        if ((isCheckbox || isRadio)) {
            var thisChecked = $(this).prop("checked");

            if (isCheckbox) {
                o[this.name] = thisChecked.toString();
            } else if (isRadio) {
                // Required attribute "value" at radio
                var thisValue = $(this).attr("value");
                o[this.name] = (thisChecked ? thisValue : '');
            }
        }
    });
    return o;
};

$.fn.customDatepicker = function (options) {
    // Support Only Date without time
    // format display:  dd/MM/yyyy
    // format value:    yyyy/MM/dd

    var defaultDisplayFormat = "dd/mm/yyyy";

    var formatDateToServer = function (d) {
        var result = "";
        if (!IsEmptyObj(d) && typeof (d) == "object") {
            var date = d.getDate();
            var month = d.getMonth();
            var year = d.getFullYear();

            result = year + "-" + (month + 1).toString().paddingLeft("00") + "-" + date.toString().paddingLeft("00") + getConcatTime();
        }
        return result;
    }

    var getConcatTime = function () {
        var result = "";

        if (!IsEmptyObj(opts.endWithStartTime) && typeof (opts.endWithStartTime) == "boolean") {
            if (opts.endWithStartTime == true) {
                result = " 00:00:00";
            } else {
                result = " 23:59:59";
            }
        }

        return result;
    }

    var getDatepickerData = function (selector) {
        return $(selector).data("datepicker");
    }

    var opts = $.extend({
        format: options.format,
        endWithStartTime: options.endWithStartTime
    }, options);

    if (IsEmptyString(opts.format))
        opts.format = defaultDisplayFormat;

    if (!$.isFunction(opts.callback))
        opts.callback = function (e) { };

    var _this = $(this);
    _this.datepicker({
        format: opts.format,
        autoclose: true,
        clearBtn: true,
        todayBtn: false,
        todayHighlight: true
    }).on('changeDate', function (e) {
        opts.callback(e);
    });

    return {
        display: function () {
            return _this.val();
        },
        value: function () {
            if (_this.val() == "") {
                return "";
            } else {
                var _dp = getDatepickerData(_this);
                var date = _dp.getDate();
                return formatDateToServer(date);
            }
        },
        obj: function () {
            return getDatepickerData(_this);
        }
    }
};


