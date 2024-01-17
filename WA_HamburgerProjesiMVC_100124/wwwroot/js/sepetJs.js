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
function DeleteProduct(sid) {
    let product = {
        id: sid
    };
    $.ajax({
        url: "/Home/DeleteProduct",
        type: "post",
        data: { id: sid },

        success: function (response) {
            if (response == "ok") {
                GetShoppingCard();
            }
            else {
                $("#error").html("<h3>Something went wrong</h3>");
            }
        }

    });

}