ProjectTracker.factory('projectService',
    function ($resource)
    {
        
        return {
            getProjects() {
                var projs = $resource('/api/project/')
                return projs.query();
            }
        } 
    })