ProjectTracker.factory('projectService',
    function ($resource)
    {
        
        return {
            getProjects() {
                var projs = $resource('/api/project/')
                return projs.query();
            },
            getProject(projectID) {
                var projs = $resource('/api/project/:ProjectID', { ProjectID: '@ProjectID' })
                return projs.get({ ProjectID: projectID });
            }
        } 
    })