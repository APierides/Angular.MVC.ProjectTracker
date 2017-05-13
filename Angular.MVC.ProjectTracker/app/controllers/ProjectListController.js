ProjectTracker.controller('ProjectListController',
    function ProjectListController($scope) {
        $scope.CheckItsWorking = "It Worked!";
        $scope.projects = [{ startdate: new Date(), title: 'Static Sample', status: 'I', priority: 'H' },
                           { startdate: new Date(), title: 'Static Sample 2', status: 'C', priority: 'M' }];
    });