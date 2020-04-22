using TMPro;

namespace Assets.Scripts
{
    using UnityEngine;

    public class ScoreKeeper : MonoBehaviour
    {
        private GameManager gameManager;
        // Start is called before the first frame update
        void Start()
        {
            this.gameManager = FindObjectOfType<GameManager>();
        }

        // Update is called once per frame
        void Update()
        {
            this.gameObject.GetComponentInChildren<TextMeshProUGUI>().text = this.gameManager.Score.ToString();
        }
    }
}
