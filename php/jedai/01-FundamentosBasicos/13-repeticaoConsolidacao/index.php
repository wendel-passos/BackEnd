<?php
/*
  //laço de repetição for
  for ($cont =0;$cont<10;$cont++)
  echo "Ola mundo FOR $cont <hr>";

  //laço de repetição while
  $cont1 =0;
  while ($cont1 < 10){
    echo "Ola mundo WHILE $cont1 <hr>";
    $cont1 ++;
  }

  //laço de repetição do 
  $cont2 = 0;
  do {
    echo "Ola mundo DO WHILE $cont2 <hr>";
    $cont2++;
  }
  while ($cont2 <10);
*/


//Tabuada do 10  

//O primeiro for corresponde ao número da tabuada
for ($tab = 1; $tab <= 10; $tab++){

  //O segundo for correponde aos números multiplicadores
  for ($cont = 0; $cont <= 10; $cont++)

  echo "<div> $cont X $tab= ".$tab * $cont." <hr> </div>" ;

}

?>

