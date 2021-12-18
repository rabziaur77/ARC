$(document).ready(function () {
    var urllist = ["/home/residential", "/home/comercial", "/home/index","/"];
    let index = urllist.filter(row => row == window.location.pathname.toLowerCase());
    if (index.length > 0) {
        window.setTimeout(showPopup, 10000)
    }
})


function showPopup() {
    if (!$("#formPopup").hasClass("active")) {
        $("#formPopup").addClass("active");
    }
    else {
        $("#formPopup").removeClass("active");
    }
}
function SendMessage() {
    event.preventDefault();
    $("#submitbtn").prop("disabled", true);
    $("#submitbtn").text("Wait...")
    let Body = "Name: " + $("#Name").val() + "<br/>";
    Body += "Mobile Number: " + $("#MobileNumber").val() + "<br/>";
    Body += "EmailID: " + $("#EmailID").val() + "<br/>";
    Body += "Lookingfor: " + $("#lookingfor").val();
    let Model = {
        Body: Body,
        Subject: "Request"
    };
    $.ajax({
        url: "/Home/SendEmail",
        method: "POST",
        contentType: "application/json",
        data: JSON.stringify(Model),
        success: function (Response) {
            console.log(Response);
            $("#submitbtn").removeAttr("disabled");
            $("#submitbtn").text("Submit")
        },
        error: function (Response) {
            console.log(Response);
            $("#submitbtn").removeAttr("disabled");
            $("#submitbtn").text("Submit")
        }
    })
}
function Cancel() {
    var lstElement = ["#Name", "#MobileNumber", "#EmailID", "#lookingfor"];
    for (var i = 0; i < lstElement.length; i++) {
        if ($(lstElement[i]).prop("tagName") == "INPUT") {
            $(lstElement[i]).val("");
        }
        else if ($(lstElement[i]).prop("tagName") == "SELECT") {
            $(lstElement[i]).val($(lstElement[i]).find($("option")).eq(0).val());
        }
    }
}