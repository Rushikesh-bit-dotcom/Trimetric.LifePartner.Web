<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfilePhoto.aspx.cs" Inherits="Trimetric.LifePartner.Web.ProfilePhoto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../assets/css/croppie.css" rel="stylesheet" />
    <link rel="stylesheet" href="assests/css/Profile.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/croppie/2.6.5/croppie.min.css" />

      <style>
        .upload-demo .upload-demo-wrap,
        .upload-demo.ready .upload-msg {
            display: none;
           
        }
        .photo {
            margin-left: auto;
            margin-right: auto;
            width: 100%;
        }
        .upload-demo.ready .upload-demo-wrap {
            display: block;
        }

        .upload-demo.ready .upload-result {
            display: block;
        }

        .upload-demo-wrap {
            width: 300px;
            height: 300px;
            margin: 0 auto;
        }

        /*  .upload-demo .container {
         margin-left: 0px;
         padding-left: 0px;
     }*/

        .upload-msg {
            text-align: center;
            padding: 50px 0;
            font-size: 22px;
            color: #aaa;
            width: 160px;
            border: 3px solid #aaa;
            border-radius: 50%;
        }

       /* #cropped-result {
            margin-top: 100px;
        }*/
    </style>
</head>
<body>
    <div class="demo-wrap upload-demo">
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <div class="upload-demo-wrap">
                        <div id="upload-demo"></div>
                    </div>
                </div>
                <div class="col-12 photo">
                    <a class="btn file-btn">
                        <input type="file" id="upload" value="Выберите файл" accept="image/*" />
                    </a>
                    <button class="upload-result">result</button>
                    <input type="hidden" id="userprofile" class="form-control" />

                </div>
            </div>
        </div>
    </div>
    <div id="cropped-result">
        Result:<br>
        <img>
    </div>


    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/croppie/2.6.5/croppie.min.js"></script>
    <script src="../assets/js/croppie.min.js"></script>
    <script>
        $(document).ready(function () {
            var $uploadCrop;
            function readFile(input) {
                if (input.files && input.files[0]) {
                    var reader = new FileReader();

                    reader.onload = function (e) {
                        $('.upload-demo').addClass('ready');
                        $uploadCrop.croppie('bind', {
                            url: e.target.result
                        })
                    }
                    reader.readAsDataURL(input.files[0]);
                }
            }

            $uploadCrop = $('#upload-demo').croppie({
                viewport: {
                    width: 300,
                    height: 300,
                    type: 'circle'
                },
                enableExif: true
            });

            $('#upload').on('change', function () { readFile(this); });
            $('.upload-result').on('click', function (ev) {
                $uploadCrop.croppie('result', {
                    type: 'canvas',
                    size: 'viewport'

                }).then(function (resp) {
                    $('#userprofile').val(resp);
                    $('#cropped-result img').attr('src', resp);
                });

            });

        });
    </script>
</body>
</html>
