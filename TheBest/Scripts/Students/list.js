var Tab = function(){
    $(".menu .item").tab();

    var RetrievStudentsData = function () {
        self.LoadData = function () {
            $.ajax({
                method: "POST",
                url: "students-data",           
            })
                .done(function (students) {
                             
                });
        }   
    };

};

var VoteCalculator = (function () {



    return {

    };
})();

$(function () {
    var page = $("#student-list");
    if (!page)
        return;

    var viewModel = new StudentViewModel();
    viewModel.LoadData();
    ko.applyBindings(viewModel);
    Tab();
});