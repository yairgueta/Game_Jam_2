using System;
using UnityEngine;

namespace Stations
{
    public abstract class Station : MonoBehaviour
    {
        public enum StationTypeEnum
        {
            NoStation,
            Wheel, 
            Aiming,
        };

        public Action OnEjection, OnInjection;
        public StationTypeEnum StationType => stationType;
        [Header("General Station Attributes")] 
        [SerializeField] protected TriggerActionInvoker triggerActionInvoker;
    
        protected StationController currentController;

        protected StationTypeEnum stationType;
        private bool isActive = true;
        

        protected virtual void Start()
        {
            if (triggerActionInvoker == null) return;
            triggerActionInvoker.OnTriggerAction += OnTriggerAction_TriggerInvoker;
        }

        private void OnTriggerAction_TriggerInvoker(Collider2D other)
        {
            if (currentController != null) return;
            currentController = other.gameObject.GetComponent<StationController>();
            currentController?.EnterStation(this);
        }
        
        public void Inject(PlayerInputController playerInputController)
        {
            if (!isActive) return;
            playerInputController.ejectAction += EjectAction;
            playerInputController.fireAction += FireAction;
            playerInputController.horizontalAction += HorizontalAction;
            playerInputController.verticalAction += VerticalAction;
        
            OnInjection?.Invoke();
        }

        public void Eject(PlayerInputController playerInputController)
        {
            currentController = null;
            playerInputController.ejectAction -= EjectAction;
            playerInputController.fireAction -= FireAction;
            playerInputController.horizontalAction -= HorizontalAction;
            playerInputController.verticalAction -= VerticalAction;

            OnEjection?.Invoke();
        }

        public virtual void DisableStation()
        {
            if (!isActive) return;
            if (currentController != null)
            {
                currentController.ExitStation();
            }

            triggerActionInvoker.OnTriggerAction -= OnTriggerAction_TriggerInvoker;
            isActive = false;
        }   
    
        protected abstract void EjectAction();

        protected abstract void FireAction();

        protected abstract void HorizontalAction(float t);

        protected abstract void VerticalAction(float t);
    }
}
