function ShareBoardCtrl($scope, $http, $log) {
    $scope.postItem = {};
    $scope.postItem.type = 'Hear';
    $scope.types = ['Hear', 'Share', 'Introduce'];

    $scope.save = function () {
        $log.log('saving person');
        $http.post('/api/post', $scope.postItem).success(function (data) {
            var item = { Content: $scope.postItem.content, Type: 0 };
            $scope.postItems.push(angular.copy(item));
        });
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
        $scope.postItems = data;
    });
}