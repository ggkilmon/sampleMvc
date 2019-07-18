angular.module('SoccerApp')
    .factory('dataService', ['$http', function ($http) {
        return {
            getAllPlayers: function () {
                return $http.get('/api/SoccerApi/GetAllPlayers');
            },
            getSinglePlayer: function (id) {
                return $http.get('/api/SoccerApi/GetPlayer/' + id);
            }
        };
    }]);