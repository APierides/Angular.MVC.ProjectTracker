ProjectTracker.controller('ProjectController',
    function ProjectController($scope, projectService, $routeParams,$location,$log,$route) {
        if ($routeParams.ProjectID === undefined) {
            $scope.project = {};
            console.log(new Date());
            $scope.project.StartDate = new Date();
            $scope.EditLabel = "Create Project";
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
               $scope.EditLabel = "Save Changes";
        }
        $scope.ReturnHome = function()
        {
            $location.path('/');
        }
        $scope.AddProject = function (project, projectform)
        {
            if (!projectform.$valid)
                return;
            if ($routeParams.ProjectID === undefined)
                projectService.createProject(project);            
            else
                projectService.editProject(project);    
            console.log(project);
            $location.path('/');
            $route.Reload();
        }
    });