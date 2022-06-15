$(function () {
    var colors = [
        {
            min: 0,
            max: 33,
            fgColor: "#db2360",
            bgColor: "#571435"
        },
        {
            min: 34,
            max: 66,
            fgColor: "#d2d531",
            bgColor: "#423d0f"
        },
        {
            min: 67,
            max: 100,
            fgColor: "#21d07a",
            bgColor: "#204529"
        }
    ];
    //$(".dial")
    //    .each(function () {
    //        var v = parseInt($(this).val()),
    //            c = null;
    //        for (var i = 0; i < colors.length; i++) {
    //            if (colors[i].min <= v && colors[i].max >= v) {
    //                c = colors[i];
    //                break;
    //            }
    //        }
    //        if (c != null) {
    //            $(this).dial({
    //                readOnly: true,
    //                thickness: 0.15,
    //                width: 60,
    //                height: 60,
    //                fontSize: 24,
    //                fgColor: c.fgColor,
    //                bgColor: c.bgColor
    //            });
    //        }
    //    });
});