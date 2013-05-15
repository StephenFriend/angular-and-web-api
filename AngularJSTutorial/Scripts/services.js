'use strict';

/* Services */

angular.module('phonecatServices', ['ngResource']).
    factory('Phone', function($resource){
          return $resource('api/phones/:phoneId', {}, {
            query: {method:'GET', isArray:true}
  });
});
