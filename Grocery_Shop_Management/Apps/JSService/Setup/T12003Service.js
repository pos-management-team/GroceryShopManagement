
app.service("T12003Service", ["$http", function ($http) {
    var data = {
        getCompanyData: getCompanyData
        //SaveData: SaveData
        // insertData: insertData
    };
    return data;
    function getCompanyData() {
        try {
            var url = '/T12003/GetCompanyData';
           
            return $http({
                url: url,
                method: "POST",               
                data: {},
            }).then(function (results) {
                return results.data;
            }).catch(function (ex) {
                throw ex;
            });
        } catch (ex) {
            throw ex;
        }
    }
    //function SaveData(T12002) {
    //    try {
    //        var url = '/T12002/SaveData';
          
    //        return $http({
    //            url: url,
    //            method: "POST",
               
    //            data: { T02: T12002 }
    //        }).then(function (results) {

    //            return results.data;
    //        }).catch(function (ex) {
    //            throw ex;
    //        });
    //    } catch (ex) {
    //        throw ex;
    //    }
    //}
}]);