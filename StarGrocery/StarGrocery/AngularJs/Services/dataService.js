function dataService($http, $rootScope, $q) {
    return {
        GetCategories: GetCategories,
        
    };

    function GetCategories() {
        var request = $http.post(
            '/CallBackMethods/userDataCallback.aspx/GetCategories', { }
        );
        return request.then(handleSuccess, handleError);
    }
    


    function handleError(response) {

        if (
            !angular.isObject(response.data.d) ||
            !response.data.message
        ) {

            return ($q.reject("An unknown error occurred."));

        }

        return ($q.reject(response.data.message));

    }
    function handleSuccess(response) {
        return (response.data.d);
    }

};