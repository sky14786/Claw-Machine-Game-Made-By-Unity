<?php
$db_hostname="sky14786.cafe24.com";
$db_username="sky14786";
$db_password="whdkfk32!~";
$dbname = "sky14786";
$connect= mysql_connect($db_hostname,$db_username,$db_password);
mysql_query("set names utf8",$connect);
mysql_select_db($dbname,$connect);
if(!$connect)die("연결에 실패 하였습니다.".mysql_error());

$score = $_POST[score];


$result = mysql_query('select * from score where score>0 order by score DESC limit 0,10');

$data =array();

while($row=mysql_fetch_array($result))
{
array_push($data,array('nick_name'=>$row[1],'score'=>$row[2]));
}

// $json = json_encode(array("score"=>$data));

$json=Json_encode($data);

echo $json;


?>