(function () {
    $(document).on('thingsNeeded', function (e, id) {
        $.getJSON('/Component1/GetThingOwners', { id: id }, function (data) {
            $(document).trigger('thingsGotten', data);
        });
    });
    $(document).on('thingOwnersSubmitted', function (e, thingOwners) {
        $.ajax({
            url: "/Component1/UpdateThingOwners",
            data: thingOwners,
            contentType: "application/json; charset=utf-8",
            success: function () {
                $(document).trigger('thingOwnersUpdated');
            },
            type: "POST",
            datatype: "json"
        });
    });
})();