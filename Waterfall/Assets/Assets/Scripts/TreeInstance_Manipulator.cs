using UnityEngine;
using System.Collections;


public class Tree_Manipulator : MonoBehaviour
{
        public bool colorEffectActive = true;
        public int colorChangeFrequency = 1;
        public float colorChangeDuration = 0.008F;

        private TreeInstance[] trees;
        private float prevTimestamp = 0F;

        // Use this for initialization
        void Start()
        {
                //trees = GameObject.FindGameObjectsWithTag("Tree");
                //trees;//FindObjectsOfType(typeof(TreeInstance));//TerrainData.GetTreeInstance(0);
                trees = Terrain.activeTerrain.terrainData.treeInstances;
                print("TreeInstance Count: " + trees.Length);
        }


        // Update is called once per frame
        void Update()
        {
                float curTimestamp = Time.realtimeSinceStartup;
                /*print("Current Time: " + curTimestamp
                + "Prev Alarm: " + prevTimestamp);*/

                if ((curTimestamp - prevTimestamp) > colorChangeFrequency)
                {
                        for (var i = 0; i < trees.Length; i++)
                        {
                                // Gradually red-en tree color
                                trees[i].color = Color.Lerp(trees[i].color, Color.white, colorChangeDuration);
                        }
                        prevTimestamp = curTimestamp;
                }
        }
}
