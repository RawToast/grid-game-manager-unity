
using UnityEngine;

namespace Managers {
	public class ScoreManager : MonoBehaviour {
		[SerializeField] private long score;
        
		void Awake() {
			DontDestroyOnLoad(transform.gameObject);
			print("Starting game with: " + Grd.Score.GetScore());
		}

		public long GetScore() {
			return score;
		}
		
		public void AddToScore(long x) {
			score += x;
		}
	}
}

