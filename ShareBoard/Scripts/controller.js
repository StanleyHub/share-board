function ShareBoardCtrl($scope, $http, $log) {
    $scope.postItem = {};
    $scope.postItem.type = 'Hear';
    $scope.types = ['Hear', 'Share', 'Introduce'];

    $scope.save = function () {
        $log.log('saving person');
        $http.post('/api/post', $scope.postItem).success(function () {
            var postType = 0;
            for (var i = 0; i < $scope.types.length; i++) {
                if ($scope.types[i] == $scope.postItem.type) {
                    postType = i;
                }
            }
            var item = { Content: $scope.postItem.content, Type: postType };
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

function FileUploadCtrl($scope, $rootScope, uploadManager) {
    $scope.files = [];
    $scope.percentage = 0;

    $scope.upload = function () {
        uploadManager.upload();
        $scope.files = [];
    };

    $rootScope.$on('fileAdded', function (e, call) {
        $scope.files.push(call);
        $scope.$apply();
    });

    $rootScope.$on('uploadProgress', function (e, call) {
        $scope.percentage = call;
        $scope.$apply();
    });    
}



