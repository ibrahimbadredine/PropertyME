app.controller("controllerList", function ($scope, $http) {
    $http.get("http://localhost:7673/Property365.Service.svc/GetPropertyList/")
    .success(function (response) { $scope.properties = response; });
})

app.controller("controllerList", function ($scope, $http) {
    $http.get("http://localhost:7673/Property365.Service.svc/GetPropertyList/")
    .success(function (response) { $scope.properties = response; });
})