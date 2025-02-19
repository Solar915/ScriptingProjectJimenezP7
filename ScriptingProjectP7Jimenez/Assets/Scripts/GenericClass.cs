using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClass <T>
{
    T item;

    // Update is called once per frame
  public void UpdateItem(T newItem)
    {
        item = newItem;
    }
}
