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
function DeleteMenu(sid) {
    let menu = {
        id: sid
    };
    $.ajax({
        url: "/Home/DeleteMenu",
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

function ChangeQuantity(productId, changeAmount) {
    // İlgili ürünün quantity değerini güncelle
    var quantityElement = $("#quantity_" + productId);
    var currentQuantity = parseInt(quantityElement.text());
    var newQuantity = currentQuantity + changeAmount;

    if (newQuantity >= 0) {
        // AJAX isteği gönder
        $.ajax({
            url: "/Home/ChangeQuantity",
            type: "post",
            data: { productId: productId, newQuantity: newQuantity },

            success: function (response) {
                if (response == "ok") {
                    // AJAX başarılı ise sayfayı güncelle
                    quantityElement.text(newQuantity);
                    UpdateTotalAmount();
                } else {
                    // Hata durumunda kullanıcıya bilgi ver
                    console.error("Quantity change failed.");
                }
            }
        });
    }
}

function UpdateTotalAmount() {
    // Tüm ürünlerin fiyatlarını ve adetlerini toplamak için döngü
    var totalAmount = 0;
    $(".product-row").each(function () {
        var quantity = parseInt($(this).find(".quantity").text());
        var price = parseFloat($(this).find(".price").text());
        totalAmount += quantity * price;
    });

    // Toplam ücreti ekrana yazdır
    $("#totalAmount").text(totalAmount.toFixed(2));
}