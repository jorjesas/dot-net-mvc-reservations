'use strict';
app.factory('reservationsService', ['$http', 'ngAuthSettings', function ($http, ngAuthSettings) {

    var serviceBase = ngAuthSettings.apiServiceBaseUri;

    var reservationsServiceFactory = {};

    var _getReservations = function () {

        return $http.get(serviceBase + 'api/reservations').then(function (results) {
            return results;
        });
    };

    reservationsServiceFactory.getReservations = _getReservations;

    return reservationsServiceFactory;

}]);