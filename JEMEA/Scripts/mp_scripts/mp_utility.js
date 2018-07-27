;
$(document).ready(function () {
    pageLoad();
   


});


function pageLoad() {
   
    AttachPlugin();


};



//===================Utility============================

function AttachPlugin() {
     $('.mp_ctrl_js_dd').each(function () {
         $(this).select2({ width: '100%' });
    });
    };
