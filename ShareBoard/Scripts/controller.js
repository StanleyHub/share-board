function ShareBoardCtrl($scope, $http, $rootScope, uploadManager) {
    $scope.postItem = {};
    $scope.postItem.type = 'Hear';
    $scope.types = ['Hear', 'Share', 'Introduce'];
    $scope.files = [];
    $scope.percentage = 0;
    $scope.imagePath = '';

    $scope.save = function () {
        $http.post('/api/post', $scope.postItem).success(function () {
            var postType = 0;
            for (var i = 0; i < $scope.types.length; i++) {
                if ($scope.types[i] == $scope.postItem.type) {
                    postType = i;
                }
            }
            var item = { Content: $scope.postItem.content, Type: postType, ImagePath: $scope.ImagePath };
            $scope.postItems.push(angular.copy(item));

            $scope.ImagePath = '';
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
    };

    $http.get('/api/post').success(function (data) {
        $scope.postItems = data;
    });

    $scope.upload = function () {
        uploadManager.upload();
        $scope.files = [];
    };

    $rootScope.$on('fileAdded', function (e, call) {
        $scope.files.push(call);
        $scope.imagePath = "/uploads/" + call;
        $scope.$apply();
    });

    $rootScope.$on('uploadProgress', function (e, call) {
        $scope.percentage = call;
        $scope.$apply();
    });

    $rootScope.$on('displayImg', function (e, call) {
        $scope.imagePath = "/uploads/" + call;
        $scope.$apply();
    });
}


