#if UNITY_EDITOR
using UnityEditor;
#endif

using Managers;
using UnityEngine;
using UnityEngine.SceneManagement;

static class Grd {
	public static ScoreManager Score;
	public static LevelManager Level;
    
	static Grd() {
		GameObject g = safeFind("App");

		Score = (ScoreManager)SafeComponent( g, "ScoreManager" );
		Level = (LevelManager)SafeComponent(g, "LevelManager");
        
#if UNITY_EDITOR
		SceneManager.LoadScene(System.IO.Path.GetFileNameWithoutExtension(
			EditorPrefs.GetString("SceneAutoLoader.PreviousScene")));
#else
		Level.NextLevel();
#endif
		
	}

	// when Grid wakes up, it checks everything is in place
	// it uses these trivial routines to do so
	private static GameObject safeFind(string s) {
		GameObject g = GameObject.Find(s);
		if (g == null) Woe("GameObject " + s + "  not on _preload.");
		return g;
	}

	private static Component SafeComponent(GameObject g, string s) {
		Component c = g.GetComponent(s);
		if (c == null) Woe("Component " + s + " not on _preload.");
		return c;
	}

	private static void Woe(string error) {
		Debug.Log(">>> Cannot proceed... " + error);
		Debug.Log(">>> It is very likely you just forgot to launch");
		Debug.Log(">>> from scene zero, the _preload scene.");
	}
	// be sure to read this:
	// http://stackoverflow.com/a/35891919/294884
    
}

