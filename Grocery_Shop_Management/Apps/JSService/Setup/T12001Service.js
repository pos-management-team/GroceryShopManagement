

app.service("T12001Service", ["$http", function ($http) {
        var data = {
            getGridData: getGridData,
            getDdlData: getDdlData,
            SaveData: SaveData
            // insertData: insertData
        };
        return data;

    function getGridData() {
            try {
                var url = '/T12001/GetGridData';
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
    function getDdlData() {
        try {
            var url = '/T12001/GetDdlData';
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
    function SaveData(T12001) {
        try {
            var url = '/T12001/SaveData';
            var params = {};
            return $http({
                url: url,
                method: "POST",
                //data: params
                data: { T01: T12001}
            }).then(function (results) {

                return results.data;
            }).catch(function (ex) {
                throw ex;
            });
        } catch (ex) {
            throw ex;
        }
    }

    }
]);