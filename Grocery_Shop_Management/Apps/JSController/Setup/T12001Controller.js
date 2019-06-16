
app.controller("T12001Controller", ["$scope", "$filter", "$http", "$window", "T12001Service", "Data", function (scope, $filter, $http, $window, T12001Service, Data) {
    //for instance
    scope.obj = {};
    scope.obj = Data;
    //scope.Save_Click = function(obj) {
    //    var save = TestService.saveData(obj);
    //    save.then(function() {
    //        alert('Save successfully');
    //    });
    //};
    var getdata = T12001Service.getGridData();
    getdata.then(function (data) {
        scope.dataList = data;
    })

}]);