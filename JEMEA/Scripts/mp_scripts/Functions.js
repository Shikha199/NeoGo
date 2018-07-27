var timer = null;
       

function ConfirmYesno(a) {
    var ans = confirm(a);
    if (ans) {
        return 1;
    }
    else {
        return 0;
    }
}

//Trial
//function CallConfirmBx(ctrl) {
//   // alert(ctrl);
//    //  this.preventDefault();
    
//    var ctrlmsg = $(ctrl).attr('data-Msg');
//    // alert(ctrlmsg);

    
//    $('#mp_confirmbx_btnYes').attr('data-btnid', $(ctrl).attr('id'));
//    $("#mp_confirmbx_btnYes").click(function () {
       
//        //$($(this).attr('data-btnid')).click();
//       // __doPostBack('btnsave', "");
//        theForm.__EVENTTARGET.value = 'btnsave';
//        theForm.__EVENTARGUMENT.value = '';
//        theForm.submit();
//       // $('#mp_confirmbx').modal('hide');
       
//    });
//    $('#mp_ctrl_js_cbmsg').html('');
//    $('#mp_ctrl_js_cbmsg').html(ctrlmsg);
//    $('#mp_confirmbx').modal('show');
//    return false;
//}


 
function ConfirmYesno(a) {
    var ans = confirm(a);
    if (ans) {
        return 1;
    }
    else {
        return 0;
    }
}


function roundOff(value, precision) {
    result = 0;
    if (!isNaN(value) && !isNaN(precision)) {
        value = parseFloat(value);
        precision = parseInt(precision);
        var whole = Math.round(value * Math.pow(10, precision)) / Math.pow(10, precision);
        whole = whole.toString();
        if (precision > 0) {
            var str = whole.indexOf(".");
            var zeropad = 0;
            if (str == -1) {
                zeropad = "."
                for (r = 1; r <= precision; r++) {
                    zeropad = zeropad + "0";
                }
                return whole + "" + zeropad;
            }
            else {
                var dotoprt = whole.length - str;
                if (dotoprt == precision + 1) {
                }
                else {
                    padd = precision - dotoprt;
                    for (k = 1; k <= padd; k++) {
                        zeropad = zeropad + "0";
                    }
                    whole = whole.concat(zeropad);
                }
            }
        }
        result = whole;
    }
    else {
        // alert('INVALID NUMERIC VALUE / PRECISION.');
        return 0;
    }
    return result;
}

//function noRightClick() {
//    if (event.srcElement.tagName != "INPUT") {
//        if (event.button == 2) {
//            alert("Right click disabled.");
//            return false;
//        }
//    }
//}
//document.onmousedown = noRightClick

function noBack() {
    if (event.srcElement.tagName != "INPUT" && event.srcElement.tagName != "TEXTAREA") {
        if (event.keyCode == 8 || event.keyCode == 93) {
            self.event.returnValue = false;
        }
    }
    if (event.srcElement.tagName == "INPUT") {
        if (event.keyCode == 222 || event.keyCode == 34) {
            self.event.returnValue = false;
        }
    }
    if (event.srcElement.tagName == "TEXTAREA") {
        if (event.keyCode == 13 || event.keyCode == 222 || event.keyCode == 34) {
            self.event.returnValue = false;
        }
    }
}
document.onkeydown = noBack
var strSeperator = "-";
// If you are using any Java validation on the back side you will want to use the / because
// Java date validations do not recognize the dash as a valid date separator.
var vDateType = 3; // Global value for type of date format
//                1 = mm/dd/yyyy
//                2 = yyyy/dd/mm  (Unable to do date check at this time)
//                3 = dd/mm/yyyy

var vYearType = 4; //Set to 2 or 4 for number of digits in the year for Netscape
var vYearLength = 2; // Set to 4 if you want to force the user to enter 4 digits for the year before validating.
var err = 0; // Set the error code to a default of zero
if (navigator.appName == "Netscape") {
    if (navigator.appVersion < "5") {
        isNav4 = true;
        isNav5 = false;
    }
    else
        if (navigator.appVersion > "4") {
            isNav4 = false;
            isNav5 = true;
        }
}
else {
    isIE4 = true;
}
function CheckDateCharacters(txt) {
    if (event.keyCode < 48 || event.keyCode > 57) {
        if (event.keyCode != 47) {
            event.returnValue = false;
        }
    }
    if (event.returnValue != false) {
        if (txt.value.length == 2 || txt.value.length == 5) {
            txt.value = txt.value + "/"
        }
    }
};



function ValidateDate(txt) {
    var dt = txt.value.split("-")
    if (txt.value == "")
        return false;
    else {
        if (dt.length != 3) {
            alert("Invalid Date");
            txt.focus();
        }
        else {
            var vDateValueCheck = dt[0] + strSeperator + dt[1] + strSeperator + dt[2];
            if (dt[2].length == 2) {   //Turn a two digit year into a 4 digit year
                var mToday = new Date();
                //If the year is greater than 30 years from now use 19, otherwise use 20
                var checkYear = mToday.getFullYear() + 30;
                var mCheckYear = '20' + dt[2];
                if (mCheckYear >= checkYear)
                    mYear = '19' + dt[2];
                else
                    mYear = '20' + dt[2];
                vDateValueCheck = dt[0] + strSeperator + dt[1] + strSeperator + mYear;
            }
            txt.value = vDateValueCheck

            if (!MPDateValidCheck(dt)) {
                alert("Invalid Date\nFormat - DD-MM-YYYY");
                txt.select();
                txt.focus();
                return false;
            }
        }
    }
}

var varMonthNames = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December",
                     "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"];

function MPDateValidCheck(dt) {
    var intday;
    var intMonth;
    var intYear;

    intday = parseInt(dt[0], 10);
    if (isNaN(intday)) {
        err = 2;
        return false;
    }
   // alert(parseInt(GetMonthNo(dt[1]), 10));
    intMonth = parseInt(GetMonthNo(dt[1]), 10);
    if (isNaN(intMonth)) {
        err = 3;
        return false;
    }

    //for (var i = 0; i < varMonthNames.length; i++) {
    //    if (varMonthNames[i] == dt[1]) {
    //        intMonth = 1;
    //    } else {
    //        intMonth = 0;
    //    }
    //    if (intMonth == 0) {
    //        err = 3;
    //        return false;
    //    }

        intYear = parseInt(dt[2], 10);
        if (isNaN(intYear)) {
            err = 4;
            return false;
        }
        if (intMonth > 12 || intMonth < 1) {
            err = 5;
            return false;
        }
        if ((intMonth == 1 || intMonth == 3 || intMonth == 5 || intMonth == 7 || intMonth == 8 || intMonth == 10 || intMonth == 12) && (intday > 31 || intday < 1)) {
            err = 6;
            return false;
        }
        if ((intMonth == 4 || intMonth == 6 || intMonth == 9 || intMonth == 11) && (intday > 30 || intday < 1)) {
            err = 7;
            return false;
        }
        if (intMonth == 2) {
            if (intday < 1) {
                err = 8;
                return false;
            }
            if (LeapYear(intYear) == true) {
                if (intday > 29) {
                    err = 9;
                    return false;
                }
            }
            else {
                if (intday > 28) {
                    err = 10;
                    return false;
                }
            }
        }
        return true;
    }


function GetMonthNo(MonthName) {
    var result = 0;
    switch (MonthName) {
        case 'Jan':
            result = 1;
            break;
        case 'Feb':
            result = 2;
            break;
        case 'Mar':
            result = 3;
            break;
        case 'Apr':
            result = 4;
            break;
        case 'May':
            result = 5;
            break;
        case 'Jun':
            result = 6;
            break;
        case 'Jul':
            result = 7;
            break;
        case 'Aug':
            result = 8;
            break;
        case 'Sep':
            result = 9;
            break;
        case 'Oct':
            result = 10;
            break;
        case 'Nov':
            result = 11;
            break;
        case 'Dec':
            result = 12;
            break;
    }
   
    return result;
}