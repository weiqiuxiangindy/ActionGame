using System.Collections;
using System.Collections.Generic;
using ActionGame.System;
using UnityEngine;

namespace ActionGame.Control
{
    /// <summary>
    /// キーボード
    /// </summary>
    public class KeyboardControl : ControlBase
    {
        [SerializeField]
        private KeyBoardSetting setting = null;

        void Update()
        {
            if (Input.GetKeyDown(setting.Left))
            {
                OnLeft?.Invoke();
            }

            if (Input.GetKeyDown(setting.Right))
            {
                OnRight?.Invoke();
            }

            if (Input.GetKeyDown(setting.Up))
            {
                OnUp?.Invoke();
            }

            if (Input.GetKeyDown(setting.Down))
            {
                OnDown?.Invoke();
            }

            if (Input.GetKeyDown(setting.ButtonX))
            {
                OnButtonX?.Invoke();
            }

            if (Input.GetKeyDown(setting.ButtonA))
            {
                OnButtonA?.Invoke();
            }
        }
    }
}