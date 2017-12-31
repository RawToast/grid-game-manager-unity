using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Managers {
	public class LevelManager : MonoBehaviour {

		[SerializeField] private List<string> levelNames;
        
		private List<string> currentGameLevelsList;
        
		void Awake() {
			DontDestroyOnLoad(transform.gameObject);
		}

		public void NextLevel() {
			print("Changing level, score is: " + Grd.Score);
			if (currentGameLevelsList == null || currentGameLevelsList.Count == 0) {
				ResetLevels();
			}
			var sceneToLoad = currentGameLevelsList.FirstOrDefault(s => true);
            
			UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToLoad);

			if (currentGameLevelsList.Count > 1) {
				currentGameLevelsList = currentGameLevelsList.Skip(1).ToList();
			}
		}

		public void ResetLevels() {
			currentGameLevelsList = levelNames;
		}
	}
}

