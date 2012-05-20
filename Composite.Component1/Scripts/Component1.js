(function () {
    $(document).on('thingsNeeded', function (e, id) {
        $.getJSON('/Component1/GetThingOwners', { id: id }, function (data) {
            $(document).trigger('thingsGotten', data);
        });
    });
})();