using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections;

public class BowlingController : MonoBehaviour {
	public int currentFrame = 0;

	public  Text frame1;
	public  Text frame1_1;
	public  Text frame1_2;

	public  Text frame2;
	public  Text frame2_1;
	public  Text frame2_2;

	public Text frame3;
	public Text frame3_1;
	public Text frame3_2;

	public Text frame4;
	public Text frame4_1;
	public Text frame4_2;

	public Text frame5;
	public Text frame5_1;
	public Text frame5_2;

	public Text frame6;
	public Text frame6_1;
	public Text frame6_2;

	public Text frame7;
	public Text frame7_1;
	public Text frame7_2;

	public Text frame8;
	public Text frame8_1;
	public Text frame8_2;

	public Text frame9;
	public Text frame9_1;
	public Text frame9_2;

	public Text frame10;
	public Text frame10_1;
	public Text frame10_2;


	public  Text[] frames;

	public  Text[] subFrames;

	public int [] score = new int[20];

	// Use this for initialization
	void Start () {
		frames = new Text[10];
		subFrames = new Text[20];

		frames [0] = frame1;
		frames [1] = frame2;
		frames [2] = frame3;
		frames [3] = frame4;
		frames [4] = frame5;
		frames [5] = frame6;
		frames [6] = frame7;
		frames [7] = frame8;
		frames [8] = frame9;
		frames [9] = frame10;

		subFrames [0] = frame1_1;
		subFrames [1] = frame1_2;
		subFrames [2] = frame2_1;
		subFrames [3] = frame2_2;
		subFrames [4] = frame3_1;
		subFrames [5] = frame3_2;
		subFrames [6] = frame4_1;
		subFrames [7] = frame4_2;
		subFrames [8] = frame5_1;
		subFrames [9] = frame5_2;
		subFrames [10] = frame6_1;
		subFrames [11] = frame6_2;
		subFrames [12] = frame7_1;
		subFrames [13] = frame7_2;
		subFrames [14] = frame8_1;
		subFrames [15] = frame8_2;
		subFrames [16] = frame9_1;
		subFrames [17] = frame9_2;
		subFrames [18] = frame10_1;
		subFrames [19] = frame10_2;


		for (int i = 0; i < 10; i++) {
			frames [i].text = "";
		}

		for (int i = 0; i < 20; i++) {
			subFrames [i].text = "";
		}

		for (int i = 0; i < 20; i++) {
			score [i] = 0;
		}

		DontDestroyOnLoad (frame1);
		DontDestroyOnLoad (frame2);
		DontDestroyOnLoad (frame3);
		DontDestroyOnLoad (frame4);
		DontDestroyOnLoad (frame5);
		DontDestroyOnLoad (frame6);
		DontDestroyOnLoad (frame7);
		DontDestroyOnLoad (frame8);
		DontDestroyOnLoad (frame9);
		DontDestroyOnLoad (frame10);

		DontDestroyOnLoad (frame1_1);
		DontDestroyOnLoad (frame2_1);
		DontDestroyOnLoad (frame3_1);
		DontDestroyOnLoad (frame4_1);
		DontDestroyOnLoad (frame5_1);
		DontDestroyOnLoad (frame6_1);
		DontDestroyOnLoad (frame7_1);
		DontDestroyOnLoad (frame8_1);
		DontDestroyOnLoad (frame9_1);
		DontDestroyOnLoad (frame10_1);

		DontDestroyOnLoad (frame1_2);
		DontDestroyOnLoad (frame2_2);
		DontDestroyOnLoad (frame3_2);
		DontDestroyOnLoad (frame4_2);
		DontDestroyOnLoad (frame5_2);
		DontDestroyOnLoad (frame6_2);
		DontDestroyOnLoad (frame7_2);
		DontDestroyOnLoad (frame8_2);
		DontDestroyOnLoad (frame9_2);
		DontDestroyOnLoad (frame10_2);

		DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < 20; i++) {
			if (i == 0) {
				frames [0].text = "" + (score [0] + score [1]);
			}
			if (i == 1) {
				frames [1].text = "" + (score [2] + score [3]);
			}
		}

		for (int i = 0; i < 20; i++) {
			if (i == 0) {
				subFrames [0].text = "" + (score [i]) ;
			} else if (i == 1) {
				subFrames [1].text = "" + (score [i]) ;
			} else if (i == 2) {
				subFrames [2].text = "" + (score [i]) ;
			} else if (i == 3) {
				subFrames [3].text = "" + (score [i]) ;
			}

		}
	}
}
