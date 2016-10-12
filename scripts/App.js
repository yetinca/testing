var myApp = angular.module('myApp', []);
myApp.controller('MainController',function ($scope, $http) {
    $http.get('/GetData')
        .success(function(result){
        $scope.names=result;
        })
    .error(function (data) {
        console.log(data);
    })
    ;
              
             
});