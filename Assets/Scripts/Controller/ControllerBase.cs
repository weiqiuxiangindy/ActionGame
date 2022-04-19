using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ActionGame.Control
{
    /// <summary>
    /// コントロールベース(キーボード、スマホ、コントローラのコントロールベース)
    /// </summary>
    public class ControlBase : MonoBehaviour
    {
        public Action OnButtonA = null;
        public Action OnButtonB = null;
        public Action OnButtonX = null;
        public Action OnButtonY = null;
        public Action OnLeftButtom = null;
        public Action<float> OnLeftTrigger = null;
        public Action OnRightButtom = null;
        public Action<float> OnRightTrigger = null;
        public Action<Vector2> OnLeftStick = null;
        public Action<Vector2> OnRightStick = null;
        public Action OnUp = null;
        public Action OnDown = null;
        public Action OnLeft = null;
        public Action OnRight = null;
        public Action OnButtonSelect = null;
        public Action OnButtonMenu = null;
    }
}