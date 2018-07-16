<?php
$db_hostname="sky14786.cafe24.com";
$db_username="sky14786";
$db_password="whdkfk32!~";
$dbname = "sky14786";
$connect= mysql_connect($db_hostname,$db_username,$db_password);
mysql_query("set names utf8",$connect);
mysql_select_db($dbname,$connect);
if(!$connect)die("연결에 실패 하였습니다.".mysql_error());

$result = mysql_query('select * from score where score>0 order by score DESC limit 0,10');

while($row = mysql_fetch_row($result))
{
	
	
	echo $row[1].'#'.$row[2].'#';
	
	
	
	
	
	
}



?>

