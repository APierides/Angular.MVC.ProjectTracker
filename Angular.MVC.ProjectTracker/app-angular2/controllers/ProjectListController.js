ProjectTracker.controller('ProjectListController',
    function ProjectListController($scope,$locale,projectService,$log) {
        $scope.CheckItsWorking = "It Worked!";

        $scope.ShortDateFormat = $locale.DATETIME_FORMATS.mediumDate;
        projectService.getProjects()
            .$promise
            .then(function (response) {
                $scope.projects = response;
            })
            .catch(function (response) {
                $log.error(response);
            });
   

    }); 