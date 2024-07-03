using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NormalItemTexture", menuName = "ScriptableObject/NormalItemTexture", order = 0)]
public class SONormalItemTexture : ScriptableObject
{
    public List<NormalItemSkin> normalItemSkinList = new();
    public int skinId;

    public Sprite GetNormalItemSprite(NormalItem.eNormalType type)
    {
        NormalItemSkin skin = normalItemSkinList[0];
        for (int i = 0; i < normalItemSkinList.Count; i++)
        {
            if (normalItemSkinList[i].skinId == skinId)
            {
                skin = normalItemSkinList[i];
                break;
            }
        }

        switch (type)
        {
            case NormalItem.eNormalType.TYPE_ONE:
                return skin.normalItemSprite1;
            case NormalItem.eNormalType.TYPE_TWO:
                return skin.normalItemSprite2;
            case NormalItem.eNormalType.TYPE_THREE:
                return skin.normalItemSprite3;
            case NormalItem.eNormalType.TYPE_FOUR:
                return skin.normalItemSprite4;
            case NormalItem.eNormalType.TYPE_FIVE:
                return skin.normalItemSprite5;
            case NormalItem.eNormalType.TYPE_SIX:
                return skin.normalItemSprite6;
            case NormalItem.eNormalType.TYPE_SEVEN:
                return skin.normalItemSprite7;
        }

        return skin.normalItemSprite1;
    }
}

[Serializable]
public class NormalItemSkin
{
    public int skinId;
    public Sprite normalItemSprite1;
    public Sprite normalItemSprite2;
    public Sprite normalItemSprite3;
    public Sprite normalItemSprite4;
    public Sprite normalItemSprite5;
    public Sprite normalItemSprite6;
    public Sprite normalItemSprite7;
}
