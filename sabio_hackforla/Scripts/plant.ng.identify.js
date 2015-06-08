
plant.page.startUp = function () {
	plant.page.idController = plant.ng.getControllerInstance($('#idController'));
//	plant.page.getPhotos.get();
}

plant.services.idfactory = function ($baseService) {
	var plantServiceObj = plant.page.getPhotos;
	var newService = $.extend(true, plantServiceObj, $baseService)
	return newService;
}

plant.page.idControllerFactory = function ($scope, $baseController, $idService) {
	var viewModel = this;
	viewModel.item = null;
	viewModel.idService = $idService;
	viewModel.onSuccess = _onSuccess;
	viewModel.onResultError = _onResultError;
	
	viewModel.getPlants = _getPlants;

	$.extend(viewModel, $baseController);
	viewModel.notify = viewModel.idService.getNotifier($scope);

	render();

	function render() {
	    //viewModel.getCompare();
	    viewModel.getPlants('http://sabiohack4la.azurewebsites.net/img/yellow_hibiscus.jpg', onSuccess, onResultError);
	}


	function _getPlants(imageUrl, onSuccess, onError) {

	    var imagePath;

	    var url = "/plant/jvquery/" ;
	    var settings = {
	        dataType: JSON,
	        type: "get",
	        data: {
	            imagePath: imageUrl
	        },
	        success: onSuccess,
	        error: onSuccess,
	    }
	    $.ajax(url, settings);
	}

	//function _getCompare(originalUrl) {
	//	viewModel.notify(function () {
	//		var response,
	//			plantList = {};

	//		viewModel.$scope.getJSON("/plant/jvquery" + originalUrl, function onSuccess(response) {

	//			plantList = response;
	//			i = 0;

	//			localStorage.setItem("Plants", response);
	//			for (var i; i === response.length; i++) {
	//				console.log(response.images.key + "," + response.image.value);
	//			}
	//		});
	//	}
	//			);

	//}


	function _onSuccess(result) {

	    //viewModel.item = JSON.parse(result.responseText);
	    viewModel.item = result.item;
		    console.log("Hello");
		    console.log(viewModel.item);
	}

	function _onResultError(jqXhr, error) {

		console.log("Danger Will Robinson, Danger!!!");
		console.log(error);
	}

}

plant.ng.addService(plant.ng.app.module, "$idService", ["$baseService"], plant.services.idfactory);
plant.ng.addController(plant.ng.app.module, "idController", ["$scope", "$baseController", "$idService"], plant.page.idControllerFactory);