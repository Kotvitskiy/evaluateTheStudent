function Student(id, name, rate, group, imageUrl, socialUrl, description){
    var self = this;

    self.Id = id;
    self.Name = name;
    self.Rate = ko.observable(rate);
    self.Group = group;
    self.ImageUrl = imageUrl;
    self.SocialUrl = socialUrl;
    self.Description = description;


    self.Rate.subscribe(function (newValue) {
        debugger;
        self.updateRate(newValue);
        debugger;
        $(event.toElement).parents().eq(2).hide();
        $(event.toElement).parents().eq(3).find(".thanks").fadeIn();
    }, event);

    self.updateRate = function (updatedRate) {
        if(updatedRate != undefined)
        $.ajax({
            method: "POST",
            url: "rate",
            data: {student : self},
            success: function () {
            }
        });
    }
}

function StudentViewModel() {
    
    var self = this;

    self.students = ko.observableArray();

    self.LoadData = function () {
        $.ajax({
            method: "POST",
            url: "students-data",           
        })
            .done(function (students) {

                for(var i = 0; i < students.students.length; i++){
                    var student = students.students[i];
                    self.students.push(new Student(student.Id, student.Name, student.Rate, student.Group, student.ImageUrl, student.SocialUrl, student.Description));
                }
            });
    }   
}




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

$(function () {
    var page = $("#student-list");
    if (!page)
        return;

    var viewModel = new StudentViewModel();
    viewModel.LoadData();
    ko.applyBindings(viewModel);
    Tab();
});