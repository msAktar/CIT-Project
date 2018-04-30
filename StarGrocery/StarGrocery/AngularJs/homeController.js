
var homeController = function (dataService, $scope) {
    var vm = this;
    dataService.GetCategories().then(function (data) {
       // debugger;
        vm.Categories = data;
    });

    //vm.Categories = [
    //    { id: 1, name: 'Rice', url: 'assets/img/rsz_2india-gate-super-basmati-rice-5kg.jpg' },
    //    { id: 2, name: 'Flour', img: 'assets/img/ashirvaad_atta.jpg' },
    //    { id: 3, name: 'Oil', img: 'assets/img/fresh-vegetable.jpg' }
    //];

    vm.Slitems = [
        { id: 1, name: 'item1', img: 'assets/img/rsz_2india-gate-super-basmati-rice-5kg.jpg' },
        { id: 2, name: 'item2', img: 'assets/img/ashirvaad_atta.jpg' },
        { id: 3, name: 'item3', img: 'assets/img/fresh-vegetable.jpg' }
    ];

    vm.update = function () {
        vm.Slitems = [
            { id: 1, name: 'item1b', img: 'assets/img/rsz_2india-gate-super-basmati-rice-5kg.jpg' },
            { id: 2, name: 'item2b', img: 'assets/img/ashirvaad_atta.jpg'},
            { id: 3, name: 'item3b', img: 'assets/img/fresh-vegetable.jpg' }
        ]
    };
}