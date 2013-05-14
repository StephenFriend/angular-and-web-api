'use strict';

/* App Module */

angular.module('phonecat', []).
  config(['$routeProvider', function($routeProvider) {
  $routeProvider.
      when('/phones', {templateUrl: 'AngularPartials/phone-list.html',   controller: PhoneListCtrl}).
      when('/phones/:phoneId', { templateUrl: 'AngularPartials/phone-detail.html', controller: PhoneDetailCtrl }).
      otherwise({redirectTo: '/phones'});
}]);
