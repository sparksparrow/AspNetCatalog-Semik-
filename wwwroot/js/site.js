//$('body > p').change(function () {
//    alert('s');
//    alert($(this).val());
//    $('#metaDescription').val($(this).val());
//    alert($('#metaDescription').val());
//}    
$(document).ready(function () {

    $('#nameItem').change(function () {
        $('#titleItem').val($(this).val());
    })

    $('#nameItem').val($('#productItemType option:selected').text() + " ");
    $('#metaKeywords').val($('#productItemType option:selected').text() + ", ");

    $('#productItemType').change(function () {

        let selectedWords = ['Костюм', 'Платье', 'Юбка'];

        for (var i = 0; i < selectedWords.length; i++) {             
            $('#nameItem').val($('#nameItem').val().replace(selectedWords[i], ''));
            $('#metaKeywords').val($('#metaKeywords').val().replace(selectedWords[i] + ", ", ''));
        }
        let tempName = $('#nameItem').val();
                   
        $('#nameItem').val($('#productItemType option:selected').text() + tempName);

            temp = $('#metaKeywords').val();
            $('#metaKeywords').val(temp + $('#productItemType option:selected').text() + ", ");
        });

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

    
    let preview = document.getElementById("preview");

    while (preview.firstChild) {
        preview.removeChild(preview.firstChild);
        }    
    
    for (let i = 0; i < files.length; i++) {
        let file = files[i];

        if (!file.type.startsWith('image/')) { continue }

        let img = document.createElement("img");
        img.classList.add("image");
        img.file = file;
        preview.appendChild(img);

        let reader = new FileReader();
        reader.onload = (function (aImg) { return function (e) { aImg.src = e.target.result; }; })(img);
        reader.readAsDataURL(file);
    }
}