'use strict';
app.controller('reservationsController', ['$scope', 'reservationsService', function ($scope, reservationsService) {

    $scope.reservations = [];

    reservationsService.getReservations().then(function (results) {

        $scope.reservations = results.data;

    }, function (error) {
        //alert(error.data.message);
    });

}]);