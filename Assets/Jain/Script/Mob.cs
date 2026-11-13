using UnityEngine;

namespace Jain
{
    [CreateAssetMenu(fileName = "Mob", menuName = "Scriptable Objects/Mob")]
    public class Mob : ScriptableObject
    {
        public string MobName;
        public string MobJoin;
        public float hp;
        public float mp;
        public float damage;
        public float defense;
    }
}
