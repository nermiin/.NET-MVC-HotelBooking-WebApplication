$(document).ready(function()
{
	"use strict";
    initMainSlider();
    function initMainSlider()
	{
		if($('.hero_slider').length)
		{
			var heroSlider = $('.hero_slider');

			heroSlider.owlCarousel({
				items: 1,
				loop: true,
				autoplay:true,
				autoplayTimeout:5000,
				autoplaySpeed:800,
				smartSpeed:800,
				dotsContainer:'main_slider_custom_dots'
			});

			/* Custom dots events */
			if($('.main_slider_custom_dot').length)
			{
				$('.main_slider_custom_dot').on('click', function()
				{
					$('.main_slider_custom_dot').removeClass('active');
					$(this).addClass('active');
					heroSlider.trigger('to.owl.carousel', [$(this).index(), 300]);
				});
			}

			/* Change active class for dots when slide changes by nav or touch */
			heroSlider.on('changed.owl.carousel', function(event)
			{
				$('.main_slider_custom_dot').removeClass('active');
				$('.main_slider_custom_dots li').eq(event.page.index).addClass('active');
			});	

			/* Custom navigation */
			if($('.main_slider_nav').length)
			{
				$('.main_slider_nav_left').on('click', function()
				{
					heroSlider.trigger('prev.owl.carousel');
				});

				$('.main_slider_nav_right').on('click', function()
				{
					heroSlider.trigger('next.owl.carousel');
				});
			}

		}
	}
function initClientsSlider()
	{
		if($('.clients_slider').length)
		{
			var clientsSlider = $('.clients_slider');

			clientsSlider.owlCarousel(
			{
				loop: true,
				dots: false,
				responsive:
				{
					0:{items:1},
					575:{items:2},
					768:{items:3},
					992:{items:4},
					1199:{items:5}
					
				}
			});
		}
	}
    });