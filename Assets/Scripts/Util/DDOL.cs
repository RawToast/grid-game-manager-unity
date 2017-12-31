using UnityEngine;

namespace Util {
    public class DDOL : MonoBehaviour {
        void Awake() {
            DontDestroyOnLoad(transform.gameObject);
        }
    }
}