package appBingo;

import java.text.DecimalFormat;
import java.text.NumberFormat;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class Cartela {

	public static Random rnd = new Random();

	private static List<Integer> mListBalls = new ArrayList<Integer>();
	private static List<Integer> mListBallsB = new ArrayList<Integer>();
	private static List<Integer> mListBallsI = new ArrayList<Integer>();
	private static List<Integer> mListBallsN = new ArrayList<Integer>();
	private static List<Integer> mListBallsG = new ArrayList<Integer>();
	private static List<Integer> mListBallsO = new ArrayList<Integer>();

	private static int mUnitBallsSorted = 0;

	private static int mTotalBalls = 75; // altere aqui
	private static int mTotalBallsColumn = 5;

	private static NumberFormat nf = new DecimalFormat("00");

	public void initializeBalls() {
		for (int i = 0; i < mTotalBalls; i++) {
			mListBalls.add(0);
		}
		for (int j = 0; j < mTotalBallsColumn; j++) {
			mListBallsB.add(0);
			mListBallsI.add(0);
			mListBallsN.add(0);
			mListBallsG.add(0);
			mListBallsO.add(0);
		}
	}

	public void createColumn() {

		int randomNumber = rnd.nextInt(15);
		int min = 1;
		int max = 15;

		for (int row = 0; row < 5; row++) {
			for (int col = 0; col < 5; col++) {
				while (!checkNumber(randomNumber)) {
					randomNumber = rnd.nextInt(max - min + 1) + min;
				}
				mListBalls.set(randomNumber, 1);
				switch (col) {
				case 0:
					mListBallsB.set(row, randomNumber + 1);
					break;
				case 1:
					mListBallsI.set(row, randomNumber + 1);
					break;
				case 2:
					mListBallsN.set(row, randomNumber + 1);
					break;
				case 3:
					mListBallsG.set(row, randomNumber + 1);
					break;
				case 4:
					mListBallsO.set(row, randomNumber + 1);
					break;
				}
			}
			min = max + 1;
			max = min + 14;
		}
	}

	public boolean checkNumber(int number) {
		boolean result = true;
		if (mListBalls.get(number).equals(1)) {
			result = false;
		}
		return result;
	}

	public void showCard() {
		int number = 0;
		for (int row = 0; row < 5; row++) {

			for (int col = 0; col < 5; col++) {
				switch (row) {
				case 0:
					number = mListBallsB.get(col).intValue();
					break;
				case 1:
					number = mListBallsI.get(col).intValue();
					break;
				case 2:
					number = mListBallsN.get(col).intValue();
					break;
				case 3:
					number = mListBallsG.get(col).intValue();
					break;
				case 4:
					number = mListBallsO.get(col).intValue();
					break;
				}

				if (row == 2 && col == 2) {
					System.out.print("** | ");
				} else {
					formatNumberShow(number);
				}

			}
			System.out.println("");
		}
	}

	public void formatNumberShow(int number) {
		if (number < 10) {
			System.out.print(nf.format(number) + " | ");
		} else {
			System.out.print(number + " | ");
		}
	}

}
