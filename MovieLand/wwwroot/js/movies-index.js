$(function () {
    $('.item-action-favorite').on('click', function (e) {
        var id = $(this).parentsUntil('.item-wrapper').parent().attr('id'),
            parent = $(this).parent();

        $.get("/Movies/SetFavorite/" + id, function (result) {
            if (result) {
                parent.toggleClass('favorite');
            }
        });
    });
});