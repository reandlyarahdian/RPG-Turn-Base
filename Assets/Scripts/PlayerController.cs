using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.Scripts
{
    public class PlayerController : MonoBehaviour, IAssign, IAction
    {
        [SerializeField] private ScriptableStat stat;

        private StatComponent statComponent;

        public float speed;
        public float Defense;
        public float Exp;
        public float Range;
        public float Melee;

        public Play play { get; set; }

        public int ID { get; set; }

        private Rigidbody2D rb2D;


        public void Init()
        {
            statComponent.MaxHealth = stat.stat.Health;
            statComponent.MaxMana = stat.stat.Energy;

            Defense = stat.extraStat.Defense;
            Exp = stat.extraStat.Exp;
            Range = stat.extraStat.Range;
            Melee = stat.extraStat.Melee;

            statComponent.Init();
        }

        // Use this for initialization
        void Start()
        {
            rb2D = GetComponent<Rigidbody2D>();
            statComponent = GetComponentInChildren<StatComponent>();
        }

        public void AssignObj(GameObject obj)
        {
            rb2D.MovePosition(Vector2.MoveTowards(rb2D.position, obj.GetComponent<Rigidbody2D>().position, speed));
        }

        public void Animate(string nameAnimation)
        {
            this.gameObject.GetComponent<Animator>().Play(nameAnimation);
        }

        public float Acts(float variable, Type type)
        {
            if (type.Equals(Type.Heal))
            {
                return variable;
            }
            return -variable;
        }
    }
}