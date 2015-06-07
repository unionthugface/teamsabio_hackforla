plant.page.getRecom = {};
plant.page.getRecom.get = function (onSuccess, onError) {
    var url = "/plant/recommend/";
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
    plant.page.recomController = plant.ng.getControllerInstance($('#RecomControllerElement'));
}

plant.services.recomfactory = function ($baseService) {
    var aPlantServiceObject = plant.page.getRecom;
    var newService = $.extend(true, {}, aPlantServiceObject, $baseService);
    return newService;
}

plant.page.recomControllerFactory = function ($scope, $baseController, $recomService) {
    var viewModel = this;
    viewModel.item = null;
    viewModel.recomService = $recomService;
    viewModel.receivedItems = _onSuccess;
    viewModel.onResultError = _onResultError;

    $.extend(viewModel, $baseController);

    viewModel.notify = viewModel.recomService.getNotifier($scope);

    render();


    function render() {
        viewModel.recomService.get(viewModel.onResultError,viewModel.receivedItems);
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
    "$recomService",
    ["$baseService"],
    plant.services.recomfactory);

plant.ng.addController(plant.ng.app.module,
    "recomController",
    ['$scope', '$baseController', '$recomService'],
    plant.page.recomControllerFactory);

