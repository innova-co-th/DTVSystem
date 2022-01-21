// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

ShowError = (title, message) => {
    $("#form-modal-Error .modal-title").html(title);
    $("#form-modal-Error .modal-body").html(message);
    $("#form-modal-Error").modal('show');
}

ShowInfomation = (title, message) => {
    $("#form-modal-Infomation .modal-title").html(title);
    $("#form-modal-Infomation .modal-body").html(message);
    $("#form-modal-Infomation").modal('show');
}

ShowWarining = (title, message) => {
    $("#form-modal-Warining .modal-title").html(title);
    $("#form-modal-Warining .modal-body").html(message);
    $("#form-modal-Warining").modal('show');
}

ShowPopup = (title) => {
    $("#form-modal .modal-body").html("");
    $("#form-modal .modal-title").html(title);
    $("#form-modal").modal('show');
}

CallAjaxClick = (url) => {
    $.ajax({
        type: "POST",
        url: url,
        success: function (res) {
            alert(res);
        }
    })
}