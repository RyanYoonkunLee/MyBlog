jQuery(document).ready(function () {
	change_header();

	function change_header() {
		if (jQuery("#changing_text").length > 0) {
			var options = {
				strings: [
					"Good Team Player",
					"Web Developer",
					"Logical Thinker",
					"Debug Codes",
					"Enthusiastic",
					"Positive Person"
				],
				typeSpeed: 30,
				backSpeed: 30,
				showCursor: false,
				backDelay: 2000,
				loop: true
			}

			var typed = new Typed("#changing_text", options);
		}
	}


	$(window).scroll(function () {
		var windowBottom = $(this).scrollTop() + $(this).innerHeight();
		$(".fade").each(function () {
			/* Check the location of each desired element */
			var objectBottom = $(this).offset().top + $(this).outerHeight();

			/* If the element is completely within bounds of the window, fade it in */
			if (objectBottom < windowBottom) { //object comes into view (scrolling down)
				if ($(this).css("opacity") == 0)
				{
					$(this).fadeTo(500, 1);
					
					$('.techicon').animate({
						width: "10%",						
						fontSize: "3em",
						borderWidth: "10px"
					}, 1500);
					$('.progress').each(function () {
						animateProgressBar($(this).find("div"), $(this).data("width"))
					});
				}				
			} 
		});

		$(".portimg").each(function () {
			var objectBottom = $(this).offset().top + $(this).outerHeight();
			if (objectBottom < windowBottom) {
				if ($(this).css("opacity") == 0) {
					$(this).fadeTo(5000, 1);
					$(this).animate({ 'margin-top': '-=120' }, 1000);

				}	
			}
		});
	}).scroll(); //invoke scroll-handler on page-load

	function animateProgressBar(el, width) {
		el.css("backgound-color", "")
		el.animate(
			{ duration: 2000, width: (width * 10) + "%" },
			{
				duration: 2000,
				step: function (now, fx) {

				}
			}
		);
	}

	var index = 0;

	imageSlider();

	function imageSlider() {
		var slide = document.getElementsByClassName('slider');

		for (var i = 0; i < slide.length; i++) {
			slide[i].style.display = "none";
		}
		
		slide[index].style.display = "block";
		slide[index].classList.add("show");

		if (index == 0) {
			slide[slide.length - 1].classList.remove("show");
		}
		else {
			slide[index - 1].classList.remove("show");
		}
		
		index++

		if (index == slide.length) {
			index = 0;
		}

		setTimeout(imageSlider, 5000);

	}
	var jIndex = 0;
	jqueryImageSlider()
	function jqueryImageSlider() {

		var element = $('.Jslider');

		$(element).each(function () {
			$(this).css({ display: "none" });
		});
		$(element).eq(index).css({ display: "block" });
		$(element).eq(index).addClass("show");

		if (index == 0) {
			$(element).eq($(element).length -1).removeClass("show");
		}
		else {
			$(element).eq(jIndex - 1).removeClass("show");
		}

		jIndex++
		if (index == $(element).lengthh) {
			jIndex = 0;
		}

		setTimeout(jqueryImageSlider, 5000);

	}
});



