using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Trivia.PackDataItem;

namespace Trivia.PackData
{
    public class PackDataController : ObjectController<PackDataController, PackDataModel, PackDataView>
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
        }

        public void GenerateLevel()
        {
            GameObject prefab = Resources.Load<GameObject>("Pack/PackView");
            PackDataItemView view = Object.Instantiate(prefab).GetComponent<PackDataItemView>();
            view.transform.SetParent(_view.transform);
            
            PackDataItemModel model = new PackDataItemModel();
            PackDataItemController controller = new PackDataItemController();
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

        public List<PackDataModel> GetPackList()
        {
            return null;
        }

        public void InitPackList(List<PackDataItemModel> pack)
        {
            foreach(var p in pack)
            {
                
            }
        }

        public override void SetView(PackDataView view)
        {
            base.SetView(view);
            LoadPackList();
        }
    }

}
