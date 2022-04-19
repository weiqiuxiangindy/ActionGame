using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ActionGame.System
{
    [CreateAssetMenu(fileName = "KeyBoardSetting", menuName = "ScriptableObjects/System")]
    [Serializable]
    public class KeyBoardSetting : ScriptableObject
    {
        public KeyCode ButtonA = KeyCode.None;
        public KeyCode ButtonB = KeyCode.None;
        public KeyCode ButtonX = KeyCode.None;
        public KeyCode ButtonY = KeyCode.None;
        public KeyCode Left = KeyCode.None;
        public KeyCode Right = KeyCode.None;
        public KeyCode Up = KeyCode.None;
        public KeyCode Down = KeyCode.None;
    }
}