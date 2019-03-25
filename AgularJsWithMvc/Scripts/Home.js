
app.controller("MyCntrl", function ($scope, $http) {

    $http.get("http://localhost:50666/api/HomeStudent")
.then(function (res) {
    console.log(res);
    $scope.Student = res.data;
});

});