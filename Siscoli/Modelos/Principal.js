1/// <reference path="Login/Login.js" />
/// <reference path="Login/LoginService.js" />
// script.js


// create the module and name it scotchApp
var SiscoliApp = angular.module('SiscoliApp', ['ngRoute', 'ngCookies']);



// configure our routes
SiscoliApp.config(function ($routeProvider) {
    $routeProvider
    //$locationProvider

    // route for the home page

    .when('/Busqueda', {
        templateUrl: 'Views/Busqueda.html',
        controller: 'BusquedaController'
     })

    .when('/Login', {
        templateUrl: 'Views/Login.html',
        controller: 'LoginController'
    })
    .when('/Lista', {
        templateUrl: 'Views/lista.html',
        controller: 'BusquedaController'
    })
    .when('/dashboard', {
        templateUrl: 'Views/dashboard.html',
        controller: 'BusquedaController'
    })
    .when('/detalle', {
        templateUrl: 'Views/detalle.html',
        controller: 'BusquedaController'
    })

           
    //$locationProvider.html5Mode(true);

})
.run(['$rootScope', '$location', '$cookies', '$cookieStore', '$http', '$templateCache',
    function ($rootScope, $location, $cookies, $cookieStore, $http, $templateCache) {
        $rootScope.$on('$locationChangeStart', function (event, next, current) {
            $rootScope.globals = $cookieStore.get('username');
            $rootScope.proyecto = $cookieStore.get('datosProyecto');

            ////Posición para las alertas
            //alertify.set('notifier', 'position', 'top-right');

            //if ($rootScope.globals != undefined) {

            //    if (!$rootScope.proyecto && $rootScope.InicioProyecto == 0) {
            //        $location.url("/Menu");

            //    } else {

            //        //Para redireccionar de acuerdo al tipo de usuario
            //        if ($rootScope.globals.currentUser.tipousuario == 3) {
            //            $location.url("/Admin");
            //        }

            //        if ($rootScope.proyecto.datos.Etapa < 11 && $location.path() == '/Reporte') {
            //            $location.url("/Menu");

            //        }
            //        if ($rootScope.proyecto.datos.Etapa == 1 && ($location.path() == '/Reporte' || $location.path() == '/Objetivos' || $location.path() == '/Involucrados'
            //            || $location.path() == '/PerfilProyecto' || $location.path() == '/Cronograma' || $location.path() == '/MarcoL')) {

            //            $location.url("/Menu");
            //            return;
            //        }
            //        if ($rootScope.proyecto.datos.Etapa == 2 && ($location.path() == '/Reporte' || $location.path() == '/Objetivos' || $location.path() == '/Involucrados'
            //            || $location.path() == '/PerfilProyecto' || $location.path() == '/Cronograma' || $location.path() == '/MarcoL')) {

            //            $location.url("/Menu");
            //            return;
            //        }
            //        if ($rootScope.proyecto.datos.Etapa == 3 && ($location.path() == '/Reporte' || $location.path() == '/Involucrados'
            //           || $location.path() == '/PerfilProyecto' || $location.path() == '/Cronograma' || $location.path() == '/MarcoL')) {

            //            $location.url("/Menu");
            //            return;
            //        }
            //        if ($rootScope.proyecto.datos.Etapa == 5 && ($location.path() == '/Reporte' || $location.path() == '/PerfilProyecto'
            //            || $location.path() == '/Cronograma' || $location.path() == '/MarcoL')) {
            //            $location.url("/Menu");
            //            return;
            //        }
            //        if ($rootScope.proyecto.datos.Etapa == 6 && ($location.path() == '/Reporte' || $location.path() == '/Cronograma' || $location.path() == '/MarcoL')) {
            //            $location.url("/Menu");
            //            return;
            //        }
            //        if ($rootScope.proyecto.datos.Etapa == 8 && ($location.path() == '/Reporte' || $location.path() == '/MarcoL')) {
            //            $location.url("/Menu");
            //            return;
            //        }
            //        if ($rootScope.proyecto.datos.Etapa == 10 && ($location.path() == '/Reporte')) {
            //            $location.url("/Menu");
            //            return;
            //        }
            //    }

            //} else {
            //    $location.url("/Login");
            //}

        });
    }]);


// crear la directiva "format" para Formatear con punto de miles los inputs.

SiscoliApp.$inject = ['$scope'];

SiscoliApp.directive('format', ['$filter', function ($filter) {
    return {
        require: '?ngModel',
        link: function (scope, elem, attrs, ctrl) {
            if (!ctrl) return;


            ctrl.$formatters.unshift(function (a) {
                return $filter(attrs.format)(ctrl.$modelValue)
            });


            ctrl.$parsers.unshift(function (viewValue) {
                var plainNumber = viewValue.replace(/[^\d|\-+|\.+]/g, '');
                elem.val($filter(attrs.format)(plainNumber));
                return plainNumber;
            });
        }
    };
}]);

//---------------------------------------------------------------------------

// create the controller and inject Angular's $scope
SiscoliApp.controller('PrincipalController',
    ['$scope', '$rootScope', '$http', '$location', '$cookies', '$cookieStore',
    function ($scope, $rootScope, $http, $location, $cookies, $cookieStore) {

        $rootScope.cerrarSesion = function () {
            $cookies.remove("datosProyecto");
            $cookies.remove("username");
            $rootScope.nombreProyecto = "";
            $location.url("/Login");
        }

        //$scope.UsuarioCambiarPass = {
        //    Password: "",
        //    newPass: ""
        //};

        //$scope.AbrirModalCambiarPass = function () {
        //    $("#ModalCambiarPass").modal("show");
        //};

        //$scope.CambiarPass = function () {
        //    LoginService.CambiarPassword($scope.UsuarioCambiarPass, $rootScope.globals.currentUser.id, function (response) {
        //        if (response.success = true) {

        //            bootbox.dialog({
        //                title: "Información",
        //                message: "El cambio de contraseña se realizó con éxito",
        //                buttons: {
        //                    success: {
        //                        label: "Cerrar",
        //                        className: "btn-primary",
        //                    }
        //                }
        //            });
        //        }
        //    })
        //};
    }]);


