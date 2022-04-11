using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.FPS.Game;
using UnityEngine.Events;

public class ObjectiveDestroyTargets : Objective
{
    public List<GameObject> targets;
    public UnityEvent<GameObject> OnDestroyTarget;

    public UnityEvent OnDestroyedAllTargets;

    // Start is called before the first frame update
    protected override void Start()
    {
        for(int i = 0; i < targets.Count; i++)
        {
            GameObject targetObject = targets[i];
            Health h = targetObject.GetComponent<Health>();
            h.OnDie.AddListener(() => DestroyTargetEvent(targetObject));
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DestroyTargetEvent(GameObject objectThatDied)
    {
        targets.Remove(objectThatDied);
        OnDestroyTarget.Invoke(objectThatDied);

        if (targets.Count <= 0)
        {
            OnDestroyedAllTargets.Invoke();
        }
    }
}
