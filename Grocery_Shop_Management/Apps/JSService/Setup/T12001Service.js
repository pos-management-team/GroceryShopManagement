

app.service("T12001Service", ["$http", function ($http) {
        var data = {
            getGridData: getGridData
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

    }
]);