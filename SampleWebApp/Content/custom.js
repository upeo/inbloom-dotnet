$(function() {
	$("a[data-target=#SectionDetailModal]").click(function(ev) {
	    ev.preventDefault();
	    var target = $(this).attr("href");
	    var limit = $('#limit').val();
	    var offset = $('#offset').val();
	    var view = $('#view').val();

	    if (limit != '') {
	        target = updateQueryStringParameter(target, 'limit', limit);
	    }
	    if (offset != '') {
	        target = updateQueryStringParameter(target, 'offset', offset);
	    }
	    if (view != '') {
	        target = updateQueryStringParameter(target, 'view', view);
	    }
	   
		// load the url and show modal on success
		$("#SectionDetailModal .modal-body").html("Loading...").load(target, function() {
			$("#SectionDetailModal").modal("show");
		});

		return false;
	});

	function updateQueryStringParameter(uri, key, value) {
	    var re = new RegExp("([?|&])" + key + "=.*?(&|$)", "i");
	    separator = uri.indexOf('?') !== -1 ? "&" : "?";
	    if (uri.match(re)) {
	        return uri.replace(re, '$1' + key + "=" + value + '$2');
	    }
	    else {
	        return uri + separator + key + "=" + value;
	    }
	}

});