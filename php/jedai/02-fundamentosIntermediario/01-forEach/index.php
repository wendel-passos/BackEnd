<?php

$arr = array ('Wendel','Lucia','Romulo','Paula');


//Exibir o array com utilizando forEach
foreach ( $arr as $key => $value) {
  echo $key;
  echo  '=>';
  echo $value;
  echo '<hr>';
}

//---------------------------------//

$total = count ($arr);

for ($i = 0; $i < $total; $i++){
  echo $arr [$i];
  echo '<br>';
}




?>