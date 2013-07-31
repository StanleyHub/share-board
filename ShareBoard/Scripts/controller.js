'use strict'

function ShareBoardCtrl($scope, $http, $log) {
    $scope.postItem = {};
    $scope.postItem.type = 'Hear';
    $scope.types = ['Hear', 'Share', 'Introduce'];

    $scope.save = function () {
        $log.log('saving person');
    };

    $scope.postTypeSelect = function (type) {
        $scope.postItem.type = type;
        if (type == 'Hear') {
            $('.share-title').text("I want to hear to a session about...");
        } else if (type == 'Share') {
            $('.share-title').text("I want to share something about...");
        } else {
            $('.share-title').text("I am...");
        }
        $log.log('test');
    };

    $http.get('/api/post').success(function (data) {
        $scope.phones = data;
    });
}