<?php
$db_hostname="sky14786.cafe24.com";
$db_username="sky14786";
$db_password="whdkfk32!";
$dbname = "sky14786";
$connect= mysql_connect($db_hostname,$db_username,$db_password);
mysql_query("set names utf8",$connect);
mysql_select_db($dbname,$connect);
if(!$connect)die("연결에 실패 하였습니다.".mysql_error());

$nick_name = $_POST['nick_name'];
$score = $_POST['score'];
$regdate=date("YmdHis", time());
$ip=getenv("REMOTE_ADDR");

$sql = "insert into score (nick_name, score, regdate, ip) values ('$nick_name' , '$score' , '$regdate' , '$ip')";
mysql_query("set names ust8",$connect);
$res = mysql_query($sql);
$rs = mysql_fetch_row($res);

$sql = "select * from score where regdate= '$regdate'";

echo ("hello");




?>

