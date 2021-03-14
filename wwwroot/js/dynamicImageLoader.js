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
        img.classList.add("col-md-4");
        img.classList.add("card");

        img.file = file;
        preview.appendChild(img);

        let reader = new FileReader();
        reader.onload = (function (aImg) { return function (e) { aImg.src = e.target.result; }; })(img);
        reader.readAsDataURL(file);
    }
}