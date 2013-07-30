'use strict'

angular.module('shareBoard')
    .config([$routeProvider, function ($routeProvider) {
        $routeProvider.
            when('/api/values', {templateUrl: ''}).
            otherwise({ redirectTo: '/' });
    } ]);