plant.page.getGarden = {};
plant.page.getGarden.get = function (onSuccess, onError) {
    var url = "/plant/garden/";
    var settings = {
        dataType: JSON,
        type: "get",
        data: null,
        success: onSuccess,
        error: onError,
    }
    $.ajax(url, settings);
}

plant.page.startUp = function () {
    plant.page.gardenController = plant.ng.getControllerInstance($('#PlantControllerElement'));
}

plant.services.gardenfactory = function ($baseService) {
    var aPlantServiceObject = plant.page.getGarden;
    var newService = $.extend(true, {}, aPlantServiceObject, $baseService);
    return newService;
}

plant.page.gardenControllerFactory = function ($scope, $baseController, $gardenService) {
    var viewModel = this;
    viewModel.item = null;
    viewModel.gardenService = $gardenService;
    viewModel.receivedItems = _onSuccess;
    viewModel.onResultError = _onResultError;

    $.extend(viewModel, $baseController);

    viewModel.notify = viewModel.gardenService.getNotifier($scope);

    render();


    function render() {
        viewModel.gardenService.get(viewModel.receivedItems, viewModel.onResultError);
    }

    function _onSuccess(result) {
        viewModel.notify(function () {
            viewModel.item = JSON.parse(result.responseText);
        });
    }

    function _onResultError(result) {
        viewModel.notify(function () {
            viewModel.item = JSON.parse(result.responseText);
        });
    }
}

plant.ng.addService(plant.ng.app.module,
    "$gardenService",
    ["$baseService"],
    plant.services.gardenfactory);

plant.ng.addController(plant.ng.app.module,
    "gardenController",
    ['$scope', '$baseController', '$gardenService'],
    plant.page.gardenControllerFactory);

