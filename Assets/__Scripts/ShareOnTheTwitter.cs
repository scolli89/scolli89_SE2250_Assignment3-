using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShareOnTheTwitter : MonoBehaviour {

	// Use this for initialization
	string TWITTER_ADDRESS = "http://www.twitter.com/intent/tweet";
	string TWEET_LANGUAGE = "en";
	string DisplayText = "Check out my score: ";

	public void ShareScoreOnTwitter () {

		Application.OpenURL (TWITTER_ADDRESS + "?text=" +WWW.EscapeURL(DisplayText)+ 
			ScoreManager.SCORE + "&amp;lang=" + WWW.EscapeURL(TWEET_LANGUAGE));
	}
}
