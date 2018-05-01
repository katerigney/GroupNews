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

app.controller("createStoryController", ["$scope", "$routeParams", "$http", "$window", function ($scope, $routeParams, $http, $window) {

    $scope.submitStory = () => {
        console.log("Submit button was clicked!")
        $http({
            method: "POST",
            url: "/api/createStory",
            data: {
                Headline: $scope.headlineInput,
                BodyContent: $scope.bodyContentInput,
                UserName: $scope.authorInput,
                Category: $scope.categoryInput
            }
        }).then(resp => {
            console.log(resp.data);
            $scope.story = resp.data;

            //open story page template with newStory ID
            ID = resp.data.ID;
            $window.location.href = "news/stories/" + ID;

            //$scope.redirectTo("/stories/:ID");
        })
    }
}])

app.controller("mainNewsController", ["$scope", "$http", function ($scope, $http) {
 
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