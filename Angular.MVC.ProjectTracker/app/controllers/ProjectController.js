ProjectTracker.controller('ProjectController',
    function ProjectController($scope, projectService, $routeParams,$log) {
        if ($routeParams.ProjectID === undefined) {
            $scope.project = {};
            console.log(new Date());
            $scope.project.StartDate = new Date();
        }
        else
        {
            projectService.getProject($routeParams.ProjectID)
                .$promise
                .then(function (response) {
                    $scope.project = response;
                    console.log(new Date($scope.project.StartDate));
                    $scope.project.StartDate = new Date($scope.project.StartDate);
                    $scope.project.DueDate = new Date($scope.project.DueDate);
                 //   $scope.project.StartDate = new Date();
                })
                .catch(function (response) {
                    $log.error(response);
                });
           
        }
        $scope.AddProject = function (project, projectform)
        {
            if (!projectform.$valid)
                return;
            console.log(project);

        }
    });