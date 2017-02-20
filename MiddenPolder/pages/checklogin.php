<?php
include 'components/sql.php';

// username and password sent from form 
$myusername=$_POST['username'];
$mypassword=$_POST['password'];
$mypassword= md5($mypassword);

$sql="SELECT * FROM care_users WHERE login_id=`$myusername` and password=`$mypassword`";
$result=mysqli_query($con,$sql);

// Mysql_num_row is counting table row
$count = count($result);

// If result matched $myusername and $mypassword, table row must be 1 row
if($count==1){

// Register $username, $password and redirect to file "login_success.php"
    session_start();
    $_SESSION["username"] = $myusername;
    header("location:login_success.php");
}
else {
    echo "Wrong Username or Password";
    echo $count;
}
?>