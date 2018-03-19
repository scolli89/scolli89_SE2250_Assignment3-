using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Question 1 a): 
//Change 1: "Card.cs" Line 83:
//public void OnMouseUpAsButton(){
// Function needs to be virtual so it can be overiden by the sub class
//change 2: "Prospector.cs" line 9:
//private ScoreManager SM = new ScoreManager(); 
// This is declaring/ instanticating a singleton class. This is not need.
	// Change 2: more changes: "Prospector.cs" line 298, Using the instance of the Singleton class previously created. 
	// It is enough to change SM to ScoreManager so that it works within the singleton Pattern. 
// Event(...) is the wrong function call. needs to be EVENT(...)
	//Change 2: more changes: "Prospector.cs: line 320.
	//Using the instance of the Singleton class previously created. 
	// It is enough to change SM to ScoreManager so that it works within the singleton Pattern.
// Event(...) is the wrong function call. needs to be EVENT(...)
	// "ScoreManager.cs" Line 16, change private to public so information is more accessable
 //CHange 3: "Deck.cs" line 147:
//for (int i=0; i<14; i++) { 
//The for loop goes out of bounds and tries to access information that is not there.
// the loop should run only to i<13
//Question 2: b) Changes are implement in the appropriate files at the  lines provided 


//Question 4 : 

// 1 There is a 64k limit on vertices on a mesh. To overcome, larger models can be seperated into multiple parts 
// 
// 2 Modding is difficult to implement in Unity. One suggestion was to build you game from the beginning to be modable. 
//It was suggested to make the game engine then, make gameplay and core content as mods.
//
//There is no integrated text/code editor. There is, however, Script Inspector 3 on the asset store that adds an internat text/code editor.



	// An enum defines a variable type with a few prenamed values        // a
	public enum eCardState {
		drawpile,
		tableau,
		target,
		discard
	}

	public class CardProspector : Card { // Make sure CardProspector extends Card
		[Header("Set Dynamically: CardProspector")]
		// This is how you use the enum eCardState
		public eCardState             state = eCardState.drawpile;
		// The hiddenBy list stores which other cards will keep this one face down
		public List<CardProspector>   hiddenBy = new List<CardProspector>();
		// The layoutID matches this card to the tableau XML if it's a tableau card
		public int                    layoutID;
		// The SlotDef class stores information pulled in from the LayoutXML <slot>
		public SlotDef                slotDef;

		// This allows the card to react to being clicked
		override public void OnMouseUpAsButton() {
			// Call the CardClicked method on the Prospector singleton
			Prospector.S.CardClicked(this);
		 	
			base.OnMouseUpAsButton ();
		                                        
		}
	} 



