function validateForm() {
    var firstNameRegex = /^[A-Z]+[A-z]{1,30}$/
    var lastNameRegex = /^[A-Z]+[A-z]{1,30}$/
    var EmailRegex = /^([A-z0-9]{5,30})@([A-z]{5,10}).([a-z]{2,3})$/
    var PhoneRegex = /^\d{3}-\d{3}-\d{4}$/
    var PasswordRegex = /^[A-z0-9]{5,30}$/
    var first;
    var last;
    var email;
    var phone;
    var password;

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
            alert("First Name Not Valid");
        }

        if (last === false) {
            alert("Last Name Not Valid");
        }

        if (email === false) {
            alert("Email Not Valid. Must valid address");
        }

        if (phone === false) {
            alert("Phone must be in format of 555-555-5555");
        }

        if (password === false) {
            alert("Invalid Password");
        }


        return false;
    }

}