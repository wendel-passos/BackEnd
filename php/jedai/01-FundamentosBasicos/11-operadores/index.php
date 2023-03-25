<?php
  $var1 = 1;
  $var2 = 2;
  $var3 = 3;

  //operadores matemáticos
  if ($var1 < $var2){
    echo 'Verdade <br/>';
  }
  if ($var1 <= $var2){
    echo 'Verdade <br/>';
  }
  if ($var1 > $var2){
    echo 'Verdade <br/>';
  }
  if ($var1 >= $var2){
    echo 'Verdade <br/>';
  }

  //operadores lógicos
  if (($var1 < $var2)&&($var3 > $var2)) {
    echo 'Verdade <br/>';
  }
  if (($var1%2 ==1)&&($var3%2==1)) {
    echo 'Verdade <br/>';
  }
  if ((($var1==1) || ($var3==300)) && $var2 ==2){
    echo 'Verdade no ou<br/>';

  }




?>