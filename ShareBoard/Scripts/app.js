'use strict';

angular.module('shareBoardApp', ['shareBoardApp.services', 'shareBoardApp.directives'])
    .config(['$routeProvider', function($routeProvider) {
        $routeProvider.
            when('/api/values', { templateUrl: '' }).
            otherwise({ redirectTo: '/' });
    }]);