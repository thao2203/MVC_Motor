var app = angular.module("myApp", []);

app.controller("SpPost", function ($scope, $http) {

    $http({
        method: 'get',
        url: '/SanPham/getsp'
    }).then(function successCallback(res) {
        $scope.listSP = res.data;
        console.log($scope.listSP);
    })
});

app.controller("lspPost", function ($location, $scope, $http) {
    $http({
        method: 'get',
        url: '/SanPham/getdanhmuccon?mlsp=' + $location.search().mlsp
    }).then(function successCallback(res) {

        $scope.listLSP = res.data;//lưu dữ liệu vào biến $scope

        console.log($scope.listLSP);

    })
});

app.controller("lsp", function ($scope, $http) {

    $http({
        method: 'get',
        url: '/LoaiSanPham/getlsp'
    }).then(function successCallback(res) {

        $scope.listLSP = res.data;
        console.log($scope.listLSP);

    })
});


