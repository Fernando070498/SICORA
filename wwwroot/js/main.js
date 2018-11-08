$(document).ready(function(){
    
    $('ul.tabs li a:first').addClass('act');
    $('.secciones article').hide();
    $('.secciones article:first').show();

    $('ul.tabs li a').click(function(){
        $('ul.tabs li a').removeClass('act');
        $(this).addClass('act');
        $('.secciones article').hide();

        var actTab = $(this).attr('href');
        $(actTab).show();
        return false;
    });
});