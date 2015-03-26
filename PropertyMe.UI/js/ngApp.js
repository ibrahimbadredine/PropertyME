
angular.module('prop365App', ['ngResource', 'prop365App.services', 'prop365App.controllers']);

angular.module('prop365App.services', [])
    .factory('userFactory', function ($resource) {
        return $resource("http://localhost:62640/Property365Service/Users/:userId");
        //    , {},
        //{
        //    getAll: { method: "GET", url: "http://localhost:8154/Property365Service.svc/Users?$format=json" },
        //    save: { method: "POST", url: "http://localhost:8154/Property365Service.svc/Users" },
        //});
    });

angular.module('prop365App.controllers', []).controller('userController', function ($scope, userFactory) {

    $scope.users = userFactory.query();
    //userFactory = new userFactory();

    //userFactory.$getAll()
    //        .then(function (data) {
    //            $scope.users = data.value;
    //        });

    //$scope.deleteUser = function (user) {
    //    if (popupService.showPopup('Really delete this user?')) {
    //        user.$delete(function () {
    //        });
    //    }
    //}

    $scope.addUser = function () {
        userFactory.save($scope.user);
    }
});