/**
Nome: David Alves Pereira da Silva   RA: 233089
Nome: Silvio Lucas dos Santos 	     RA: 228787
Nome: Wendel Eduardo Romualdo Passos RA: 228111 
Nome: Yago Gomes Cardoso             RA: 219748
IDE utilizada: Eclipse
*/

package appBingo;

import java.util.ArrayList;

public class Globo {

	int numberBall;
	final int maxBalls;

	ArrayList<Integer> balls = new ArrayList<Integer>();

	public Globo(int maxBalls) {
		this.maxBalls = maxBalls;
	}

	public int girar() {
		return (int) (Math.random() * maxBalls + 1);
	}

	public void checkBall() {

		numberBall = girar();

		if (balls.contains(numberBall)) {
			checkBall();
		} else {
			balls.add(numberBall);
			System.out.println("Bola " + numberBall);
		}

	}

}
