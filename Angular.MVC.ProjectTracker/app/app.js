﻿var ProjectTracker = angular.module('ProjectTracker', ['ngRoute']);
ProjectTracker.config(function ($routeProvider) {
    $routeProvider.when('/projects', {
        templateUrl: '/templates/ProjectList.html',
        controller: 'ProjectListController'
    })
    $routeProvider.when('/Alerts', {
        templateUrl: '/templates/AlertList.html',
        controller: 'AlertListController'
    })
     .otherwise({ redirectTo : '/projects'})
});