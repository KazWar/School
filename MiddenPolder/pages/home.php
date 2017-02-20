<?php include("menu.php"); ?>

<h1>Welkom in het MiddenPolder</h1>
<div>
    <?php
      echo 'U bent ingelogd als '.$_SESSION['username'].'';
    ?>
</div>

<?php include("footer.php"); ?>