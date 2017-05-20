ProjectTracker.factory('projectService',
    function ($resource)
    {
        var projs = $resource('/api/project/:ProjectID', { ProjectID: '@ProjectID' }, null, {
            'update': {
                method: 'PUT'
            }
        });
        
        return {
            getProjects() {             
                return projs.query();
            },
            getProject(projectID) {
               
                return projs.get({ ProjectID: projectID });
            },
        createProject(project) {
         
                return projs.save(project);
            },
        editProject(project) {          
            return projs.update({ ProjectID : project.Id},project);
        }
        } 
    })