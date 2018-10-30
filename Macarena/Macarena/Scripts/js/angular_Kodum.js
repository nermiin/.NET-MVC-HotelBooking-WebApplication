
$(document).ready(function() {
 $("#tblDatatr:has(td)").mouseover(function(e) {
 $(this).css("cursor", "pointer");
 });
 $("#tblDatatr:has(td)").click(function(e) {
 $("#tblData td").removeClass("highlight");
 var clickedCell= $(e.target).closest("td");
 clickedCell.addClass("highlight");
 $("#spnText").html(
 'Clicked table cell value is: <b> ' + clickedCell.text() + '</b>');
 });
});