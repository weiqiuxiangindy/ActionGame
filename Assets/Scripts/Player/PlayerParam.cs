using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ActionGame.Player
{
    /// <summary>
    /// プレイヤーのデータ
    /// </summary>
    public class PlayerParam : IParam
    {
        public int HP { get; }
        public bool IsJump { get; }
    }
}
