﻿using UnityEngine;

namespace Custom_Scenery
{
    public class Main : IMod
    {
        private GameObject _go;

        public void onEnabled()
        {
            _go = new GameObject();

            _go.AddComponent<SceneryLoader>();

            _go.GetComponent<SceneryLoader>().Path = Path;

            _go.GetComponent<SceneryLoader>().Identifier = Identifier;

            _go.GetComponent<SceneryLoader>().LoadScenery();
        }

        public void onDisabled()
        {
            _go.GetComponent<SceneryLoader>().UnloadScenery();

            Object.Destroy(_go);
        }

        public string Name { get { return "shyguy's Building Set 2"; } }
        public string Description { get { return "Clapboard walls, slanted roofs, posts, awnings, signs, and more."; } }
        public string Path { get; set; }
        public string Identifier { get; set; }
    }
}
