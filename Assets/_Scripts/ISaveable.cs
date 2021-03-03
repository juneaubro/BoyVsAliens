using System;
using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public interface ISaveable
{
    object CaptureState();
    void RestoreState(object state);
}