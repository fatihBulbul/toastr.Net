# toastr.Net
toastr notifications for .Net


# Example
,,,
        ViewBag.Message = Notification.Show("Merhaba dünya", onclick: "hello");
,,,
***

        
        
        <script src="//code.jquery.com/jquery-2.2.4.min.js"></script>
        <script src="//cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js"></script>
        <link href="//cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css" rel="stylesheet" />
        
        <script type="text/javascript">
            function hello() {
                alert("Hello World")
            }
        </script>
        @Html.Raw(ViewBag.Message)

***

