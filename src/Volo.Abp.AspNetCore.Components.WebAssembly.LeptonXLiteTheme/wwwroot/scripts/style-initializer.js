(function () {

    if (isRtl()) {
        loadCssFile("_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/css/abp-bundle.rtl.css");
        loadCssFile("_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/css/blazor-bundle.rtl.css");
        loadCssFile("_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/css/bootstrap-dim.rtl.css");
        loadCssFile('_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/css/layout-bundle.rtl.css');
        loadCssFile('_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/css/font-bundle.rtl.css');
    }
    else{
        loadCssFile("_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/css/abp-bundle.css");
        loadCssFile("_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/css/blazor-bundle.css");
        loadCssFile("_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/css/bootstrap-dim.css");
        loadCssFile('_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/css/layout-bundle.css');
        loadCssFile('_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/css/font-bundle.css');
    }

    function loadCssFile(url) {
        var link = document.createElement('link');
        link.type = 'text/css';
        link.rel = 'stylesheet';
        link.href = url;
        document.getElementsByTagName('head')[0].appendChild(link);
    }

    function isRtl() {
        return document.documentElement.getAttribute('dir') === 'rtl';
    }
})();
