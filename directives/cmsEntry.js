var dsCms = angular.module('dsCms');

dsCms.directive('contentItem', function(){
        return {
            restrict: 'E',
            replace: true,
            templateUrl: "templates/cmsEntry.html",
            scope: {
                id: "="
            }
        }
    }
)