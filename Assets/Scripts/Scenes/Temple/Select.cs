using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    private bool isSelected;
    public static GameObject selected, previousSelected;

    public GameObject frog, lion, duck, lizard, flower, tree, mouse;

    public Sprite mouseSprite, frogSprite, flowerSprite, duckSprite, lizardSprite;

    void OnMouseDown()
    {
        if (!isSelected)
        {
            if (previousSelected != null)
            {
                previousSelected.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            }
            
            selected = this.gameObject;
            selected.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 1);
            previousSelected = selected;
          
            //isSelected = true;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            isSelected = false;
        }
    }

    public void MouseButton()
    {        
        if(selected == mouse)
        {
            mouse.GetComponent<SpriteRenderer>().sprite = mouseSprite;            
            OnMouseDown();
        }
    }

    public void LizardButton()
    {        
        if(selected == lizard)
        {
            lizard.GetComponent<SpriteRenderer>().sprite = lizardSprite;            
            OnMouseDown();
        }
    }

    public void FlowerButton()
    {        
        if(selected == flower)
        {
            flower.GetComponent<SpriteRenderer>().sprite = flowerSprite;            
            OnMouseDown();
        }
    }

    public void FrogButton()
    {        
        if(selected == frog)
        {
            frog.GetComponent<SpriteRenderer>().sprite = frogSprite;            
            OnMouseDown();
        }
    }

    public void DuckButton()
    {        
        if(selected == duck)
        {
            duck.GetComponent<SpriteRenderer>().sprite = duckSprite;            
            OnMouseDown();
        }
    }
}

