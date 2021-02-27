$(document).ready(function () {

    $('#nameItem').change(function () {
        $('#titleItem').val($(this).val());
    })

    synchSEOWords();

    $('#productItemType').change(function () {
        synchSEOWords();
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
        img.classList.add("card-img");
        img.classList.add("rounded-0");
        img.classList.add("img-fluid");

        img.file = file;
        preview.appendChild(img);

        let reader = new FileReader();
        reader.onload = (function (aImg) { return function (e) { aImg.src = e.target.result; }; })(img);
        reader.readAsDataURL(file);
    }
}

function synchSEOWords() {
    let selectedWords = ['Êîñòþì', 'Ïëàòüå', 'Þáêà'];

    for (var i = 0; i < selectedWords.length; i++) {
        $('#nameItem').val($('#nameItem').val().replace(selectedWords[i], ''));
        $('#metaKeywords').val($('#metaKeywords').val().replace(selectedWords[i] + ", ", ''));
    }
    let tempName = $('#nameItem').val();

    $('#nameItem').val($('#productItemType option:selected').text() + tempName);

    temp = $('#metaKeywords').val();
    $('#metaKeywords').val(temp + $('#productItemType option:selected').text() + ", ");
}