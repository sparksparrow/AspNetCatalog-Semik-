//$('body > p').change(function () {
//    alert('s');
//    alert($(this).val());
//    $('#metaDescription').val($(this).val());
//    alert($('#metaDescription').val());
//}    
$(document).ready(function () {

    $('#nameItem').change(function () {
        $('#metaKeywords').val($(this).val() + ", ");
        $('#titleItem').val($(this).val());
    })

    $('#sizes').change(function () {

        let filled = true;

        $('.size').each(function () {
            if ($(this).val() == '') {
                filled = false;
            }
        })

        if (filled) {
            var htmlInputSize = "<input class='size' id='sizeValues' name='sizeValues'  type='number' min='0' max='300' step='0.5' />";
            $('#sizes').append(htmlInputSize);
        }
    });

});


function handleFiles(files) {

    //document.getElementsByClassName("image-new").remove();
    
    for (let i = 0; i < files.length; i++) {
        let file = files[i];

        if (!file.type.startsWith('image/')) { continue }

        let img = document.createElement("img");
        img.classList.add("image", "image-new");
        img.file = file;
        document.getElementById("preview").appendChild(img);

        let reader = new FileReader();
        reader.onload = (function (aImg) { return function (e) { aImg.src = e.target.result; }; })(img);
        reader.readAsDataURL(file);
    }
}