function valid1()
{
    var x = document.forms.form.txtEmail.value;
    var y = x.indexOf("@");
    var z = x.lastIndexOf(".");
    if ((y + 2) >= x.length || y < 1 || z < (y + 2))
    {
        alert("Enter valid mail");
        return false;
    }
}
    
    