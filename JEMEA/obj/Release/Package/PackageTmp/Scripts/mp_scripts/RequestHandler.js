function applicationLoadHandler() {
    /// <summary>Raised after all scripts have been loaded and the objects in the application have been created and initialized.</summary>
};
function applicationUnloadHandler() {

    Sys.Application.dispose();
};
function beginRequestHandler() {
    /// <summary>Raised after an asynchronous postback is finished and control has been returned to the browser.</summary>
    $('#m_core_mp_apploading_bx').modal({
        backdrop: false
    })
    $('#m_core_mp_apploading_bx').modal('show');


};
function endRequestHandler() {
    /// <summary>Raised before processing of an asynchronous postback starts and the postback request is sent to the server.</summary>
    // Set status bar text if any was passed through the hidden field on the form
    $('#m_core_mp_apploading_bx').modal('hide');
};


//if (typeof (Sys) !== "undefined") Sys.Application.notifyScriptLoaded();