$(document).ready(function() {

    $("#slider").slick({

        infinite: true,
        slidesToShow: 1,
        slidesToScroll: 3,
        arrows: true,
        dots: true,
        autoplay: true,
        centerMode: true

    });



    $(".menu > li").hover(function(){
        $(this).children(".sub-menu").fadeToggle(100);
    })
    



})