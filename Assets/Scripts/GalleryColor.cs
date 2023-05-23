using System.Collections.Generic;
using System;
using UnityEngine;

public class GalleryColor: ItemsList<ItemColor, Material> {
    // [SerializeField] protected RectTransform content;
    // [SerializeField] protected List<ImageItem> imageItems = new List<ImageItem>();
    // [SerializeField] private Texture circleTexture;
    //
    // public event Action<int> ClickItemEvent;
    //
    // private void Awake() {
    //     for(var i = 0; i < imageItems.Count; i++) {
    //         var indexButton = i;
    //         imageItems[i].ClickItemEvent += () => { OnClickItem(indexButton); };
    //         //imageItems[i].Close();
    //     }
    // }
    //
    // private void OnClickItem(int index) {
    //     ClickItemEvent?.Invoke(index);
    // }
    //
    // public void SetContent(List<Material> materials, bool isTexture = false) {
    //     var i = 0;
    //     for (i = 0; i < materials.Count; i++) {
    //         var color = materials[i].color;
    //         Texture texture;
    //         texture = isTexture == false ? circleTexture : materials[i].mainTexture;
    //         imageItems[i].SetImage(texture);
    //         imageItems[i].SetColor(color);
    //     }
    //     for (int j = i; j < imageItems.Count; j++) {
    //        // imageItems[j].Close();
    //     }
    // }
   
    public event Action<int> ClickItemEvent;
    private void OnClickItem(int index) {
        ClickItemEvent?.Invoke(index);
    }
  
    public void SetContent(List<Material> materials, bool isTexture = true) {
        AddItems(materials, isTexture);
    }

    public void SetActive(bool state) {
        gameObject.SetActive(state);
    }

    protected override void OnItemCreate(ItemColor item)
    {
        var indexButton = itemsList.IndexOf(item);
        item.ClickItemEvent += () => { OnClickItem(indexButton); };
    }

    protected override void OnItemDestroy(ItemColor item) {
    }
}