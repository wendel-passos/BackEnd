<?php

//array multidimencional
 $arr = array (array ('Wendel', 'Eduardo'),array(25,34));

 echo $arr[1][0];
 echo '<br>';

//exemplo2
 $arr1[0] = array ('Wendel', 'Eduardo');
 
 echo $arr1[0][0];
 echo '<br>';

 //exemplo3
 $arr2[0] = array ('chave1'=>'Wendel', 'chave2'=>'Eduardo');
 
 echo $arr2[0]['chave2'];
 echo '<br>';

 //exemplo4 
 $arr3[0]['chave1'] = 'Wendel';
 echo $arr3[0]['chave1'];


?>