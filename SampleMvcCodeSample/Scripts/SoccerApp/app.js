var app = angular.module('SoccerApp', []);

app.controller('SoccerController', function ($scope, $http, dataService) {
    $scope.isDetail = false;
    dataService.getAllPlayers().then(function (response) { $scope.PlayerList = response.data; });

    $scope.getPlayerData = function (player) {
        if (player != null && player.Id > 0) {
            dataService.getSinglePlayer(player.Id).then(function (response) {
                $scope.PlayerDetail = response.data;
                $scope.isDetail = true;
            });
        } else {
            $scope.isDetail = false;
        }
    };
});