
function ListDesserts() {
    $.ajax({
        url: "/Home/GetDesserts",
        type: "get",
        success: function (response) {
            $("#mainContainer").html(response);
            $("#error").html("");
        },
        error: function () {
            $("#error").html("<h2>Something went wrong</h3>");
        }
    });

}