'use strict';

/* Controllers */

var app = angular.module('ngproperty.controllers', []);


// Clear browser cache (in development mode)
//
// http://stackoverflow.com/questions/14718826/angularjs-disable-partial-caching-on-dev-machine
app.run(function ($rootScope, $templateCache) {
    $rootScope.$on('$viewContentLoaded', function () {
        $templateCache.removeAll();
    });
});


app.controller('UserListCtrl', ['$scope', 'UsersFactory', 'PropertyFactory', '$location',
    function ($scope, UsersFactory, PropertyFactory, $location) {

        // callback for ng-click 'editUser':
        $scope.editUser = function (userId) {
            $location.path('/user-detail/' + userId);
        };

        // callback for ng-click 'deleteUser':
        $scope.deleteUser = function (userId) {
            PropertyFactory.delete({ id: userId });
            $scope.propertys = UsersFactory.query();
        };

        // callback for ng-click 'createUser':
        $scope.createNewProperty = function () {
            $location.path('/user-creation');
        };

        $scope.propertys = UsersFactory.query();
    }]);

app.controller('UserDetailCtrl', ['$scope', '$routeParams', 'PropertyFactory', '$location',
    function ($scope, $routeParams, PropertyFactory, $location) {

        // callback for ng-click 'updateUser':
        $scope.updateUser = function () {
            PropertyFactory.update($scope.property);
            $location.path('/user-list');
        };

        // callback for ng-click 'cancel':
        $scope.cancel = function () {
            $location.path('/user-list');
        };

        $scope.property = PropertyFactory.show({ id: $routeParams.id });
    }]);

app.controller('addPropertyCtrl', ['$scope', 'PropertyFactory', '$location',
    function ($scope, PropertyFactory, $location) {

        // callback for ng-click 'createNewProperty':
        $scope.createNewProperty = function () {
            UsersFactory.create($scope.property);
            $location.path('/add.html');
        }
    }]);

app.controller('AgentsCtrl', function ($scope,$state,popupService,$window,AgentsFactory){

    // callback for ng-click 'createNewProperty':
    $scope.agents = AgentsFactory.query();    
    }
}]);
