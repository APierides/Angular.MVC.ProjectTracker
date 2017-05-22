var ProjectTracker = angular.module('ProjectTracker', ['ngRoute','ngResource']);
ProjectTracker.config(function ($routeProvider) {
    $routeProvider.when('/projects', {
        templateUrl: '/app/templates/ProjectList.html',
        controller: 'ProjectListController'
    })
    $routeProvider.when('/Alerts', {
        templateUrl: '/app/templates/AlertList.html',
        controller: 'AlertListController'
    })
    $routeProvider.when('/EditProject/:ProjectID?', {
        templateUrl: '/app/templates/ProjectEdit.html',
        controller: 'ProjectController'
    })
 
     .otherwise({ redirectTo : '/projects'})
});