const app = angular.module("main", ["ngRoute"]);

app.config(function ($routeProvider) {

    $routeProvider.when("/news/stories", {
        templateUrl: "/Scripts/app/views/Dashboard.html",
        controller: "mainNewsController"
    })

    $routeProvider.when("/news/stories/:storyID", {
        templateUrl: "/Scripts/app/views/StoryPage.html",
        controller: "storyPageController"
    })

    $routeProvider.when("/news/create-story", {
        templateUrl: "/Scripts/app/views/CreateStory.html",
        controller: "createStoryController"
    })

    $routeProvider.otherwise({ redirectTo: "/news/stories" });
})

app.controller("storyPageController", ["$scope", "$routeParams", "$http",
    function ($scope, $routeParams, $http) {
        console.log($routeParams);
        $http({
            method: "GET",
            url: "/api/stories/" + $routeParams.storyID
        }).then(resp => {
            console.log(resp.data);
            $scope.story = resp.data;
        })
    }])

app.controller("mainNewsController", ["$scope", "$http", function ($scope, $http) {
    $scope.charLimit = 5;

    const getLatestStories = () => {
        $http({
            method: "GET",
            url: "/api/stories"
        }).then(resp => {
            console.log(resp.data);
            $scope.stories = resp.data;
        })
    }

    var start = () => {
        $scope.pageTitle = "testing";
        getLatestStories();
    }

    start();
}])