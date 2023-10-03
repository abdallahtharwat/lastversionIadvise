function DuplicateRow($url) {
  return new swal({
        title: "Your Item will be Duplicate!",
        text: "Are you sure to proceed?",
        type: "success",
        buttons: true,
        showCancelButton: true,
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "Duplicate My Item!",
        cancelButtonText: "I am not sure!",
        closeOnConfirm: false,
        closeOnCancel: false
    }).then((isConfirm) => {
        if (isConfirm) {
            $.ajax({
                type: "POST",
                url: $url,
                success: function (data) {
                    if (data == "Duplicated") {
                        new swal("Item Duplicated!", "Your Item is Duplicated!", "success");
                        setTimeout(function () {
                            location.reload();
                        }, 500);
                    } else {

                        new swal("Hurray", "Item is not Duplicated!", "error");
                    }

                }
            });

        }
        else {
            new   swal("Hurray", "Item is not Duplicated!", "error");
        }
    });

}
function DeleteRow($url) {
    return new   swal({
        title: "Your Item will be deleted!",
        text: "Are you sure to proceed?",
        type: "warning",
        buttons: true,
        showCancelButton: true,
        cancelButtonColor: "#DD6B55",
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "Remove My Item!",
        cancelButtonText: "I am not sure!",
        closeOnConfirm: false,
        closeOnCancel: false
    }).then((isConfirm) => {
        if (isConfirm) {
            $.ajax({
                type: "POST",
                url: $url,
                success: function (data) {
                    if (data == "Removed") {
                        setTimeout(function () {
                            location.reload();
                        }, 500);
                    } else {
                        new   swal("Item Removed!", "Your Item is removed!", "success");

                    }

                }
            });
            new  swal("Item Removed!", "Your Item is removed!", "success");

        }
        else {
            new  swal("Hurray", "Item is not removed!", "error");
        }
    });

}

$(function () {
    if ($('input.tag').length > 0) {
        $('input.tag').each(
            function (i, obj) {
                $(obj).selectize({
                    plugins: ['remove_button'],
                    persist: false,
                    createOnBlur: true,
                    create: true
                });
            });
    }
});



$(document).ready(function () {



    document.getElementById('contactusbutton').addEventListener('click', function () {
        if ($("#contactusform").valid()) {
            $(this).attr('disabled', true)
            $(this).parents('form').submit()
        }



    })


    //document.getElementById('contactusbuttonn').addEventListener('click', function () {
    //    if ($("#contactusformm").valid()) {
    //        $(this).attr('disabled', true)
    //        $(this).parents('form').submit()
    //    }

    //})


})





var exampleModal = document.getElementById('exampleModal')
exampleModal.addEventListener('show.bs.modal', function (event) {
    // Button that triggered the modal
    var button = event.relatedTarget
    // Extract info from data-bs-* attributes
    var recipient = button.getAttribute('data-bs-whatever')
    // If necessary, you could initiate an AJAX request here
    // and then do the updating in a callback.
    //
    // Update the modal's content.
    var modalTitle = exampleModal.querySelector('.modal-title')
    var modalBodyInput = exampleModal.querySelector('.modal-body input')

    modalTitle.textContent = 'New message to ' + recipient
    modalBodyInput.value = recipient
})



