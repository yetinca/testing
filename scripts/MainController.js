
var MainController = function ($scope, $http) {
    $http.get("http://localhost:50723/home")
             .success(function (response) {
                 $scope.names = records;
             });
});