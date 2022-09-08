using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Trivia.LevelData;

namespace Trivia.LevelSpawner
{
    public class LevelSpawnerController : ObjectController<LevelSpawnerController, LevelSpawnerModel, LevelSpawnerView>
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
        }

        public void GenerateLevel()
        {
            GameObject prefab = Resources.Load<GameObject>("Level/Level");
            LevelDataView view = Object.Instantiate(prefab).GetComponent<LevelDataView>();
            view.transform.SetParent(_view.transform);
            
            LevelDataModel model = new LevelDataModel();
            LevelDataController controller = new LevelDataController();
            InjectDependencies(controller);
            controller.Init(model, view);
            _model.AddToList(model);
        }

        public void LoadPackList()
        {
            for(int i = 0; i < 4; i++)
            {
                GenerateLevel();
            }
        }

        public List<LevelDataModel> GetPackList()
        {
            return null;
        }

        public void InitPackList(List<LevelDataModel> pack)
        {
            foreach(var p in pack)
            {
                
            }
        }

        public override void SetView(LevelSpawnerView view)
        {
            base.SetView(view);
            LoadPackList();
        }
    }

}
