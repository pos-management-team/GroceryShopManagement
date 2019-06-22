
app.service("T12002Service", ["$http", function ($http) {
    var data = {
        getGridData: getGridData,
        SaveData: SaveData
        // insertData: insertData
    };
    return data;
    function getGridData() {
        try {
            var url = '/T12002/GetGridData';
            var params = {};
            return $http({
                url: url,
                method: "POST",
                //data: params
                data: {}
            }).then(function (results) {

                return results.data;
            }).catch(function (ex) {
                throw ex;
            });
        } catch (ex) {
            throw ex;
        }
    }
    function SaveData(T12002) {
        try {
            var url = '/T12002/SaveData';
            var params = {};
            return $http({
                url: url,
                method: "POST",
                //data: params
                data: { T02: T12002 }
            }).then(function (results) {

                return results.data;
            }).catch(function (ex) {
                throw ex;
            });
        } catch (ex) {
            throw ex;
        }
    }
}]);