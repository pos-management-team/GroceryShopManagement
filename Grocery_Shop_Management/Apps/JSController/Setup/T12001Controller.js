
app.controller("T12001Controller", ["$scope", "$filter", "$http", "$window", "T12001Service", "Data", function (scope, $filter, $http, $window, T12001Service, Data) {
    //for instance
    scope.obj = {};
    scope.obj = Data;
    scope.T12001 = {};
    scope.Title = 'Save';
    scope.T12001.ComTy = {};
   
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
    var ddlData = T12001Service.getDdlData();
    ddlData.then(function (data) {
        scope.ComTypeDataList = data;
    })
    scope.Save_Click = function (T12001) {
        scope.T12001.T_COMPANY_TYPE = scope.T12001.ddlProductType.T_COMPANY_TYPE;
        var save = T12001Service.SaveData(T12001);
        save.then(function (data) {
            alert(data);
            Clear();
            scope.Title = 'Save';
            var getdata = T12001Service.getGridData();
            getdata.then(function (data) {
                scope.dataList = data;
            })
        })    
    }
    function Clear() {
        scope.T12001 = {};
        scope.T12001.ddlProductType = { T_COMPANY_TYPE: ''};
    }
    scope.setClickedRow = function (index, Z) {
        scope.T12001.ddlProductType = {};
        scope.selectedRow = index;
        scope.T12001.T_COMPANY_ID = Z.T_COMPANY_ID;
        scope.T12001.T_COMPANY_NAME = Z.T_LANG2_NAME;
        scope.T12001.T_COMPANY_TYPE = Z.T_COMPANY_TYPE;       
        scope.T12001.ddlProductType = { T_COMPANY_TYPE: Z.T_COMPANY_TYPE };              
            scope.Title = 'Update';
       
    }


   

}]);