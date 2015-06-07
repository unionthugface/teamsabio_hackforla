

plant.page.startUp = function () {
    plant.page.getGarden;
}

plant.page.getGarden = function (onSuccess, onError) {
    var url = "/garden";
    var settings = {
        dataType: JSON,
        type: get,
        data:null,
        success: onSuccess,
        error: onError,
    }
    $.ajax(url, settings);
}

plant.page.onSuccess = function (result) {

}

plant.page.onError = function (error) {

}

plant.services.gardenfactory = function ($baseService) {
    var aPlantServiceObject = plant.page.getGarden;
    var newService = $.extend(true, {}, aPlantServiceObject, $baseService);
    return newService;
}

plant.page.gardenControllerFactory = function ($scope, $baseController, gardenService) {
    var viewModel = this;
    viewModel.item = null;
    viewModel.gardenService = gardenService;
    viewModel.receivedItems = _onSuccess;
    viewModel.onResultError = _onResultError;

    $.extend(viewModel, $baseController);

    viewModel.notify = viewModel.gardenService.getNotifier($scope);

    render();


    function render() {
        viewModel.gardenService(viewModel.receivedItems, viewModel.onResultError);
    }

    function _onSuccess(result) {
        viewModel.notify(function () {
            viewModel.item = result.item;
        });
    }

    function _onResultError(jqXhr, error) {
        console.log("Danger Will Robinson, Danger!!!");
        console.log(error);
    }
}

plant.ng.addService(plant.ng.app.module,
    "gardenService",
    ["$baseService"],
    plant.services.gardenfactory);

plant.ng.addController(plant.ng.app.module,
    "gardenController",
    ['$scope', '$baseController', 'gardenService'],
    plant.page.gardenControllerFactory);

