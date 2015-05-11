

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
        var f = document.getElementById('photo1').files[0];
        if (f)
            r.readAsDataURL(f);

        $scope.user.Picture.Image = f;

        userFactory.update($scope.user);
        $scope.user = null;
    }

    $("#photo1").fileinput({
        //uploadUrl: 'http://localhost:62640/Property365Service/Pictures/',
        allowedFileExtensions: ['jpg', 'png', 'gif'],
        overwriteInitial: false,
        maxFileSize: 1000,
        maxFilesCount: 1,
        uploadAsync: false,
        allowedFileTypes: ['image']
    });

    r = new FileReader();
    r.onloadend = function () {
        var img = new Image();
        img.src = r.result;
    }

});


/**
 * Converts an image to
 * a base64 string.
 * 
 * If you want to use the 
 * outputFormat or quality param
 * I strongly recommend you read the docs 
 * @ mozilla for `canvas.toDataURL()`
 * 
 * @param 	{String} 	url
 * @param 	{Function}	callback
 * @param 	{String}	[outputFormat='image/png']
 * @param 	{Float}   	[quality=0.0 to 1.0]
 * @url 	https://gist.github.com/HaNdTriX/7704632/
 * @docs 	https://developer.mozilla.org/en-US/docs/Web/API/HTMLCanvasElement#Methods
 * @author 	HaNdTriX
 * @example
 * 			imgToDataURL('http://goo.gl/AOxHAL', function(err, base64Img){
 * 				console.log('IMAGE:',base64Img);
 * 			})
 */
function imgToDataURL(url, callback, outputFormat, quality) {
    var canvas = document.createElement('CANVAS'),
		ctx = canvas.getContext('2d'),
		img = new Image();
    img.crossOrigin = 'Anonymous';
    img.onload = function () {
        var dataURL;
        canvas.height = img.height;
        canvas.width = img.width;
        try {
            ctx.drawImage(img, 0, 0);
            dataURL = canvas.toDataURL(outputFormat, quality);
            callback(null, dataURL);
        } catch (e) {
            callback(e, null);
        }
        canvas = img = null;
    };
    img.onerror = function () {
        callback(new Error('Could not load image'), null);
    };
    img.src = url;
}