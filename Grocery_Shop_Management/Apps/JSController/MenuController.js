
app.controller("MenuController",["$scope", "MenuService", "Data", "$window", "$filter",
        function ($scope, MenuService, Data, $window, $filter) { //$location,
            $scope.obj = {};
            $scope.obj = Data;
            var from = MenuService.getfromData();
            from.then(function(data) {
                $scope.fromList = data;
            });
            //$scope.OK_Click = function () {
            //    var d = LoginService.getData($scope.obj.UserId, $scope.obj.PassWord);
            //    d.then(function (data) {
            //        alert(data);
            //    });
            //};


        }
    ]);