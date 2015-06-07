plant.page.getPhotos = {};

plant.page.getPhotos.get = function () {
	$.get("/plant/jvquery", null, onSuccess);
	$.get("", null, onSuccess);
}

plant.page.startUp = function () {
	plant.page.idController = plant.ng.getControllerInstance($('#idController'));
	plant.page.handlers.getFirstPhoto();
}


plant.services.idfactory = function ($baseService) {
	var plantServiceObj = plant.page.getPhotos;
	var newService = $.extend(true, plantServiceObj, $baseService)
	return newService;
}


plant.page.idControllerFactory = function ($scope, $baseController, $idService) {
	var viewModel = this;
	viewModel.item = null;
	viewModel.$idService = $idService;
	viewModel.receivedItems = _onSuccess;
	viewModel.onResultError = _onResultError;
	viewModel.decide = _decide;
	viewModel.getOriginal = _getOriginal;
	viewModel.getCompare = _getCompare;

	$.extend(viewModel, $baseController);
	viewModel.notify = viewModel.$idService.getNotifier($scope);

	render();

	function render() {
		viewModel.$idService.getOriginal();
		viewModel.$idService.getCompare();

	}

	function _getCompare(img) {
		viewModel.notify(function () {
			var response,
				plantList = {};
			$.getJSON("/plant/jvquery", function onSuccess(response) {

				plantList = response;
				i = 0;

				localStorage.setItem("Plants", response);
				for (var i; i === response.length; i++) {
					console.log(response.images.key + "," + response.image.value);
				}
			});
		}
				);

	}
	function _getOriginal(img) {
		var imageId;
		viewModel.notify(function () {
			viewModel.$idService.get(imageId, viewModel.receivedItems, viewModel.onResultError);

		})
	};
	function _getComparisons(img) {
		var comparisonList = [];
		viewModel.notify(function () {
			viewModel.$idService.get(imageId, viewModel.receivedItems, viewModel.onResultError);

		})
	};


	function _decide(vote) {
		viewModel.notify(function () {
			//  send thumbs down  to next result
			//$('.mdi-action-thumb-down').click(function () {


			//var data = viewModel.item;
			//if (image != null) {
			//	viewModel.idService.post(data, viewModel.returnHome, viewModel.onResultError);
			//} else {
			//	console.log("didn't have photo to upload");
			//	console.log(data);
			//}
		})
	};

	function _onSuccess(result) {
		viewModel.notify(function () {
			viewModel.item = result.item;
			console.log("Hello");
		});
	}


	function _onResultError(jqXhr, error) {

		console.log("Danger Will Robinson, Danger!!!");
		console.log(error);
	}

}

plant.ng.addService(plant.ng.app.module, "$idService", ["$baseService"], plant.services.idfactory);
plant.ng.addController(plant.ng.app.module, "idController", ["$scope", "$baseController", "$idService"], plant.page.idControllerFactory);