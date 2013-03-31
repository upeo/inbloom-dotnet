$(function() {
	$("a[data-target=#SectionDetailModal]").click(function(ev) {
		ev.preventDefault();
		var target = $(this).attr("href");

		// load the url and show modal on success
		$("#SectionDetailModal .modal-body").html("Loading...").load(target, function() {
			$("#SectionDetailModal").modal("show");
		});
	});
});