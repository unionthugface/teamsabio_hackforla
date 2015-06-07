var plant = {
    layout: {}
    , page: {
        handlers: {}
        , startUp: null
    }
    , services: {}
};


plant.layout.startUp = function () {

    console.debug("plant.layout.startUp");

    //this does a null check on plantapp.page.startUp
    if (plant.page.startUp) {
        console.debug("plant.page.startUp");
        plant.page.startUp();
    }
};
$(document).ready(plant.layout.startUp);