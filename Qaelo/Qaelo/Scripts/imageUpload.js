$(document).on('click', '#close-preview', function () {
    $('.image-preview').popover('hide');
    // Hover befor close the preview
    $('.image-preview').hover(
        function () {
            $('.image-preview').popover('show');
        },
         function () {
             $('.image-preview').popover('hide');
         }
    );
});

$(function () {
    // Create the close button
    var closebtn = $('<button/>', {
        type: "button",
        text: 'x',
        id: 'close-preview',
        style: 'font-size: initial;',
    });
    closebtn.attr("class", "close pull-right");
    // Set the popover default content
    $('.image-preview').popover({
        trigger: 'manual',
        html: true,
        title: "<strong>Preview</strong>" + $(closebtn)[0].outerHTML,
        content: "There's no image",
        placement: 'bottom'
    });
    // Clear event
    $('.image-preview-clear').click(function () {
        $('.image-preview').attr("data-content", "").popover('hide');
        $('.image-preview-filename').val("");
        $('.image-preview-clear').hide();
        $('.image-preview-input input:file').val("");
        $(".image-preview-input-title").text("Browse");
    });
    // Create the preview image
    $(".image-preview-input input:file").change(function () {
        var img = $('<img/>', {
            id: 'dynamic',
            width: 250,
            height: 200
        });
        var file = this.files[0];
        var reader = new FileReader();
        // Set preview image into the popover data-content
        reader.onload = function (e) {
            $(".image-preview-input-title").text("Change");
            $(".image-preview-clear").show();
            $(".image-preview-filename").val(file.name);
            img.attr('src', e.target.result);
            $(".image-preview").attr("data-content", $(img)[0].outerHTML).popover("show");
        }
        reader.readAsDataURL(file);
    });
});


//Image upload 2
$(document).on('click', '#close-preview', function () {
    $('.image-preview2').popover('hide');
    // Hover befor close the preview
    $('.image-preview2').hover(
        function () {
            $('.image-preview2').popover('show');
        },
         function () {
             $('.image-preview2').popover('hide');
         }
    );
});

$(function () {
    // Create the close button
    var closebtn = $('<button/>', {
        type: "button",
        text: 'x',
        id: 'close-preview',
        style: 'font-size: initial;',
    });
    closebtn.attr("class", "close pull-right");
    // Set the popover default content
    $('.image-preview2').popover({
        trigger: 'manual',
        html: true,
        title: "<strong>Preview</strong>" + $(closebtn)[0].outerHTML,
        content: "There's no image",
        placement: 'bottom'
    });
    // Clear event
    $('.image-preview2-clear').click(function () {
        $('.image-preview2').attr("data-content", "").popover('hide');
        $('.image-preview2-filename').val("");
        $('.image-preview2-clear').hide();
        $('.image-preview2-input input:file').val("");
        $(".image-preview2-input-title").text("Browse");
    });
    // Create the preview image
    $(".image-preview2-input input:file").change(function () {
        var img = $('<img/>', {
            id: 'dynamic',
            width: 250,
            height: 200
        });
        var file = this.files[0];
        var reader = new FileReader();
        // Set preview image into the popover data-content
        reader.onload = function (e) {
            $(".image-preview2-input-title").text("Change");
            $(".image-preview2-clear").show();
            $(".image-preview2-filename").val(file.name);
            img.attr('src', e.target.result);
            $(".image-preview2").attr("data-content", $(img)[0].outerHTML).popover("show");
        }
        reader.readAsDataURL(file);
    });
});
//Image upload 3
$(document).on('click', '#close-preview', function () {
    $('.image-preview3').popover('hide');
    // Hover befor close the preview
    $('.image-preview3').hover(
        function () {
            $('.image-preview3').popover('show');
        },
         function () {
             $('.image-preview3').popover('hide');
         }
    );
});

$(function () {
    // Create the close button
    var closebtn = $('<button/>', {
        type: "button",
        text: 'x',
        id: 'close-preview',
        style: 'font-size: initial;',
    });
    closebtn.attr("class", "close pull-right");
    // Set the popover default content
    $('.image-preview3').popover({
        trigger: 'manual',
        html: true,
        title: "<strong>Preview</strong>" + $(closebtn)[0].outerHTML,
        content: "There's no image",
        placement: 'bottom'
    });
    // Clear event
    $('.image-preview-clear').click(function () {
        $('.image-preview3').attr("data-content", "").popover('hide');
        $('.image-preview3-filename').val("");
        $('.image-preview3-clear').hide();
        $('.image-preview3-input input:file').val("");
        $(".image-preview3-input-title").text("Browse");
    });
    // Create the preview image
    $(".image-preview3-input input:file").change(function () {
        var img = $('<img/>', {
            id: 'dynamic',
            width: 250,
            height: 200
        });
        var file = this.files[0];
        var reader = new FileReader();
        // Set preview image into the popover data-content
        reader.onload = function (e) {
            $(".image-preview3-input-title").text("Change");
            $(".image-preview3-clear").show();
            $(".image-preview3-filename").val(file.name);
            img.attr('src', e.target.result);
            $(".image-preview3").attr("data-content", $(img)[0].outerHTML).popover("show");
        }
        reader.readAsDataURL(file);
    });
});
//Image upload 4
$(document).on('click', '#close-preview', function () {
    $('.image-preview4').popover('hide');
    // Hover befor close the preview
    $('.image-preview4').hover(
        function () {
            $('.image-preview4').popover('show');
        },
         function () {
             $('.image-preview4').popover('hide');
         }
    );
});

$(function () {
    // Create the close button
    var closebtn = $('<button/>', {
        type: "button",
        text: 'x',
        id: 'close-preview',
        style: 'font-size: initial;',
    });
    closebtn.attr("class", "close pull-right");
    // Set the popover default content
    $('.image-preview4').popover({
        trigger: 'manual',
        html: true,
        title: "<strong>Preview</strong>" + $(closebtn)[0].outerHTML,
        content: "There's no image",
        placement: 'bottom'
    });
    // Clear event
    $('.image-preview4-clear').click(function () {
        $('.image-preview4').attr("data-content", "").popover('hide');
        $('.image-preview4-filename').val("");
        $('.image-preview4-clear').hide();
        $('.image-preview4-input input:file').val("");
        $(".image-preview4-input-title").text("Browse");
    });
    // Create the preview image
    $(".image-preview4-input input:file").change(function () {
        var img = $('<img/>', {
            id: 'dynamic',
            width: 250,
            height: 200
        });
        var file = this.files[0];
        var reader = new FileReader();
        // Set preview image into the popover data-content
        reader.onload = function (e) {
            $(".image-preview4-input-title").text("Change");
            $(".image-preview4-clear").show();
            $(".image-preview4-filename").val(file.name);
            img.attr('src', e.target.result);
            $(".image-preview4").attr("data-content", $(img)[0].outerHTML).popover("show");
        }
        reader.readAsDataURL(file);
    });
});
//Image upload 5

$(document).on('click', '#close-preview', function () {
    $('.image-preview5').popover('hide');
    // Hover befor close the preview
    $('.image-preview5').hover(
        function () {
            $('.image-preview5').popover('show');
        },
         function () {
             $('.image-preview5').popover('hide');
         }
    );
});

$(function () {
    // Create the close button
    var closebtn = $('<button/>', {
        type: "button",
        text: 'x',
        id: 'close-preview',
        style: 'font-size: initial;',
    });
    closebtn.attr("class", "close pull-right");
    // Set the popover default content
    $('.image-preview5').popover({
        trigger: 'manual',
        html: true,
        title: "<strong>Preview</strong>" + $(closebtn)[0].outerHTML,
        content: "There's no image",
        placement: 'bottom'
    });
    // Clear event
    $('.image-preview-clear').click(function () {
        $('.image-preview5').attr("data-content", "").popover('hide');
        $('.image-preview5-filename').val("");
        $('.image-preview5-clear').hide();
        $('.image-preview5-input input:file').val("");
        $(".image-preview5-input-title").text("Browse");
    });
    // Create the preview image
    $(".image-preview5-input input:file").change(function () {
        var img = $('<img/>', {
            id: 'dynamic',
            width: 250,
            height: 200
        });
        var file = this.files[0];
        var reader = new FileReader();
        // Set preview image into the popover data-content
        reader.onload = function (e) {
            $(".image-preview5-input-title").text("Change");
            $(".image-preview5-clear").show();
            $(".image-preview5-filename").val(file.name);
            img.attr('src', e.target.result);
            $(".image-preview5").attr("data-content", $(img)[0].outerHTML).popover("show");
        }
        reader.readAsDataURL(file);
    });
});



