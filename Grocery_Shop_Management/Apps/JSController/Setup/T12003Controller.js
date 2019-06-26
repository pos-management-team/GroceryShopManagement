
app.controller("T12003Controller", ["$scope", "T12003Service", "Data", "$window", "$filter",
    function ($scope, T12003Service, Data, $window, $filter) { //$location,
        $scope.obj = {};
        $scope.obj = Data;
        $scope.Title = 'Save';
        var from = T12003Service.getCompanyData();
        from.then(function (data) {
            $scope.CompanyList = data;
        });

        //$scope.OK_Click = function () {
        //    var d = LoginService.getData($scope.obj.UserId, $scope.obj.PassWord);
        //    d.then(function (data) {
        //        alert(data);
        //    });
        //};


    }
]);