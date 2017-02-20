<?php include("menu.php"); ?>


<h1>Contactgegevens</h1>
<div>
    MiddenPolder Ziekenhuis
</div>
<div>
    Hoogstraat 180
</div>
<div>
    5542 LA Utrecht
</div>
<div>
    tel. 0020 77 22 334
</div>

<div class="container">
            <div class="hero-unit">
                <input  type="text" placeholder="click to show datepicker"  id="example1">
            </div>
        </div>
        <script type="text/javascript">
            // When the document is ready
            $(document).ready(function () {

                $('#example1').datepicker({
                    format: "dd/mm/yyyy"
                });

            });
        </script>


<?php include("footer.php"); ?>