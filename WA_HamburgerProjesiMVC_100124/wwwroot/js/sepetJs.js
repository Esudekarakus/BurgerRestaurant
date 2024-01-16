function GetShoppingCard() {
    $.ajax({
        url: "/Home/GetShoppingCard",
        type: "get",
        success: function (response) {
            $("#container").html(response);
        },
        error: function () {
            $("#error").html("<h3>Something went wrong</h3>");
        }
    });

}