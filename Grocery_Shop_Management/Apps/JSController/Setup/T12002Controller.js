
app.controller("T12002Controller", ["$scope", "$filter", "$http", "$window", "T12002Service", "Data", function (scope, $filter, $http, $window, T12002Service, Data) {
    //for instance
    scope.obj = {};
    scope.obj = Data;
    scope.T12002 = {};
    scope.Title = 'Save';

    var getdata = T12002Service.getGridData();
    getdata.then(function (data) {
        scope.dataList = data;
    })
    scope.Save_Click = function (T12002) {      
        var save = T12002Service.SaveData(T12002);
        save.then(function (data) {
            alert(data);
            Clear();
            scope.Title = 'Save';
            var getdata = T12002Service.getGridData();
            getdata.then(function (data) {
                scope.dataList = data;
            })
        })
    }
    function Clear() {
        scope.T12002 = {};
       
    }

    scope.setClickedRow = function (index, Z) {
        //scope.T12001.ddlProductType = {};
        scope.selectedRow = index;
        scope.T12002.T_PRODUCT_TYPE_NAME = Z.T_PRODUCT_TYPE_NAME;
        scope.T12002.T_PRODUCT_TYPE_ID = Z.T_PRODUCT_TYPE_ID;
       // scope.T12001.T_COMPANY_TYPE = Z.T_COMPANY_TYPE;
       // scope.T12001.ddlProductType = { T_COMPANY_TYPE: Z.T_COMPANY_TYPE };
        scope.Title = 'Update';

    }

}]);