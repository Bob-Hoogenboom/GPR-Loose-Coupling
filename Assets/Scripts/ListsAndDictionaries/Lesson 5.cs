using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson5 
{
    //Dictionary <TKey, TValue>
    private Dictionary<string, int> _guns = new Dictionary<string, int>();


    public string GetGun(string gun)
    {
        if(!_guns.ContainsKey(gun))
        {
            return "";
        }

        var currentGun = _guns[gun];

        return currentGun.ToString();
    }

    public int GetAmmo(string gun)
    {
        if (!_guns.ContainsKey(gun))
        {
            return 0;
        }

        return _guns[gun];
    }

    public void Shoot(string gun)
    {
        if (!_guns.ContainsKey(gun))
        {
            return;
        }

        _guns[gun] -= 1;
    }


    public void AddItem(string gunType, int ammoCount)
    {
        _guns.Add(gunType, ammoCount);

    }
}
