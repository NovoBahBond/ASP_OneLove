$(function() {
    $('.slider').slick({
        nextArrow: '<button class="slick-arrow slick-next"><img src="images/next.svg" alt=""></button>',
        prevArrow: '<button class="slick-arrow slick-prev"><img src="images/prev.svg" alt=""></button>',
        fade: true,
        responsive: [{
            breakpoint: 441,
            settings: {
                arrows: false
            }
        }]
    });
});