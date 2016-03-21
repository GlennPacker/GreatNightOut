var gnomodule = angular.module('gnoapp', ['ui.router', 'eventsmod']);

gnomodule.config(function($stateProvider, $urlRouterProvider) {
    $urlRouterProvider.otherwise("/events");

    $stateProvider
        .state('events', {
            url: "/events",
            templateUrl: '/home/events',
            controllerAs: "eventscontroller"
        });
});


