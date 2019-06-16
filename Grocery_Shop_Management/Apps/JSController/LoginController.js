
app.controller("LoginController",
    [
        "$scope", "LoginService", "Data", "$window", "$filter",
        function($scope, LoginService, Data, $window, $filter) { //$location,
            $scope.obj = {};
            $scope.obj = Data;
            $scope.login = function() {
                var d = LoginService.getData($scope.obj.UserId, $scope.obj.PassWord);
                d.then(function(data) {
                    //alert(data);
                    if (data == 1) {
                        window.location.href = "/Menu/Menu";
                    }
                });
            };


        }
    ]);