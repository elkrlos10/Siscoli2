SiscoliApp.controller('LoginController',
    ['$scope', '$rootScope', '$location', '$cookies', '$cookieStore', '$routeParams', '$sce',
        function ($scope, $rootScope, $location, $cookies, $cookieStore, $routeParams, $sce) {
            $('#headerPrincipal').hide();
            $('.side-navbar').hide();
            $('#Registro').hide();
           

            //$scope.Empresa = {
            //    No
            //}

            $scope.RegistroEmpresa = function () {
                $('#login').hide();
                $('#Registro').show();

            }

            $scope.MostrarLogin = function () {
                $('#login').show();
                $('#Registro').hide();
            }


        }]);