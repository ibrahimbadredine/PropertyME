'use strict';

/* Services */

/*
 http://docs.angularjs.org/api/ngResource.$resource

 Default ngResources are defined as

 'get':    {method:'GET'},
 'save':   {method:'POST'},
 'query':  {method:'GET', isArray:true},
 'remove': {method:'DELETE'},
 'delete': {method:'DELETE'}

 */

var propertyServices = angular.module('ngproperty.services', ['ngResource']);
propertyServices.factory('PropertyFactory', function ($resource) {
    return $resource('/Property365.Service.svc', {}, {
        query: { method: 'GET', isArray: true },
        create: { method: 'POST' }
    })
});

var agentServices = angular.module('ngagency.services', ['ngResource']);
agentServices.factory('AgentsFactory', function ($resource) {
    return $resource('http://localhost:7673/Property365.Service.svc', {}, {
        query: { method: 'GET', isArray: true },
        create: { method: 'POST' }
    })
});
//agentServices.factory('AgentFactory', function ($resource) {
//    return $resource('/AddAgent', {}, {
//        show: { method: 'GET' },
//        update: { method: 'PUT', params: { id: '@id' } },
//        delete: { method: 'DELETE', params: { id: '@id' } }
//    })
//});