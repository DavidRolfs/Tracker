$(document).ready(function () {
    $('.display-view').click(function () {
        $.ajax({
            type: 'GET',
            dataType: 'html',
            url: '/Associate/Create',
            success: function (result) {
                $('#result4').html(result);
            }
        });
    });
});