<?
/////데이터베이스 연결계정 정의 시작///////
$db_hostname="sky14786.cafe24.com";
$db_username="sky14786";
$db_password="whdkfk32!~";
$dbname = "sky14786";
/////데이터베이스 연결계정 정의 끝///////

$sock = mysql_connect($db_hostname,$db_username,$db_password)
		or die ("데이터베이스 서버에 연결할 수 없습니다.");
$db = mysql_select_db($dbname,$sock)
		or die ("'$dbname' 데이터베이스를 찾을 수 없거나 접근권한이 없습니다.");
?>