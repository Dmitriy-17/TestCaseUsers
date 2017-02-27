'use strict';

myApp.controller('UserController', function ($scope, $http, $location, $window, $mdDialog) {

    $scope.dialogUrl = '/Scripts/views/dialog.html';
    $scope.homeUrl = '/';
    $scope.removeUrl = '/User/Remove/';
    $scope.createUrl = '/User/Create/';
    $scope.updateUrl = '/User/Update/';
    $scope.getUrl = '/User/Get/';

    $scope.goToHomePage = function () {
        $window.location.href = $scope.homeUrl;
    };
    $scope.editDialog = function (ev, user) {
        var confirm = $mdDialog.prompt({
            controller: 'DialogController',
            templateUrl: $scope.dialogUrl,
            parent: angular.element(document.body),
            targetEvent: ev,
            resolve: {
                addNew: function () { return false; },
                userToEdit: function () { return user; }
            },
            clickOutsideToClose: true
        });
        $mdDialog.show(confirm).then(function (user) {
            $http.post($scope.updateUrl, user);
            $scope.goToHomePage();
        });
    };
    $scope.addDialog = function (ev) {
        var confirm = $mdDialog.prompt({
            controller: 'DialogController',
            templateUrl: $scope.dialogUrl,
            parent: angular.element(document.body),
            targetEvent: ev,
            resolve: {
                addNew: function () { return true; },
                userToEdit: function () { return null; }
            },
            clickOutsideToClose: true
        });
        $mdDialog.show(confirm).then(function (user) {
            $http.post($scope.createUrl, user);
            $scope.goToHomePage();
        });
    };
    $scope.remove = function (id) {
        $http({ method: 'GET', url: $scope.removeUrl, params: { 'id': id } }).then($scope.goToHomePage());
    }
    $scope.update = function (id, ev) {
        $http({ method: 'GET', url: $scope.getUrl, params: { 'id': id } }).then(function (user) {
            $scope.editDialog(ev, user.data)
        });
    };
    $scope.cancel = function () {
        $mdDialog.cancel();
    };

});