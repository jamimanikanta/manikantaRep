
/// <reference path="https://ajax.googleapis.com/ajax/libs/angularjs/1.0.5/angular.min.js" />
/// <reference path="controller.js" />


var Myapp = angular.module("Mystore", [ngroute]);
Myapp.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.
    when('/', {
        
        templateUrl: 'Home/Index',
        controller: MyController

    }).
    when('Home/store', {
        templateUrl: 'AllHtml/store.html',
        controller: MyController

    }).
    when('/rings/:productSku', {
        templateUrl: 'AllHtml/product.html',
        controller: MyController


    }).when('/cart', {
        templateUrl: 'AllHtml/cart.html',
        controller: MyController


    })
}]);
