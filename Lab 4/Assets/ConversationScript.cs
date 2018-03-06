using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationScript : MonoBehaviour {

	void Start(){

		Greet ();

	}

	public int iq = 5;

	void Greet(){
		switch (iq) {
			case 5:
				print ("Why, hello there! Would you like to discuss quantum mechanics, good sir?");
				break;

			case 4:
				print ("Hello and good day!");
				break;

			case 3:
				print ("Whaddaya want, scrub?");
				break;

			case 2:
				print ("Brogg angry! Brogg smash face!");
				break;

			case 1:
				print ("Bleb pfffff ggrrrrrr *farts*");
				break;

			default:
				print ("Incorrect IQ level -- try again.");
				break;
		}
	}
}
