using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter {



    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player){
        if (!HasKitchenObject()) {
            //there is no kitchenobject here
            if (player.HasKitchenObject()){
                //player is carrying something
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else{
                // player not carrying anything
            }
        }
        else{
            //here is a kitchenobject here
            if (player.HasKitchenObject()){
                //player is carrying smotething
            }
            else{
                //player is not carrying anything
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }
}
