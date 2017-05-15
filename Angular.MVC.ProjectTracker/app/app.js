var ProjectTracker = angular.module('ProjectTracker', ['ngRoute','ngResource']);
ProjectTracker.config(function ($routeProvider) {
    $routeProvider.when('/projects', {
        templateUrl: '/templates/ProjectList.html',
        controller: 'ProjectListController'
    })
    $routeProvider.when('/Alerts', {
        templateUrl: '/templates/AlertList.html',
        controller: 'AlertListController'
    })
    $routeProvider.when('/AddProject', {
        templateUrl: '/templates/ProjectEdit.html',
        controller: 'ProjectController'
    })
     .otherwise({ redirectTo : '/projects'})
});