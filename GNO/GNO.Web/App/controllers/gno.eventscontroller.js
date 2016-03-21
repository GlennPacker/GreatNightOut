var eventsmod = angular.module('eventsmod', ['latestmembers']);

eventsmod.controller('eventscontroller', ['$scope', function ($scope) {
    $scope.greeting = 'Hello from events controller';
}]);