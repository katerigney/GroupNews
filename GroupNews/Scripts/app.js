const app = angular.module("main", ["ngRoute"]);

app.config(function ($routeProvider) {

    $routeProvider.when("/news-dashboard", {
        templateUrl: "/Scripts/app/views/Dashboard.html",
        controller: "mainNewsController"
    })

    $routeProvider.when("/story/:storyID", {
        templateUrl: "/Scripts/app/views/StoryPage.html",
        controller: "storyPageController"
    })

    $routeProvider.when("/news-dashboard/create-story", {
        templateUrl: "/Scripts/app/views/CreateStory.html",
        controller: "createStoryController"
    })

    $routeProvider.otherwise({ redirectTo: "/news-dashboard" });
})

app.controller("mainNewsController", ["$scope", "$http", function ($scope, $http) {

    const getEvents = () => {
        let searchURL = "/api/news";
        if ($scope.searchQuery) {
            searchURL = searchURL + "?title=" + $scope.searchQuery
        }
        $http({
            method: "GET",
            url: searchURL
        }).then(resp => {
            console.log(resp.data);
            $scope.events = resp.data;
        })
    }

    $scope.searchForEvent = () => {
        getEvents();
    }

    var start = () => {
        $scope.pageTitle = "PROburg Events Page"
        getEvents();
    }

    start();
}])