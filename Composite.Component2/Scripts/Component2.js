(function () {
    $(document).on('personsNeeded', function (e, ids) {
        $.ajax({
            url: "/Component2/GetPersons",
            data: JSON.stringify({ ids: ids }),
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                $(document).trigger('personsGotten', data);
            },
            type: "POST",
            datatype: "json"
        });

    });
})();