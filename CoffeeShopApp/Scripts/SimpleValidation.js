function validateForm() {
    var firstNameRegex = /^[A-Z]+[A-z]{1,30}$/
    var w = document.forms["userReg"]["FirstName"].value;
    if (firstNameRegex.test(x)) {
        alert("First Name Not Valid");
        return false;
    }

    var lastNameRegex = /^[A-Z]+[A-z]{1,30}$/
    var x = document.forms["userReg"]["LastName"].value;
    if (lastNameRegex.test(x)) {
        alert("Last Name Not Valid");
        return false;
    }

    var EmailRegex = /^([A-z0-9]{5,30})@([A-z]{5,10}).([a-z]{2,3})$/
    var y = document.forms["userReg"]["Email"].value;
    if (EmailRegex.test(y)) {
        alert("Email Not Valid. Must valid address");
        return false;
    }

    var PhoneRegex = /^\d{3}-\d{3}-\d{4}$/
    var z = document.forms["userReg"]["PhoneNumber"].value;
    if (PhoneRegex.test(z)) {
        alert("Phone must be in format of 555-555-5555");
        return false;
    }

}