using System;
using Unity.Behavior;
using UnityEngine;

[Serializable, Unity.Properties.GeneratePropertyBag]
[Condition(name: "Distance joueur", story: "Agent Colliding with [Player]", category: "Conditions", id: "53103a3fc225e2c798ecfe694035b7b8")]
public partial class DistanceJoueurCondition : Condition
{
    [SerializeReference] public BlackboardVariable<GameObject> Player;

    public override bool IsTrue()
    {
        return true;
    }

    public override void OnStart()
    {
    }

    public override void OnEnd()
    {
    }
}
