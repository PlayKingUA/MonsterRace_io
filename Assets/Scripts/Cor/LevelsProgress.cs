using UnityEngine;
using UnityEngine.UI;

namespace BlueStellar.Cor
{
    public class LevelsProgress : MonoBehaviour
    {
        #region Variables

        [SerializeField] Image[] lvlProgressImg;
        [SerializeField] Text[] textLvls;
        [SerializeField] GameObject[] heads;
        [SerializeField] private int indexProgress;
        //??
        [SerializeField] Sprite[] img1;
        [SerializeField] Sprite[] img2;
        [SerializeField] Sprite[] img3;
        [SerializeField] Sprite[] img4;
        [SerializeField] int[] lvl1;
        [SerializeField] int[] lvl2;
        [SerializeField] int[] lvl3;

        SkinsController _skinsController;

        #endregion

        private void Start()
        {
            _skinsController = GameObject.FindObjectOfType<SkinsController>();
            CheckProgress();
        }

        public void CheckProgress()
        {
            foreach(var i in heads) { i.SetActive(false); }
            heads[_skinsController.GetIndexProgress()].SetActive(true);
            int progress = LevelController.Instance.LvlNumber() - 1;
            lvlProgressImg[0].sprite = img1[progress];
            lvlProgressImg[1].sprite = img2[progress];
            lvlProgressImg[2].sprite = img3[progress];
            lvlProgressImg[3].sprite = img4[progress];
            textLvls[0].text = lvl1[progress].ToString();
            textLvls[1].text = lvl2[progress].ToString();
            textLvls[2].text = lvl3[progress].ToString();
        }
    }
}
