
$('#GradeForm').click(function () {
    // get each grade from index and figure out what percentage they go into final grade
    var asignments = $('#asignments').val() * .5376;
    var quizzes = $('#quizzes').val() * .0860;
    var projects = $('#projects').val() * .0538;
    var intex = $('#intex').val() * .1075;
    var exams = $('#exams').val() * .2151;
    var extra = $('#extra').val() * 1;
    var finalGrade = asignments + quizzes + projects + intex + exams + extra;

    $('#finalPercent').html('Final Percentage: ' + finalGrade + ' %');

    // checks what letter grade range each percentage is
    //outputs result onto html page
    if (finalGrade >= 94) {
        $('#finalLetter').html('A')
    }
    else if (finalGrade >= 90) {
        $("#finalLetter").html('A-')
    }
    else if (finalGrade >= 87) {
        $("#finalLetter").html('B+')
    }
    else if (finalGrade >= 84) {
        $("#finalLetter").html('B')
    }
    else if (finalGrade >= 80) {
        $("#finalLetter").html('B-')
    }
    else if (finalGrade >= 77) {
        $("#finalLetter").html('C+')
    }
    else if (finalGrade >= 74) {
        $("#finalLetter").html('C')
    }
    else if (finalGrade >= 70) {
        $("#finalLetter").html('C-')
    }
    else if (finalGrade >= 67) {
        $("#finalLetter").html('D+')
    }
    else if (finalGrade >= 64) {
        $("#finalLetter").html('D')
    }
    else if (finalGrade >= 60) {
        $("#finalLetter").html('D-')
    }
    else {
        $('#finalLetter').html('E')
    };

})