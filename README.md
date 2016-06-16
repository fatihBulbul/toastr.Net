# toastr.Net
toastr notifications for .Net


# Example
,,,
        public ActionResult Index()
        {
            ViewBag.Message =
                Notification.Show("Merhaba dünya", onclick: "hello") +
                Notification.Show("Elveda dünya", position: Position.BottomCenter, type: ToastType.Error, timeOut: 7000) +
                Notification.Show("System of down", "Error", type: ToastType.Error);
            return View();
        }
        
        
        
        <script src="//code.jquery.com/jquery-2.2.4.min.js"></script>
        <script src="//cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js"></script>
        <link href="//cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css" rel="stylesheet" />
        
        <script type="text/javascript">
            function hello() {
                alert("Hello World")
            }
        </script>
        @Html.Raw(ViewBag.Message)

,,,

