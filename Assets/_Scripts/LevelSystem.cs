using System;
using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public class LevelSystem : MonoBehaviour, ISaveable
{
    [SerializeField] private int level = 1;
    public object CaptureState()
    {
        return new SaveData {
            level = level
        };
    }

    public void RestoreState(object state)
    {
        var saveData = (SaveData)state;

        level = saveData.level;
    }

    [Serializable]
    private struct SaveData
    {
        public int level;
    }
}   
