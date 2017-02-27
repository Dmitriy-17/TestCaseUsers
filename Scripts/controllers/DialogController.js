'use strict';

myApp.controller('DialogController', function ($scope, $http, $mdDialog, addNew, userToEdit) {
    $scope.user = userToEdit;
    $scope.addNew = addNew;
    $scope.listText = {
        "edit": { "title": 'Редактировать пользователя', "button": 'Редактировать' },
        "add": { "title": 'Добавить пользователя', "button": 'Добавить' }
    }
    $scope.text = addNew ? $scope.listText.add : $scope.listText.edit;

    $scope.add = function (user) {
        $mdDialog.hide(user);
    };

    $scope.update = function (user) {
        $mdDialog.hide(user);
    };
   
    $scope.cancel = function () {
        $mdDialog.cancel();
    };
});