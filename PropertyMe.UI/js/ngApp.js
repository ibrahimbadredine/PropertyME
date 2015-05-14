

angular.module('prop365App', ['ngResource', 'prop365App.services', 'prop365App.controllers']);

angular.module('prop365App.services', [])
    .factory('userFactory', function ($resource) {
        return $resource('http://localhost:62640/Property365Service/Users/:userId', { userId: '@id' }, {
            update: {
                method: 'PUT', params: { userId: 'id' }
            }
        }
    )
    });

angular.module('prop365App.controllers', []).controller('userController', function ($scope, userFactory) {

    $scope.editMode = true;

    $scope.users = userFactory.query();
    //userFactory = new userFactory();

    $scope.deleteUser = function (uId) {
        userFactory.delete({ userId: uId }, function () {
            $scope.editMode = false;
        });
    }

    $scope.addUser = function () {
        userFactory.save($scope.user);
        $scope.user = null;
    }

    $scope.editUser = function (uId) {
        $scope.user = userFactory.get({ userId: uId }, function () {
            $scope.editMode = false;
        });
    }

    $scope.cancelUser = function () {
        $scope.user = null;
        $scope.editMode = true;
    }

    $scope.updateUser = function () {

        //    if (image) {
            //        $scope.user.Picture = {};
            //        $scope.user.Picture.ID = 12;
            //        $scope.user.Picture.Image = JSON.stringify(image);
        //}


        userFactory.update($scope.user);
        $scope.user = null;
    }

    var imageInput = $("#photo1");
    imageInput.fileinput({
        uploadUrl: 'http://localhost:62640/Property365Service/Pictures/',
        allowedFileExtensions: ['jpg', 'png', 'gif'],
        overwriteInitial: false,
        maxFileSize: 1000,
        maxFilesCount: 1,
        uploadAsync: false,
        allowedFileTypes: ['image']
    });

    var image;
    //imageInput.change(function (event) {
    //    var reader = new FileReader();
    //    reader.onload = function (event) {
    //        image = event.target.result;
    //    };
    //    reader.readAsDataURL(image);
    //});

    //imageInput.change(function(event) {
    //    $.each(event.target.files, function (index, file) {
    //        var reader = new FileReader();
    //        reader.onload = function (event) {
    //            object = { 
    //        };
    //            object.filename = file.name;
    //            image = event.target.result;
    //            //files.push(object);
    //        };
    //        reader.readAsDataURL(file);
    //    });
    //});
});
