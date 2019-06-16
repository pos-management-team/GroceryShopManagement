
app.service("LoginService",["$http", function($http) {
            var data = {
                getData: getData
               // insertData: insertData
            };
    return data;

        function getData(id,pass) {
            try {
                var url = '/Login/GetData';
                var params = {};
                return $http({
                    url: url,
                    method: "POST",
                    //data: params
                    data: { id:id, pass:pass}
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