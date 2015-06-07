/// <reference path="plant.js" />
/// <reference path="/scripts/ng/angular.js" />

plant.ng = {
    app: {
        services: {}
		, controllers: {}
    }
	, exceptions: {}
	, examples: {}
    , defaultDependencies: ["ngAnimate", "ngRoute"]
    , getModuleDependencies: function () {
        if (plant.extraNgDependencies) {
            var newItems = plant.ng.defaultDependencies.concat(plant.extraNgDependencies);
            return newItems;
        }
        return plant.ng.defaultDependencies;
    }
};

plant.ng.app.module = angular.module('plantApp', plant.ng.getModuleDependencies());

plant.ng.app.module.value('$plant', plant);

//#region - base functions and objects -

plant.ng.exceptions.argumentException = function (msg) {
    this.message = msg;
    var err = new Error();


    console.error(msg + "\n" + err.stack);
}

plant.ng.app.services.baseService = function ($win, $loc, $util) {
    /*
        when this function is envoked by Angular, Angular wants an instance of the Service object. 
		
    */

    var getChangeNotifier = function ($scope) {
        /*
        will be called when there is an event outside Angular that has modified
        our data and we need to let Angular know about it.
        */
        var self = this;

        self.scope = $scope;

        return function (fx) {
            self.scope.$apply(fx);//this is the magic right here that cause ng to re-evaluate bindings
        }


    }

    var baseService = {
        $window: $win
        , getNotifier: getChangeNotifier
        , $location: $loc
        , $utils: $util
    };

    return baseService;
}

plant.ng.app.controllers.baseController = function ($doc, $logger, $fri) {
    /*
        this is intended to serve as the base controller
    */

    var _formatDate = function (d) {
        if (typeof d === "object") {
            var curr_date = d.getDate();
            var curr_month = d.getMonth() + 1; //Months are zero based
            var curr_year = d.getFullYear();
            return curr_month + "/" + curr_date + "/" + curr_year;
        } else if (typeof d === "string") {
            return d;
        } else {
            return null;
        }
    }

    var baseController = {
        $document: $doc
		, $log: $logger
        , $plant: $fri
        , formatDate: _formatDate
    };

    return baseController;
}

//#endregion

//#region  - core ng wrapper functions --

plant.ng.getControllerInstance = function (jQueryObj) {///used to grab an instance of a controller bound to an Element
    console.log(jQueryObj);
    return angular.element(jQueryObj[0]).controller();
}

plant.ng.addService = function (ngModule, serviceName, dependencies, factory) {
    /*
    plant.ng.app.module.service(
    '$baseService', 
    ['$window', '$location', '$utils', plant.ng.app.services.baseService]);
    */
    if (!ngModule ||
		!serviceName || !factory ||
		!angular.isFunction(factory)) {
        throw new plant.ng.exceptions.argumentException("Invalid Service Call");
    }

    if (dependencies && !angular.isArray(dependencies)) {
        throw new plant.ng.exceptions.argumentException("Invalid Service Call [dependencies]");
    }
    else if (!dependencies) {
        dependencies = [];
    }

    dependencies.push(factory);

    ngModule.service(serviceName, dependencies);

}

plant.ng.addController = function (ngModule, controllerName, dependencies, factory) {
    if (!ngModule ||
		!controllerName || !factory ||
		!angular.isFunction(factory)) {
        throw new plant.ng.exceptions.argumentException("Invalid Service defined");
    }

    if (dependencies && !angular.isArray(dependencies)) {
        throw new plant.ng.exceptions.argumentException("Invalid Service Call [dependencies]");
    }
    else if (!dependencies) {
        dependencies = [];
    }

    dependencies.push(factory);
    ngModule.controller(controllerName, dependencies);

}

//#endregions


//#region - adding in baseService and baseController

/*
the basic explaination for these three function arguments

name of thing we are creating:'baseService'
array containing the dependancies of the function we will use to create said thing
the last item in this array is invoked to create the object and passed the preceding dependancies.


*/
plant.ng.addService(plant.ng.app.module
					, "$baseService"
					, ['$window', '$location']
					, plant.ng.app.services.baseService);

plant.ng.addService(plant.ng.app.module
					, "$baseController"
					, ['$document', '$log', '$plant']
					, plant.ng.app.controllers.baseController);


//#endregion

//#region - Examples on how to use the core functions

//***************************************************************************************
//------------------------ Examples -------------------------------------
/*
 * 
 *              How to call the .addService and .addController
 * 
 */




plant.ng.examples.exampleServices = function ($baseService) {
    /*
		when this function is envoked by Angular,
		Angular wants an instance of the Service object. here
		we reuse the same instance of the JS object we have above
	*/

    /*
		we are using this as an example to demonstrate we can use our existing
		code with this new pattern.
	*/

    var aplantServiceObject = plant.services.users;
    var newService = $.extend(true, {}, aplantServiceObject, baseService);

    return newService;
}

plant.ng.examples.exampleController = function ($scope, $baseController, $exampleSvc) {

    var vm = this;
    vm.items = null;
    vm.receiveItems = _receiveItems;

    //-- this line to simulate inheritance
    $.extend(true, vm, $baseController);

    //this is a wrapper for our small dependency on $scope
    vm.notify = $exampleSvc.getNotifier($scope);

    function _receiveItems(data) {
        //this receives the data and calls the special
        //notify method that will trigger ng to refresh UI
        vm.notify(function () {
            vm.items = data.items;
        });
    }
}


plant.ng.addService(plant.ng.app.module
					, "$exampleSvc"
					, ['$baseService']
					, plant.ng.examples.exampleServices);

plant.ng.addController(plant.ng.app.module
	, 'controllerName'
	, ['$scope', '$baseController', '$exampleSvc']
	, plant.ng.examples.exampleController
	);


//------------------------ Examples -------------------------------------
//***************************************************************************************


//#endregion
