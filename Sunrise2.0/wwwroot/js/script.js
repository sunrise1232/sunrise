$(document).ready(function(){
    
    // Modal

    $('[data-modal=authorization]').on('click', function() {
        $('.modal, #authorization').addClass("modal_active");
    });
    $('.modal__close').on('click', function() {
        $('.overlay, #tour, #authorization').removeClass("modal_active");
    });

    $('.catalog-item').each(function(i) {
        $(this).on('click', function() {
            //$('#order .modal__descr').text($('.catalog-item__subtitle').eq(i).text());
            $('.modal, #tour').addClass("modal_active");

            $('.modalCarousel').slick({
                autoplay: true,
                prevArrow: '<button class="prevArrow"><i class="fas fa-chevron-left"></i></button>',
                nextArrow: '<button class="nextArrow"><i class="fas fa-chevron-right"></i></button>',
              });
        });
    });

    




    // slick

    $('.carousel').slick({
        autoplay: true,
        prevArrow: '<button class="prevArrow"><i class="fas fa-chevron-left"></i></button>',
        nextArrow: '<button class="nextArrow"><i class="fas fa-chevron-right"></i></button>',
      });



    // like

    $('.tour__rating').on('click', function() {
        $('.fa-heart').toggleClass("fas");
    });

});