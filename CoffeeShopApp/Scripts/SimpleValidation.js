function validateForm() {
    var firstNameRegex = /^[A-Z]+[A-z]{1,30}$/;
    var lastNameRegex = /^[A-Z]+[A-z]{1,30}$/;
    var EmailRegex = /^([A-z0-9]{5,30})@([A-z]{5,10}).([a-z]{2,3})$/;
    var PhoneRegex = /^\d{3}-\d{3}-\d{4}$/;
    var PasswordRegex = /^[A-z0-9]{5,30}$/;
    var first;
    var last;
    var email;
    var phone;
    var password;

    document.getElementById("errorfirst").innerHTML = "";
    document.getElementById("errorlast").innerHTML = "";
    document.getElementById("errorphone").innerHTML = "";
    document.getElementById("erroremail").innerHTML = "";
    document.getElementById("errorpassword").innerHTML = "";
    //var w = document.getElementById("FirstName").value;
    var w = document.forms["userReg"]["FirstName"].value;
    if (firstNameRegex.test(w)) {
        first = true;
    }
    else {

        first = false;
    }


    var x = document.forms["userReg"]["LastName"].value;
    if (lastNameRegex.test(x)) {
        last = true;
    }
    else {

        last = false;
    }


    var y = document.forms["userReg"]["Email"].value;
    if (EmailRegex.test(y)) {
        email = true;
    }
    else {

        email = false
    }


    var z = document.forms["userReg"]["PhoneNumber"].value;
    if (PhoneRegex.test(z)) {
        phone = true;
    }
    else {

        phone = false;
    }

    var p = document.forms["userReg"]["Password"].value;
    if (PasswordRegex.test(p)) {
        password = true;
    }
    else {

        password = false;
    }


    if (first === true && last === true && email === true && phone === true && password === true) {
        return true;
    }
    else {
        if (first === false) {
            document.getElementById("errorfirst").innerHTML = "First Name Not Valid Try Again";
        }

        if (last === false) {
            document.getElementById("errorlast").innerHTML = "Last Name Not Valid Try Again";
        }

        if (email === false) {
            document.getElementById("erroremail").innerHTML = "Email Not Valid Try Again";
        }

        if (phone === false) {
            document.getElementById("errorphone").innerHTML = "Phone Number Must Be In Format 555-555-5555";
        }

        if (password === false) {
            document.getElementById("errorpassword").innerHTML = "Password Must Be ____";
        }


        return false;
    }

}
var check = function () {
    if (document.getElementById("Password").value === document.getElementById("PasswordConfirm").value) {

        //document.getElementById("PasswordConfirm").style.input[type = password] = "green";
        document.getElementById("message").style.color = "green";
        document.getElementById("message").innerHTML = "Passwords Match";
    }
    else {

        //document.getElementById("Password").style.input[type = password] = "red";
        document.getElementById("message").style.color = "red";
        document.getElementById("message").innerHTML = "Passwords do not match";
    }
}