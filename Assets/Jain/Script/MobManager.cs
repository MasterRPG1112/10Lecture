using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Jain
{
    public class MobManager : MonoBehaviour
    {
        public Mob mob;
        [HideInInspector] public Mob mobInfo;

        public Button skillBtn;
        public UnityEvent OnButtonCilcked;

        void Start()
        {
            mobInfo = Instantiate(mob);
            mob.hp = 20;
            Debug.Log("이름 : " + mob.name);
            Debug.Log("HP : " + mob.hp);
        }

        void FixedUpdate()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                OnButtonCilcked.Invoke();
            }
        }

        private void OnEnable()
        {
            OnButtonCilcked.AddListener(Attack);
        }

        private void OnDisable()
        {
            OnButtonCilcked.RemoveListener(Attack);
        }

        void Attack()
        {
            Debug.Log("공격");
        }

        public void UseSkill()
        {
            Debug.Log("스킬 사용!");
        }
    }
}
