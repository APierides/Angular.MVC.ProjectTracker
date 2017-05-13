ProjectTracker.controller('ProjectListController',
    function ProjectListController($scope,$locale) {
        $scope.CheckItsWorking = "It Worked!";
        $scope.ShortDateFormat = $locale.DATETIME_FORMATS.shortDate;
        $scope.projects = [{ startdate: new Date(), title: 'Static Sample', status: 'I', priority: 'H' },
                           { startdate: new Date(), title: 'Static Sample 2', status: 'C', priority: 'M' }];
    });