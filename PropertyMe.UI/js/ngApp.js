angular.module('prop365App', ['ngResource', 'prop365App.services', 'prop365App.controllers']);
//angular.module('prop365App').config(function ($stateProvider, $httpProvider) {
//    $stateProvider.state('agents', {
//        url: '/agents',
//        templateUrl: '../index-agency.html',
//        controller: 'agentController'
//        //}).state('viewMovie', {
//        //    url: '/movies/:id/view',
//        //    templateUrl: 'partials/movie-view.html',
//        //    controller: 'MovieViewController'
//        //}).state('newMovie', {
//        //    url: '/movies/new',
//        //    templateUrl: 'partials/movie-add.html',
//        //    controller: 'MovieCreateController'
//        //}).state('editMovie', {
//        //    url: '/movies/:id/edit',
//        //    templateUrl: 'partials/movie-edit.html',
//        //    controller: 'MovieEditController'
//    });
//    //}).run(function ($state) {
//    //    $state.go('movies');
//});

angular.module('prop365App.services', [])
    .factory('agentFactory', function ($resource) {
        var odataUrl = "http://localhost:8154/Property365Service.svc/Agents/";
        return $resource("", {},
        {
            'getAll': { method: "GET", url: "http://localhost:8154/Property365Service.svc/Agents?$expand=User/Role&$format=json" },
            'save': { method: "POST", url: odataUrl },
            'update': { method: 'PUT', params: { key: "@key" }, url: odataUrl + "(:key)" },
            'query': { method: 'GET', params: { key: "@key" }, url: odataUrl + "(:key)" },
            'remove': { method: 'DELETE', params: { key: "@key" }, url: odataUrl + "(:key)" }
        });
        //return $resource('http://localhost:7673/Property365.Service.svc/:id', {}, {
        //    query: { method: 'GET', params: {}, isArray: false}
        //});
    });

angular.module('prop365App.controllers', []).controller('agentController', function ($scope, agentFactory) {
    $scope.templateList = [{ id: 0, name: 'Select Role' }, { id: 1, name: 'Admin' }, { id: 2, name: 'Agency' }, { id: 3, name: 'Agent' }, { id: 4, name: 'User' }]
    $scope.selectedRole = 'Select Role';
    $scope.setValue = function (list) {
        //$scope.agent.user.RoleID = list.id;
        $scope.selectedRole = list.name;
    }
    new agentFactory().$getAll()
            .then(function (data) {
                $scope.agents = data.value;
            });

    $scope.deleteAgent = function (agent) {
        if (popupService.showPopup('Really delete this agent?')) {
            agent.$delete(function () {
                $window.location.href = '';
            });
        }
    }

    //}).controller('MovieViewController',function($scope,$stateParams,Movie){
    //$scope.agent = agentFactory.get({ id: agent.id });

    //}).controller('MovieCreateController',function($scope,$state,$stateParams,Movie){

    //$scope.agent = new agentFactory();

    $scope.addAgent = function () {
        $scope.agent.$save(function () {
            //$state.go('movies');
        });
    }

    //}).controller('MovieEditController',function($scope,$state,$stateParams,Movie){

    //$scope.updateAgent = function () {
    //    $scope.agent.$update(function () {
    //        //$state.go('movies');
    //    });
    //};

    //$scope.loadAgent = function () {
    //    //$scope.agent = agentFactory.get({ id: $stateParams.id });
    //};

    //$scope.loadAgent();
});