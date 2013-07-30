'use strict'

function ShareBoardCtrl($scope, $http) {
    $http.get('/api/values').success(function (data) {
        $scope.phones = data;
    });
}