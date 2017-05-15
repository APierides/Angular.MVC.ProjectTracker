ProjectTracker.controller('ProjectController',
    function ProjectController($scope, projectService) {
        $scope.project = {};
        $scope.project.StartDate = new Date();
        $scope.AddProject = function (project, projectform)
        {
            if (!projectform.$valid)
                return;
            console.log(project);

        }
    });