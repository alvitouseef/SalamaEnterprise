
function dropDownFill(keyDDL, param) {
    var combo = "";
    var rootUrl = "dropDownFiller";
    $.ajax({
        url: rootUrl,
        async: false,
        data: JSON.stringify({ 'key': keyDDL, 'param': param }),
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            $.each(result, function (key, item) {
                if (item[2] != null && item[2] == "Y") {
                    combo += '<option value="' + item[0] + '" selected>' + item[1] + '</option>';
                }
                else {
                    combo += '<option value="' + item[0] + '">' + item[1] + '</option>';
                }
            });
            $('#' + keyDDL).append($(combo));
        },
        error: function (errormessage) {
            if (errormessage.status == "200" || errormessage.status == "306" || errormessage.status == "404" || errormessage.status == "500" || errormessage.status == "0") {
              //  redirectToLogin(errormessage.status, errormessage.responseJSON);
            }
            else {
                alert(errormessage.responseJSON);
            }
        }
    });
}