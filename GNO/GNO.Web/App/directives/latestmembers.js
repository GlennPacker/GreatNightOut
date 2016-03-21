var latestmembers = angular.module("latestmembers", []);

latestmembers.directive("latestmembers", [function() {
    return {
        restrict: 'E',
        templateUrl: 'home/latestmembers',
        //scope: {
        //    var: '='
        //},
        link: function(scope) {
            scope.msg = 'hello';
        }

    }
}]);