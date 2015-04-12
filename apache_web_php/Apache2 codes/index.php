<?php
header("refresh:5");
echo $globalblUrl = "http://wsms.adpers.net/retreive.php";

$ch = curl_init($globalblUrl);
curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);

$curl_scraped_page = curl_exec($ch);
curl_close($ch);


$dom = new DOMDocument;
echo $dom->loadHTML($curl_scraped_page);

$file = fopen("test.txt","w");
$rows = array();
foreach( $dom->getElementsByTagName( 'tr' ) as $tr ) {
    $cells = array();
    foreach( $tr->getElementsByTagName( 'td' ) as $td ) {
        $cells[] = $td->nodeValue;
        fwrite($file,$td->nodeValue);
    }
    fwrite($file,"\n");
    $rows[] = $cells;
    
}
echo "<pre>";
print_r($rows);
fclose($file);
?> 
