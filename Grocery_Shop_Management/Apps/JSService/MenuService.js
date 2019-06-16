
app.service("MenuService",["$http", function($http) {
            var data = {
                getfromData: getfromData
                // insertData: insertData
            };
    return data;
    function getfromData() {
            try {
                var url = '/Menu/getfromData';
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